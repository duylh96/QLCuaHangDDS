using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    class DichVuDAO
    {
        public static bool ThemDichVu(DICHVU dv)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.DICHVUs.InsertOnSubmit(dv);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                DevExpress.XtraEditors.XtraMessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool SuaDichVu(String tenDv, DICHVU dv)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            DICHVU dICHVU = db.DICHVUs.Single(p => p.TenDV == tenDv);
            dICHVU.TenDV = dv.TenDV;
            dICHVU.DonGia = dv.DonGia;

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

        public static bool XoaDichVu(String tenDv)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            DICHVU dv = db.DICHVUs.Single(p => p.TenDV == tenDv);
            db.DICHVUs.DeleteOnSubmit(dv);

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
