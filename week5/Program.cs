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
        class dog
        {
            public dog (string name, string breed)
            {
                dog_name = name;
                dog_breed = breed;
              

            }

            public dog()
            {
            }

            public string dog_name;
            public string dog_breed;
            public dog next_dog;
           public dog pervious_dog;
        }
        class birthday_party

        {
            
            public dog peanut;
            public dog fifi;
            public dog clerence;
            public dog roy;

            public dog head;
            public dog tail;
            public void setUpPartyList()
            {
                peanut = new dog();
                fifi = new dog();
                clerence = new dog();
                roy = new dog();

                peanut.pervious_dog = null;
                peanut.next_dog = fifi;
                fifi.pervious_dog = peanut;
                fifi.next_dog = clerence;
                clerence.pervious_dog = fifi;
                clerence.next_dog = roy;
                roy.pervious_dog = clerence;
                roy.next_dog = null;
                head = peanut;
                tail = clerence;
            }
        }

            }

}
