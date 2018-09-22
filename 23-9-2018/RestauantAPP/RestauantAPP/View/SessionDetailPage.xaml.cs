using System;
using System.Collections.Generic;
using ConferenceSessions.ViewModel;
using RestauantAPP.Model;
using Xamarin.Forms;

namespace RestauantAPP.View
{
    public partial class SessionDetailPage : ContentPage
    {
        public SessionDetailsViewModel ViewModel { get; }
        public SessionDetailPage(Session session)
        {
            InitializeComponent();

            BindingContext = ViewModel = new SessionDetailsViewModel();
            ViewModel.SetData(session);
        }
    }
}
