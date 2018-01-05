using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class BangSuaChuaBUS
    {
        public static bool ThemBangSuaChua(BANGSUACHUA bsc)
        {
            if (bsc.TenMHSC.Equals("") || bsc.ChiPhiSuaChua.Equals(""))
            {
                return false;
            }
            return BangSuaChuaDAO.ThemBangSuaChua(bsc);
        }

        public static bool SuaBangSuaChua(String tenbsc, BANGSUACHUA bsc)
        {
            if (bsc.TenMHSC.Equals("") || bsc.ChiPhiSuaChua.Equals("") || tenbsc.Equals(""))
            {
                return false;
            }
            return BangSuaChuaDAO.SuaBangSuaChua(tenbsc, bsc);
        }
        public static bool isValidNumber(object number)
        {
            try
            {
                int n = int.Parse(number.ToString());
                if (n > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool isValidFloat(object number)
        {
            try
            {
                float n = float.Parse(number.ToString());
                if (n > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
