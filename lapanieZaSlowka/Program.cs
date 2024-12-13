namespace lapanieZaSlowka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sent1 = Console.ReadLine().Split(' ');
            string[] sent2 = Console.ReadLine().Split(' ');
            string? rozneSlowa = "";

            foreach(string s in sent1)
                if (!sent2.Contains(s))
                    rozneSlowa += $" {s}";

            foreach(string s in sent2)
                if(!sent1.Contains(s))
                    rozneSlowa += $" {s}";

            Console.WriteLine(rozneSlowa.Trim());
        }
    }
}
