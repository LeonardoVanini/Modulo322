<<<<<<< HEAD
<<<<<<< HEAD
=======
﻿using MyRoutine.Models;
>>>>>>> 36e872494541a598e1772546e2aa5a57ace06bd3
using MyRoutineNew.Models;
=======
﻿using MyRoutineNew.Models;
>>>>>>> parent of e588e68 (banana hihihihi)
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
<<<<<<< HEAD
<<<<<<< HEAD
        private static Attivita attivita;

        // ── Nuova variabile: data di nascita ────────────────
        private static DateTime _dataNascita;
=======
        private static Attivita _attivita;
        private static List<Attivita> _attivitaInsieme = new List<Attivita>();
        private static int _attivitaOggi;
        private static int _attivitaOggiCompletate;
>>>>>>> 36e872494541a598e1772546e2aa5a57ace06bd3
=======
        private static Attivita _attivita;
        private static int _attivitaOggi;
        private static int _attivitaOggiCompletate;
>>>>>>> parent of e588e68 (banana hihihihi)

        private static List<Badge> _badgeInsieme = new List<Badge>();

        private static int _attivitaMese;        
        private static int _attivitaMeseCompletate;
        private static int _attivitaMesePrecedente;
        private static int _attivitaMeseCompletatePrecedente;     

        private static int _streak;//almeno un attivita al giorno
        private static int _recordStreak;        
        
        private static int _badgeGuadagnati;
        private static int _badgeMancanti;

        
        

        //implementazioni future
        //
        //giorno della settimana
        //ora del giorno

        //metodi per insieme attività
        public static void AddAttivita(Attivita newAttivita)
        {
            _attivitaInsieme.Add(newAttivita);
        }

<<<<<<< HEAD
<<<<<<< HEAD
        // ── Getter/Setter esistenti (invariati) ─────────────
=======
        public static void RemoveAttivita(Attivita newAttivita)
        {
            _attivitaInsieme.Remove(newAttivita);
        }

        public static void UpdateAttivita(Attivita newAttivita)
        {
            _attivitaInsieme.Find(currentAttivita => currentAttivita.DateTimeInizio == newAttivita.DateTimeInizio);            
        }

        public static List<Attivita> GetAllAttivita()
        {
            return _attivitaInsieme;
        }

        public static Attivita GetAttivita(int index)
        {
            return _attivitaInsieme.ElementAt(index);
        }
        //metodi per insieme badge
        public static void AddBadge(Badge newBadge)
        {
            _badgeInsieme.Add(newBadge);
        }

        public static void RemoveBadge(Badge newBadge)
        {
            _badgeInsieme.Remove(newBadge);
        }

        public static void UpdateBadge(Badge newBadge)
        {
            _badgeInsieme.Find(currentBadge => currentBadge.Nome == newBadge.Nome);
        }

        public static List<Badge> GetAllBadge()
        {
            return _badgeInsieme;
        }

        public static Badge GetBadge(int index)
        {
            return _badgeInsieme.ElementAt(index);
        }
        //metodi per badge counter
        public static int BadgeGuadagnati()
        {
            int count = 0;
            foreach (Badge currentBadge in _badgeInsieme)
            {
                if (currentBadge.Ottenuto)
                {
                    count++;
                }
            }
            return count;
        }

        public static int BadgeMancanti()
        {
            return _badgeInsieme.Count - BadgeGuadagnati();
        }
        //metodi per statistiche
        public static int DeltaMese()
        {
            return _attivitaMeseCompletate - _attivitaMeseCompletatePrecedente;
        }

        public static int CompletamentoPct()
        {
            return (_attivitaMeseCompletate / _attivitaMese) * 100;
        }
        public static int DeltaCompletamento()
        {
            return CompletamentoPct() - (_attivitaMeseCompletatePrecedente / _attivitaMesePrecedente) * 100;
        }

        //metodi getter/setter
>>>>>>> 36e872494541a598e1772546e2aa5a57ace06bd3
=======

        //metodi getter/setter
>>>>>>> parent of e588e68 (banana hihihihi)
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
            get { return _attivita; }
            set { _attivita = value; }
        }
<<<<<<< HEAD

<<<<<<< HEAD
        // ── Nuovo getter/setter: data di nascita ────────────
        public static DateTime DataNascita
=======
        public static int AttivitaOggi
>>>>>>> 36e872494541a598e1772546e2aa5a57ace06bd3
=======
        public static int AttivitaOggi
>>>>>>> parent of e588e68 (banana hihihihi)
        {
            get { return _attivitaOggi; }
            set { _attivitaOggi = value; }
        }
        public static int AttivitaOggiCompletate
        {
            get { return _attivitaOggiCompletate; }
            set { _attivitaOggiCompletate = value; }
        }
        public static int AttivitaMese
        {
            get { return _attivitaMese; }
            set { _attivitaMese = value; }
        }
        public static int AttivitaMesePrecedente
        {
            get { return _attivitaMesePrecedente; }
            set { _attivitaMesePrecedente = value; }
        }
        public static int AttivitaMeseCompletate
        {
            get { return _attivitaMeseCompletate; }
            set { _attivitaMeseCompletate = value; }
        }
        public static int AttivitaMeseCompletatePrecedente
        {
            get { return _attivitaMeseCompletatePrecedente; }
            set { _attivitaMeseCompletatePrecedente = value; }
        }
        public static int Streak
        {
            get { return _streak; }
            set { _streak = value; }
        }
        public static int RecordStreak
        {
            get { return _recordStreak; }
            set { _recordStreak = value; }
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
