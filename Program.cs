namespace GA_Constructors_JuanHernandez
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Exploring Constructors in C#");

            Books book1 = new Books("1982", "The Color Purple");
            Console.WriteLine($"Book 1: Title = {book1.Title}, Author = {book1.Author}");

            Books book2 = new Books("Cat in the Hat");
            Console.WriteLine($"Book 2: Title = {book2.Title}, Author = {book2.Author}");
        }
    }
}