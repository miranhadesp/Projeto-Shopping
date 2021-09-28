using System;

namespace projeto1
{
    public interface IAeronave : IPassagem
    {
        int Id {get; set;}

        string ClasseAeronave {get; set;}

        //void EscolherClasse();
    }   
}