using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Sistema_de_Hospedagem.Models
{
    public class Reserva
    {
        private List<Pessoa> hospedes;
        private Suite suite;
        private int diasReserva;

        public Reserva(List<Pessoa> Hospedes, Suite Acomodacao, int DiasReserva)
        {
            if (Hospedes.Count > Acomodacao.Capacidade)
            {
                throw new ArgumentOutOfRangeException("A quantidade de hospedes é maior que o suportado pela suíte, favor escolha outra acomodação.");
            }
            else if (Hospedes.Count <= 0)
            {
                throw new ArgumentException("Não é possível fazer uma reserva sem hóspedes");
            }
            else if (DiasReserva < 0)
            {
                throw new ArgumentException("Não é possível fazer uma reserva com menos de um dia.");
            }
            this.hospedes = Hospedes;
            this.suite = Acomodacao;
            this.diasReserva = DiasReserva;
        }

        public List<Pessoa> Hospedes
        {
            get => hospedes;

            set
            {
                if (ObterQantidadeHospedes() < 0)
                {
                    throw new ArgumentException("A quantidade de hóspedes deve ser maior ou igual a um.");
                }
                else if (Hospedes.Count > Acomodacao.Capacidade)
                {
                    throw new ArgumentOutOfRangeException("A quantidade de hospedes é maior que o suportado pela suíte, favor escolha outra acomodação.");
                }
                hospedes = value;
            }
        }
        public Suite Acomodacao 
        { 
            get => suite; 
            
            set
            {
                if (value.Capacidade < 0)
                {
                    throw new ArgumentException("A suíte deve acomodar ao menos uma pessoa.");
                }
                else if (value.ValorDiaria < 0)
                {
                    throw new ArgumentException("O valor da diária deve ser maior que zero.");
                }
                suite = value;
            }
        }

        public int DiasReserva 
        { 
            get => diasReserva; 
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A reserva deve ser de pelo menos um dia.");
                }
                diasReserva = value;
            } 
        }

        public void CadastrarHospedes(List<Pessoa> hosp)
        {
            Hospedes = hosp;
        }
        public void CadastrarSuite(Suite Suite)
        {
            Acomodacao = Suite;
        }

        public int ObterQantidadeHospedes()
        {
            return hospedes.Count;
        }
        
        public decimal CalcularValorDiaria()
        {
            decimal totalHospedagem  = 0.00M;
            
            if (diasReserva >= 10)
            {
                totalHospedagem = suite.ValorDiaria * diasReserva * 0.90M;
            }
            else 
            {
                totalHospedagem = suite.ValorDiaria * diasReserva;
            }            
            return totalHospedagem;
        }
    }
}