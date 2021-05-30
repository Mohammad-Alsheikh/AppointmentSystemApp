using AppointmentSystemApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppointmentSystemApp.Views
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