using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var regular = new HashSet<string>();
        var vip = new HashSet<string>();
        var regexValidator = new Regex(@"^\d\w*");

        string input;
        while ((input = Console.ReadLine()) != "PARTY")
        {

            if (regexValidator.IsMatch(input))
            {
                vip.Add(input);
            }
            else
            {
                regular.Add(input);
            }
        }

        while ((input = Console.ReadLine()) != "END")
        {
            bool isVIP = regexValidator.IsMatch(input);

            if (isVIP)
            {
                if (vip.Contains(input))
                {
                    vip.Remove(input);
                }
            }
            else
            {
                if (regular.Contains(input))
                {
                    regular.Remove(input);
                }
            }
        }

        int unArrived = vip.Count + regular.Count;
        Console.WriteLine(unArrived);

        if (vip.Count > 0)
        {
            foreach (var vipGuest in vip)
            {
                Console.WriteLine(vipGuest);
            }
        }

        if (regular.Count > 0)
        {
            foreach (var regularGuest in regular)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}

