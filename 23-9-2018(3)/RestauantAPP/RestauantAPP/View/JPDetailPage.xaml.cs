using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class JPDetailPage : ContentPage
    {
        public JPDetailsViewModel ViewModel { get; }
        public JPDetailPage(JP jp)
        {
            InitializeComponent();
            BindingContext = ViewModel = new JPDetailsViewModel();
            ViewModel.SetData(jp);
        }
    }
}
