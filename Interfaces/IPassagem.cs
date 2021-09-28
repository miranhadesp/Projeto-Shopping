using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1{

     public interface IPassagem{

         string NomeEmpresa {get;set;}

         double PrecoPassagem {get;set;}

         string Destino {get;set;}

         void VenderPassagem();
    }
}