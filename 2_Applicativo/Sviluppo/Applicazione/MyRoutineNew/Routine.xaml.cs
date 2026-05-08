using MyRoutineNew.Models;

namespace MyRoutineNew;

public partial class Routine : ContentPage
{
    // ── CODICE DEL COMPAGNO (invariato) ────────────────────
    // (nessun metodo esistente da preservare)
    // ───────────────────────────────────────────────────────

    public Routine()
    {
        InitializeComponent();

        // Mese corrente nell'header
        LabelMeseCorrente.Text = DateTime.Now.ToString("MMMM yyyy",
            new System.Globalization.CultureInfo("it-IT"));

        // Numero giorno "oggi" nella prima card
        LabelDay1Num.Text = DateTime.Now.Day.ToString();
        LabelDay1Nome.Text = $"{DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("it-IT"))} · Oggi";
    }

    // ── Espansione / chiusura day-card ─────────────────────

    private void OnDay1Tapped(object sender, TappedEventArgs e)
    {
        ToggleGiorno(TasksDay1, null, ChevronDay1);
    }

    private void OnDay2Tapped(object sender, TappedEventArgs e)
    {
        ToggleGiorno(TasksDay2, SepDay2, ChevronDay2);
    }

    private void OnDay3Tapped(object sender, TappedEventArgs e)
    {
        ToggleGiorno(TasksDay3, SepDay3, ChevronDay3);
    }

    // Apre/chiude il pannello task di un giorno e aggiorna il chevron
    private static void ToggleGiorno(View taskPanel, BoxView separatore, Label chevron)
    {
        bool aperto = !taskPanel.IsVisible;
        taskPanel.IsVisible = aperto;
        if (separatore != null)
            separatore.IsVisible = aperto;
        chevron.Text = aperto ? "▾" : "▸";
    }

    // ── Aggiungi task ───────────────────────────────────────

    private async void OnAggiungiTapped(object sender, TappedEventArgs e)
    {
        // Raccoglie i dati base della nuova Attivita tramite prompt nativi.
        // Quando il compagno implementerà la pagina di inserimento,
        // sostituire questo blocco con: await Navigation.PushAsync(new NuovaTask());

        string nome = await DisplayPromptAsync(
            "Nuova Task",
            "Nome dell'attività:",
            accept: "Avanti",
            cancel: "Annulla",
            maxLength: 50);

        if (string.IsNullOrWhiteSpace(nome)) return;

        string descrizione = await DisplayPromptAsync(
            "Nuova Task",
            "Descrizione (opzionale):",
            accept: "Avanti",
            cancel: "Annulla",
            initialValue: "",
            maxLength: 100);

        // Crea e salva nell'Attivita globale (estendere con lista quando pronta)
        var nuova = new Attivita
        {
            Nome = nome,
            Descrizione = descrizione ?? "",
            DateTimeInizio = DateTime.Now,
            DateTimeFine = DateTime.Now.AddMinutes(30),
            Categoria = "Generale"
        };

        // Per ora salva l'ultima attività creata in MainCS
        MainCS.Attivita = nuova;

        await DisplayAlert("Task aggiunta", $"'{nome}' aggiunta con successo.", "OK");
    }
}