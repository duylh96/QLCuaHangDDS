using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class HangSanXuatDAO
    {
        public static bool ThemHangSanXuat(HANGSANXUAT hsx)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            db.HANGSANXUATs.InsertOnSubmit(hsx);

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

        public static bool SuaHangSanXuat(String tenHsx, HANGSANXUAT hsx)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            HANGSANXUAT hANGSANXUAT = db.HANGSANXUATs.Single(p => p.TenHangSX == tenHsx);
            hANGSANXUAT.TenHangSX = hsx.TenHangSX;
            hANGSANXUAT.MoTa = hsx.MoTa;

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

        public static bool XoaHangSanXuat(String tenHangSX)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            HANGSANXUAT hsx = db.HANGSANXUATs.Single(p => p.TenHangSX == tenHangSX);
            db.HANGSANXUATs.DeleteOnSubmit(hsx);

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
