using System;
using System.Collections.Generic;

namespace task_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cashRegister=0;

            Queue<int> purchaseAmount = new Queue<int>();

            purchaseAmount.Enqueue(12);
            purchaseAmount.Enqueue(134);
            purchaseAmount.Enqueue(177);
            purchaseAmount.Enqueue(65);
            purchaseAmount.Enqueue(56);
            purchaseAmount.Enqueue(45);
            purchaseAmount.Enqueue(32);
            purchaseAmount.Enqueue(99);
            purchaseAmount.Enqueue(999);
            purchaseAmount.Enqueue(435);

            ServeTheClients(purchaseAmount,ref cashRegister);

            Console.WriteLine("Прибыль в кассе не сегодня = " + cashRegister);
        }

        static int ServeTheClients(Queue<int> purchaseAmount,ref int cashRegister)
        {
            while (purchaseAmount.Count > 0)
            {
                cashRegister += purchaseAmount.Dequeue();
                Console.WriteLine("Сумма в кассе: " + cashRegister);
                Console.ReadKey();
                Console.Clear();
            }

            return cashRegister;
        }
    }
}