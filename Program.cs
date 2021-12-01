using System;

namespace JustTypeThis
{
    class Program
    {
        static void Main(string[] args)
        {
            string Palavra = "string e uma sequencia de caracteres geralmente utilizada para representar palavras frases ou textos de um programa";
            string PalavraSemEspaco = Palavra.Replace(" ", "");
            string PalavraBcp = Palavra + " ";
            string[] PalavrasSeparadas = new string[PalavraSemEspaco.Length + 1];
            
            int s = 0;
            
            Console.Clear();
            Console.WriteLine(Palavra);

            
                 foreach(char letra in PalavraSemEspaco.ToLower())
                 {
                     PalavrasSeparadas[s] = letra.ToString();
                     s++;
                 }


            for(int i = 0; i < PalavraSemEspaco.Length;)
            {
                string a = Convert.ToString(Console.ReadKey().Key);
                Console.Clear();
                a = a.ToLower();
                if(a == PalavrasSeparadas[i])
                {
                    i++;
                    PalavraBcp = PalavraBcp.Remove(0, 1);
                    string str = PalavraBcp.Substring(0, 1);
                    if(str == " ")
                        PalavraBcp = PalavraBcp.Remove(0, 1);
                    
                    Console.WriteLine(PalavraBcp);
                }
                else
                {
                     Console.WriteLine(PalavraBcp);
                }
            }   
         }
    }
}
