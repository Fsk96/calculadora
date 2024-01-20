using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    // Definição de uma nova classe
    public class Calculadora
    {
        // Membros da classe
        //
        // Propriedade
        public int Display { get; set; } // pode-se ler e escrever

        // Método para somar
        public int Somar(int num)
        {
            Display += num;
            return Display;
        }

        // Método para subtrair
        public int Subtrair(int num)
        {
            Display -= num;
            return Display;
        }

        //Método para multiplicar
        public int Multi(int num)
        {
            Display = Display * num;
            return Display;
        }

        //Método para dividir
        public int Div(int num)
        {
            if(num == 0)
            {
                Console.WriteLine("Erro,impossivel dividir por 0");
                return Display;
                
            }
            else
            {
                Display = Display / num;
                return Display;
            }
        }
        // Construtor (define as condições iniciais)
        // O método construtor é chamado quando o objecto é criado
        // Só é chamado UMA vez
        public Calculadora()
        {
            Display = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Testar a calculadora

            // Criar um objecto do tipo calculadora
            Calculadora MyCalc = new Calculadora();

            // Alterar o conteúdo do display
            // (tirar partido do "set")
            MyCalc.Display = 15;

            // Quero somar 4
            // Chamar o método Somar (que é público)
            int res = MyCalc.Somar(4);
            Console.WriteLine($"O resultado é {res}");
            // após a alteração ao método Somar(), o código podia ser só
            //MyCalc.Somar(4);
            //Console.WriteLine($"O resultado é {MyCalc.Display}");

            // Verificar o valor que está guardado dentro do objecto (da calculadora)
            // (tirar partido do "get")
            Console.WriteLine($"Ficou guardado {MyCalc.Display}");

            MyCalc.Subtrair(2);
            Console.WriteLine($"Display {MyCalc.Display}");


            // 2- Fazer as 4 operações elementares.

            MyCalc.Multi(2);
            Console.WriteLine($"17*2= {MyCalc.Display}");

            MyCalc.Div(0);
            Console.WriteLine($"Display = {MyCalc.Display}");

            MyCalc.Div(2);
            Console.WriteLine($"34/2 = {MyCalc.Display}");

           

            Console.ReadLine();


        }
    }
}
