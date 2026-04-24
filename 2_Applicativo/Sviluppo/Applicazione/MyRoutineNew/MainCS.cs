using MyRoutineNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutineNew
{
    public class MainCS
    {
        //variabili statiche
        private static string _nome;
        private static string _cognome;
        private static DateTime _dataOra;
        private static string _tema;
        private static bool _task;
        private static Attivita attivita;


        //implementazioni future
        //
        //giorno della settimana
        //ora del giorno



        //metodi getter/setter
        public static string Nome
        {
            get{ return _nome; }
            set{ _nome = value;}
        }
        public static string Cognome
        {
            get { return _cognome; }
            set{ _cognome = value; }
        }
        public static DateTime DataOra
        {
            get { return _dataOra; }
            set { _dataOra = value;}
        }
        public static string Tema
        {
            get { return _tema; }
            set { _tema = value; }
        }
        public static bool Task
        { 
            get { return _task; }
            set { _task = value; }
        }
        public static Attivita Attivita
        {
            get { return attivita; }
            set { attivita = value; }
        }

        //metodi di navigazione
        public static async void PerImpostazioni(INavigation navigation)
        {
            await navigation.PushAsync(new Impostazioni());
        }
        public static async void PerProfilo(INavigation navigation)
        {
            await navigation.PushAsync(new Profilo());
        }
        public static async void PerRoutine(INavigation navigation)
        {
            await navigation.PushAsync(new Routine());
        }
        public static async void PerStatistiche(INavigation navigation)
        {
            await navigation.PushAsync(new Statistiche());
        }


    }        
        
}
