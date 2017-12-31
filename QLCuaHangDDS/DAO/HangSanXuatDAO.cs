using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return false;
            }
        }
    }
}
