namespace Enums
{
    enum Days
    {
        Sunday, //0
        Monday, //2
        Tuesday, //3 
        Wed,   //4
        Thur,
        Fry,
        Saturday,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Days birthday = Days.Fry;

            Console.WriteLine(birthday);
           Console.WriteLine(Days.Sunday);
        }
    }
}
