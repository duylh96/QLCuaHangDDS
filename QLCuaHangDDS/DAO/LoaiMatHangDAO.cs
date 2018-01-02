using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class LoaiMatHangDAO
    {
        public static bool ThemLoaiMatHang(LOAIMATHANG lmh)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.LOAIMATHANGs.InsertOnSubmit(lmh);

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

        public static bool SuaLoaiMatHang(String tenLmh, LOAIMATHANG lmh)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            LOAIMATHANG q = db.LOAIMATHANGs.Single(p => p.TenLoaiMH == tenLmh);
            q.TenLoaiMH = lmh.TenLoaiMH;
            q.MoTa = lmh.MoTa;

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

        public static bool XoaLoaiMatHang(String tenLmh)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            LOAIMATHANG q = db.LOAIMATHANGs.Single(p => p.TenLoaiMH == tenLmh);
            db.LOAIMATHANGs.DeleteOnSubmit(q);

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
