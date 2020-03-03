using System;
using System.Collections.Generic;
using Repositories;

namespace Models
{
    public class Funcionario
        {
            private int ID { get; set; }
            public String Nome { get; set; }
            public String Cpf { get; set; }
            public Funcionario(int id, String nome, string cpf){
                ID = id;
                Nome = nome;
                Cpf = cpf;
                Repositories.Funcionario.addFunc(this);
            }
            
        }
}