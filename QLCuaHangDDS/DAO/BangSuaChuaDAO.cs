using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class BangSuaChuaDAO
    {
        public static BANGSUACHUA getMatHangById(string id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            return db.BANGSUACHUAs.Single(p => p.TenMHSC == id);
        }

        public static bool ThemBangSuaChua(BANGSUACHUA bsc)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.BANGSUACHUAs.InsertOnSubmit(bsc);

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

        public static bool SuaBangSuaChua(String tenMHSC, BANGSUACHUA bsc)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            BANGSUACHUA bangSC = db.BANGSUACHUAs.Single(p => p.TenMHSC == tenMHSC);
            bangSC.TenMHSC = bsc.TenMHSC;
            bangSC.ChiPhiSuaChua = bsc.ChiPhiSuaChua;

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
        public static bool XoaBangSuaChua(String tenMHSC)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            BANGSUACHUA q = db.BANGSUACHUAs.Single(p => p.TenMHSC == tenMHSC);
            db.BANGSUACHUAs.DeleteOnSubmit(q);

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
