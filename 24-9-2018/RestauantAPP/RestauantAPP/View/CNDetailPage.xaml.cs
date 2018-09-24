using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class CNDetailPage : ContentPage
    {
        public CNDetailsViewModel ViewModel { get; }
        public CNDetailPage(CN cn)
        {
            InitializeComponent();
            BindingContext = ViewModel = new CNDetailsViewModel();
            ViewModel.SetData(cn);
        }
    }
}
