using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLCuaHangDDS.BUS;
using QLCuaHangDDS.DAO;
using DevExpress.XtraEditors;

namespace QLCuaHangDDS.GUI.ManHinhPhanLoai
{
    public partial class ThongTinPhanLoai : DevExpress.XtraEditors.XtraForm
    {
        private String currentTenLmh;
        public ThongTinPhanLoai()
        {
            InitializeComponent();
            gridControl1.DataSource = new QLCuaHangDDSDBDataContext().LOAIMATHANGs;
            gridView1.Columns[0].Caption = "Phân loại";
            gridView1.Columns[1].Caption = "Mô tả";
        }

        private void RefreshData()
        {
            gridControl1.DataSource = new QLCuaHangDDSDBDataContext().LOAIMATHANGs;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            LOAIMATHANG lmh = new LOAIMATHANG();
            lmh.TenLoaiMH = edt_tenLmh.Text.ToString();
            lmh.MoTa = edt_moTa.Text.ToString();

            if (LoaiMatHangBUS.ThemLoaiMatHang(lmh))
            {
                XtraMessageBox.Show("Thêm thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshData();
                return;
            }
            else
            {
                XtraMessageBox.Show("Thêm thất bại!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            LOAIMATHANG lmh = new LOAIMATHANG();
            lmh.TenLoaiMH = this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenLoaiMH").ToString();
            lmh.MoTa = this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MoTa").ToString();

            if (LoaiMatHangBUS.SuaLoaiMatHang(this.currentTenLmh, lmh))
            {
                XtraMessageBox.Show("Cập nhật thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshData();
                return;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thất bại!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.currentTenLmh = this.gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenLoaiMH").ToString();
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
        }
    }
}