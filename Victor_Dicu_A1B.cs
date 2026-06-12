using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Lucas_Numbers_Generator
{

    //The overall Time Complexity of this program is O(n), because of the recursion function used in generating the Lucas Numbers
    internal class OddLucasNumbers
    {

        //This is where the magic happens, in the Main method, where the LucasNumbers20 list is initialized and the Lucas Numbers are generated
        public static void Main(string[] args)
        {

            List<int> LucasNumbers20 = new List<int>();

            int Index = 0;

            CalculateLucasNumbers.Generate_Lucas_Numbers(0, LucasNumbers20, Index);

            Console.WriteLine("The first 20 Odd Lucas Numbers are: ");

            //Go through the LucasNumbers20 list, and check if the numbers are odd
            foreach(int LucasNumber in LucasNumbers20)
            {

                if (LucasNumber % 2 != 0)

                    Console.Write($"{LucasNumber}, ");


            }

        }

    }

    //Recursive function for generating the Lucas Numbers
    internal class CalculateLucasNumbers
    {

        //This is where the Lucas Numbers are generated and then transfered to a List
        public static void Generate_Lucas_Numbers(int n, List<int> LucasNumbersList, int index)
        {

            //This is where the Lucas Numbers Generator begins
            //If n is 0, then the number 2 is added to the List, and if n is 1, then 1 is added to the List, with n being the subordinal number from Ln, and incremented at the end
            if (n == 0)

                LucasNumbersList.Add(2);

            else if (n == 1)
            {
                LucasNumbersList.Add(1);
                index++;

            }

            else if (n > 1)
            {
                LucasNumbersList.Add(LucasNumbersList[n - 1] + LucasNumbersList[n - 2]);

                if ((LucasNumbersList[n - 1] + LucasNumbersList[n - 2]) % 2 != 0)

                    index++;

            }

            n++;

            if (index < 20)

                Generate_Lucas_Numbers(n, LucasNumbersList, index);

        }

    }

}