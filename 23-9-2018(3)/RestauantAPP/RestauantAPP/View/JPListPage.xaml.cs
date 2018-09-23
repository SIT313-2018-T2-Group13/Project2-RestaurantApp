using System;
using System.Collections.Generic;
using RestauantAPP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestauantAPP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JPListPage : ContentPage
    {
        public JPListPage()
        {
            InitializeComponent();
            BindingContext = new JPListViewModel(Navigation);
        }
    }
}
