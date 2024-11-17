namespace Agendas_13_14_DSII.Models
{
    public class Hospedagem
    {
        public required Quarto quartoSelecionado { get; set; }
        public required int QntAdultos { get; set; }
        public required int QntCriancas{ get; set; }
        public required DateTime dataCheckIn { get; set; }
        public required DateTime dataCheckOut { get; set; }
        public int estadia
        {
            get => dataCheckOut.Subtract(dataCheckIn).Days;
        }
        public double valorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * quartoSelecionado.vDiariaAdulto;
                double valor_criancas = QntCriancas * quartoSelecionado.vDiariaCrianca;
                return (valor_adultos+valor_criancas)*estadia;
            }
        }
    }
}
