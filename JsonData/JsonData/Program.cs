using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace JsonData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o caminho do arquivo: ");
            string path = Console.ReadLine();


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    double media = 0;
                    int i = 0;
                    int k = 0;
                    double min = double.PositiveInfinity;
                    double max = 0;
                    string list = sr.ReadToEnd();

                    Distribuidora[] dist = JsonSerializer.Deserialize<Distribuidora[]>(list);
                    

                    foreach (Distribuidora item in dist)
                    {
                        if (item.valor != 0)
                        {
                            media += item.valor;
                            i++;
                            if (item.valor < min) min = item.valor;
                            if (item.valor >= max)  max = item.valor;  


                        }
                    }

                    media = media / i;
                    foreach (Distribuidora item in dist)
                    {
                        if (item.valor > media) k++;
                    }

                    Console.WriteLine($"A quantidade de dias que foram maiores que a média foi: {k} dias");
                    Console.WriteLine($"O menor valor de faturamento foi: {min}");
                    Console.WriteLine($"O maior valor de faturamento foi: {max}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}