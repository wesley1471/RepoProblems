namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o número: ");
            int num = int.Parse(Console.ReadLine());
            
            if(num == 0)
            {
                Console.WriteLine("Your input is equal to zero!!");
            }
            List<int> list = new List<int>();
            list.Add(1);
            for(int i = 0; i < num;){
            
                list.Add(list.Last() + i);

                i = i + list.Last();

            }
            if(list.Last() == num) 
            {
                Console.WriteLine("Fibonachi!!");
            }
            else
            {
                Console.WriteLine("Not Fibonacci!!");
            }

        }
    }
}