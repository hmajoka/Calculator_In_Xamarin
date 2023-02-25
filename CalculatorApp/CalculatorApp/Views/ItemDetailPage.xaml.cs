using CalculatorApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CalculatorApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}