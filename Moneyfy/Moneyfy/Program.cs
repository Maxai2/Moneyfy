﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------------
namespace Monefy
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.getInstance().DrawFrame();

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(0, 30);
        }
    }
}
//--------------------------------------------------------