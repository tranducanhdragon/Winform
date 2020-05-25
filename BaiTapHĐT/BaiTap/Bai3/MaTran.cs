using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class MaTran
    {

        private int[,] matrix = new int[ 100, 100];
        private int hang;
        private int cot;

        public MaTran(int row, int column)
        {
            hang = row;
            cot = column;
        }
        public int this[int index1, int index2]
        {
            get {
                if (index1 < 0 || index1 > 100 || index2 < 0 || index2 > 100)
                    throw new IndexOutOfRangeException("Vuot qua chi so mang");
                else
                    return matrix[index1, index2];
            }
            set {
                if ( value < 0 || value > 100)
                    throw new IndexOutOfRangeException("Vuot qua chi so mang");
                else
                    matrix[index1, index2] = value;
            }
        }
        public int Hang
        {
            get { return hang; }
            set { hang = value; }
        }
        public int Cot
        {
            get { return cot; }
            set { cot = value; }
        }
        public void Nhap()
        {
            for(int i = 0; i< hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    Console.WriteLine("[" + i + "][" + j + "] = ");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }
        public void HienThi()
        {
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }

        public static MaTran operator +(MaTran mt1, MaTran mt2)
        {
            MaTran mt3 = new MaTran(mt1.Hang, mt1.Cot);
            for(int i = 0; i< mt1.Hang; i++)
            {
                for(int j = 0; j< mt1.Cot; j++)
                {
                    mt3[i, j] = mt1[i, j] + mt2[i, j];
                }
            }
            return mt3;
        }
        public static MaTran operator -(MaTran mt1, MaTran mt2)
        {
            MaTran mt3 = new MaTran(mt1.Hang, mt1.Cot);
            for (int i = 0; i < mt1.Hang; i++)
            {
                for (int j = 0; j < mt1.Cot; j++)
                {
                    mt3[i, j] = mt1[i, j] - mt2[i, j];
                }
            }
            return mt3;
        }
        public static MaTran operator *(MaTran mt1, MaTran mt2)
        {
            MaTran mt3 = new MaTran(mt1.Hang, mt2.Cot);
            if(mt1.Hang == mt2.Cot && mt1.Cot == mt2.Hang)
            {
                for(int i = 0; i < mt1.Hang; i++)
                {
                    for(int j = 0; j < mt2.Cot; j++)
                    {
                        for(int k = 0; k< mt2.Hang; k++)
                        {
                            mt3[i, j] += mt1[i, k] * mt2[k, j];
                        }
                    }
                }
                return mt3;
            }
            else
            {
                return null;
            }
        }
    }
}
