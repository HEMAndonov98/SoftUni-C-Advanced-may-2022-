using System;

namespace _8.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 1
            //{first name} {last name} {address} {town} all are of type string

            var personInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var address = personInfo[2];
            var town = personInfo[3];

            var personThreeple = new Threeuple<string, string, string>(fullName, address, town);

            //Input 2
            //string{name} int{liters of beer} bool{drunk or not}

            var beerInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = beerInfo[0];
            var liters = int.Parse(beerInfo[1]);
            var isDrunk = beerInfo[2] == "drunk" ? true : false;

            var beerThreeple = new Threeuple<string, int, bool>(name, liters, isDrunk);

            //Input 3
            //string{name} double{account balance} string{bank name}

            var accountInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var accountHolder = accountInfo[0];
            var accountBalance = double.Parse(accountInfo[1]);
            var bankName = accountInfo[2];

            var accountThreeple = new Threeuple<string, double, string>(accountHolder, accountBalance, bankName);

            //Print all Threeple's
            Console.WriteLine(personThreeple);
            Console.WriteLine(beerThreeple);
            Console.WriteLine(accountThreeple);

            //Example Input :

            //Adam Smith Wallstreet New York
            //Mark 18 drunk
            //Karren 0.10 USBank
        }
    }
}

