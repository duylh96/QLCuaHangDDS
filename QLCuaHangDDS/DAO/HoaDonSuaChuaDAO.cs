using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class HoaDonSuaChuaDAO
    {
        public static bool ThemHoaDonSuaChua(HOADONSUACHUA hdsc, ref long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.HOADONSUACHUAs.InsertOnSubmit(hdsc);

            try
            {
                db.SubmitChanges();
                id = hdsc.MaHDSC;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool ThemHoaDonSuaChua(HOADONSUACHUA hdsc)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            hdsc.TongTien = 0;
            db.HOADONSUACHUAs.InsertOnSubmit(hdsc);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool SuaHoaDonSuaChua(int maHDSC, HOADONSUACHUA hdsc)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            HOADONSUACHUA hoadonSC = db.HOADONSUACHUAs.Single(p => p.MaHDSC == maHDSC);
            hoadonSC.MaHDSC = hdsc.MaHDSC;
            hoadonSC.MaPH = hdsc.MaPH;
            hoadonSC.TenKH = hdsc.TenKH;
            hoadonSC.NgayLap = hdsc.NgayLap;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CapNhatTongTienHD(long id, decimal ThanhTien, ref decimal result)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var hd = db.HOADONSUACHUAs.Single(p => p.MaHDSC == id);
            hd.TongTien += ThanhTien;

            result = hd.TongTien.Value;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
  
}
