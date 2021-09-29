using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1{

     public interface IPassagem{

         int Id {get; set;}

         string NomeEmpresa {get;set;}

         double PrecoPassagem {get;set;}

         string Destino {get;set;}
         

        //  public void VenderPassagem();
    }
}