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
            
            
                shift=shift % abeceda.Length;
            
            



            for (int i = 0; i < stCrk; i++)
            {
                int l = 0;
                while (true)                      //primerjanje črk in izpis če je prav SAMO TEST
                {
                    
                    
                    if (crke[i] == abeceda[l])                      //primerja vneseno črko z črko v tebeli abeceda
                    {


                        if ((l + shift) >= (abeceda.Length))        //če je seštevek črke in preika večji od dolžine tabele gre znova, k začetni črki
                        {
                            

                            Console.Write(abeceda[(l + shift) % abeceda.Length]);                //izpiše številko črke z zamiko 
                            
                        
                        }
                        else
                        {
                            Console.Write(abeceda[l + shift]);          //izpiši številko črke z zamikom
                        }
                        break;

                    }
                    l++;                   // poveča l za 1. Za premik črke v tabeli
                }
                
            }
            
        }
    }
}

