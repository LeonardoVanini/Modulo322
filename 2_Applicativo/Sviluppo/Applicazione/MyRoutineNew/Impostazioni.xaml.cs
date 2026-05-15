<<<<<<< Updated upstream
=======
﻿
using MyRoutineNew.Models;

>>>>>>> Stashed changes
namespace MyRoutineNew;

public partial class Impostazioni : ContentPage
{
    // ── CODICE DEL COMPAGNO (invariato) ────────────────────
    // (nessun metodo esistente da preservare)
    // ───────────────────────────────────────────────────────
    
    public Impostazioni()
    {
        InitializeComponent();
<<<<<<< Updated upstream
=======

        MainCS.Impostazioni = new ImpostazioniClasse(false,true,false,"Italiano",new TimeOnly(6,5));// esempio, da inserire nella pagina del primo accesso

        SwitchPromemoria.IsToggled = MainCS.Impostazioni.Promemoria;
        SwitchBadge.IsToggled = MainCS.Impostazioni.Avvisi;
        SwitchReport.IsToggled = MainCS.Impostazioni.Report;
        LabelLinguaValore.Text = MainCS.Impostazioni.Lingua;
        LabelInizioGiornata.Text =MainCS.Impostazioni.InizioGiornata.ToString("HH:mm");

        // Carica valori salvati in MainCS (se già impostati) || fatto
        // Lingua e orario inizio giornata non sono ancora in MainCS: || fatto
        // aggiungere le proprietà quando il compagno implementerà il salvataggio 
>>>>>>> Stashed changes
    }

    // ── Switch Notifiche ────────────────────────────────────

    private void OnSwitchPromemoriaToggled(object sender, ToggledEventArgs e)
    {
        // Collegare al sistema di notifiche quando implementato
    }

    private void OnSwitchBadgeToggled(object sender, ToggledEventArgs e) { }

    private void OnSwitchReportToggled(object sender, ToggledEventArgs e) { }

    // ── Preferenze ──────────────────────────────────────────

    private async void OnLinguaTapped(object sender, TappedEventArgs e)
    {
        string scelta = await DisplayActionSheetAsync(
            "Lingua", "Annulla", null,
            "Italiano", "English", "Español", "Français");

        if (!string.IsNullOrEmpty(scelta) && scelta != "Annulla")
            LabelLinguaValore.Text = scelta;
    }

    private async void OnInizioGiornataTapped(object sender, TappedEventArgs e)
    {
        string ora = await DisplayPromptAsync(
            "Inizio giornata", "Inserisci l'orario (HH:mm):",
            accept: "Salva", cancel: "Annulla",
            initialValue: LabelInizioGiornata.Text,
            keyboard: Keyboard.Numeric, maxLength: 5);

        if (!string.IsNullOrWhiteSpace(ora))
            LabelInizioGiornata.Text = ora;
    }

    // ── Riconfigura dati (NUOVO) ────────────────────────────

<<<<<<< Updated upstream
    private async void OnRiconfiguraTapped(object sender, TappedEventArgs e)
=======
    private async void OnEsciTapped(object sender, TappedEventArgs e)//più che esci si potrebbe mettere un reset no? perchè esci è legato a un account, reset ale informazioni. solo un cosiglio
>>>>>>> Stashed changes
    {
        bool conferma = await DisplayAlert(
            "Riconfigura i miei dati",
            "Vuoi ripetere la configurazione iniziale?\n" +
            "I tuoi dati personali verranno aggiornati.\n" +
            "Le task salvate verranno eliminate.",
            "Sì, riconfigura",
            "Annulla");

        if (!conferma) return;

        // Reset completo (dati utente + task)
        MainCS.ResetCompleto();

        // Rilancia l'onboarding
        Application.Current.MainPage = new NavigationPage(new Onboarding.OnboardingNome())
        {
            BarBackgroundColor = Color.FromArgb("#FDF7F0"),
            BarTextColor       = Color.FromArgb("#1C1409")
        };
    }

    // ── Esci ────────────────────────────────────────────────

    private async void OnEsciTapped(object sender, TappedEventArgs e)
    {
        bool conferma = await DisplayAlert(
            "Esci", "Sei sicuro di voler uscire?",
            "Sì, esci", "Annulla");

        if (!conferma) return;

        MainCS.Nome    = null;
        MainCS.Cognome = null;
        MainCS.Tema    = null;
        // Nota: i dati rimangono nelle Preferences, l'utente non deve rifare l'onboarding
    }
}
