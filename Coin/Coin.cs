using System; 
using System.Collections.Generic;
using Coin.Method;

namespace Coin 
{
        public class Program
        {
             public static void Main()
            {
                Console.WriteLine("Please enter an amount (in cents): ");
                int userInput = int.Parse(Console.ReadLine());
                CoinCombination instanceVariable = new CoinCombination(userInput);
                Console.WriteLine(instanceVariable.ChangeCounter());
                Console.WriteLine("Number of possible combinations: " + instanceVariable.ChangeCounterCombo());
            }
        }
}