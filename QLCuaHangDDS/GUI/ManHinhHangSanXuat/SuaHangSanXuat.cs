using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDDS.GUI.ManHinhHangSanXuat
{
    public partial class SuaHangSanXuat : DevExpress.XtraEditors.XtraForm
    {
        public SuaHangSanXuat(String tenHangSX, String moTa)
        {
            InitializeComponent();
            this.edt_TenHangSanXuat.Text = tenHangSX;
            this.edt_MoTa.Text = moTa;
        }
    }
}
