using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class PhieuHenBUS
    {
        public static bool ThemPhieuHen(PHIEUHEN ph)
        {
            if (ph.TenKH.Equals("") || ph.SoDT.Equals("") || ph.TinhTrangMay.Equals("") || ph.NgayLap.Equals(""))
            {
                return false;
            }
            return PhieuHenDAO.ThemPhieuHen(ph);
        }

        public static bool SuaPhieuHen(int maph, PHIEUHEN ph)
        {
            if (ph.TenKH.Equals("") || ph.SoDT.Equals("") || ph.TinhTrangMay.Equals("") || ph.NgayLap.Equals("") || maph.Equals(""))
            {
                return false;
            }
            return PhieuHenDAO.SuaPhieuHen(maph, ph);
        }
        public static bool XoaPhieuHen(int MaPH)
        {
            return PhieuHenDAO.XoaPhieuHen(MaPH);
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
