using System;
using System.Collections.Generic;
namespace Week6Project
{
    class Program
    {
        static void Main(string[] args)
        {

            //ProblemOne();
            ProblemTwo();

        }


        static void ProblemOne()
        {

            List<string> friendsLiked = new List<string>();
            string userInput;
            do
            {
                Console.WriteLine("Please enter your name: ");
                userInput = Console.ReadLine();
                friendsLiked.Add(userInput);

            } while (userInput != "");

                if (friendsLiked.Count > 3)
                Console.WriteLine(friendsLiked[0]  + ", " + friendsLiked[1] + ", and "
                    + (friendsLiked.Count - 3)+ " others liked this.");
            else
            {
                Console.WriteLine(friendsLiked[0] + " and " + friendsLiked[1] + " Liked this.");
            }

        }
        static void ProblemTwo()
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            Console.WriteLine("Please enter a scentence");
            foreach(char letter in Console.ReadLine())
            {
                int count = 0;
                if (letterCount.ContainsKey(letter))
                {
                    count = letterCount[letter];
                }
               letterCount[letter] = count + 1;
            }
            foreach(KeyValuePair<char, int> chrEqInt in letterCount)
            {
                Console.WriteLine(chrEqInt.Key + " = " + chrEqInt.Value);
            }
        }
            
    }

}
