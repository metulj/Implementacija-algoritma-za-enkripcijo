using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace seminarska_šifriranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sifriranje besedilo = new Sifriranje();
            Tabela tabela= new Tabela();
            Console.Write("Vpiši besedo, ki jo želiš šifrirati: ");     //vpišem besedilo, ki ga hočem kriptirat
            besedilo.text = Console.ReadLine();
            besedilo.encryption(besedilo.text,2);
            Console.WriteLine();
            Console.WriteLine(besedilo.text);
            Console.WriteLine(besedilo.stCrk);
            


        }
    }
}
