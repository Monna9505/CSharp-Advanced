﻿using System;

namespace GenericBoxOfIntegerEXERCISE
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int someInt = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(someInt);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
