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
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using QLCuaHangDDS.DAO;
using QLCuaHangDDS.BUS;

namespace QLCuaHangDDS.GUI.ManHinhChiTietHoaDonSuaChua
{
    public partial class ManHinhHoaDonSuaChua1 : DevExpress.XtraEditors.XtraForm
    {
        private static string selectedTenMHSC;
        private int selectedMaCTSC;
        private int selectedMaHDSC;
        private string selecteTenMHSC;
        public ManHinhHoaDonSuaChua1()
        {
            InitializeComponent();
            this.refreshData();
        }
        public void refreshData()
        {
           ChiTietHoaDonSuaChua_table.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().CHITIETHOADONSUACHUAs;

            ChiTietHoaDonSuaChua_gv.Columns[0].OptionsColumn.AllowEdit = false;
            ChiTietHoaDonSuaChua_gv.Columns[1].OptionsColumn.AllowEdit = false;
            ChiTietHoaDonSuaChua_gv.Columns[2].OptionsColumn.AllowEdit = false;
            ChiTietHoaDonSuaChua_gv.Columns[3].OptionsColumn.AllowEdit = false;
            ChiTietHoaDonSuaChua_gv.Columns[4].OptionsColumn.AllowEdit = false;
            ChiTietHoaDonSuaChua_gv.Columns[5].OptionsColumn.AllowEdit = false;

            ChiTietHoaDonSuaChua_gv.Columns[0].Caption = "Mã Chi Tiết Hoá Đơn Sửa Chữa";
            ChiTietHoaDonSuaChua_gv.Columns[1].Caption = "Mã Hoá Đơn Sửa Chữa";
            ChiTietHoaDonSuaChua_gv.Columns[2].Caption = "Tên Mặt Hàng Sửa Chữa";
            ChiTietHoaDonSuaChua_gv.Columns[3].Caption = "Số Lượng";
            ChiTietHoaDonSuaChua_gv.Columns[4].Caption = "Chi Phí Lúc Sửa";
            ChiTietHoaDonSuaChua_gv.Columns[5].Caption = "Thành Tiền";
            ChiTietHoaDonSuaChua_gv.Columns[6].Visible = false;
            ChiTietHoaDonSuaChua_gv.Columns[7].Visible = false;

          
        }
        public static List<string> LoadMaHDSC()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.HOADONSUACHUAs
                        select pl;

            foreach (var pl in query)
            {
                results.Add(pl.MaHDSC.ToString());
            }

            return results;
        }
        public static List<string> LoadTenMHSC()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.BANGSUACHUAs
                        select pl;

            foreach (var pl in query)
            {
                results.Add(pl.TenMHSC.ToString());
            }

            return results;
        }

        public static List<string> LoadChiPhiSC()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.BANGSUACHUAs
                        select pl;

            foreach (var pl in query)
            {
                results.Add(pl.ChiPhiSuaChua.ToString());
            }

            return results;
        }
        public static String getChiPhiSC()
        {
            
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            String ChiPhi="";
            var query = from pl in db.BANGSUACHUAs
                        where pl.TenMHSC == selectedTenMHSC
                        select pl;

            foreach (var pl in query)
            {
                ChiPhi = pl.ChiPhiSuaChua.ToString();
            }
            return ChiPhi;

        }
       

       

        private void ChiTietHoaDonSuaChua_gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.selectedMaHDSC = int.Parse(ChiTietHoaDonSuaChua_gv.GetFocusedRowCellValue("MaHDSC").ToString());
                this.selectedMaCTSC= int.Parse(ChiTietHoaDonSuaChua_gv.GetFocusedRowCellValue("MaCTSC").ToString());
                this.selecteTenMHSC = ChiTietHoaDonSuaChua_gv.GetFocusedRowCellValue("TenMHSC").ToString();
            }
            catch (Exception) { }
        }

        private void ManHinhHoaDonSuaChua1_Load(object sender, EventArgs e)
        {

        }
    }
}