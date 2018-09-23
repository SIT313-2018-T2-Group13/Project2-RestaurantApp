using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        async void BtnAus_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new AUListPage());
        async void BtnChi_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new CNListPage());
        async void BtnIta_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new ITListPage());
        async void BtnJap_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new JPListPage());
        async void BtnKor_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new KOListPage());
        async void BtnMex_Onclicked(object sender, EventArgs e) => await Navigation.PushAsync(new MXListPage());

    }
}
