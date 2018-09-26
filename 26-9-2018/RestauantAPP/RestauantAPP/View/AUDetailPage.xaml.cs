using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{

   
    public partial class AUDetailPage : ContentPage
    {
        public AUDetailsViewModel ViewModel { get; }
        public AUDetailPage(AU au)
        {
            InitializeComponent();
            BindingContext = ViewModel = new AUDetailsViewModel();
            ViewModel.SetData(au);
        }
    }
}
