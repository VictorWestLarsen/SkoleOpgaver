using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PigLatin
{
    public class Translator
    {
        

        public string Translate(string v)
        {
            bool capital = false;
            string slut = "";
            string temp = "";
            string[] liste = v.Split(' ');

            for (int j = 0; j < liste.Length ; j++) {

                string tempI = liste[j];
                
                for (int i = 0; i < tempI.Length; i++) {
                    if (Char.IsUpper(tempI[0]))
                    {
                        capital = true;
                    }
                     
                    if (tempI.StartsWith("a") || tempI.StartsWith("e") || tempI.StartsWith("i") || tempI.StartsWith("o"))
                    {
                        if (capital == true)
                        {
                          tempI = tempI.Substring(0, 1).ToUpper() + tempI.Substring(1).ToLower();
                            capital = false;
                        }
                        tempI += "ay";
                        break;
                    }
                    else
                    {
                        temp = tempI.Substring(0, 1);
                        tempI = tempI.Substring(1);
                        tempI += temp;
                    }
                }
                slut = slut + tempI + " ";
            }
            slut = slut.Substring(0, slut.Length - 1);
            return slut;
        }
        public string TranslateDansk(string v)
        {
            bool capital = false;
            string slut = "";
            string temp = "";
            string[] liste = v.Split(' ');

            for (int j = 0; j < liste.Length; j++)
            {

                string tempI = liste[j];

                for (int i = 0; i < tempI.Length; i++)
                {
                    if (Char.IsUpper(tempI[0]))
                    {
                        capital = true;
                    }
                   
                    if (tempI.StartsWith("a") || tempI.StartsWith("e") || tempI.StartsWith("i") || tempI.StartsWith("o") || tempI.StartsWith("u") || tempI.StartsWith("y") || tempI.StartsWith("æ") || tempI.StartsWith("ø") || tempI.StartsWith("å"))
                    {
                        if (capital == true)
                        {
                            tempI = tempI.Substring(0, 1).ToUpper() + tempI.Substring(1).ToLower();
                            capital = false;
                        }
                        tempI += "ay";
                        break;
                    }
                    else
                    {
                        temp = tempI.Substring(0, 1);
                        tempI = tempI.Substring(1);
                        tempI += temp;
                    }
                }
                slut = slut + tempI + " ";
            }
            slut = slut.Substring(0, slut.Length - 1);
            return slut;
        }
    }
   

}
