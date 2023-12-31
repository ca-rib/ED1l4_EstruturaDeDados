//Caroline e Vinnicius 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade-21-08-2023
{
    public class Contatos
    {
        public List<Contato> Agenda { get; }

        public Contatos()
        {
            Agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            Agenda.Add(c);
            return true;
        }
        public Contato pesquisar(Contato contato)
        {
            return Agenda.FirstOrDefault(c => c.Equals(contato));
        }
        public bool alterar(Contato contato)
        {
            int index = Agenda.IndexOf(contato);

            if(index >= 0) {
                Agenda[index] = contato;
                return true;
            }
            
            return false;
        }
        public bool remover(Contato c)
        {
            return Agenda.Remove(c);
        }
    }
}
