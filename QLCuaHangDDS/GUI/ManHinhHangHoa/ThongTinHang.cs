using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCuaHangDDS.BUS;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.GUI.ManHinhHangHoa
{
    public partial class ThongTinHang : Form
    {
        public ThongTinHang()
        {
            InitializeComponent();
            gridControl.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().MATHANGs;

            // Init Phan Loai
            cbb_PhanLoai.Properties.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().LOAIMATHANGs;
            cbb_PhanLoai.Properties.ShowHeader = false;

            // Init Hang san xuat
            cbb_HangSanXuat.Properties.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().HANGSANXUATs;
            cbb_HangSanXuat.Properties.ShowHeader = false;
        }

        private void refeshData()
        {
            gridControl.DataSource = new QLCuaHangDDS.DAO.QLCuaHangDDSDBDataContext().MATHANGs;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!MatHangBUS.isValidNumber(edt_SoLuong.Text.ToString()))
            {
                XtraMessageBox.Show("Số lượng không hợp lệ!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MatHangBUS.isValidFloat(edt_DonGia.Text.ToString()))
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MATHANG mh = new MATHANG();
            mh.TenMH = edt_TenMatHang.Text.ToString();
            mh.TenLoaiMH = cbb_PhanLoai.Text.ToString();
            mh.TenHangSX = cbb_HangSanXuat.Text.ToString();
            mh.NamSX = edt_NamSanXuat.Text.ToString();
            mh.SoLuong = int.Parse(edt_SoLuong.Text.ToString());
            mh.DonGia = float.Parse(edt_DonGia.Text.ToString());
            mh.Mota = edt_MoTa.Text.ToString();

            if (MatHangBUS.ThemMatHang(mh))
            {
                XtraMessageBox.Show("Thêm thành công!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.refeshData();
                return;
            }
            else
            {
                XtraMessageBox.Show("Thêm thất bại!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
