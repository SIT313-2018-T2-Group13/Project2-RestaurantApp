using System;
using System.Collections.Generic;
using RestauantAPP.Model;
using RestauantAPP.ViewModel;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class ITDetailPage : ContentPage
    {
        public ITDetailsViewModel ViewModel { get; }
        public ITDetailPage(IT it)
        {
            InitializeComponent();
            BindingContext = ViewModel = new ITDetailsViewModel();
            ViewModel.SetData(it);
        }
    }
}
