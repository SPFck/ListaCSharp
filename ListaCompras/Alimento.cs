using System;

namespace ListaCompras
{
    public class Alimento
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Custo { get; set; }
        public string Tipo { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; }

        public Alimento(string n, double p, double c, string t, string u)
        {
            this.Nome = n;
            this.Preco = p;
            this.Calorias = c;
            this.Tipo = t;
            this.Unidade = u;
        }
        public void setCusto(double qnt)
        {
            this.Custo += this.Preco * qnt;
        }
        public double getCustoCompra(double qnt)
        {
            return qnt * this.Preco;
        }
        public void resetCusto()
        {
            this.Custo = 0;
        }
    }
}
