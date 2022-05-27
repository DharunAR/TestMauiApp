using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.ViewModel
{
    public partial class TestPageViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public TestPageViewModel()
        {
           // this.connectivity = connectivity;
        }


        [ICommand]
        async Task GoTo()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new PushModal());
        }
    }
}
