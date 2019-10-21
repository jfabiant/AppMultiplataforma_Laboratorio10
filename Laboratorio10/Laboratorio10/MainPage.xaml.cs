using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Laboratorio10.views;

namespace Laboratorio10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnOperaciones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Operaciones());
        }
    }
}
