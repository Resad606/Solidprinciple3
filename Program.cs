namespace SolidPrinciple3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            Console.WriteLine(developer.GetFullName());
            Person teacher = new Teacher();
            Console.WriteLine(developer.GetFullName());
            Person student = new Student();
            Console.WriteLine(developer.GetFullName());
        }
    }
}