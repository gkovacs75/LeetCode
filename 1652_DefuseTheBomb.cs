//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode
//{
//    internal class _1652_DefuseTheBomb
//    {
//        public void Run()
//        {
//            //Console.WriteLine(Decrypt([5, 7, 1, 4], 3)); // [12,10,16,13]
//            Console.WriteLine(Decrypt([2, 4, 9, 3], -2)); // [12,5,6,13]
//        }

//        public int[] Decrypt(int[] code, int k)
//        {
//            int[] output = new int[code.Length];

//            // Copy code into temp array
//            for (int i = 0; i < code.Length; i++)
//            {
//                output[i] = code[i];
//            }

//            if (k > 0)
//            {
//                int sum = 0;
//                int index = 1;
//                for (int i = 0; i < k; i++)
//                {
//                    if (index == k + 1)
//                    {
//                        index = 0;
//                    }

//                    sum += code[index];

//                    index++;
//                }

//                index = 1;
//                for (int i = 0; i < output.Length; i++)
//                {
//                    code[i] = sum;

//                    if (i == output.Length - 1)
//                    {
//                        break;
//                    }

//                    sum -= output[i + 1];

//                    index = i + k + 1;

//                    if (index >= code.Length)
//                    {
//                        index = index % code.Length;
//                    }

//                    sum += output[index];
//                }
//            }
//            else if (k < 0)
//            {
//                int sum = 0;
//                int index = code.Length - 1;
//                for (int i = 0; i < k; i++)
//                {
//                    if (index == -1)
//                    {
//                        index = code.Length - 1;
//                    }

//                    sum += code[index];

//                    index--;
//                }

//                index = 1;
//                for (int i = 0; i < output.Length; i++)
//                {
//                    code[i] = sum;

//                    if (i == output.Length - 1)
//                    {
//                        break;
//                    }

//                    sum -= output[i + 1];

//                    index = i + k + 1;

//                    if (index >= code.Length)
//                    {
//                        index = index % code.Length;
//                    }

//                    sum += output[index];
//                }
//            }
//            else
//            {
//                for (int i = 0; i < output.Length; i++)
//                {
//                    code[i] = 0;
//                }
//            }

//            return code;
//        }
//    }
//}
