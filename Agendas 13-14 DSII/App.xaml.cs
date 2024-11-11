using Agendas_13_14_DSII.Models;

namespace Agendas_13_14_DSII
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                descricao = "Suíte Super Luxo",
                vDiariaAdulto = 110.0,
                vDiariaCrianca = 55.0
            },
            new Quarto()
            {
                descricao = "Suíte Luxo",
                vDiariaAdulto = 80.0,
                vDiariaCrianca = 40.0
            },
            new Quarto()
            {
                descricao = "Suíte Single",
                vDiariaAdulto = 50.0,
                vDiariaCrianca = 25.0
            },
            new Quarto()
            {
                descricao = "Suíte Crise",
                vDiariaAdulto = 25.0,
                vDiariaCrianca = 12.50
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
