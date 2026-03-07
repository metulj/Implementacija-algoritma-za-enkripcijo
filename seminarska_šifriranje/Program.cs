using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace seminarska_šifriranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Sifriranje sifrtitanej = new Sifriranje();
            Tabela tabela = new Tabela();
            Console.Write("Vpiši besedo, ki jo želiš šifrirati: ");     //vpišem besedilo, ki ga hočem kriptirat
            sifrtitanej.text = Console.ReadLine();
            Console.Write("Vpiši šifrirni ključ: ");
            sifrtitanej.shift= int.Parse(Console.ReadLine());
            sifrtitanej.encryption(sifrtitanej.text, sifrtitanej.shift);
            Console.WriteLine();
         

            Desifriranje desifriranje=new Desifriranje();
            Console.Write("Vpiši besedo, ki jo želiš dešifrirta: ");     //vpišem besedilo, ki ga hočem kriptirat
            desifriranje.text = Console.ReadLine();
            Console.Write("Vpiši šifrirni ključ: ");
            desifriranje.shift = int.Parse(Console.ReadLine());
            desifriranje.decrypt(desifriranje.text, desifriranje.shift);
            Console.WriteLine();
           



        }
    }
}
