using System.Collections.Generic;
namespace Repositories
{
    public class Funcionario
        {
            static List<Models.Funcionario> funcionarios = new List<Models.Funcionario>();
            public static void addFunc(Models.Funcionario funcionario){
                funcionarios.Add(funcionario);
            }
            public static List<Models.Funcionario> getFuncs(){
                return funcionarios;
            }
        }
}