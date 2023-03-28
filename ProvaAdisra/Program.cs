using System;

public class Program
{

    //Questão número 1:
    public static void SequenciaFibonacci(string[] args)
    {
        Console.Write("Digite a posição desejada na sequência de Fibonacci: ");
        int posicao = int.Parse(Console.ReadLine());

        int anterior = 0;
        int atual = 1;
        int proximo = anterior + atual;

        for (int i = 2; i <= posicao; i++)
        {
            proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        Console.WriteLine($"O número da sequência de Fibonacci na posição {posicao} é {proximo}");
    }

    //Questão número 2:
    public static void Main(string[] args)
    {
        int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int pares = 0;
        int impares = 0;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
        }

        if (pares > impares)
        {
            Console.WriteLine($"A matriz tem mais números pares ({pares}) do que ímpares ({impares})");
        }
        else if (impares > pares)
        {
            Console.WriteLine($"A matriz tem mais números ímpares ({impares}) do que pares ({pares})");
        }
        else
        {
            Console.WriteLine($"A matriz tem a mesma quantidade de números pares ({pares}) e ímpares ({impares})");
        }
    }

    // Questão número 3:

    //O resultado que aparece em tela é 4.



    //Questão número 4:

    abstract class Carro
    {
        public string NumeroChassi { get; set; }
        public string NumeroMotor { get; set; }

        public abstract double CalcularCustoVenda();
    }

    class CarroFlex : Carro
    {
        public int NumeroPortas { get; set; }
        public int Cilindrada { get; set; }
        public double CustoProducao { get; set; }

        public override double CalcularCustoVenda()
        {
            double imposto = CustoProducao * 0.2;
            double lucro = CustoProducao * 0.25;
            return CustoProducao + imposto + lucro;
        }
    }
    class CarroDiesel : Carro
    {
        public int CapacidadeCarga { get; set; }
        public int VolumeCacamba { get; set; }
        public double CustoProducao { get; set; }

        public override double CalcularCustoVenda()
        {
            double imposto = CustoProducao * 0.3;
            double lucro = CustoProducao * 0.25;
            return CustoProducao + imposto + lucro;
        }
    }
    class CarroEletrico : Carro
    {
        public int Potencia { get; set; }
        public int DuracaoBateria { get; set; }
        public double CustoProducao { get; set; }

        public override double CalcularCustoVenda()
        {
            double imposto = CustoProducao * 0.1;
            double lucro = CustoProducao * 0.25;
            return CustoProducao + imposto + lucro;
        }
    }
    static void Carros(string[] args)
    {
        CarroFlex carroFlex = new CarroFlex();
        carroFlex.NumeroChassi = "123456";
        carroFlex.NumeroMotor = "ABC123";
        carroFlex.NumeroPortas = 4;
        carroFlex.Cilindrada = 2000;
        carroFlex.CustoProducao = 50000;

        Console.WriteLine($"O custo de venda do carro flex é R${carroFlex.CalcularCustoVenda()}");

        CarroDiesel carroDiesel = new CarroDiesel();
        carroDiesel.NumeroChassi = "654321";
        carroDiesel.NumeroMotor = "XYZ789";
        carroDiesel.CapacidadeCarga = 1000;
        carroDiesel.VolumeCacamba = 500;
        carroDiesel.CustoProducao = 80000;

        Console.WriteLine($"O custo de venda do carro diesel é R${carroDiesel.CalcularCustoVenda()}");

        CarroEletrico carroEletrico = new CarroEletrico();
        carroEletrico.NumeroChassi = "789456";
        carroEletrico.NumeroMotor = "DEF456";
        carroEletrico.Potencia = 200;
        carroEletrico.DuracaoBateria = 500;
        carroEletrico.CustoProducao = 100000;

        Console.WriteLine($"O custo de venda do carro elétrico é R${carroEletrico.CalcularCustoVenda()}");
    }
}

