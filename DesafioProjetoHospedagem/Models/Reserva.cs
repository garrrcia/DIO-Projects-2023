using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }


        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;

        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes recebido
            // "IMPLEMENTE AQUI"

            if (Suite.Capacidade >= hospedes.Count)
            {

                Hospedes = hospedes;

                Console.WriteLine("A capacidade da suíte é maior ou igual ao número de hóspedes");
            }
            else
            {
                throw new Exception("A capacidade disponível é menor do que o número de hóspedes.");
                //TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes
            }
        }

        public string ObterTipoSuite()
        {
            return Suite.NomeSuite;
        }

        public void CadastrarSuite(List<Suite> suites)
        {
            Suite = suites;
           
        }
        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*  
            return Hospedes.Count;


        }
        public decimal CalcularValorDiaria()
        {
            // TODO: Retornar o valor da diária
            // cALCULO: DiasReservados * Suite.ValorDiaria

            decimal valorReserva = Suite.ValorDiaria * DiasReservados;

            //Regra: Se reservar uma súite por um perído de 10 dias ou mais, 
            //o valor da reserva tem desconto de 10%

            if (DiasReservados >= 10)
            {
                decimal valorDesconto = valorReserva * Convert.ToDecimal(0.10);
                valorReserva -= valorDesconto;
            }

            return valorReserva;
        }

       
    }
}