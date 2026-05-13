namespace MyRoutineNew;

public partial class Statistiche : ContentPage
{
    // ── CODICE DEL COMPAGNO (invariato) ────────────────────
    // (nessun metodo esistente da preservare)
    // ───────────────────────────────────────────────────────

    public Statistiche()
    {
        InitializeComponent();

        // Mese corrente nell'header
        LabelStatsMese.Text = DateTime.Now.ToString("MMMM yyyy",
            new System.Globalization.CultureInfo("it-IT"));

        // Valori di esempio – sostituire con calcoli reali sulla lista Attivita
        // quando il compagno avrà implementato il repository dati
        AggiornaStat(taskMese: MainCS.AttivitaMeseCompletate, deltaMese: MainCS.DeltaMese(),
                     streak: MainCS.Streak, recordStreak: MainCS.RecordStreak,
                     completamentoPct: MainCS.CompletamentoPct(), deltaComp: MainCS.DeltaCompletamento(),
                     badgeGuadagnati: MainCS.BadgeGuadagnati(), badgeMancanti: MainCS.BadgeMancanti());
    }

    // Aggiorna tutti i label delle statistiche in un colpo solo.
    // Chiamare di nuovo questo metodo ogni volta che i dati cambiano.
    private void AggiornaStat(int taskMese, int deltaMese,
                               int streak, int recordStreak,
                               int completamentoPct, int deltaComp,
                               int badgeGuadagnati, int badgeMancanti)
    {
        LabelTaskMese.Text = taskMese.ToString();
        LabelTaskMeseDelta.Text = $"{(deltaMese >= 0 ? "↑ +" : "↓ ")}{deltaMese} vs scorso mese";
        LabelTaskMeseDelta.TextColor = deltaMese >= 0
            ? Color.FromArgb("#10B981")
            : Color.FromArgb("#F43F5E");

        LabelStreak.Text = $"{streak}🔥";
        LabelStreakRecord.Text = $"Record: {recordStreak} giorni";

        LabelCompletamento.Text = $"{completamentoPct}%";
        LabelCompletamentoDelta.Text = $"{(deltaComp >= 0 ? "↑ +" : "↓ ")}{deltaComp}% vs scorso mese";
        LabelCompletamentoDelta.TextColor = deltaComp >= 0
            ? Color.FromArgb("#10B981")
            : Color.FromArgb("#F43F5E");

        LabelBadgeCount.Text = badgeGuadagnati.ToString();
        LabelBadgeMancanti.Text = $"{badgeMancanti} ancora da sbloccare";
    }
}