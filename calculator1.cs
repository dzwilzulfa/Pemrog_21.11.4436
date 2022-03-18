using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // deklarasi variabel a, nilai awal 10
            var b = 6; // deklarasi variabel b, nilai awal 6

            var cal = new Calculator(); // deklarasi objek cal
            Console.WriteLine(a + " + " + b + " = " + cal.Tambah(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, cal.Kurang(a, b));

            Console.ReadKey();
        }
    }

    class Calculator
    {
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
		
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
		
		private int Perkalian(int a, int b)
        {
            return a * b;
        }
		
		private int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}


		public int Penambahan(int a, int b)
        {
            return a + b;
        }
		
        public int Pengurangan(int a, int b)
        {
            return a - b;
        }
		
		public int Perkalian(int a, int b)
        {
            return a * b;
        }
		
		public static int Pembagian(int a, int b)
        {
            return a / b;
        }