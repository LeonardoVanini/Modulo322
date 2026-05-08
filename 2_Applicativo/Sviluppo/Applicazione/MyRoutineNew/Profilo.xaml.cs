using MyRoutine.Models;

namespace MyRoutineNew;

public partial class Profilo : ContentPage
{
    // ── CODICE DEL COMPAGNO (invariato) ────────────────────
    // (nessun metodo esistente da preservare)
    // ───────────────────────────────────────────────────────

    public Profilo()
    {
        InitializeComponent();

        // Nome e cognome da MainCS
        string nome = MainCS.Nome ?? "Utente";
        string cognome = MainCS.Cognome ?? "";
        LabelNomeCognome.Text = $"{nome} {cognome}".Trim();

        // Iniziali avatar
        string ini = "";
        if (!string.IsNullOrEmpty(MainCS.Nome)) ini += MainCS.Nome[0];
        if (!string.IsNullOrEmpty(MainCS.Cognome)) ini += MainCS.Cognome[0];
        LabelAvatarIni.Text = ini.Length > 0 ? ini.ToUpper() : "?";

        // Carica badge nella griglia (dati di esempio)
        // Sostituire con sorgente reale quando disponibile
        BadgeCollection.ItemsSource = GetBadge();
    }

    // Restituisce la lista badge di esempio.
    // Quando il compagno implementerà il salvataggio, sostituire
    // con il caricamento dal repository/servizio dati.
    private List<Badge> GetBadge()
    {
        return new List<Badge>
        {
            new Badge("🏆 Prima settimana",  "Completa 7 giorni di routine", ottenuto: true),
            new Badge("🔥 Streak 7gg",       "7 giorni consecutivi",         ottenuto: true),
            new Badge("💪 Fitness x10",      "10 attività fitness",           ottenuto: true),
            new Badge("📚 Lettore",          "10 sessioni di lettura",        ottenuto: true),
            new Badge("🌅 Mattiniero",       "Completa 5 task prima delle 8", ottenuto: true),
            new Badge("⚡ 50 Task",          "50 task completate in totale",  ottenuto: true),
            new Badge("🎯 Puntuale",         "10 task iniziate in orario",    ottenuto: true),
            new Badge("🌙 Notturno",         "5 task dopo le 22:00",          ottenuto: false),
            new Badge("🧘 Zen 30gg",         "30 giorni di meditazione",      ottenuto: false),
            new Badge("🚀 100 Task",         "100 task completate",           ottenuto: false),
            new Badge("👑 Campione",         "Tutti i badge sbloccati",       ottenuto: false),
            new Badge("🌟 Perfetto",         "100% completamento per 7 giorni", ottenuto: false),
        };
    }
}