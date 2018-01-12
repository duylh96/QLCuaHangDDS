using DevExpress.XtraEditors;
using QLCuaHangDDS.BUS;
using QLCuaHangDDS.DAO;
using System;
using System.Windows.Forms;

namespace QLCuaHangDDS.GUI.ManHinhBanHang
{
    public partial class BanHang : DevExpress.XtraEditors.XtraForm
    {
        private long currentMaHDBH;
        private long currentMaMH;
        private long currentMaCTHD = -1;
        private long selectedMaMH;

        private int currentSL;

        public BanHang()
        {
            InitializeComponent();

            //Init DS Mat Hang
            gridControlDSMatHang.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().MATHANGs;
            gridViewDSMatHang.Columns[0].Visible = false;
            gridViewDSMatHang.Columns[1].Caption = "Phân loại";
            gridViewDSMatHang.Columns[2].Caption = "Tên mặt hàng";
            gridViewDSMatHang.Columns[3].Caption = "Đơn giá";
            gridViewDSMatHang.Columns[4].Caption = "Hãng sản xuất";
            gridViewDSMatHang.Columns[5].Caption = "Năm sản xuất";
            gridViewDSMatHang.Columns[6].Caption = "Số lượng";
            gridViewDSMatHang.Columns[7].Caption = "Mô tả";
            gridViewDSMatHang.Columns[8].Visible = false;
            gridViewDSMatHang.Columns[9].Visible = false;
            gridViewDSMatHang.Columns[10].Visible = false;
        }

        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            HOADONBANHANG hd = new HOADONBANHANG();
            hd.TenKH = edt_TenKH.Text.ToString();
            hd.NgayLap = DateTime.Now;
            hd.TongTien = 0;

