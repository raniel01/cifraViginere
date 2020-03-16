using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifraViginere
{
    class Substituicao
    {
        protected int iChave;
        protected string alfabeto = "abcdefghijklmnopqrstuvwxyz";

        public Substituicao()
        {
        }
        public string Encriptar(string entradaTxt)
        {
            int counter = 0;
            string saidaTxt = "";
            foreach (char c in entradaTxt)
            {
                if (alfabeto.Contains(c.ToString()))
                {
                    int i = alfabeto.IndexOf(c) + iChave;
                    if (i > 26)
                    {
                        i -= alfabeto.Length;
                    }
                    if (char.IsUpper(c))
                    {
                        saidaTxt = saidaTxt + char.ToUpper(alfabeto[i]).ToString();
                    }
                    else
                    {
                        saidaTxt = saidaTxt + char.ToLower(alfabeto[i]).ToString();
                    }
                }
                else
                {
                    saidaTxt = saidaTxt + c.ToString();
                }
                counter++;
            }
            return saidaTxt;
        }

        public string Descriptar(string entradaTxt)
        {
            int counter = 0;
            string outputText = "";
            foreach (char c in entradaTxt)
            {
                if (alfabeto.Contains(c.ToString()))
                {
                    int i = alfabeto.IndexOf(c) - iChave;
                    if (i < 0)
                    {
                        i += alfabeto.Length;
                    }
                    if (char.IsUpper(c))
                    {
                        outputText = outputText + char.ToUpper(alfabeto[i]).ToString();
                    }
                    else
                    {
                        outputText = outputText + char.ToLower(alfabeto[i]).ToString();
                    }
                }
                else
                {
                    outputText = outputText + c.ToString();
                }
                counter++;
            }
            return outputText;
        }
    }
    
}
