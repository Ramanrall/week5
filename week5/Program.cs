using System;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
    }

    class TestQuestion2 {
        public int myFavVariable = 0;

        public void PlayingWithForLoops()
        {
            // add  10 numbers
                    
                for(; MyMethod(); )
            {
                if (myFavVariable > 10)
                {
                    Console.WriteLine("i am so out of here");
                    break;
                }
                Console.WriteLine("ohh no i have to go through stupid loop again");

            }


        }
        public bool MyMethod()
        {
            myFavVariable ++;
            return true;
        }
            }

}
