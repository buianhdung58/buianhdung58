using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptbac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap vao gia tri cua a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao gia tri cua b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                float x = -b * 0.1f / a;
                Console.WriteLine("Phuong trinh co nghiem x:" + x);
            }
        }
    }
}