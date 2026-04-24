using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutineNew.Models
{
    public class Attivita
    {
        private string _nome;
        private string _descrizione;
        private DateTime _dateTimeInizio;
        private DateTime _dateTimeFine;
        private string _categoria;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public DateTime DateTimeInizio
        {
            get { return _dateTimeInizio; }
            set { _dateTimeInizio = value; }
        }
        public DateTime DateTimeFine
        {
            get { return _dateTimeFine; }
            set { _dateTimeFine = value; }
        }
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

    }
}
