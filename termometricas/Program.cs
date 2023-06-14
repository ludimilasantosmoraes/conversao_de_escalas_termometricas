using System;

class temperaturas
{
    // 2 versão
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o que você quer converter:");
        Console.WriteLine("1 - de Celsius para Fahrenheit.");
        Console.WriteLine("2 - de Celsius para Kelvin.");
        Console.WriteLine("3 - de Fahrenheit para Celsius.");
        Console.WriteLine("4 - de Fahrenheit para Kelvin.");
        Console.WriteLine("5 - de Kelvin para Celsius.");
        Console.WriteLine("6 - de Kelvin para Fahrenheit.");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Digite a temperatura em Celsius:");
                double c = Convert.ToDouble(Console.ReadLine());
                double conta = (c * 1.8) + 32;
                Console.WriteLine($"{conta.ToString("0.00")} °F");
                break;

            case 2:
                Console.WriteLine("Digite a temperatura em Celsius:");
                double cs = Convert.ToDouble(Console.ReadLine());
                double conta1 = cs + 273.15;
                Console.WriteLine($"{conta1.ToString("0.00")}  °K");
                break;

            case 3:
                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                double f = Convert.ToDouble(Console.ReadLine());
                double conta2 = (f - 32) / 1.8;
                Console.WriteLine($"{conta2.ToString("0.00")}  °C");
                break;

            case 4:
                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                double fh = Convert.ToDouble(Console.ReadLine());
                double conta3 = (fh - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{conta3.ToString("0.00")} °K");
                break;

            case 5:
                Console.WriteLine("Digite a temperatura em Kelvin:");
                double k = Convert.ToDouble(Console.ReadLine());
                double conta4 = k - 273.15;
                Console.WriteLine($"{conta4.ToString("0.00")}  °C");
                break;

            case 6:
                Console.WriteLine("Digite a temperatura em Kelvin:");
                double kv = Convert.ToDouble(Console.ReadLine());
                double conta5 = 1.8 * (kv - 273.15) + 32;
                Console.WriteLine($"{conta5.ToString("0.00")} °F");
                break;

                default:
                Console.WriteLine("opção inválida");
                break;
        }
        Console.ReadKey();
    }
}