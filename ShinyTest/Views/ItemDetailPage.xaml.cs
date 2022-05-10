using System.ComponentModel;
using Xamarin.Forms;
using ShinyTest.ViewModels;

namespace ShinyTest.Views
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
