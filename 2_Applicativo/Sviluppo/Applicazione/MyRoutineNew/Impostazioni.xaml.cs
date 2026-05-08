
namespace MyRoutineNew;

public partial class Impostazioni : ContentPage
{
    // ── CODICE DEL COMPAGNO (invariato) ────────────────────
    // (nessun metodo esistente da preservare)
    // ───────────────────────────────────────────────────────

    public Impostazioni()
    {
        InitializeComponent();

        // Carica valori salvati in MainCS (se già impostati)
        // Lingua e orario inizio giornata non sono ancora in MainCS:
        // aggiungere le proprietà quando il compagno implementerà il salvataggio
    }

    // ── Switch Notifiche ────────────────────────────────────

    private void OnSwitchPromemoriaToggled(object sender, ToggledEventArgs e)
    {
        // e.Value = true → notifiche promemoria attive
        // Da collegare al sistema di notifiche quando implementato
    }

    private void OnSwitchBadgeToggled(object sender, ToggledEventArgs e)
    {
        // e.Value = true → notifiche badge attive
    }

    private void OnSwitchReportToggled(object sender, ToggledEventArgs e)
    {
        // e.Value = true → report domenicale attivo
    }

    // ── Preferenze ──────────────────────────────────────────

    private async void OnLinguaTapped(object sender, TappedEventArgs e)
    {
        string scelta = await DisplayActionSheetAsync(
            "Lingua",
            "Annulla",
            null,
            "Italiano", "English", "Español", "Français");

        if (!string.IsNullOrEmpty(scelta) && scelta != "Annulla")
            LabelLinguaValore.Text = scelta;
    }

    private async Task<string> DisplayActionSheetAsync(string v1, string v2, object value, string v3, string v4, string v5, string v6)
    {
        throw new NotImplementedException();
    }

    private async void OnInizioGiornataTapped(object sender, TappedEventArgs e)
    {
        string ora = await DisplayPromptAsync(
            "Inizio giornata",
            "Inserisci l'orario (HH:mm):",
            accept: "Salva",
            cancel: "Annulla",
            initialValue: LabelInizioGiornata.Text,
            keyboard: Keyboard.Numeric,
            maxLength: 5);

        if (!string.IsNullOrWhiteSpace(ora))
            LabelInizioGiornata.Text = ora;
    }

    // ── Account ─────────────────────────────────────────────

    private async void OnEsciTapped(object sender, TappedEventArgs e)
    {
        bool conferma = await DisplayAlert(
            "Esci",
            "Sei sicuro di voler uscire?",
            "Sì, esci",
            "Annulla");

        if (!conferma) return;

        // Reset dati MainCS
        MainCS.Nome = null;
        MainCS.Cognome = null;
        MainCS.Tema = null;

        // Tornare alla pagina di login quando sarà implementata
        // await Shell.Current.GoToAsync("//Login");
    }
}