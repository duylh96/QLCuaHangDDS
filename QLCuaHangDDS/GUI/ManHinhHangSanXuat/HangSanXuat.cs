using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDDS.BUS;

namespace QLCuaHangDDS.GUI.ManHinhHangSanXuat
{
    public partial class HangSanXuat : Form
    {
        public HangSanXuat()
        {
            InitializeComponent();
            dataResults.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().HANGSANXUATs;
            gridView.Columns[0].Caption = "Hãng sản xuất";
            gridView.Columns[1].Caption = "Mô tả";
        }

        private void btn_dong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemMoiHangSanXuat form = new ThemMoiHangSanXuat();
            form.Show();
            form.FormClosed += RefreshTableData;
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenHangSX = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "TenHangSX").ToString();
            String moTa = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "MoTa").ToString();
            SuaHangSanXuat form = new SuaHangSanXuat(tenHangSX, moTa);
            form.Show();
            form.FormClosed += RefreshTableData;
        }

        private void RefreshTableData(object sender, FormClosedEventArgs e)
        {
            dataResults.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().HANGSANXUATs;
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa Hãng sản xuất này ? Điều này không thể hoàn tác!", "Waring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                String tenHangSX = this.gridView.GetRowCellValue(this.gridView.FocusedRowHandle, "TenHangSX").ToString();

                if (HangSanXuatBUS.XoaHangSanXuat(tenHangSX))
                {
                    XtraMessageBox.Show("Xóa thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.RefreshTableData(null, null);
                }
                else
                {
                    XtraMessageBox.Show("Xóa thất bại!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
