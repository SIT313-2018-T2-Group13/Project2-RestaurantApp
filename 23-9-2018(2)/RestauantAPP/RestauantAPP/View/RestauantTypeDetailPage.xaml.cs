using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class RestauantTypeDetailPage : ContentPage
    {
        public RestauantTypeDetailsViewModel ViewModel { get; }
        public RestauantTypeDetailPage(RestauantType restauantType)
        {
            InitializeComponent();
            BindingContext = ViewModel = new RestauantTypeDetailsViewModel();
            ViewModel.SetData(restauantType);
        }
    }
}
