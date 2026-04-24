using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ============================================================
// Badge.cs
// Modello OOP per rappresentare un singolo badge.
// Ogni badge ha un nome, una descrizione e uno stato di ottenimento.
// ============================================================

namespace MyRoutine.Models
{
    /// <summary>
    /// Rappresenta un badge ottenibile dall'utente completando determinate azioni.
    /// </summary>
    public class Badge
    {
        // ── Proprietà ──────────────────────────────────────────

        /// <summary>Nome univoco del badge (es. "Prima Routine").</summary>
        public string Nome { get; set; }

        /// <summary>Descrizione del badge: spiega come si ottiene.</summary>
        public string Descrizione { get; set; }

        /// <summary>
        /// Indica se il badge è stato ottenuto dall'utente.
        /// false = non ancora guadagnato | true = già guadagnato.
        /// </summary>
        public bool Ottenuto { get; set; }

        // ── Costruttori ────────────────────────────────────────

        /// <summary>
        /// Costruttore completo: crea un badge con tutti i dati.
        /// Di default Ottenuto è false (il badge non è ancora stato guadagnato).
        /// </summary>
        /// <param name="nome">Nome del badge.</param>
        /// <param name="descrizione">Descrizione del badge.</param>
        /// <param name="ottenuto">Stato iniziale (opzionale, default: false).</param>
        public Badge(string nome, string descrizione, bool ottenuto = false)
        {
            Nome = nome;
            Descrizione = descrizione;
            Ottenuto = ottenuto;
        }

        // ── Metodi ─────────────────────────────────────────────

        /// <summary>
        /// Segna il badge come ottenuto.
        /// Chiamare questo metodo quando la condizione del badge viene soddisfatta.
        /// </summary>
        public void Guadagna()
        {
            Ottenuto = true;
        }

        /// <summary>
        /// Reimposta il badge allo stato non ottenuto (utile per reset profilo).
        /// </summary>
        public void Reimposta()
        {
            Ottenuto = false;
        }

        /// <summary>
        /// Restituisce una stringa leggibile per debug e log.
        /// Esempio: "[✓] Prima Routine - Completa la tua prima routine"
        /// </summary>
        public override string ToString()
        {
            string stato = Ottenuto ? "[✓]" : "[ ]";
            return $"{stato} {Nome} - {Descrizione}";
        }
    }
}