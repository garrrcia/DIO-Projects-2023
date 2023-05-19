using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        

         public Suite() { }

        public Suite(string nomeSuite, int capacidade, string comodidadesSuite, string descricaoSuite, decimal valorDiaria)
        {
            NomeSuite = nomeSuite;
            Capacidade = capacidade;
            ComodidadesSuite = comodidadesSuite;
            DescricaoSuite = descricaoSuite;
            ValorDiaria = valorDiaria;
        }

        public Suite(string nomeSuite, int capacidade, string comodidadesSuite, string descricaoSuite, decimal valorDiaria, int v) : this(nomeSuite, capacidade, comodidadesSuite, descricaoSuite, valorDiaria)
        {
        }

        public string NomeSuite { get; set; }
        public string ComodidadesSuite { get; set; }
        public string DescricaoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public static implicit operator Suite(List<Suite> v)
        {
            throw new NotImplementedException();
        }
    }
}

