using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Evento
{
    public class Eventos
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public double Valor { get; set; }
        public List<double> Prancheta { get; set; }

        public Eventos(string nome, string local, double valor)
        {
            this.Nome = nome;
            this.Local = local;
            this.Valor = valor;
        }

        public void AdicionarPessoa(int pessoa)
        {
            Prancheta ??= new List<double>();
            Prancheta.Add(pessoa);
        }

        public double VerificarEvento()
        {
            return Valor > 0 ? Valor : 0;
        }

        //E os eventos que serão criados podem ter várias pessoas, mas não mais que 4.
       


    }
}