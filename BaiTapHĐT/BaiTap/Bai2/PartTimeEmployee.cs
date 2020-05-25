using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class PartTimeEmployee:Employee
    {

        public PartTimeEmployee(string MaNV, string HoTen, string SoHD, int Ngay) : base(MaNV, HoTen, SoHD, Ngay) {}
        public override void TaoHD()
        {
            so_hd = "HDPT" + ma_nv + ngay_vao.ToString();
            Console.WriteLine("So hop dong: " + so_hd);
        }
    }
}
