using System;

namespace projeto1
{
    public interface IAeronave : IPassagem // -> puxando características de IPAssagem
    {
        int Id {get; set;}

        string ClasseAeronave {get; set;}

        //void EscolherClasse();
    }   
}