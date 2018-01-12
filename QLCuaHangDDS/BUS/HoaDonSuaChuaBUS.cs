using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class HoaDonSuaChuaBUS
    {
        public static bool ThemHoaDonSuaChua(HOADONSUACHUA hdsc, ref long id)
        {
            if (hdsc.TenKH.Equals(""))
                return false;
            return HoaDonSuaChuaDAO.ThemHoaDonSuaChua(hdsc, ref id);
        }
        public static bool ThemHoaDonSuaChua(HOADONSUACHUA hdsc)
        {
            if (hdsc.MaHDSC.Equals("") || hdsc.MaPH.Equals("") || hdsc.TenKH.Equals("") || hdsc.TongTien.Equals(""))
            {
                return false;
            }
            return HoaDonSuaChuaDAO.ThemHoaDonSuaChua(hdsc);
        }

        public static bool SuaHoaDonSuaChua(int mahdsc, HOADONSUACHUA hdsc)
        {
            if (hdsc.MaHDSC.Equals("") || hdsc.MaPH.Equals("") || hdsc.TenKH.Equals("") || hdsc.TongTien.Equals(""))
            {
                return false;
            }
            return HoaDonSuaChuaDAO.SuaHoaDonSuaChua(mahdsc, hdsc);
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

        public static bool CapNhatTongTienHD(long id, decimal ThanhTien, ref decimal result)
        {
           
                return HoaDonSuaChuaDAO.CapNhatTongTienHD(id, ThanhTien, ref result);
            
        }
    }
}
