﻿using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("1");
            list.Add("5");
            list.Add("4");
            list.Add("2");
            Console.WriteLine(list.RandomString());
        }
    }
}