using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Bai3
{
    
    class Program
    {
        
        public static void Main(String[] args)
        {
            //             HamiltonianCycle hamiltonian = new HamiltonianCycle(5);
            //             /* Let us create the following graph 
            //             (0)--(1)--(2) 
            //                 | / \ | 
            //                 | / \ | 
            //                 | /     \ | 
            //             (3)-------(4) */
            //             int[,] graph1 = {
            //             {0, 1, 0, 1, 0},
            //             {1, 0, 1, 1, 1},
            //             {0, 1, 0, 0, 1},
            //             {1, 1, 0, 0, 1},
            //             {0, 1, 1, 1, 0},
            //         };
            // 
            //             // Print the solution 
            //             Console.WriteLine(hamiltonian.hamCycle(graph1));
            // 
            //             /* Let us create the following graph 
            //             (0)--(1)--(2) 
            //                 | / \ | 
            //                 | / \ | 
            //                 | /     \ | 
            //             (3)     (4) */
            //             int[,] graph2 = {
            //             {0, 1, 0, 1, 0},
            //             {1, 0, 1, 1, 1},
            //             {0, 1, 0, 0, 1},
            //             {1, 1, 0, 0, 0},
            //             {0, 1, 1, 0, 0},
            //         };
            // 
            //             // Print the solution 
            //             Console.WriteLine(hamiltonian.hamCycle(graph2));


            string[] s = { "hanoi-haiphong", "haiphong-quangninh", "quangninh-saigon"};
            Console.WriteLine(" " + TravelPath(s));
            Console.Read();
        }
        static bool TravelPath(string[] pathList)
        { 
            Dictionary<int, string> capdinh = new Dictionary<int, string>();
            
            string[] s0 = pathList[0].Split('-');

            capdinh.Add(0, s0[0].ToUpper());

            capdinh.Add(1, s0[1].ToUpper());
            int t = 2;
            for(int i = 1; i<pathList.Length; i++)
            {
                string[] s = pathList[i].Split('-');
                if(s == null || s[0] == s[1])
                {
                    return false;
                }
                if(!ContainsOnlyAlphaNumericCharacters(s[0]) && !ContainsOnlyAlphaNumericCharacters(s[1]) )
                {
                    return false;
                }
                capdinh[t] = s[0].ToUpper();
                capdinh[t + 1] = s[1].ToUpper();
                t += 2;
            }
            if(capdinh == null)
            {
                return false;
            }
            HashSet<string> knownValues = new HashSet<string>();
            Dictionary<int, string> dinh = new Dictionary<int, string>();

            int cs = 0;
            foreach (var pair in capdinh)
            {
                if (knownValues.Add(pair.Value))
                {
                    dinh.Add(cs, pair.Value);
                    cs+= 1;
                }
            }

            int col_dinh = dinh.Count;
            int row_dinh = dinh.Count;
            int[,] bangtrongso = new int[row_dinh, col_dinh];
            for(int i = 0; i< row_dinh; i++)
            {
                for(int j = 0; j< col_dinh; j++)
                {
                    bangtrongso[i, j] = 0;
                }
            }

            for(int i = 0; i< capdinh.Count; i = i + 2)
            {
                if (dinh.ContainsValue(capdinh[i]))
                {
                    int myKey = dinh.FirstOrDefault(x => x.Value == capdinh[i]).Key;
                    if (dinh.ContainsValue(capdinh[i + 1]))
                    {
                        int myKey2 = dinh.FirstOrDefault(x => x.Value == capdinh[i+1]).Key;
                        bangtrongso[myKey, myKey2] = 1;
                        bangtrongso[myKey2, myKey] = 1;
                    }

                }
            }

            HamiltonianCycle hamiltonian = new HamiltonianCycle(col_dinh);
            if( hamiltonian.hamCycle(bangtrongso) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static bool ContainsOnlyAlphaNumericCharacters(string inputString) {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            return regexItem.IsMatch(inputString);
        }
        
    }

    public class HamiltonianCycle
    {
        readonly int V = 20;
        int[] path;
        public int dem;

        public HamiltonianCycle(int v)
        {
            V = v;
            dem = 0;
        }
        bool isSafe(int v, int[,] graph, int[] path, int pos)
        {

            if (graph[path[pos - 1], v] == 0)
            {
                return false;
            }
                

            for (int i = 0; i < pos; i++)
            {
                if (path[i] == v)
                {
                    return false;
                }

            }
            return true;
        }


        bool hamCycleUtil(int[,] graph, int[] path, int pos)
        {

            if (pos == V)
            {

                if (graph[path[pos - 1], path[0]] == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                    
            }

            for (int v = 1; v < V; v++)
            {

                if (isSafe(v, graph, path, pos))
                {
                    path[pos] = v;
                    if (hamCycleUtil(graph, path, pos + 1) == true)
                    {
                        return true;
                    }
                    path[pos] = -1;
                }
            }


            return false;
        }


        public int hamCycle(int[,] graph)
        {
            path = new int[V];
            for (int i = 0; i < V; i++)
            {
                path[i] = -1;
            }
            path[0] = 0;

            if (hamCycleUtil(graph, path, 1) == false)
            {
                return 0;
            }
            
            return 1;
        }


//         void printSolution(int[] path)
//         {
//             Console.WriteLine("Solution Exists: Following" +
//                             " is one Hamiltonian Cycle");
//             for (int i = 0; i < V; i++)
//             {
//                 Console.Write(" " + path[i] + " ");
//             }
//             Console.WriteLine(" " + path[0] + " ");
//         }
 
    }

}
