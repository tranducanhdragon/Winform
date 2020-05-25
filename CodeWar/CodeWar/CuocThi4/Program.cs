using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuocThi4
{
    class Program
    {

        static void Main(string[] args)
        {


            //             NgoiNha a = new NgoiNha();
            //             a.Color = "vang";
            //             List<NgoiNha> ds = new List<NgoiNha>();
            //             ds.Add(a);
            //             NgoiNha b = new NgoiNha();
            //             b.Color = "vang";
            //             int index = ds.FindIndex(x => x.Color == b.Color);
            //             Console.WriteLine(" " + index);

            string[] s = {"red","blue","green","pink","black","orange","gray","white","purple"};
            string[] s1 = { "pink is on the left of gray",
                "black is on the right of blue",
                "orange is on the right of pink",
                "purple is in beetween of white and pink",
                "black is next to the right of blue",
                "green is in beetween of white and gray",
                "blue is on the right of purple",
                "pink is on the left of orange",
                "black is on the right of gray",
                "green is in beetween of orange and black",
                "purple is on the right of red",
                "red is on the left of blue",
                "red is on the left of green",
                "purple is on the left of orange",
                "orange is in beetween of purple and black",
                "green is in beetween of white and blue",
                "blue is in beetween of orange and black",
                "orange is on the right of red",
                "purple is on the right of white",
                "red is on the left of gray",
                "pink is in beetween of purple and black",
                "pink is on the left of blue",
                "black is on the right of orange",
                "purple is in beetween of red and green",
                "gray is in beetween of red and blue",
                "purple is in beetween of red and pink",
                "purple is in beetween of white and blue",
                "red is on the left of pink",
                "purple is in beetween of white and gray",
                "gray is in beetween of white and black",
                "blue is on the right of red", "pink is in beetween of purple and gray", "gray is in beetween of red and black", "gray is in beetween of pink and blue", "white is on the left of blue", "blue is on the left of black", "gray is in beetween of white and blue", "pink is in beetween of red and black", "green is on the right of red", "gray is on the right of green", "red is in beetween of white and pink", "orange is in the middle of pink and green", "pink is on the right of white", "gray is on the right of white", "pink is in beetween of purple and blue", "orange is in beetween of pink and green", "green is in beetween of purple and black", "white is on the left of pink", "orange is on the left of green", "orange is in beetween of purple and green", "white is on the left of gray", "black is on the right of purple", "red is in beetween of white and gray", "black is on the right of green", "gray is on the left of black", "gray is in beetween of orange and blue", "red is in beetween of white and blue", "green is in beetween of pink and blue", "gray is on the right of red", "red is on the left of purple", "gray is in beetween of purple and black", "orange is in beetween of red and green", "green is next to the left of gray", "purple is in the middle of red and pink", "black is on the right of pink", "green is in beetween of pink and gray", "red is next to the right of white", "green is on the right of pink", "gray is in beetween of purple and blue", "gray is on the right of pink", "purple is in beetween of red and black", "purple is next to the right of red", "green is on the left of black", "orange is on the right of white", "pink is in beetween of red and green", "white is on the left of orange", "green is in beetween of red and blue", "gray is next to the left of blue", "green is in beetween of red and gray", "gray is in beetween of pink and black", "gray is in the middle of green and blue", "gray is on the left of blue", "gray is on the right of purple", "pink is in beetween of red and orange", "orange is in beetween of purple and gray", "gray is in beetween of orange and black", "blue is on the right of gray", "pink is on the left of black", "purple is next to the left of pink", "purple is in beetween of white and black", "black is on the right of white", "blue is on the right of pink", "pink is in beetween of white and orange", "gray is in beetween of green and blue", "green is in beetween of white and black", "white is on the left of red", "purple is on the left of pink", "orange is in beetween of white and black", "orange is in beetween of pink and blue", "red is on the right of white", "white is on the left of green", "orange is next to the right of pink", "red is in beetween of white and orange", "green is in beetween of purple and blue", "pink is on the right of red", "red is on the left of orange", "red is in beetween of white and black", "red is in the middle of white and purple", "green is on the right of white", "white is on the left of black", "pink is in beetween of white and green", "green is in beetween of purple and gray", "purple is on the left of gray", "green is on the right of orange", "orange is in beetween of red and gray", "orange is on the left of gray", "orange is in beetween of pink and gray", "green is in beetween of red and black", "purple is on the left of blue", "green is in the middle of orange and gray", "orange is on the right of purple", "orange is in beetween of white and gray", "purple is on the left of green", "orange is in beetween of white and blue", "orange is on the left of blue", "green is on the right of purple", "red is in beetween of white and purple", "blue is in beetween of purple and black", "blue is in beetween of green and black", "pink is on the left of green", "pink is in beetween of purple and orange", "pink is in beetween of purple and green", "blue is in beetween of pink and black", "purple is on the left of black", "gray is next to the right of green", "pink is in beetween of white and gray", "blue is next to the right of gray", "purple is in beetween of red and blue", "orange is in beetween of pink and black", "gray is in beetween of green and black", "white is next to the left of red", "purple is in beetween of red and orange", "blue is on the right of white", "green is in beetween of orange and blue", "orange is next to the left of green", "orange is in beetween of white and green", "blue is on the right of orange", "red is on the left of black", "pink is in the middle of purple and orange", "purple is in beetween of white and green", "green is on the left of gray", "blue is next to the left of black", "green is in beetween of orange and gray", "blue is in beetween of white and black", "pink is next to the left of orange", "green is on the left of blue", "red is in beetween of white and green", "orange is in beetween of red and blue", "purple is in beetween of red and gray", "green is in beetween of pink and black", "gray is on the right of orange", "purple is in beetween of white and orange", "pink is in beetween of white and black", "pink is in beetween of red and gray", "orange is in beetween of red and black", "pink is in beetween of red and blue", "pink is on the right of purple", "blue is in beetween of gray and black", "pink is in beetween of white and blue", "black is on the right of red", "blue is on the right of green", "red is next to the left of purple", "green is next to the right of orange", "orange is on the left of black", "pink is next to the right of purple", "orange is in beetween of purple and blue", "blue is in the middle of gray and black", "blue is in beetween of red and black",
                "white is on the left of purple" };
            string[] res = HousesList(s, s1);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
        static string[] HousesList(string[] houseColors, string[] houseConditions)
        {
            Array.Sort(houseColors, StringComparer.InvariantCulture);
            List<NgoiNha> ds = new List<NgoiNha>();
            for (int i = 0; i < houseColors.Length; i++)
            {
                NgoiNha a = new NgoiNha();
                a.Color = houseColors[i];
                ds.Add(a);
            }
            ds.Distinct();

            for (int i = 0; i < houseConditions.Length; i++)
            {
                string[] tach_string = houseConditions[i].Split(' ');

                if (tach_string[2] == "on")
                {
                    if (tach_string[4] == "right")
                    {
                        if (houseColors.Contains(tach_string[0]) && houseColors.Contains(tach_string[6]) && ds.Count != 0)
                        {
                            NgoiNha a = new NgoiNha();
                            a.Color = tach_string[0];
                            NgoiNha b = new NgoiNha();
                            b.Color = tach_string[6];
                            if (ds.IndexOf(a) < ds.IndexOf(b))
                            {
                                ds.Remove(a);
                                ds.Add(a);
                            }

                        }
                    }
                    else if (tach_string[4] == "left")
                    {
                        if (houseColors.Contains(tach_string[0]) && houseColors.Contains(tach_string[6]) && ds.Count != 0)
                        {
                            NgoiNha a = new NgoiNha();
                            a.Color = tach_string[0];
                            NgoiNha b = new NgoiNha();
                            b.Color = tach_string[6];
                            if (ds.IndexOf(a) > ds.IndexOf(b))
                            {
                                ds.Remove(a);
                                ds.Insert(0, a);
                            }
                        }
                    }
                }
                else if (tach_string[2] == "next")
                {
                    if (tach_string[5] == "right")
                    {
                        if (houseColors.Contains(tach_string[0]) && houseColors.Contains(tach_string[7]) && ds.Count != 0)
                        {
                            NgoiNha a = new NgoiNha();
                            a.Color = tach_string[0];
                            NgoiNha b = new NgoiNha();
                            b.Color = tach_string[7];
                            int index = ds.FindIndex(x => x.Color == b.Color);
                            int index2 = ds.FindIndex(x => x.Color == a.Color);
                            if (ds[index].Right == false && ds[index2].Left == false && ds[index].Right2 == false && ds[index].Left2 == false)
                            {
                                ds.RemoveAt(index2);
                                ds.Insert(index, a);
                                ds[index - 1].Right = true;
                                ds[index - 1].Left2 = true;
                                ds[index].Left = true;
                                ds[index].Right2 = true;

                            }
                            else
                            {
                                ds.Clear();
                            }

                        }
                    }
                    else if (tach_string[5] == "left")
                    {
                        if (houseColors.Contains(tach_string[0]) && houseColors.Contains(tach_string[7]) && ds.Count != 0)
                        {
                            NgoiNha a = new NgoiNha();
                            a.Color = tach_string[0];
                            NgoiNha b = new NgoiNha();
                            b.Color = tach_string[7];
                            int index = ds.FindIndex(x => x.Color == b.Color);
                            int index2 = ds.FindIndex(x => x.Color == a.Color);
                            if (ds[index].Left == false && ds[index2].Right == false && ds[index].Right2 == false && ds[index2].Left2 == false)
                            {
                                ds.RemoveAt(index2);
                                ds.Insert(index, a);
                                ds[index - 1].Left = true;
                                ds[index - 1].Right2 = true;
                                ds[index].Right = true;
                                ds[index].Left2 = true;
                            }
                            else
                            {
                                ds.Clear();
                            }

                        }
                    }
                }
                else if (tach_string[2] == "in")
                {
                    if (tach_string[3] == "the")
                    {
                        if (houseColors.Contains(tach_string[0]) && houseColors.Contains(tach_string[6]) &&
                            houseColors.Contains(tach_string[8]) && ds.Count != 0)
                        {
                            NgoiNha a = new NgoiNha();
                            a.Color = tach_string[0];
                            NgoiNha b = new NgoiNha();
                            b.Color = tach_string[6];
                            NgoiNha c = new NgoiNha();
                            c.Color = tach_string[8];
                            int index = ds.FindIndex(x => x.Color == a.Color);
                            int index2 = ds.FindIndex(x => x.Color == b.Color);
                            int index3 = ds.FindIndex(x => x.Color == c.Color);
                            if (Math.Abs(index2 - index3) % 2 == 0)
                            {
                                ds.RemoveAt(index);
                                ds.Insert((index2 + index3) / 2, a);

                            }

                        }
                        else if (tach_string[3] == "beetween")
                        {
                            if (houseColors.Contains(tach_string[0]) && houseColors.Contains(tach_string[5]) &&
                                houseColors.Contains(tach_string[7]) && ds.Count != 0)
                            {
                                
                                NgoiNha a = new NgoiNha();
                                a.Color = tach_string[0];
                                NgoiNha b = new NgoiNha();
                                b.Color = tach_string[5];
                                NgoiNha c = new NgoiNha();
                                c.Color = tach_string[7];
                                int index = ds.FindIndex(x => x.Color == a.Color);
                                int index2 = ds.FindIndex(x => x.Color == b.Color);
                                int index3 = ds.FindIndex(x => x.Color == c.Color);
                                if(Math.Abs(index3 - index2) != 0)
                                {
                                    ds.RemoveAt(index);
                                    ds.Insert((index2 + index3) / 2, a);
                                }
                                
                            }
                        }
                    }

                }
            }
            string[] result = new string[ds.Count];
            for (int i = 0; i < ds.Count; i++)
            {
                result[i] = ds[i].Color;
            }
            return result;

        }
    }
    class NgoiNha
    {
        bool left;
        bool right;
        bool left2;
        bool right2;
        string color;

        public NgoiNha()
        {
            color = "";
            left = false;
            right = false;
            left2 = false;
            right2 = false;
        }
        public bool Left
        {
            get { return left; }
            set { left = value; }
        }
        public bool Right
        {
            get { return right; }
            set { right = value; }
        }

        public bool Left2
        {
            get { return left2; }
            set { left2 = value; }
        }
        public bool Right2
        {
            get { return right2; }
            set { right2 = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}

