using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCuaHangDDS.BUS;
using QLCuaHangDDS.DAO;
using DevExpress.XtraEditors.Controls;

namespace QLCuaHangDDS.GUI.ManHinhHoaDonSuaChua1
{
    public partial class HoaDonSuaChua1 : DevExpress.XtraEditors.XtraForm
    {
        private string currentTenMHSC;
        //private string selectedTenMHSC;
        private long currentMaHDSC;
        private long currentMaCTHDSC = -1;
        private string selectedTenMHSC;
        private int currentSL;
        public HoaDonSuaChua1()
        {
            InitializeComponent();
            this.refreshData();
           
        }
        public void updateExternalBind()
        {
            // Init Phan Loai
            BangSuaChua_gc.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().BANGSUACHUAs;
            

            //BangSuaChua_gc.Properties.ShowHeader = false;

            // Init Hang san xuat
            //cbb_HangSanXuat.Properties.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().HANGSANXUATs;
            //cbb_HangSanXuat.Properties.ShowHeader = false;
        }
        private void refreshData()
        {
            
            BangSuaChua_gc.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().BANGSUACHUAs;
            BangSuaChua_gv.Columns[0].OptionsColumn.AllowEdit = false;
            cbx_MaPH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            BangSuaChua_gv.Columns[0].Caption = "Tên Sửa Chữa";
            BangSuaChua_gv.Columns[1].Caption = "Chi Phí Lúc Sửa";

            ComboBoxItemCollection itemsCollection = cbx_MaPH.Properties.Items;
            cbx_MaPH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            itemsCollection.BeginUpdate();
            List<String> list = LoadMaPH();
            try
            {
                foreach (var item in list)
                    itemsCollection.Add(item);
            }
            finally
            {
                itemsCollection.EndUpdate();
            }

        }
        private static List<string> LoadMaPH()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.PHIEUHENs 
                        select pl.MaPH;
            var query2 = from pl in db.PHIEUHENs
                         where !(from o in db.HOADONSUACHUAs
                                 select o.MaPH)
                              .Contains(pl.MaPH)
                         select pl;
            foreach (var pl in query2)
            {   
                        results.Add(pl.MaPH.ToString());     
                
            }