            if (!HoaDonBanHangBUS.ThemHoaDon(hd, ref this.currentMaHDBH))
            {
                XtraMessageBox.Show("Tên khách hàng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            edt_SoLuong.Enabled = true;
            btn_Add.Enabled = true;
            btn_ThanhToan.Enabled = true;
            btn_LapHoaDon.Enabled = false;
        }

        private void gridViewDSMatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.currentMaMH = int.Parse(gridViewDSMatHang.GetFocusedRowCellValue("MaMH").ToString());
            }
            catch (Exception) { }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!HoaDonBanHangBUS.isValidNumber(edt_SoLuong.Text))
            {
                XtraMessageBox.Show("Số lượng hàng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedMH = MatHangDAO.getMatHangById(this.currentMaMH);
            int SoLuongMua = int.Parse(edt_SoLuong.Text.ToString());
            if (SoLuongMua > selectedMH.SoLuong)
            {
                XtraMessageBox.Show("Mặt hàng này hiện tại không đủ số lượng theo yêu cầu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CHITIETHOADONBANHANG ct = new CHITIETHOADONBANHANG();
            ct.MaHD = this.currentMaHDBH;
            ct.MaMH = this.currentMaMH;
            ct.SoLuong = SoLuongMua;
            ct.DonGia = selectedMH.DonGia;
            ct.ThanhTien = ct.SoLuong * ct.DonGia;

            if (!ChiTietHoaDonBanHangBUS.ThemCTHDBH(ct))
            {
                XtraMessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal result = 0;
            HoaDonBanHangBUS.CapNhatTongTienHD(this.currentMaHDBH, ct.ThanhTien.Value, ref result);
            MatHangBUS.CapNhatSoLuongMatHang(this.currentMaMH, ct.SoLuong.Value);
            edt_TongTien.Text = result.ToString();
            this.refreshTableChiTiet();
            this.refreshTableMatHang();
        }

        private void refreshTableChiTiet()
        {
            gridControlChiTiet.DataSource = ChiTietHoaDonBanHangBUS.loadAllCTHDBHById(this.currentMaHDBH);
            gridViewChiTiet.Columns[0].Visible = false;
            gridViewChiTiet.Columns[1].Visible = false;
            gridViewChiTiet.Columns[2].Visible = false;
            gridViewChiTiet.Columns[3].Caption = "Tên mặt hàng";
            gridViewChiTiet.Columns[4].Caption = "Số lượng";
            gridViewChiTiet.Columns[5].Caption = "Đơn giá";
            gridViewChiTiet.Columns[6].Caption = "Thành tiền";

            gridViewChiTiet.FocusedRowHandle = gridViewChiTiet.GetVisibleRowHandle(0);

            this.btn_Delete.Enabled = true;
            this.btn_Sua.Enabled = true;
            edt_CapNhatSoLuong.Text = "";
        }

        private void gridViewChiTiet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.currentMaCTHD = long.Parse(gridViewChiTiet.GetFocusedRowCellValue("MaChiTietHD").ToString());
                this.selectedMaMH = long.Parse(gridViewChiTiet.GetFocusedRowCellValue("MaMH").ToString());
                this.currentSL = int.Parse(gridViewChiTiet.GetFocusedRowCellValue("SoLuong").ToString());
                edt_CapNhatSoLuong.Text = this.currentSL.ToString();
            }
            catch (Exception) { }
        }

        private void refreshTableMatHang()
        {
            gridControlDSMatHang.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().MATHANGs;
            gridViewDSMatHang.Columns[0].Visible = false;
            gridViewDSMatHang.Columns[1].Caption = "Phân loại";
            gridViewDSMatHang.Columns[2].Caption = "Tên mặt hàng";
            gridViewDSMatHang.Columns[3].Caption = "Đơn giá";
            gridViewDSMatHang.Columns[4].Caption = "Hãng sản xuất";
            gridViewDSMatHang.Columns[5].Caption = "Năm sản xuất";
            gridViewDSMatHang.Columns[6].Caption = "Số lượng";
            gridViewDSMatHang.Columns[7].Caption = "Mô tả";
            gridViewDSMatHang.Columns[8].Visible = false;
            gridViewDSMatHang.Columns[9].Visible = false;
            gridViewDSMatHang.Columns[10].Visible = false;

            gridViewDSMatHang.FocusedRowHandle = gridViewDSMatHang.GetVisibleRowHandle(0);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuongMua = int.Parse(gridViewChiTiet.GetFocusedRowCellValue("SoLuong").ToString());
                decimal ThanhTien = decimal.Parse(gridViewChiTiet.GetFocusedRowCellValue("ThanhTien").ToString());
                ChiTietHoaDonBanHangBUS.XoaCTHDBH(this.currentMaCTHD);
                var selectedMH = MatHangDAO.getMatHangById(this.selectedMaMH);

                decimal result = 0;
                HoaDonBanHangBUS.CapNhatTongTienHD(this.currentMaHDBH, -ThanhTien, ref result);
                MatHangBUS.CapNhatSoLuongMatHang(this.selectedMaMH, -soLuongMua);
                edt_TongTien.Text = result.ToString();
                edt_CapNhatSoLuong.Text = "";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            this.refreshTableChiTiet();
            this.refreshTableMatHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int SoLuongMua;
            try
            {
                SoLuongMua = int.Parse(edt_CapNhatSoLuong.Text.ToString());
                if (!HoaDonBanHangBUS.isValidNumber(SoLuongMua))
                {
                    XtraMessageBox.Show("Số lượng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    edt_CapNhatSoLuong.Text = "";
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số lượng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                edt_CapNhatSoLuong.Text = "";
                return;
            }

            var selectedMH = MatHangDAO.getMatHangById(this.selectedMaMH);
            if (SoLuongMua - this.currentSL > selectedMH.SoLuong)
            {
                XtraMessageBox.Show("Mặt hàng này hiện tại không đủ số lượng theo yêu cầu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                edt_CapNhatSoLuong.Text = "";
                return;
            }

            int deltaSoLuong = 0;
            decimal deltaThanhTien = 0;
            ChiTietHoaDonBanHangBUS.CapNhatCTHDBH(this.currentMaCTHD, SoLuongMua, ref deltaSoLuong, ref deltaThanhTien);

            decimal result = 0;
            MatHangBUS.CapNhatSoLuongMatHang(this.selectedMaMH, deltaSoLuong);
            HoaDonBanHangBUS.CapNhatTongTienHD(this.currentMaHDBH, deltaThanhTien, ref result);
            edt_TongTien.Text = result.ToString();

            this.refreshTableChiTiet();
            this.refreshTableMatHang();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.btn_Add.Enabled = false;
            this.btn_Delete.Enabled = false;
            this.btn_Sua.Enabled = false;
            this.btn_ThanhToan.Enabled = false;
            this.gridControlChiTiet.DataSource = ChiTietHoaDonBanHangBUS.loadAllCTHDBHById(-1);
            this.btn_LapHoaDon.Enabled = true;

            edt_TenKH.Text = "";
            edt_CapNhatSoLuong.Text = "";
            edt_SoLuong.Text = "";
            edt_TongTien.Text = "0";

            BanHangBUS.exportPDF(ChiTietHoaDonBanHangDAO.loadChiTietToDataTable(this.currentMaHDBH));
        }

        private void gridViewChiTiet_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.currentMaCTHD = long.Parse(gridViewChiTiet.GetFocusedRowCellValue("MaChiTietHD").ToString());
                this.selectedMaMH = long.Parse(gridViewChiTiet.GetFocusedRowCellValue("MaMH").ToString());
                this.currentSL = int.Parse(gridViewChiTiet.GetFocusedRowCellValue("SoLuong").ToString());
                edt_CapNhatSoLuong.Text = this.currentSL.ToString();
            }
            catch (Exception) { }
        }
    }
}
