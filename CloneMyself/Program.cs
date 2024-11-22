namespace CloneMyself
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hva heter du?");
            var name = Console.ReadLine();

            Console.WriteLine("Hva er egenskapene dine?");
            var abilities = Console.ReadLine();

            Console.WriteLine("Hva bruker du egenskapene til?");
            var usingAbilities = Console.ReadLine();

            NewClass Christoffer = new NewClass(name, abilities, usingAbilities);

            Christoffer.PrintText();       
        }
    }
}
