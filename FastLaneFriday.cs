
using System;

namespace Nerd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Nerd head!");

            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
            Console.ReadLine();


            #region Using the output param, also known as OUT modifier
            /*
                        static void AddUsingOutParam(int x, int y, out int ans)
                        {
                            ans = x + y;
                        }

                        Console.WriteLine("Joy with Method Out modifiers");

                        AddUsingOutParam(99, 99, out int ans);
                        Console.WriteLine("99 + 99 = {0}", ans);
                        Console.ReadLine();
            */
            #endregion End of out modifier

            #region Method Params Modifiers by Value
            /*  
                        // Method Param Modifiers
                        static void Add(int x, int y, out int ans)
                        {
                            int ans = x + y;
                            //The caller from the main method example: Add() will not see these changes
                            x = 1000;
                            y = 6666;
                           // return ans;
                        }
                        Console.WriteLine("Joy with Methods");
                        // Pass multiple variables by value
                        //int x = 9, y = 10;
                       // Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
                       // Console.WriteLine("Answer is: {0}", Add(x, y));
                        Add(out int ans);
                        Console.ReadLine();
              */
            #endregion Ending Method Params Modifiers by Value

            #region Local Functions
            /*
            static int Add(int x, int y)
            {
                //Validation process...
                return x + y;
            }
            static int AddWrapper(int x, int y)
            {
                return Add();
                    int Add()
                {
                    return x + y;
                }

            }*/
            #endregion End of Local Functions
        }
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
    }
}