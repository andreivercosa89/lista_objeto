using System;
using System.Collections.Generic;

namespace lista_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> listaCarro = new List<Carro>();

            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            carro1.nome = "Gol";
            carro1.anolancamento = "2008";
            listaCarro.Add(carro1);

            carro1.nome = "Palio";
            carro1.anolancamento = "2002";
            listaCarro.Add(carro2);

            carro1.nome = "Fusca";
            carro1.anolancamento = "1942";
            listaCarro.Add(carro3);


            foreach(var elemento in listaCarro){
                Console.WriteLine("Nome: {0}\nAno de lancamento: {1}",elemento.nome,elemento.anolancamento);
            }
        }
    }
}
