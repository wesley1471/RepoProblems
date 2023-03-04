using MonthlyState.Entities;
using System.Globalization;

namespace MonthlyState
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite quantos estados farão parte: ");
            int cont = int.Parse(Console.ReadLine());
            double total = 0;

            List<Estado> list = new List<Estado>();

            for (int i = 0; i < cont; i++)
            {
                Console.Write("Digite o nome do Estado: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor arrecadado do Estado: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Estado(nome, valor));
            }
            foreach (Estado estado in list) { total += estado.Value; }

            double Percentual(double valor)
            {

                return valor / total * 100;

            }

            foreach(Estado estado in list)
            {
                Console.WriteLine($"O percentual de {estado.Name} foi : {Percentual(estado.Value).ToString("F2")}");
            }


        }
    }
}