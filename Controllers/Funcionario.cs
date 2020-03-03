using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class Funcionario 
        {
            public List<Funcionario> getFuncs(){
                List<Funcionario> funcionarios = new List<Funcionario>();
                return funcionarios;
            }
            public void addFunc(int id, String nome, string cpf){
                //Validações dos dados inputados

                new Models.Funcionario(id, nome, cpf);
            }

        }
}