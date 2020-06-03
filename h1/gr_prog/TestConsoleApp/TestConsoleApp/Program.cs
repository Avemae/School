using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
        public int[] K(int[] dog, int[] cat)
        {
            if (dog.Length == 4 && cat.Length == 4)
            {
                int[] tiger = new int[dog.Length + cat.Length];
                int i = 0;
                int j = 0;
                /*int k = 0;
                while (i < tiger.Length)
                {
                    if (j < dog.Length)
                    {
                        tiger[i] = dog[j];
                        j++;
                    }
                    else
                    {
                        tiger[i] = cat[k];
                        k++;
                    }
                    i++;
                }*/

                while(i < dog.Length)
                {
                    tiger[i] = dog[i];
                    i++;
                }
                while(i < tiger.Length)
                {
                    tiger[i] = cat[j];
                    i++;
                    j++;
                }


                return tiger;
            }

            else
            {
                int[] elephant = new int[0];
                return elephant;
            }

        }


    }
}
