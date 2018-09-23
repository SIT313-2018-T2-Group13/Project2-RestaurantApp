using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class MXDetailPage : ContentPage
    {
        public MXDetailsViewModel ViewModel { get; }
        public MXDetailPage(MX mx)
        {
            InitializeComponent();
            BindingContext = ViewModel = new MXDetailsViewModel();
            ViewModel.SetData(mx);
        }
    }
}
