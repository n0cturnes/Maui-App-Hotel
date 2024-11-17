using Agendas_13_14_DSII.Models;

namespace Agendas_13_14_DSII.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;
		pck_suite.ItemsSource = PropriedadesApp.lista_quartos;
		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Hospedagem h = new Hospedagem
			{
				quartoSelecionado = (Quarto)pck_suite.SelectedItem,
				QntAdultos = Convert.ToInt32(stp_adultos.Value),
				QntCriancas = Convert.ToInt32(stp_criancas.Value),
				dataCheckIn = dtpck_checkin.Date,
				dataCheckOut = dtpck_checkout.Date,
			};
			await Navigation.PushAsync(new HospedagemContratada()
			{
				BindingContext = h
			});
		}
		catch (Exception ex)
		{
			await DisplayAlert("ops", ex.Message, "OK");

		}
	}

	private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker elemento = sender as DatePicker;
		DateTime data_selecionada_checkin = elemento.Date;
		dtpck_checkout.MinimumDate = data_selecionada_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = data_selecionada_checkin.Date.AddMonths(6);
	}

    private void btn_sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");

        }
    }
}