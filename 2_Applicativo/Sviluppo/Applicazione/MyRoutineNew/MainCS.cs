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
        // ── Variabili statiche (invariate) ──────────────────
        private static string _nome;
        private static string _cognome;
        private static DateTime _dataOra;
        private static string _tema;
        private static bool _task;
        private static Attivita attivita;

        // ── Nuova variabile: data di nascita ────────────────
        private static DateTime _dataNascita;


        //implementazioni future
        //
        //giorno della settimana
        //ora del giorno


        // ── Getter/Setter esistenti (invariati) ─────────────
        public static string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public static string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        public static DateTime DataOra
        {
            get { return _dataOra; }
            set { _dataOra = value; }
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

        // ── Nuovo getter/setter: data di nascita ────────────
        public static DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        // ── Metodi di navigazione (invariati) ───────────────
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

        // ── Nuovi metodi: salva/carica dati utente ──────────

        /// <summary>
        /// Salva nome, cognome e data di nascita nelle Preferences.
        /// Chiama questo metodo al termine dell'onboarding.
        /// </summary>
        public static void SalvaDatiUtente()
        {
            Preferences.Default.Set("nome",          _nome    ?? "");
            Preferences.Default.Set("cognome",        _cognome ?? "");
            Preferences.Default.Set("data_nascita",   _dataNascita.ToString("O"));
            Preferences.Default.Set("setup_ok",       true);
        }

        /// <summary>
        /// Carica nome, cognome e data di nascita dalle Preferences nelle
        /// variabili statiche. Chiama questo all'avvio dell'app se setup_ok == true.
        /// </summary>
        public static void CaricaDatiUtente()
        {
            _nome    = Preferences.Default.Get("nome",    "");
            _cognome = Preferences.Default.Get("cognome", "");

            string dataStr = Preferences.Default.Get("data_nascita", "");
            if (DateTime.TryParse(dataStr, null,
                System.Globalization.DateTimeStyles.RoundtripKind, out var d))
                _dataNascita = d;
        }

        /// <summary>
        /// Restituisce true se l'onboarding è già stato completato.
        /// </summary>
        public static bool SetupCompletato =>
            Preferences.Default.Get("setup_ok", false);

        /// <summary>
        /// Azzera tutti i dati utente e le task (usato in "Riconfigura").
        /// </summary>
        public static void ResetCompleto()
        {
            _nome         = null;
            _cognome      = null;
            _dataNascita  = default;
            Preferences.Default.Remove("nome");
            Preferences.Default.Remove("cognome");
            Preferences.Default.Remove("data_nascita");
            Preferences.Default.Remove("setup_ok");
            TaskManager.EliminaTutte();
        }
    }
}
