using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Sistema_de_Hospedagem.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        
        public Pessoa (string Nome, string Sobrenome)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                throw new ArgumentException($"Nome inválido.");
            }
            if (string.IsNullOrEmpty(Sobrenome))
            {
                throw new ArgumentException($"Sobrenome inválido.");
            }

            this.nome = Nome.ToUpper();
            this.sobrenome = Sobrenome.ToUpper();
        }        
        public string Nome 
        { 
            get => nome;
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome inválido.");
                }
                else 
                {
                    nome = value.ToUpper();
                }
            }         
        }
        public string Sobrenome 
        { 
            get => sobrenome; 
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Sobrenome inválido.");
                }
                else
                {
                    sobrenome = value.ToUpper();
                }
            } 
        }
    }
}