using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka : ");
        int input = Convert.ToInt32(Console.ReadLine());
        int cek;
        for (int i = 2; i <= input; i++)
        {
            cek = input % i;
            if (cek == 0)
            {
                if (input == i)
                    Console.WriteLine("Bilangan Prima");
                else
                {
                    Console.WriteLine("bukan bilangan prima");
                    break;
                }
            }
        }
    }
}