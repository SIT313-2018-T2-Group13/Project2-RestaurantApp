using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class KODetailPage : ContentPage
    {
        public KODetailsViewModel ViewModel { get; }
        public KODetailPage(KO ko)
        {
            InitializeComponent();
            BindingContext = ViewModel = new KODetailsViewModel();
            ViewModel.SetData(ko);
        }
    }
}
