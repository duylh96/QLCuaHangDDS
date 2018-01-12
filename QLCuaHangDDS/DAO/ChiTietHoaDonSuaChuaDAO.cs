using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLCuaHangDDS.DAO
{
    public class ChiTietHoaDonSuaChuaDAO
    {
        public static dynamic loadAllCTHDSCById(long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            var query = (from cthd in db.CHITIETHOADONSUACHUAs
                         join bsc in db.BANGSUACHUAs
                         on cthd.TenMHSC equals bsc.TenMHSC
                         where cthd.MaHDSC == id
                         select new { cthd.MaCTSC, cthd.MaHDSC, cthd.TenMHSC,cthd.SoLuong, cthd.DonGiaLucBan, cthd.ThanhTien }).ToList();

            return query;
        }
        public static bool ThemChiTietHoaDonSuaChua(CHITIETHOADONSUACHUA cthdsc)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            db.CHITIETHOADONSUACHUAs.InsertOnSubmit(cthdsc);

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

        public static bool SuaChiTietHoaDonSuaChua(int mactHDSC, CHITIETHOADONSUACHUA cthdsc)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();

            CHITIETHOADONSUACHUA chitietHDSC = db.CHITIETHOADONSUACHUAs.Single(p => p.MaCTSC == mactHDSC);
            chitietHDSC.MaCTSC = cthdsc.MaCTSC;
            chitietHDSC.MaHDSC = cthdsc.MaHDSC;
            chitietHDSC.TenMHSC = cthdsc.TenMHSC;
            chitietHDSC.SoLuong = cthdsc.SoLuong;
            chitietHDSC.DonGiaLucBan = cthdsc.DonGiaLucBan;
            chitietHDSC.ThanhTien = cthdsc.ThanhTien;
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

        public static bool XoaChiTietHDSC(long id)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var cthdsc = db.CHITIETHOADONSUACHUAs.Single(p => p.MaCTSC == id);
            db.CHITIETHOADONSUACHUAs.DeleteOnSubmit(cthdsc);

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

        public static bool CapNhatCTHDSC(long id, int sl, ref int deltaSoLuong, ref decimal deltaThanhTien)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var cthdsc = db.CHITIETHOADONSUACHUAs.Single(p => p.MaCTSC == id);

            deltaSoLuong = sl - int.Parse(cthdsc.SoLuong.Value.ToString());
            deltaThanhTien = sl * cthdsc.DonGiaLucBan.Value - cthdsc.ThanhTien.Value;


            cthdsc.SoLuong = sl;
            cthdsc.ThanhTien = cthdsc.SoLuong * cthdsc.DonGiaLucBan;


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

        public static bool CapNhatSoLuong(long id, int sl)
        {
            QLCuaHangDDSDBDataContext db = new QLCuaHangDDSDBDataContext();
            var mh = db.CHITIETHOADONSUACHUAs.Single(p => p.MaCTSC == id);
            //mh.SoLuong -= sl;

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
