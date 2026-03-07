using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace seminarska_šifriranje
{
    internal class Sifriranje:Tabela
    {
        public int shift;       //zamik črk
        public string text;     //besedilo, ki ga hočemo šifrirati
        public int stCrk;       //dolžina besedila
        
        public void encryption(string text, int shift)       //ustvaril metodo za izvanje šifriranje
        {
            this.shift = shift;     //povezal spremenljivke
            this.text = text.ToUpper();          //spremenim besedilo v velike začetnnice
            stCrk = text.Length;                //preštejem številko simbolov v besedilu
            char[] crke = this.text.ToCharArray();   //postavitev funkcije za stetje
           

            char[] vnesBesedilo = new char[stCrk];  //TABELA

            
            bool j= false;
            for (int i = 0; i < stCrk; i++)
            {
                int l = 0;
                while (true)                      //primerjanje črk in izpis če je prav SAMO TEST
                {
                    
                    
                    if (crke[i] == abeceda[l])
                    {
                        if ((l + shift) >= abeceda.Length)
                        {
                            l = 0;

                            Console.Write(abeceda[l]);
                        }
                        else
                        {
                            Console.Write(abeceda[l+shift]);
                        }
                        
                        break;

                    }
                    l++;
                }
                
            }
            
        }
    }
}
