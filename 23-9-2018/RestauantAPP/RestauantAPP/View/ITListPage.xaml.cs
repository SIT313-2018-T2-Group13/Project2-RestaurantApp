﻿using System;
using System.Collections.Generic;
using RestauantAPP.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestauantAPP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ITListPage : ContentPage
    {
        public ITListPage()
        {
            InitializeComponent();
            BindingContext = new ITListViewModel(Navigation);
        }
    }
}
