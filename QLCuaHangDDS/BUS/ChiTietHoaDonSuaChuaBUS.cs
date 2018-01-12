using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    public class ChiTietHoaDonSuaChuaBUS
    {
        public static dynamic loadAllCTHDSCById(long id)
        {
            return ChiTietHoaDonSuaChuaDAO.loadAllCTHDSCById(id);
        }

        public static bool ThemChiTietHoaDonSuaChua(CHITIETHOADONSUACHUA cthdsc)
        {
            if (cthdsc.MaCTSC.Equals("") || cthdsc.MaHDSC.Equals("") || cthdsc.TenMHSC.Equals("") || cthdsc.SoLuong.Equals("") || cthdsc.DonGiaLucBan.Equals("") || cthdsc.ThanhTien.Equals(""))
            {
                return false;
            }
            return ChiTietHoaDonSuaChuaDAO.ThemChiTietHoaDonSuaChua(cthdsc);
        }

        public static bool SuaChiTietHoaDonSuaChua(int mactsc, CHITIETHOADONSUACHUA cthdsc)
        {
            if (cthdsc.MaCTSC.Equals("") || cthdsc.MaHDSC.Equals("") || cthdsc.TenMHSC.Equals("") || cthdsc.SoLuong.Equals("") || cthdsc.DonGiaLucBan.Equals("") || cthdsc.ThanhTien.Equals("") || mactsc.Equals(""))
            {
                return false;
            }
            return ChiTietHoaDonSuaChuaDAO.SuaChiTietHoaDonSuaChua(mactsc, cthdsc);
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

       

        public static bool CapNhatSoLuong(long id, int sl)
        {
            return ChiTietHoaDonSuaChuaDAO.CapNhatSoLuong(id, sl);
        }

        public static bool XoaChiTietHDSC(long id)
        {
            return ChiTietHoaDonSuaChuaDAO.XoaChiTietHDSC(id);
        }

        public static bool CapNhatCTHDSC(long id, int sl, ref int deltaSoLuong, ref decimal deltaThanhTien)
        {
            return ChiTietHoaDonSuaChuaDAO.CapNhatCTHDSC(id, sl, ref deltaSoLuong, ref deltaThanhTien);
        }
    }
}
