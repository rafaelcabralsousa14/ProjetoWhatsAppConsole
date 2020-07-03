using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WhatsAppConsole
{
    public class Agenda : iAgenda
    {
        public List<Contatos> contato;

        private const string PATH = "Database/contatos.csv"; 

        private string PrepararLinha(Contatos c){
            return $"\nNome:{c.Nome};Telefone:{c.Telefone}";
        }

    }
}