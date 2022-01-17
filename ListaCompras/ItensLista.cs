using System;

namespace ListaCompras
{
    public class Bebida : Alimento
    {
        public Bebida(string n, double c , double p, string u) : base(n, p, c, "Bebida", u) { }
    }
    public class Matinal : Alimento
    {
        public Matinal(string n, double c, double p, string u) : base(n, p, c, "Matinal", u) { }
    }
    public class Peixe : Alimento
    {
        public Peixe(string n, double c, double p, string u) : base(n, p, c, "Peixe", u) { }
    }
    public class Fruta : Alimento
    {
        public Fruta(string n, double c, double p) : base(n, p, c, "Fruta", "Kg") { }
    }
    public class Proteina : Alimento
    {
        public Proteina(string n, double c, double p, string u) : base(n, p, c, "Proteina", u) { }
    }
    public class Vegetal : Alimento
    {
        public Vegetal(string n, double c, double p, string u) : base(n, p, c, "Vegetal", u) { }
    }

    public class Banana : Fruta
    {
        public Banana() : base("Banana", 121, 1.50) { }
    }
    public class Laranja : Fruta
    {
        public Laranja() : base("Laranja", 85, 1.50) { }
    }
    public class Tomate : Fruta
    {
        public Tomate() : base("Tomate", 27, 3.50) { }
    }
    public class Cenoura : Vegetal
    {
        public Cenoura() : base("Cenoura", 27, 2.80, "Kg") { }
    }
    public class Queijo : Matinal
    {
        public Queijo() : base("Queijo", 200, 6.50, "Kg") { }
    }
    public class Ovo : Matinal
    {
        public Ovo() : base("Ovo", 54, 3.50, "Duzia") { }
    }
    public class Alface : Vegetal
    {
        public Alface() : base("Alface", 4, 1.99, "Unidade") { }
    }
    public class Leite : Matinal
    {
        public Leite() : base("Leite", 90, 2.15, "Litro") { }
    }
    public class Guarana : Bebida
    {
        public Guarana() : base("Guarana", 120, 2.50, "Litro") { }
    }
    public class Agua : Bebida
    {
        public Agua() : base("Agua", 0.1, 1.25, "Litro") { }
    }
    public class Presunto : Proteina
    {
        public Presunto() : base("Presunto", 2.10, 5.40, "Kg") { }
    }
    public class Salmao : Peixe
    {
        public Salmao() : base("Salmao", 233, 8.60, "Kg") { }
    }
}
