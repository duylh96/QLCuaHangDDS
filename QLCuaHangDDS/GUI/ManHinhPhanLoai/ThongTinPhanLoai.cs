using DevExpress.XtraEditors;
using QLCuaHangDDS.BUS;
using QLCuaHangDDS.DAO;
using System;
using System.Windows.Forms;

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
            this.edt_tenLmh.Text = "";
            this.edt_moTa.Text = "";
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
            if (LoaiMatHangBUS.XoaLoaiMatHang(this.currentTenLmh))
            {
                XtraMessageBox.Show("Xóa thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefreshData();
                return;
            }
            else
            {
                XtraMessageBox.Show("Xóa thất bại!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.currentTenLmh = gridView1.GetFocusedRowCellValue("TenLoaiMH").ToString();
        }
    }
}