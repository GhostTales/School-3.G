using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher_brute_force
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            
            Console.WriteLine(brute("cunt"));

            string brute(string s)
            {
                string newText = "";
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j <= s.Length; j++) 
                    {
                        int index = alpha.IndexOf(s.ToUpper()[j]);
                        newText += alpha[index];
                    }
                    newText += Environment.NewLine;
                }
                

                return newText;
            }
            


        }
    }
}
