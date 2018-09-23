using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RestauantAPP
{
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
        }
        async void BtnR_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new View.HomePage());
        
        async void BtnN_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new View.JPListPage());
        async void BtnA_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new View.KOListPage());
        async void BtnL_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new OAUthLoginPage());
    }
}
