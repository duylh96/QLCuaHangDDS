using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class HoaDonBanHangDAO
    {
        public static bool ThemHoaDon(HOADONBANHANG hd, ref long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.HOADONBANHANGs.InsertOnSubmit(hd);

            try
            {
                db.SubmitChanges();
                id = hd.MaHD;
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
            var hd = db.HOADONBANHANGs.Single(p => p.MaHD == id);
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
