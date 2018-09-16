using System;
using System.Collections.Generic;
using CFSessionDB.Model;
using CFSessionDB.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CFSessionDB.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestauantList : ContentPage
    {
        public SessionListViewModel ViewModel { get; }

        public RestauantList()
        {
            InitializeComponent();
        }
    }
}
