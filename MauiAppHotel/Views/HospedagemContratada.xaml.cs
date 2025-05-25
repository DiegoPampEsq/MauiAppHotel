using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(Hospedagem dados)
        {
            InitializeComponent();
            BindingContext = dados;
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
