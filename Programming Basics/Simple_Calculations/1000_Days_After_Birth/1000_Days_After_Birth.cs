﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthday = Console.ReadLine();

            DateTime convertDate = DateTime.ParseExact(birthday, "dd-MM-yyyy", null);

            DateTime afterDays = convertDate.AddDays(999);

            Console.WriteLine(afterDays.ToString("dd-MM-yyyy"));
        }
    }
}
