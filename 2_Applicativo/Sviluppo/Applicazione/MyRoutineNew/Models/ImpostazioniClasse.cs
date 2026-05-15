using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutineNew.Models
{
    public class ImpostazioniClasse
    {
        //notifiche
        private bool _promemoria;
        private bool _avvisi;
        private bool _report;
        //preferenze
        private string _lingua;
        private TimeOnly _inizioGiornata;

        public ImpostazioniClasse(bool promemoria, bool avvisi, bool report, string lingua, TimeOnly inizioGiornata)
        {
            _promemoria = promemoria;
            _avvisi = avvisi;
            _report = report;
            _lingua = lingua;
            _inizioGiornata = inizioGiornata;
        }

        public bool Promemoria
        {
            get { return _promemoria; }
            set { _promemoria = value; }
        }

        public bool Avvisi
        {
            get { return _avvisi; }
            set { _avvisi = value; }
        }

        public bool Report
        {
            get { return _report; }
            set { _report = value; }
        }

        public string Lingua
        {
            get { return _lingua; }
            set { _lingua = value; }
        }

        public TimeOnly InizioGiornata
        {
            get { return _inizioGiornata; }
            set { _inizioGiornata = value; }
        }




    }
}
