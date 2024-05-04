using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Sistema_de_Hospedagem.Enum;

namespace _Sistema_de_Hospedagem.Models
{
    public class Suite
    {
        public Suite(TipoSuiteEnum TipoSuite, int Capacidade, decimal ValorDiaria)
        {
            if (Capacidade < 0 )
            {
                throw new ArgumentException("Capacidade inválida!");
            }
            if (ValorDiaria < 0 )
            {
                throw new ArgumentException("Valor da diária inválido!");
            }
            this.tipoSuite = TipoSuite;
            this.capacidade = Capacidade;
            this.valorDiaria = ValorDiaria;
        }
        private TipoSuiteEnum tipoSuite;
        private int capacidade;
        private decimal valorDiaria;

        public TipoSuiteEnum TipoSuite 
        { 
            get => tipoSuite; 
            
            set => tipoSuite = value; 
        }
        public int Capacidade 
        { 
            get => capacidade; 
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacidade inválida!");
                }
                else
                {
                    capacidade = value;
                }
            } 
        }
        public decimal ValorDiaria 
        { 
            get => valorDiaria; 
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Valor da diária inválido!");
                }
                else
                {
                    valorDiaria = value;
                }
            } 
        }
    }
}