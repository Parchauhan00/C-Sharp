namespace Ref_Vs_Out
{
    internal class Program
    {
        static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }


        static void PassByOut(out int a)
        {
            a = 20;
            Console.WriteLine("value is : " + a);
        }
        static void Main(string[] args)
        {
            int x = 5;
          //  PassByRef(ref x);
         //   Console.WriteLine("Value is {0}",x);


            int a  ;
            PassByOut(out a);
            Console.WriteLine("Value by out {0}",a);
        }
    }
}
