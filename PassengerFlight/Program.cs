using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassengerFlight
{
    class Program
    {


        static bool CheckMovies(int[] movieDuration,
                           int lengthofFlight)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < movieDuration.Length; ++i)
            {
                int temp = lengthofFlight - movieDuration[i];

                // checking for condition
                if (s.Contains(temp))
                {
                    Console.Write("sum " +
               lengthofFlight + " is (" + movieDuration[i] + ", " + temp + ")");
                    return true;
                }
                s.Add(movieDuration[i]);
                
            }
            return false;
        }

        //test our func
        static void Main()
        {
            int[] A = new int[] { 9,6,1, 4, 45,
                              6, 10, 8 };
            int n = 10;
            if (CheckMovies(A, n) == false)
            {
                Console.Write("Not found");
            }
            Console.ReadLine();
        }
    }
}
