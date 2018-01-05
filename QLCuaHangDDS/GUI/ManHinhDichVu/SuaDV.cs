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
    public partial class SuaDV : DevExpress.XtraEditors.XtraForm
    {
        String originName;
        public SuaDV(String tenDv, String donGia)
        {
            InitializeComponent();
            this.originName = tenDv;
            this.textEdit1.Text = tenDv;
            this.textEdit2.Text = donGia;
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
            dv.TenDV = textEdit1.Text.ToString();
            if (Decimal.TryParse(textEdit2.Text, out val))
                dv.DonGia = val;
            if (DichVuBUS.SuaDichVu(this.originName, dv))
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
    }
}