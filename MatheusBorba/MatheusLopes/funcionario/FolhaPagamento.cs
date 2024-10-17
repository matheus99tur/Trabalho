using System;

namespace MatheusLopes.funcionario;

public class FolhaPagamento
{
    public FolhaPagamento(){
        Id = Guid.NewGuid().ToString();
    }
 public String Valor{get;set;}
 public int Ano{get;set;}
 public String Mes {get;set;}
 public String Quantidade {get;set;}
 public String Id{get;set;}

 public int SalarioBruto{get;set;}
 public int impostoIrrf{get;set;}
 public int impostoInss{get;set;}
 public int salarioliquido{get;set;}

}


