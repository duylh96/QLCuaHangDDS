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
using QLCuaHangDDS.DAO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using QLCuaHangDDS.BUS;
using DevExpress.Utils;

namespace QLCuaHangDDS.GUI.ManHinhHoaDonSuaChua
{
    public partial class HoaDonSuaChua : DevExpress.XtraEditors.XtraForm
    {
        private int selectedMaHDSC;
        private int selectedMaPH;
        public HoaDonSuaChua()
        {
            InitializeComponent();
            this.refreshData();
        }
        public void refreshData()
        {
            HoaDonSuaChua_table.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().HOADONSUACHUAs;
            HoaDonSuaChua_gv.Columns[0].OptionsColumn.AllowEdit = false;
            HoaDonSuaChua_gv.Columns[1].OptionsColumn.AllowEdit = false;
            HoaDonSuaChua_gv.Columns[2].OptionsColumn.AllowEdit = false;
            HoaDonSuaChua_gv.Columns[3].OptionsColumn.AllowEdit = false;
            HoaDonSuaChua_gv.Columns[4].OptionsColumn.AllowEdit = false;

            HoaDonSuaChua_gv.Columns[0].Caption = "Mã Hoá Đơn Sửa Chữa";
            HoaDonSuaChua_gv.Columns[1].Caption = "Mã Phiếu Hẹn";
            HoaDonSuaChua_gv.Columns[2].Caption = "Tên Khách Hàng";
            HoaDonSuaChua_gv.Columns[3].Caption = "Ngày Lập";
            HoaDonSuaChua_gv.Columns[4].Caption = "Tổng Tiền";
            HoaDonSuaChua_gv.Columns[5].Visible = false;
            HoaDonSuaChua_gv.Columns[3].DisplayFormat.FormatType = FormatType.DateTime;
            HoaDonSuaChua_gv.Columns[3].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
           
           
          
        }
        public static List<string> LoadMaPH()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.PHIEUHENs
                        select pl;

            foreach (var pl in query)
            {
                results.Add(pl.MaPH.ToString());
            }

            return results;
        }
        
      

        private void HoaDonSuaChua_gv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
            try
            {
                this.selectedMaHDSC = int.Parse(HoaDonSuaChua_gv.GetFocusedRowCellValue("MaHDSC").ToString());
                this.selectedMaPH = int.Parse(HoaDonSuaChua_gv.GetFocusedRowCellValue("MaPH").ToString());
            }
            catch (Exception) { }
        }

       
       

        private void HoaDonSuaChua_tabl_Click(object sender, EventArgs e)
        {

        }
    }
}