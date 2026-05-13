namespace MyRoutineNew
{
    public partial class MainPage : ContentPage
    {
        // ── CODICE DEL COMPAGNO (invariato) ────────────────────
        int count = 0;

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            // CounterBtn rimosso dal nuovo XAML, metodo mantenuto per compatibilità
        }

        private void test1(object sender, EventArgs e)
        {
            MainCS.PerImpostazioni(Navigation);
        }
        private void test2(object sender, EventArgs e)
        {
            MainCS.PerProfilo(Navigation);
        }
        private void test3(object sender, EventArgs e)
        {
            MainCS.PerRoutine(Navigation);
        }
        private void test4(object sender, EventArgs e)
        {
            MainCS.PerStatistiche(Navigation);
        }
        // ───────────────────────────────────────────────────────

        public MainPage()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
=======

            // Saluto con nome da MainCS (se già impostato)
            string nome = MainCS.Nome ?? "Utente";
            string cognome = MainCS.Cognome ?? "";
            LabelBenvenuto.Text = $"{nome} {cognome}".Trim();

            // Iniziali avatar (max 2 caratteri)
            string ini = "";
            if (!string.IsNullOrEmpty(MainCS.Nome)) ini += MainCS.Nome[0];
            if (!string.IsNullOrEmpty(MainCS.Cognome)) ini += MainCS.Cognome[0];
            LabelAvatarIni.Text = ini.Length > 0 ? ini.ToUpper() : "U?";

            // Progresso giornaliero – da aggiornare quando avremo la lista task
            // Per ora valori di esempio; sostituire con conteggio reale
            int completate = MainCS.AttivitaOggiCompletate;
            int totali = MainCS.AttivitaOggi;
            ProgressOggi.Progress = totali > 0 ? (double)completate / totali : 0;
            LabelProgressTesto.Text = $"{completate} / {totali}";

            // Task di esempio – da sostituire con dati reali da lista Attivita
            // quando il compagno avrà implementato la collezione
            AggiornaTasks();
>>>>>>> 36e872494541a598e1772546e2aa5a57ace06bd3
        }
=======
>>>>>>> parent of e588e68 (banana hihihihi)

            // Saluto con nome da MainCS (se già impostato)
            string nome = MainCS.Nome ?? "Utente";
            string cognome = MainCS.Cognome ?? "";
            LabelBenvenuto.Text = $"{nome} {cognome}".Trim();

            // Iniziali avatar (max 2 caratteri)
            string ini = "";
            if (!string.IsNullOrEmpty(MainCS.Nome)) ini += MainCS.Nome[0];
            if (!string.IsNullOrEmpty(MainCS.Cognome)) ini += MainCS.Cognome[0];
            LabelAvatarIni.Text = ini.Length > 0 ? ini.ToUpper() : "U?";

            // Progresso giornaliero – da aggiornare quando avremo la lista task
            // Per ora valori di esempio; sostituire con conteggio reale
            int completate = 2;
            int totali = 5;
            ProgressOggi.Progress = totali > 0 ? (double)completate / totali : 0;
            LabelProgressTesto.Text = $"{completate} / {totali}";

            // Task di esempio – da sostituire con dati reali da lista Attivita
            // quando il compagno avrà implementato la collezione
            AggiornaTasks();
        }

        // Tap sull'avatar → apre il Profilo (riusa la logica del compagno)
        private void OnAvatarTapped(object sender, TappedEventArgs e)
        {
            MainCS.PerProfilo(Navigation);
        }

        // Popola le 3 card task con l'attività corrente da MainCS.Attivita
        // Se l'attività non è ancora impostata mostra i valori di default
        private void AggiornaTasks()
        {
            if (MainCS.Attivita == null) return;

            var a = MainCS.Attivita;
            LabelTask2Nome.Text = a.Nome ?? "—";
            LabelTask2Cat.Text = a.Categoria ?? "";
            LabelTask2Ora.Text = a.DateTimeInizio.ToString("HH:mm");
            LabelTask2OraFine.Text = $"– {a.DateTimeFine.ToString("HH:mm")}";
        }
    }
}