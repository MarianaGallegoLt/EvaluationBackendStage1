using System;
using System.Linq;

namespace BackendStage1Evaluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;

            Console.WriteLine("Ingrese un texto:");
            text = Console.ReadLine();

            Console.WriteLine(stringVerification(text));
        }

        static string stringVerification(string txt)
        {
            string texto = txt;
            Boolean isEmpty = true;
            string newString = "NA";

            string[] invalidChars = new string[] { "@", "!", "\"", "#", "$", "%", "&", "/", "(", ")", "=", "?", "¿", "¡", "´", "¨", "+", "*", "~", "{", "}", "^", "[", "]", "`", ".", ";", ":", "," };
            string[] validChars = new string[] { " ", "-", "_"};

            foreach(char l in texto)
            {
                string lTxt = l.ToString();
                if(Char.IsLetter(l) | char.IsDigit(l) | validChars.Contains(l.ToString()))
                    isEmpty = false;
            }

            if (!isEmpty)
            {
                foreach (var c in invalidChars)
                {
                    texto = texto.Replace(c, string.Empty);
                    newString = texto;
                }
            }
            return newString;
        }
    }
}
