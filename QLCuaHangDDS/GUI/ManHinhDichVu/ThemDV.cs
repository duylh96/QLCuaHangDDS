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

namespace QLCuaHangDDS.GUI.ManHinhDichVu
{
    public partial class ThemDV : DevExpress.XtraEditors.XtraForm
    {
        public ThemDV()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chắc chắn muốn thoát?", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            decimal val;
            DAO.DICHVU dv = new DAO.DICHVU();
            dv.TenDV = txtTenDV.Text.ToString();
            if (Decimal.TryParse(txtDonGia.Text, out val))
                dv.DonGia = val;
            if (DichVuBUS.ThemDichVu(dv))
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