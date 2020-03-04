using System;
namespace CSharpeDesktop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int op =0;
            do{
                Console.WriteLine("\n\n");
                Console.WriteLine("Digite a Lista");
                Console.WriteLine(
                    "1-Add um Funcionario\n"+
                    "2-Ver todos Funcionario\n"+
                    "3-Sair \n"
                );
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (op)
                {
                    case 1:{
                        Views.Funcionario.addFunc();
                        break;
                    }
                    case 2:{
                        Views.Funcionario.getFuncs();
                        break;
                    }
                    case 3:{
                        break;
                    }
                    default:{
                        Console.WriteLine("Número inválido");
                        break;
                    }
                }
            }while(op!=3);
        }
    }
}