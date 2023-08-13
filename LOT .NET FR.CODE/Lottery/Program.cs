using System;

namespace MTMLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is code written by Martuor Dysiphon for Lottery purposes!");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
  
            Console.Write("Enter Your Name & Surname: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Your Lottery Date: ");
            string LotteryDate = Console.ReadLine();

            Console.Write("Enter Your Lottery Name: ");
            string lotteryName = Console.ReadLine();

            Console.Write("How many numbers to Generate exc Bonus Ball: ");
            int numbersToBeGenerated = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numbers should range from 0 to : ");
            int rangeNumbers = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] numbers = new int[numbersToBeGenerated];
            for (int i = 0; i < numbersToBeGenerated; i++)
            {
                numbers[i] = rnd.Next(0, rangeNumbers);
            }
         
            Console.Write("BonusBall should range from 0 to : ");
            int rangeBonusBall = Convert.ToInt32(Console.ReadLine());
            int bonusBall = rnd.Next(0, rangeBonusBall);
            
            
            Console.WriteLine("||||||||||||||||Personal Informations||||||||||||||||||||||||");
            Console.WriteLine($"{Name} Your Generated {LotteryDate} Lottery numbers for {lotteryName} are:");
            Console.Write(string.Join(" ", numbers));
            Console.WriteLine(" Bonus Ball: " + bonusBall);
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

        }
    }
}


