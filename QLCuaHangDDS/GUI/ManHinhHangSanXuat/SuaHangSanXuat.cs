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

namespace QLCuaHangDDS.GUI.ManHinhHangSanXuat
{
    public partial class SuaHangSanXuat : DevExpress.XtraEditors.XtraForm
    {
        String originalName;
        public SuaHangSanXuat(String tenHangSX, String moTa)
        {
            InitializeComponent();
            this.originalName = tenHangSX;
            this.edt_TenHangSanXuat.Text = tenHangSX;
            this.edt_MoTa.Text = moTa;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DAO.HANGSANXUAT hsx = new DAO.HANGSANXUAT();
            hsx.TenHangSX = edt_TenHangSanXuat.Text.ToString();
            hsx.MoTa = edt_MoTa.Text.ToString();
            if (HangSanXuatBUS.SuaHangSanXuat(this.originalName, hsx))
            {
                XtraMessageBox.Show("Cập nhật thành công!", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thất bại!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_HuyThayDoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
