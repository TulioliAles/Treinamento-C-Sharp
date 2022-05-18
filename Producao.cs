using System;

namespace Array
{
    public class Producao
    {
        public int Caixas { get; set; }
        public DateTime Data { get; set; }
        
        public Producao(int caixas, DateTime data)
        {
            Caixas = caixas;
            Data = data;
        }

        public static Producao GerarProducao(){
            Random  rnd = new Random();
            return new Producao(rnd.Next(1, 10), DateTime.Now);
        }
    }
}