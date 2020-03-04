using System;
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
            public override string ToString(){
                return $" ID: { ID } \n Nome: { Nome } \n Cpf: { Cpf }";
            }
            
        }
}