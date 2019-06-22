using System;

namespace Aula2.Entidades
{
    class Carro
    {

        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Marca { get; set; }
        public string Pais { get; set; }
        public int QPortas { get; set; }
        public double CapacidadeT { get; set; }
        public bool Flex { get; set; }

        public Carro()
        {
            Nome = "Civic";
            Data = DateTime.Now;
            Marca = "Honda";
            Pais = "Brazil";
            QPortas = 4;
            CapacidadeT = 50;
            Flex = false;
        }
        public Carro(string nome,DateTime DATA,string marca,string pais,int portas,double capacidade,bool flex) {

            Nome = nome;
            Data = DATA;
            Marca = marca;
            Pais = pais;
            QPortas = portas;
            CapacidadeT = capacidade;
            Flex = flex;
        }

        private string FuncaoPrivada()=>Nome = Nome.ToUpper();

        public int Velocidade() => 220;

        public double QuilometroLitro(double Km, double Litro) => Km / Litro;

        public double Autonomia(double km, double litro) => QuilometroLitro(km, litro) * CapacidadeT;

        public override string ToString()
        {
            return $"Nome:{Nome}\nData de Fabricação:{Data}\nMarca:{Marca}\nPais:{Pais}\nPortas:{QPortas}" +
                $"\nCapacidade do Tanque:{CapacidadeT}\nCarro é flex:{Flex}";
        }
    }
}
