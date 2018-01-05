using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuaHangDDS.DAO;

namespace QLCuaHangDDS.BUS
{
    class DichVuBUS
    {
        public static bool ThemDichVu(DICHVU dv)
        {
            if (dv.TenDV.Equals("") || dv.DonGia.Equals(""))
            {
                return false;
            }
            return DichVuDAO.ThemDichVu(dv);
        }

        public static bool SuaDichVu(String tenDv, DICHVU dv)
        {
            if (dv.TenDV.Equals("") || dv.DonGia.Equals(""))
            {
                return false;
            }
            return DichVuDAO.SuaDichVu(tenDv, dv);
        }

        public static bool XoaDichVu(String tenDv)
        {
            return DichVuDAO.XoaDichVu(tenDv);
        }
    }
}

