using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cifraViginere
{
    class Viginere : Substituicao
    {
        private StringBuilder encriptacao;
        private StringBuilder descriptacao;
        private readonly char[] viginereAlfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789?!,.:()' ".ToCharArray();
        private double num;
        private bool isNum;

        public string Encriptar(string entradaTxt, string chaveTxt)
        {
            string chave = AdjustKeyLength(entradaTxt, chaveTxt);
            encriptacao = new StringBuilder();
            isNum = double.TryParse(chaveTxt, out num);
            if (isNum)
            {
                MessageBox.Show("Invailid Key, only letters from a - z are valid.");
                MessageBox.Show(viginereAlfabeto.Length.ToString());
                return null;
            }

                                   
            for (int i = 0; i < entradaTxt.Length; i++)
            {
                encriptacao.Append(viginereAlfabeto[Modulo(Array.IndexOf(viginereAlfabeto, entradaTxt[i]) + Array.IndexOf(viginereAlfabeto, chave[i]), 71)]);
            }

            return encriptacao.ToString();
        }

        public static string AdjustKeyLength(string entradatxt, string chavest)
        {

            StringBuilder chave = new StringBuilder(chavest);
            while (entradatxt.Length > chave.Length)
            {
                chave.Append(chavest);
            }


            return chave.ToString();
        }


        public string Descriptar(string encryptedText, string keyText)
        {
            string key = AdjustKeyLength(encryptedText, keyText);
            descriptacao = new StringBuilder();
            //Invailed Key
            isNum = double.TryParse(keyText, out num);
            if (isNum)
            {
                MessageBox.Show("Invailid Key, only letters from a - z are valid.");
                return null;
            }
            //Decryption magic
            for (int i = 0; i < encryptedText.Length; i++)
            {
                descriptacao.Append(viginereAlfabeto[Modulo(Array.IndexOf(viginereAlfabeto, encryptedText[i]) - Array.IndexOf(viginereAlfabeto, key[i]), 71)]);
            }
            return descriptacao.ToString();
        }
        public static int Modulo(int dividend, int divisor)
        {
            int rest = dividend % divisor;
            if (rest < 0)
            {
                return rest + divisor;
            }
            else
            {
                return rest;
            }
        }
    }
}
