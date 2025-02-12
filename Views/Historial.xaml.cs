using HistorialApp.ViewModels;
using Microsoft.Maui.Controls;

namespace HistorialApp.Views
{
    public partial class Historial : ContentPage
    {
        public Historial()
        {
            InitializeComponent();
            BindingContext = new HistorialViewModel();
        }
    }
}