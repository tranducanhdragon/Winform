using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MayTinhBLL
    {
        PhongMayAccess pma = new DAL.PhongMayAccess();
        public List<MayTinh> LayToanBoMayTinh()
        {
            return pma.LayToanBoMayTinh();
        }
        public bool TatMay(string ma)
        {
            return pma.TatMay(ma);
        }
        public bool TatMayTuUser(string tenUser)
        {
            return pma.TatMayTuUser(tenUser);
        }
        public void UpDateGioChoi(string tenDangNhap, string sogio)
        {
            pma.UpDateGioChoi(tenDangNhap, sogio);
        }
        public string CheckEmptyMay()
        {
            if(pma.CheckEmpty() == null)
            {
                return null;
            }
            else
            {
                return pma.CheckEmpty();
            }
        }
    }
}
