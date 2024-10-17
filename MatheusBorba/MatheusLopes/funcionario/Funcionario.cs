using System;

namespace MatheusLopes.funcionario;

public class Funcionario
{
    public Funcionario(){
        Id = Guid.NewGuid().ToString();
    }

    public String Id{get;set;}
    public String? Nome{get;set;}
    public String? Cpf{get;set;} 
}
