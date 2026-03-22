using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyVatLieuXayDung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatLieuXayDung.Forms
{
    public partial class frmHoaDon : Form
    {
        QLVLDbContext context = new QLVLDbContext();
        int id;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();

            // Thêm các lệnh Include ở đây
            hd = context.HoaDon
                .Include(r => r.NhanVien)
                .Include(r => r.KhachHang)
                .Include(r => r.HoaDon_ChiTiet)
                .AsEnumerable()
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien?.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang?.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (double)ct.SoLuongBan * (double)ct.DonGiaBan),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();

            dgvHoaDon.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa hóa đơn số " + dgvHoaDon.CurrentRow.Cells["ID"].Value.ToString() + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvHoaDon.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Hóa đơn ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // --- SHEET 1: DANH SÁCH HÓA ĐƠN ---
                        DataTable dtHoaDon = new DataTable();
                        dtHoaDon.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Mã HĐ", typeof(int)),
                    new DataColumn("Tên Nhân Viên", typeof(string)),
                    new DataColumn("Tên Khách Hàng", typeof(string)),
                    new DataColumn("Ngày Lập", typeof(DateTime)),
                    new DataColumn("Tổng Tiền", typeof(double)),
                    new DataColumn("Ghi Chú", typeof(string))
                });

                        // Truy vấn dữ liệu sử dụng lớp DanhSachHoaDon để lấy đầy đủ thông tin tên
                        var dsHoaDon = context.HoaDon.Select(r => new DanhSachHoaDon
                        {
                            ID = r.ID,
                            HoVaTenNhanVien = r.NhanVien.HoVaTen,
                            HoVaTenKhachHang = r.KhachHang.HoVaTen,
                            NgayLap = r.NgayLap,
                            GhiChuHoaDon = r.GhiChuHoaDon,
                            // Tính tổng tiền trực tiếp từ danh sách chi tiết
                            TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (int)ct.SoLuongBan * (int)ct.DonGiaBan)
                        }).ToList();

                        foreach (var hd in dsHoaDon)
                        {
                            dtHoaDon.Rows.Add(hd.ID, hd.HoVaTenNhanVien, hd.HoVaTenKhachHang, hd.NgayLap, hd.TongTienHoaDon, hd.GhiChuHoaDon);
                        }
                        var sheetHD = wb.Worksheets.Add(dtHoaDon, "HoaDon");
                        sheetHD.Columns().AdjustToContents(); // Tự động giãn cột

                        // --- SHEET 2: CHI TIẾT HÓA ĐƠN ---
                        DataTable dtChiTiet = new DataTable();
                        dtChiTiet.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Mã HĐ", typeof(int)),
                    new DataColumn("Tên Sản Phẩm", typeof(string)),
                    new DataColumn("Số Lượng", typeof(int)),
                    new DataColumn("Đơn Giá", typeof(int)),
                    new DataColumn("Thành Tiền", typeof(double))
                });

                        var dsChiTiet = context.HoaDon_ChiTiet.Select(ct => new
                        {
                            ct.HoaDonID,
                            TenSP = ct.VatLieu.TenVatLieu,
                            ct.SoLuongBan,
                            ct.DonGiaBan,
                            // Sửa dòng này:
                            ThanhTien = (int)ct.SoLuongBan * (int)ct.DonGiaBan
                        }).ToList();

                        foreach (var ct in dsChiTiet)
                        {
                            dtChiTiet.Rows.Add(ct.HoaDonID, ct.TenSP, ct.SoLuongBan, ct.DonGiaBan, ct.ThanhTien);
                        }
                        var sheetCT = wb.Worksheets.Add(dtChiTiet, "HoaDon_ChiTiet");
                        sheetCT.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất báo cáo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
