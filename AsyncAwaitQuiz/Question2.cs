﻿using System;
using System.Threading;

namespace AsyncAwaitQuiz
{
    public static class Question2
    {
        /*
            What will be the output of the Run method? 

            A). Test 1
                Test 2
                Test 3

            B). Test 1
                Test 2
                Test 2.5
                Test 3

            C). Test 1
                Test 2
            
            D). None of the above. 
        */

        public static void Run()
        {
            Operation1();
            Operation2();
            Operation3();
        }

        private static void Operation1()
        {
            Console.WriteLine("Test 1");
        }

        private static void Operation2()
        {
            Console.WriteLine("Test 2");
            Thread.Sleep(5000);
            Console.WriteLine("Test 2.5");
        }

        private static void Operation3()
        {
            Console.WriteLine("Test 3");
        }
    }
}
