using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class PhieuHenDAO
    {
        public static List<string> loadMaPH()
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            List<string> results = new List<string>();
            var query = from pl in db.PHIEUHENs
                        select pl;

            foreach (var pl in query)
            {
                results.Add(pl.MaPH.ToString());
            }

            return results;
        }

        public static bool ThemPhieuHen(PHIEUHEN ph)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.PHIEUHENs.InsertOnSubmit(ph);

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

        public static bool SuaPhieuHen(int MaPH, PHIEUHEN ph)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            PHIEUHEN phieuhen = db.PHIEUHENs.Single(p => p.MaPH == MaPH);
           // phieuhen.MaPH = ph.MaPH;
            phieuhen.NgayLap = ph.NgayLap;
            phieuhen.TenKH = ph.TenKH;
            phieuhen.SoDT = ph.SoDT;
            phieuhen.TinhTrangMay= ph.TinhTrangMay;

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

        public static bool XoaPhieuHen(int MaPH)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            PHIEUHEN ph = db.PHIEUHENs.Single(p => p.MaPH == MaPH);
            db.PHIEUHENs.DeleteOnSubmit(ph);
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
