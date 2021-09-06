using System;

namespace Dice_Game
{
    class Program
    {
        static Random rand = new Random();

        static int rollDice(){
            int dice1 = rand.Next(1,6);
            int dice2 = rand.Next(1,6);
            int total = dice1 + dice2;
            return total;
        }

        static void Main(string[] args)
        {
            
            string user_input = "";


            Console.Write("Roll Dice? y/n: ");
            user_input = Console.ReadLine();


            if(user_input == "y" || user_input == "Y"){
                Console.WriteLine(user_input);
            }
        }
    }
}
