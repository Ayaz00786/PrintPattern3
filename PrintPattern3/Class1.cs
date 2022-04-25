using System;
using System.Collections.Generic;
using System.Text;

namespace PrintPattern3
{
    internal class Class1
    {
        public static void pattern3()
        {
            
            int starposition= 1;

            while (starposition < 6)
            {
                for (int i = 1; i <= 5; i++)
                {
                    
                
                        if (starposition == i)
                        {
                            Console.Write("*");
                        }

                        else
                        {
                            Console.Write(i);
                        }
                   
                }
                Console.WriteLine();
                starposition++;
            }
           
            Console.ReadLine();
        }
    }

}