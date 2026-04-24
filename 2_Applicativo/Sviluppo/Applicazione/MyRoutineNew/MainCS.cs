using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoutineNew
{
    public class MainCS
    {
        private static string _nome;
        private static string _cognome;
        private static DateTime _dataOra;
        private static string _tema;
        private static bool _task;


        //implementazioni future
        //
        //giorno della settimana
        //ora del giorno




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


        private static async void PerImpostazioni()
        {
            await Navigation.PushAsync(new Impostazioni());
        }
        private async void PerProfilo()
        {
            await Navigation.PushAsync(new Profilo());
        }
        private async void PerRoutine()
        {
            await Navigation.PushAsync(new Routine());
        }
        private async void PerStatistiche()
        {
            await Navigation.PushAsync(new Statistiche());
        }


    }        
        
}
