using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*tạo lớp người, trong đó có tên, tuổi, phương thức giới thiệu
 lớp sinh viên kế thừa lớp người, co thêm mã SV, phương thức giới thiệu SV*/
namespace KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Nguoi human = new Nguoi("Tran Duc Anh", 20);
            human.GioiThieu();

            Nguoi sv = new SinhVien("Tran Duc Anh 2", 20, "001");
            sv.GioiThieu();
        }
        public class Nguoi
        {
            private string ten;
            private int tuoi;

            public string Ten
            {
                get { return ten; }
                set { ten = value; }
            }
            public int Tuoi
            {
                get { return tuoi; }
                set { tuoi = value; }
            }
            public Nguoi(string name, int age)
            {
                Ten = name;
                Tuoi = age;
            }
            public Nguoi(): this("No name", 0) { }
            public Nguoi(string name): this(name, 0) { }
            public Nguoi(int age):this("No name", age) { }
            public virtual void GioiThieu()
            {
                Console.WriteLine("Toi la {0} va toi {1} tuoi ", Ten, Tuoi);
                Console.WriteLine($"Toi ten la {Ten} va toi {Tuoi} tuoi");
            }
        }
        public class SinhVien: Nguoi
        {
            private string IDSinhVien;
            public SinhVien(string name, int age, string maSV):base(name, age)
            {
                this.IDSinhVien = maSV;
            }
            public string ID
            {
                get { return IDSinhVien; }
                set { IDSinhVien = value; }
            } 
            public override void GioiThieu()
            {
                base.GioiThieu();
                Console.WriteLine("Ma sinh vien cua toi la {0}", ID);
            }
        }
    }
}
