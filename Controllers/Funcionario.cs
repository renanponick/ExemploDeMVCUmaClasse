using System;
using System.Collections.Generic;
namespace Controllers
{
    public class Funcionario 
        {
            public static void addFunc(int id, String nome, string cpf){
                new Models.Funcionario(id, nome, cpf);
            }
           public static List<Models.Funcionario> getFuncs(){
                return Repositories.Funcionario.getFuncs();
           }
        }
}