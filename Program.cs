using System;
using System.Threading;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Producao[] apontamentos = new Producao[5];

            int index = 0;

            while(index < apontamentos.Length){
                apontamentos[index] = Producao.GerarProducao();
                index++;
                Thread.Sleep(2000);
            }    

            for (int i = 0; i < apontamentos.Length; i++)
            {
                Console.WriteLine("Caixas: {0} - Data: {1}", apontamentos[i].Caixas, apontamentos[i].Data);
            }
        }
    }
}