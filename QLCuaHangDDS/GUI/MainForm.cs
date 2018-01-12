using QLCuaHangDDS.GUI.ManHinhBangSuaChua;
using QLCuaHangDDS.GUI.ManHinhBanHang;
using QLCuaHangDDS.GUI.ManHinhDichVu;
using QLCuaHangDDS.GUI.ManHinhHangHoa;
using QLCuaHangDDS.GUI.ManHinhHangSanXuat;
using QLCuaHangDDS.GUI.ManHinhPhanLoai;
using QLCuaHangDDS.GUI.ManHinhTraCuuHoaDonBanHang;
using System;
using System.Windows.Forms;

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

        private dynamic GetThongTinHang()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ThongTinHang))
                    return f;
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
                forms.Activated += onManHinhThongTinHangActivated;
            }
            else
            {
                frm.Activate();
            }
        }

        private void onManHinhThongTinHangActivated(object sender, EventArgs e)
        {
            dynamic frm = GetThongTinHang();
            frm.updateExternalBind();
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

        private void btn_PhanLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(ThongTinPhanLoai));
            if (frm == null)
            {
                ThongTinPhanLoai forms = new ThongTinPhanLoai();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(DichVu));
            if (frm == null)
            {
                DichVu forms = new DichVu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_BangSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(BangSuaChua));
            if (frm == null)
            {
                BangSuaChua forms = new BangSuaChua();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTraCuuBanHang_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(TraCuuHoaDonBanHang));
            if (frm == null)
            {
                TraCuuHoaDonBanHang forms = new TraCuuHoaDonBanHang();
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
