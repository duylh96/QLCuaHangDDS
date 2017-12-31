using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class HangSanXuatBUS
    {
        public static bool ThemHangSanXuat(HANGSANXUAT hsx)
        {
            if (hsx.TenHangSX.Equals("") || hsx.MoTa.Equals(""))
            {
                return false;
            }
            return HangSanXuatDAO.ThemHangSanXuat(hsx);
        }
    }
}
