using System;
using Projeto_01_RPG.src.Entities;

namespace Projeto_01_RPG
{
    class Program
    {
        static void Main()
        {
            Hero Arus = new Hero("Arus", 30, "Knight");
            Hero Jessica = new Hero("Jessica", 32, "WhiteWizzard");
            Hero Wedge = new Hero("Wedge", 29, "Ninja");
            Hero Topapa = new Hero("Topapa", 31, "BlackWizzard");


            Console.WriteLine(Arus);
            Console.WriteLine(Jessica);
            Console.WriteLine(Wedge);
            Console.WriteLine(Topapa);
        }
    }
}
