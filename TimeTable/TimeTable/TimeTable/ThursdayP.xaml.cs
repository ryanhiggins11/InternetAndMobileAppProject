using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThursdayP : ContentPage
    {
        public ThursdayP()
        {
            InitializeComponent();
        }

        //Variables
        int submitEditClickedCounter = 0;

        //Submit and Entry Button Clicked Function
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Declaring the Button
            Button btn = (Button)sender;

            //Checking if the Button is in Edit mode, or Submit
            if (submitEditClickedCounter % 2 == 0)
            {
                //Making the Labels Invisible
                thursdayEightAmLabel.IsVisible = false;
                thursdayNineAmLabel.IsVisible = false;
                thursdayTenAmLabel.IsVisible = false;
                thursdayElevenAmLabel.IsVisible = false;
                thursdayTwelvePmLabel.IsVisible = false;
                thursdayOnePmLabel.IsVisible = false;
                thursdayTwoPmLabel.IsVisible = false;
                thursdayThreePmLabel.IsVisible = false;
                thursdayFourPmLabel.IsVisible = false;
                thursdayFivePmLabel.IsVisible = false;
                thursdaySixPmLabel.IsVisible = false;


                //Making Entries Visible
                thursdayEightAmEntry.IsVisible = true;
                thursdayNineAmEntry.IsVisible = true;
                thursdayTenAmEntry.IsVisible = true;
                thursdayElevenAmEntry.IsVisible = true;
                thursdayTwelvePmEntry.IsVisible = true;
                thursdayOnePmEntry.IsVisible = true;
                thursdayTwoPmEntry.IsVisible = true;
                thursdayThreePmEntry.IsVisible = true;
                thursdayFourPmEntry.IsVisible = true;
                thursdayFivePmEntry.IsVisible = true;
                thursdaySixPmEntry.IsVisible = true;


                //Changing Button Text to Edit
                btn.Text = "Submit";

                //Incrementing Button Clicks
                submitEditClickedCounter++;
            }
            else
            {
                //Making the Labels Visible
                thursdayEightAmLabel.IsVisible = true;
                thursdayNineAmLabel.IsVisible = true;
                thursdayTenAmLabel.IsVisible = true;
                thursdayElevenAmLabel.IsVisible = true;
                thursdayTwelvePmLabel.IsVisible = true;
                thursdayOnePmLabel.IsVisible = true;
                thursdayTwoPmLabel.IsVisible = true;
                thursdayThreePmLabel.IsVisible = true;
                thursdayFourPmLabel.IsVisible = true;
                thursdayFivePmLabel.IsVisible = true;
                thursdaySixPmLabel.IsVisible = true;


                //Making Entries Visible
                thursdayEightAmEntry.IsVisible = false;
                thursdayNineAmEntry.IsVisible = false;
                thursdayTenAmEntry.IsVisible = false;
                thursdayElevenAmEntry.IsVisible = false;
                thursdayTwelvePmEntry.IsVisible = false;
                thursdayOnePmEntry.IsVisible = false;
                thursdayTwoPmEntry.IsVisible = false;
                thursdayThreePmEntry.IsVisible = false;
                thursdayFourPmEntry.IsVisible = false;
                thursdayFivePmEntry.IsVisible = false;
                thursdaySixPmEntry.IsVisible = false;


                //Change the Label Text to the Entry Text
                thursdayEightAmLabel.Text = thursdayEightAmEntry.Text;
                thursdayNineAmLabel.Text = thursdayNineAmEntry.Text;
                thursdayTenAmLabel.Text = thursdayTenAmEntry.Text;
                thursdayElevenAmLabel.Text = thursdayElevenAmEntry.Text;
                thursdayTwelvePmLabel.Text = thursdayTwelvePmEntry.Text;
                thursdayOnePmLabel.Text = thursdayOnePmEntry.Text;
                thursdayTwoPmLabel.Text = thursdayTwoPmEntry.Text;
                thursdayThreePmLabel.Text = thursdayThreePmEntry.Text;
                thursdayFourPmLabel.Text = thursdayFourPmEntry.Text;
                thursdayFivePmLabel.Text = thursdayFivePmEntry.Text;
                thursdaySixPmLabel.Text = thursdaySixPmEntry.Text;

                //Changing Button Text to Submit
                btn.Text = "Edit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;

            }
        }
    }
}