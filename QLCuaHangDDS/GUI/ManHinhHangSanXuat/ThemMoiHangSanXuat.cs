using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDDS.DAO;
using QLCuaHangDDS.BUS;
using DevExpress.XtraEditors;

namespace QLCuaHangDDS.GUI.ManHinhHangSanXuat
{
    public partial class ThemMoiHangSanXuat : DevExpress.XtraEditors.XtraForm
    {
        public ThemMoiHangSanXuat()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DAO.HANGSANXUAT hsx = new DAO.HANGSANXUAT();
            hsx.TenHangSX = edt_TenHangSanXuat.Text.ToString();
            hsx.MoTa = edt_MoTa.Text.ToString();
            if (HangSanXuatBUS.ThemHangSanXuat(hsx))
            {
                XtraMessageBox.Show("Thêm thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                XtraMessageBox.Show("Thêm thất bại!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
