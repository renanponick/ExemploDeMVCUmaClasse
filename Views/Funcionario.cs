using System;
namespace Views
{
    public class Funcionario
        {
            public static void addFunc(){
                int id = Controllers.Funcionario.getFuncs().Count+1;
                String nome, cpf;
                try{
                    Console.WriteLine("Digite o Nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o Cpf com pontuação: ");
                    cpf = Console.ReadLine();
                    Controllers.Funcionario.addFunc(id, nome, cpf);
                }catch(Exception e){
                     Console.WriteLine($"Erro: {e}");
                }
            }
            public static void getFuncs(){
                Console.WriteLine(" - Lista de Funcionarios cadastrados - ");
                foreach(Models.Funcionario funcionario in Controllers.Funcionario.getFuncs()){
                    Console.WriteLine(funcionario);
                }
            }
        }
}