﻿using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static void Main(string[] args)
        {
            int vowels = GetVowelCount("kkaaakr");
            Console.WriteLine(vowels);
            Console.Read();
        }
        //static void Main(string[] args)
        //{
        //    int vowels = GetVowelCount("kkaaakr");
        //    Console.WriteLine(vowels);
        //    Console.Read();
        //}
        public static int GetVowelCount(string str)
        {
            if (str.Length==0)
            {
                throw new ArgumentException();
            }
            if (str is null)
            {
                throw new ArgumentNullException();
            }
            if (string.IsNullOrEmpty(str))
            {

                throw new ArgumentException();
            }
            int count = 0;
            //str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'i' || str[i] == 'u' || str[i] == 'o' || str[i] == 'e')
                {
                    count++;
                }

            }
            return count;


        }
    }
}
