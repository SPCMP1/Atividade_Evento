using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Evento
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereço { get; set; }
    
        public Pessoa(string nome, int idade, string endereço)
        {
            this.Nome =  nome;
            this.Idade = idade;
            this.Endereço = endereço;
        }


    
    }
}