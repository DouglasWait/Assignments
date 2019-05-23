using System;
using System.Threading;

namespace ThreadsCA
{
    class Program
    {
        static Thread th1;
        static Thread th2;
        static Thread mainthread;

        static void Main(string[] args)
        {
            th1 = new Thread(Thread1);
            th2 = new Thread(Thread2);
           // mainthread = new Thread(mThread);

            
            th1.Name = "A";
            th2.Name = "B";

            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            int num2 = rnd.Next(num,11);

            for (int i = 0; i < 10; i++)
            {
                if (i == num - 1)
                {
                    th1.Start();
                }
                else if (i == num2 - 1)
                {
                    th2.Start();
                }
                else
                {
                    Console.Write("" + (i + 1)+" ");
                }
            }
            Console.ReadLine();
        }
        private static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Thread.CurrentThread.Name +  (i+1)+" ");
            }
        }
        private static void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Thread.CurrentThread.Name + (i + 1)+" ");
            }
        }
      /*  private static void mThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write( (i + 1) + " ");
            }
        }*/
    }
}
