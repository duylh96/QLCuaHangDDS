﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangDDS.GUI.ManHinhBanHang;
using QLCuaHangDDS.GUI.ManHinhHangHoa;
using QLCuaHangDDS.GUI.ManHinhHangSanXuat;

namespace QLCuaHangDDS.GUI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btn_BanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(BanHang));
            if (frm == null)
            {
                BanHang forms = new BanHang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_HangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(ThongTinHang));
            if (frm == null)
            {
                ThongTinHang forms = new ThongTinHang();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_HangSanXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(HangSanXuat));
            if (frm == null)
            {
                HangSanXuat forms = new HangSanXuat();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}
