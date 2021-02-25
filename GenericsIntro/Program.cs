using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new GenericsIntro.MyList<string>();
            isimler.Add("Elif");

            Console.WriteLine("Hello World!");
        }
    }
}
