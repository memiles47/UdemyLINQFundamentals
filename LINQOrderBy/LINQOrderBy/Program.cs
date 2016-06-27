using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQOrderBy
{
    internal class Program
    {
        private static void Main()
        {
            var months = new List<string>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var dayNames = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //var result = from d in dayNames
            //    group d by d.Length
            //    into dayGroups
            //    orderby dayGroups.Key
            //    select dayGroups;

            //var monthResult = from m in months
            //    group m by m.Length
            //    into dayGroups
            //    orderby dayGroups.Key
            //    select dayGroups;

            var result = dayNames.GroupBy(d => d.Length);
            var monthResult = months.GroupBy(m => m.First());

            foreach (var grp in result)
            {
                Console.WriteLine($"\nKey: {grp.Key}");
                Console.WriteLine("-------------------");
                foreach (var item in grp)
                {
                    Console.WriteLine($"Group Item: {item}");
                }
            }

            foreach (var grp in monthResult)
            {
                Console.WriteLine($"\nKey: {grp.Key}");
                Console.WriteLine("-------------------");
                foreach (var item in grp)
                {
                    Console.WriteLine($"Group Item: {item}");
                }
            }

            Console.ReadLine();
        }
    }
}
