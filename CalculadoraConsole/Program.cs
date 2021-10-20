using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcC
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            try
            {
                calc(args);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro geral  - {e.Message}{ Environment.NewLine}");
            }

        }
        public static void calc(string[] args)
        {
            if (args[0] == "+" || args[0] == "soma")
            {
                int resultado = 0;
                List<int> num = new List<int>();
                for (int i = 1; i < args.Length; i++)
                {
                    num.Add(Convert.ToInt32(args[i]));
                }
                resultado = soma(num);
                Console.WriteLine(resultado);
            }
            if (args[0] == "-" || args[0] == "subtracao")
            {
                int a = Convert.ToInt32(args[1]);
                int b = Convert.ToInt32(args[2]);
                int[] calc = { a, b };
                int x = Sub(calc);

                Console.WriteLine(x);
            }

            if (args[0] == "/" || args[0] == "divisao")
            {
                int a = Convert.ToInt32(args[1]);
                int b = Convert.ToInt32(args[2]);
                int[] calc = { a, b };
                float x = Divi(calc);

                Console.WriteLine($"{x}");
                return;
            }

            if (args[0] == "!" || args[0] == "fatoracao")
            {
                int a = (Convert.ToInt32(args[1]));
                int resultado = 0;
                resultado = fatora(a);
                Console.WriteLine(resultado);
            }

        }
        static int soma(List<int> num)
        {
            int[] x = num.ToArray();
            int resultado = 0;
            num.IndexOf(0);
            for (int i = 0; i < x.Length; i++)
            {
                int value = x[i];
                resultado += value;
            }
            return resultado;
        }

        public static int Sub(int[] calc)
        {
            int resultado = (calc[0] - calc[1]);
            return resultado;
        }

        public static float Divi(int[] calc)
        {
            int resultado = 0;
            try
            {
                resultado = (calc[0] / calc[1]);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message + $" Não é possivel dividir por 0 { Environment.NewLine}");
            }
            return resultado;
        }

        static int fatora(int fatora)
        {
            int x = 1;
            while (fatora != 1)
            {
                x = x * fatora;
                fatora = fatora - 1;
            }
            return x;
        }
    }
    public class Calc
    {

        public static void Teste(string[] args)
        {

        }
    }
}
    

       
            
            //soma, fatoracao, subtracao, divisao

            // - soma < Lista de numeros> exemplo: calcC.exe - soma 4 3 8 , resultado 15
            // - fatora < numero a ser fatorado > exemplo: calcC.exe - fatora 4 , resultado 24
            // - subtracao < numero a subtrair> < numero subtraido > exemplo: calcC.exe - subtracao 8 2, resultado 6
            // - divisao < numero dividendo > < numero divisor > exemplo: calcC.exe - subtracao 8 2, resultado 4
            