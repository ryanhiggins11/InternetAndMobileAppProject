using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTable
{

    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void MondayButton_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new MondayP());
        }

        async void TuesdayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TuesdayP());
        }

        async void WednesdayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TuesdayP());
        }

        async void ThursdayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThursdayP());
        }

        async void FridayButton_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new FridayP());
        }
    }
}
