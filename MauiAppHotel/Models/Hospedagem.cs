namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QtdeAdultos { get; set; }
        public int QtdeCriancas { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }

        public int TotalDiarias => (int)(DataCheckout - DataCheckin).TotalDays;

        public double ValorTotal =>
            (QtdeAdultos * QuartoSelecionado.ValorDiariaAdulto +
             QtdeCriancas * QuartoSelecionado.ValorDiariaCrianca) * TotalDiarias;
    }
}
