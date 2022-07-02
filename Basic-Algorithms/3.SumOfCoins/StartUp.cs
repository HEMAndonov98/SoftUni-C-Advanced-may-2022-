using System.Collections.Generic;
using System.Linq;
using System;

namespace SumOfCoins
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var availableCoins = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var targetSum = int.Parse(Console.ReadLine());
            var selectedCoins = ChooseCoins(availableCoins, targetSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var (value, coin) in selectedCoins)
            {
                Console.WriteLine($"{coin} coin(s) with value {value}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            int[] sortedCoins = coins.OrderByDescending(c => c).ToArray();
            var chosenCoins = new Dictionary<int, int>();

            int currentSum = 0;
            int coinIndex = 0;

            while (currentSum != targetSum && coinIndex < sortedCoins.Length)
            {
                int currentCoinValue = sortedCoins[coinIndex];
                int remainder = targetSum - currentSum;
                int numberOfCoins = remainder / currentCoinValue;

                if (currentSum + currentCoinValue <= targetSum)
                {
                    chosenCoins[currentCoinValue] = numberOfCoins;
                    currentSum += numberOfCoins * currentCoinValue;
                }
                coinIndex++;
            }

            if (currentSum != targetSum)
            {
                throw new InvalidOperationException();
            }

            return chosenCoins;
        }
    }
}