            return results;
        }
        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            
            if (HoaDonSuaChuaBUS.isValidNumber(edt_TenKH.Text.ToString()) || edt_TenKH.Text.ToString().Equals("") || cbx_MaPH.SelectedItem.ToString().Equals(""))
            {
                XtraMessageBox.Show("Thông tin không hợp lệ!Vui lòng kiểm tra lại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HOADONSUACHUA hdsc = new HOADONSUACHUA();

            hdsc.TenKH = edt_TenKH.Text.ToString();
            hdsc.MaPH = int.Parse(cbx_MaPH.SelectedItem.ToString());
            hdsc.NgayLap = DateTime.Now;
            hdsc.TongTien = 0;


            //  hdsc.TenKH= edt_TenSC.Text.ToString();
            // hdsc.ChiPhiSuaChua = System.Convert.ToDecimal(edt_ChiPhiSC.Text.ToString());
            if (!HoaDonSuaChuaBUS.ThemHoaDonSuaChua(hdsc, ref this.currentMaHDSC))
            {
                XtraMessageBox.Show("Tên khách hàng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            edt_CapNhatSL.Enabled = true;
            btn_Them.Enabled = true;
            btn_ThanhToan.Enabled = true;
            btn_LapHoaDon.Enabled = false;
            btn_Them.Enabled = true;
        }

        private void BangSuaChua_gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                this.currentTenMHSC = BangSuaChua_gv.GetFocusedRowCellValue("TenMHSC").ToString();
            }
            catch (Exception) { }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            btn_LapHoaDon.Enabled = true;
            this.btn_Them.Enabled = false;
            this.btn_Xoa.Enabled = false;
            this.btn_SuaSL.Enabled = false;
            this.btn_ThanhToan.Enabled = false;
            BangChiTietHoaDon_gc.DataSource = ChiTietHoaDonSuaChuaBUS.loadAllCTHDSCById(-1);
            this.btn_LapHoaDon.Enabled = true;

            edt_TenKH.Text = "";
            edt_CapNhatSL.Text = "";
            edt_SoLuong.Text = "";
            edt_TongTien.Text = "0";

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(edt_SoLuong.Text.Equals("") || !ChiTietHoaDonSuaChuaBUS.isValidNumber(edt_SoLuong.Text))
            {
                XtraMessageBox.Show("Số lượng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            edt_CapNhatSL.Enabled = true;
            btn_Xoa.Enabled = true;
            var selectedHoaDonSuaChua = BangSuaChuaDAO.getMatHangById(this.currentTenMHSC);
            int SoLuong = int.Parse(edt_SoLuong.Text.ToString());

            CHITIETHOADONSUACHUA cthdsc = new CHITIETHOADONSUACHUA();
            cthdsc.MaHDSC = this.currentMaHDSC;
            cthdsc.TenMHSC = this.currentTenMHSC;
            cthdsc.SoLuong = SoLuong;
            cthdsc.DonGiaLucBan= selectedHoaDonSuaChua.ChiPhiSuaChua;
            cthdsc.ThanhTien = cthdsc.SoLuong * cthdsc.DonGiaLucBan;

            if (!ChiTietHoaDonSuaChuaBUS.ThemChiTietHoaDonSuaChua(cthdsc))
            {
                XtraMessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal result = 0;
            HoaDonSuaChuaBUS.CapNhatTongTienHD(this.currentMaHDSC, cthdsc.ThanhTien.Value, ref result);
            edt_TongTien.Text = result.ToString();
            this.refreshTableChiTiet();
            this.refreshTableBangSC();
        }

        private void refreshTableBangSC()
        {
           BangSuaChua_gc.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().BANGSUACHUAs;
           //BangSuaChua_gv.Columns[0].Visible = false;
           BangSuaChua_gv.Columns[0].Caption = "Tên Sửa Chữa";
           BangSuaChua_gv.Columns[1].Caption = "Chi Phí Sửa Chữa";

           //BangSuaChua_gv.FocusedRowHandle =BangSuaChua_gv.GetVisibleRowHandle(0);
        }

        private void refreshTableChiTiet()
        {
            BangChiTietHoaDon_gc.DataSource = ChiTietHoaDonSuaChuaBUS.loadAllCTHDSCById(this.currentMaHDSC);
            BangChiTietHoaDon_gv.Columns[0].Visible = false;
            BangChiTietHoaDon_gv.Columns[1].Visible = false;
           // BangChiTietHoaDon_gv.Columns[2].Visible = false;

            BangChiTietHoaDon_gv.Columns[2].Caption = "Tên mặt hàng";
            BangChiTietHoaDon_gv.Columns[3].Caption = "Số lượng";
            BangChiTietHoaDon_gv.Columns[4].Caption = "Đơn giá";
            BangChiTietHoaDon_gv.Columns[5].Caption = "Thành tiền";

            BangChiTietHoaDon_gv.FocusedRowHandle = BangChiTietHoaDon_gv.GetVisibleRowHandle(0);

            this.btn_Xoa.Enabled = true;
            this.btn_SuaSL.Enabled = true;
            edt_CapNhatSL.Text = "";
        }

        private void BangChiTietHoaDon_gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.currentMaCTHDSC = long.Parse(BangChiTietHoaDon_gv.GetFocusedRowCellValue("MaCTSC").ToString());
                this.selectedTenMHSC = BangChiTietHoaDon_gv.GetFocusedRowCellValue("TenMHSC").ToString();
                this.currentSL = int.Parse(BangChiTietHoaDon_gv.GetFocusedRowCellValue("SoLuong").ToString());
                edt_CapNhatSL.Text = this.currentSL.ToString();
            }
            catch (Exception) { }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int SoLuong = int.Parse(BangChiTietHoaDon_gv.GetFocusedRowCellValue("SoLuong").ToString());
                decimal ThanhTien = decimal.Parse(BangChiTietHoaDon_gv.GetFocusedRowCellValue("ThanhTien").ToString());
                ChiTietHoaDonSuaChuaBUS.XoaChiTietHDSC(this.currentMaCTHDSC);
                var selectedHoaDonSuaChua = BangSuaChuaDAO.getMatHangById(this.currentTenMHSC);

                decimal result = 0;
                HoaDonSuaChuaBUS.CapNhatTongTienHD(this.currentMaHDSC, -ThanhTien, ref result);
                //MatHangBUS.CapNhatSoLuongMatHang(this.selectedMaMH, -soLuongMua);
                edt_TongTien.Text = result.ToString();
                edt_CapNhatSL.Text = "";
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            this.refreshTableChiTiet();
            this.refreshTableBangSC();
        }

        private void btn_SuaSL_Click(object sender, EventArgs e)
        {
            int SoLuong;
            try
            {
                SoLuong = int.Parse(edt_CapNhatSL.Text.ToString());
                if (!HoaDonSuaChuaBUS.isValidNumber(SoLuong))
                {
                    XtraMessageBox.Show("Số lượng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    edt_CapNhatSL.Text = "";
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số lượng không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                edt_CapNhatSL.Text = "";
                return;
            }

            var selectedHoaDonSuaChua = BangSuaChuaDAO.getMatHangById(this.currentTenMHSC);
           
            int deltaSoLuong = 0;
            decimal deltaThanhTien = 0;
            ChiTietHoaDonSuaChuaBUS.CapNhatCTHDSC(this.currentMaCTHDSC, SoLuong, ref deltaSoLuong, ref deltaThanhTien);

            decimal result = 0;
            //MatHangBUS.CapNhatSoLuongMatHang(this.selectedMaMH, deltaSoLuong);
            HoaDonSuaChuaBUS.CapNhatTongTienHD(this.currentMaHDSC, deltaThanhTien, ref result);
            edt_TongTien.Text = result.ToString();

            this.refreshTableChiTiet();
            this.refreshTableBangSC();
        }
    }
}