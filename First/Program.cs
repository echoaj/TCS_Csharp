﻿using System;
// With oliver
namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 21;
            long num2 = 100;
            float num3 = 5.5f;
            double num4 = 5.55555d;
            bool tf = true;
            char letter = 'A';
            string name = "Alex";


            System.Console.WriteLine($"{num}, {num2}, {num3}, {num4}, {tf}, {letter}, {name}");

            // if-statements
            if(num > 10){
                System.Console.WriteLine("num is greater than 10");
            }else if(num < 20){
                System.Console.WriteLine("num is less than 20");
            }else{
                System.Console.WriteLine("else");
            }

            // switch statements
            switch (num2)
            {
                case 99:
                    System.Console.WriteLine("num2 is 99");
                    break;
                case 100:
                    System.Console.WriteLine("num2 is 100");
                    break;
                case 101:
                    System.Console.WriteLine("num2 is 101");
                    break;   
                default:
                    System.Console.WriteLine("num2 is none of those values");
                    break;
            }

            
            // More advanced Data Types
            // Array
            int[] array = {6,7,3,4,56,7,8,100,43,4,4};
            Array.Sort(array);


            // Loops: While, Do While, For, Foreach
            // 0 or more time
            int i = 0;
            while (i < array.Length){
                System.Console.Write(array[i] + ", ");
                i++;
            }

            // 1 or more times
            int j = 0;
            do {
                System.Console.Write(array[j] + ", ");
                j++;
            }while(j < array.Length);


        }
    }
}
