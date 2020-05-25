using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SinhVien
    {
        private string maSV;
        private string ho;
        private string ten;
        private float diemTB;

        public SinhVien()
        {
            maSV = "NULL";
            ho = "NULL";
            ten = "NULL";
            diemTB = 0;
        }

        public string Ten
        {
            get {
                return ten;
            }
            set { ten = value; }
        }
        public float Diem
        {
            get { return diemTB; }
            set { diemTB = value; }
        }
//         public string LayTen()
//         {
//             string s = "NULL";
//             char[] c = new char[ho_ten.Length];
//             c = ho_ten.ToCharArray();
//             for (int i = ho_ten.Length - 1; i >= 0; i--)
//             {
//                 if (c[i] == ' ')
//                 {
//                     s = ho_ten.Substring(i + 1, ho_ten.Length);
//                     break;
//                 }
//             }
//             return s;
//         }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien: ");
            ho = Console.ReadLine();
            ten = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh sinh vien: ");
            diemTB = Int32.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien: "+ maSV);
            Console.WriteLine("Ho va ten sinh vien: "+ ho + " "+ten);
            Console.WriteLine("Diem trung binh sinh vien: "+ diemTB);
        }
    }
    class SapXepTen : IComparer<SinhVien>
    {
        public int Compare(SinhVien sv1, SinhVien sv2)
        {
            if(string.Compare( sv1.Ten, sv2.Ten, false) > 0)
            {
                return 1;
            }
            else if(string.Compare(sv1.Ten, sv2.Ten, false) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    class SapXepDiem : IComparer<SinhVien>
    {
        public int Compare(SinhVien sv1, SinhVien sv2)
        {
            if (sv1.Diem < sv2.Diem)
            {
                return 1;
            }
            else if (sv1.Diem > sv2.Diem)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
