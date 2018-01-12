<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
=======
using QLCuaHangDDS.GUI.ManHinhBangSuaChua;
>>>>>>> 0ebda5c128737e4cc7dc8d4a4e5a054d0af1645a
using QLCuaHangDDS.GUI.ManHinhBanHang;
using QLCuaHangDDS.GUI.ManHinhDichVu;
using QLCuaHangDDS.GUI.ManHinhHangHoa;
using QLCuaHangDDS.GUI.ManHinhHangSanXuat;
using QLCuaHangDDS.GUI.ManHinhPhanLoai;
<<<<<<< HEAD
using QLCuaHangDDS.GUI.ManHinhDichVu;
using QLCuaHangDDS.GUI.ManHinhBangSuaChua;
using QLCuaHangDDS.GUI.ManHinhPhieuHen;
using QLCuaHangDDS.GUI.ManHinhHoaDonSuaChua;
using QLCuaHangDDS.GUI.ManHinhChiTietHoaDonSuaChua;
using QLCuaHangDDS.GUI.ManHinhHoaDonSuaChua1;
=======
using System;
using System.Windows.Forms;
>>>>>>> 0ebda5c128737e4cc7dc8d4a4e5a054d0af1645a

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
                //forms.Activated += onManHinhPhieuHenActivated;
            }
            else
            {
                frm.Activate();
            }
        }
        private void onManHinhPhieuHenActivated(object sender, EventArgs e)
        {
            PhieuHen frm = GetThongTinPhieuHen();
           frm.updateExternalBind();

        }
       
        private dynamic GetThongTinPhieuHen()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PhieuHen))

                    return f;
            }
            return null;
        }

        private void btn_PhieuHen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(PhieuHen));
            if (frm == null)
            {
                PhieuHen forms = new PhieuHen();
                forms.MdiParent = this;
                forms.Show();
                forms.Activated += onManHinhPhieuHenActivated;
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_HoaDonSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(HoaDonSuaChua));
            if (frm == null)
            {
                HoaDonSuaChua forms = new HoaDonSuaChua();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_ChiTietHoaDonSuaChua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(ManHinhChiTietHoaDonSuaChua.ManHinhHoaDonSuaChua1));
            if (frm == null)
            {
                ManHinhChiTietHoaDonSuaChua.ManHinhHoaDonSuaChua1 forms = new ManHinhChiTietHoaDonSuaChua.ManHinhHoaDonSuaChua1();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btn_HoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(HoaDonSuaChua1));
            if (frm == null)
            {
                HoaDonSuaChua1 forms = new HoaDonSuaChua1();
                forms.MdiParent = this;
                forms.Show();
                forms.Activated += onManHinhHoaDonActivated;

            }
            else
            {
                frm.Activate();
            }
        }
        private void onManHinhHoaDonActivated(object sender, EventArgs e)
        {
            dynamic frm = GetThongTinHoaDonSuaChua();
            frm.updateExternalBind();
        }

        private dynamic GetThongTinHoaDonSuaChua()
        {
            foreach (Form  f in this.MdiChildren)
            {
                if (f.GetType() == typeof(HoaDonSuaChua1))
          
                return f;
            }
            return null;
        }
    }
}
