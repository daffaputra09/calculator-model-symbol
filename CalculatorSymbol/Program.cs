using System;

namespace CalculatorSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pertama = 0m;
            decimal kedua = 0m;
            decimal hasil = 0m;
            string ulang = "";
            do
            {
                Console.Clear();
                Console.Write("\nAngka pertama: ");
                pertama = Convert.ToInt32(Console.ReadLine());
                Console.Write("Angka kedua: ");
                kedua = Convert.ToInt32(Console.ReadLine());

                Console.Write("Pilih Symbol: ");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        hasil = pertama + kedua;
                        Console.WriteLine($"{pertama} + {kedua} = {hasil}");
                        break;

                    case "-":
                        hasil = pertama - kedua;
                        Console.WriteLine($"{pertama} - {kedua} = {hasil}");
                        break;

                    case "*":
                        hasil = pertama * kedua;
                        Console.WriteLine($"{pertama} * {kedua} = {hasil}");
                        break;

                    case ":":
                        hasil = pertama / kedua;
                        Console.WriteLine($"{pertama} : {kedua} = {hasil}");
                        break;

                    case "/":
                        hasil = pertama / kedua;
                        Console.WriteLine($"{pertama} / {kedua} = {hasil}");
                        break;
                    default:
                        Console.WriteLine("Hanya bisa memilih symbol (+, -, *, /");
                        break;
                }
                Console.Write("\nApakah anda ingin menghitung lagi? (Y / N): ");
                ulang = Console.ReadLine();
            } while (ulang == "y" || ulang == "Y");
        }
    }
}