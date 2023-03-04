using System.Text;

namespace StringReverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua string: ");
            string invert = Console.ReadLine();
            StringBuilder sr = new StringBuilder();
            for (int i = invert.Length -1 ; i >= 0 ; i--) 
            {
                sr.Append(invert[i]);
            }
            Console.WriteLine($"String invertida: {sr.ToString()}");
        }
    }
}