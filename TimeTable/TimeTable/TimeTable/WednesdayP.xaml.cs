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
    public partial class WednesdayP : ContentPage
    {
        public WednesdayP()
        {
            InitializeComponent();
        }

        //Variables
        int submitEditClickedCounter = 0;

        //Submit and Entry Button Clicked Function
        private void SubmitandEditButton_Clicked(object sender, EventArgs e)
        {
            //Declaring the Button
            Button btn = (Button)sender;

            //Checking if the Button is in Edit mode, or Submit
            if (submitEditClickedCounter % 2 == 0)
            {
                //Making the Labels Invisible
                wednesdayEightAmLabel.IsVisible = false;
                wednesdayNineAmLabel.IsVisible = false;
                wednesdayTenAmLabel.IsVisible = false;
                wednesdayElevenAmLabel.IsVisible = false;
                wednesdayTwelvePmLabel.IsVisible = false;
                wednesdayOnePmLabel.IsVisible = false;
                wednesdayTwoPmLabel.IsVisible = false;
                wednesdayThreePmLabel.IsVisible = false;
                wednesdayFourPmLabel.IsVisible = false;
                wednesdayFivePmLabel.IsVisible = false;
                wednesdaySixPmLabel.IsVisible = false;

                //Making Entries Visible
                wednesdayEightAmEntry.IsVisible = true;
                wednesdayNineAmEntry.IsVisible = true;
                wednesdayTenAmEntry.IsVisible = true;
                wednesdayElevenAmEntry.IsVisible = true;
                wednesdayTwelvePmEntry.IsVisible = true;
                wednesdayOnePmEntry.IsVisible = true;
                wednesdayTwoPmEntry.IsVisible = true;
                wednesdayThreePmEntry.IsVisible = true;
                wednesdayFourPmEntry.IsVisible = true;
                wednesdayFivePmEntry.IsVisible = true;
                wednesdaySixPmEntry.IsVisible = true;
                //Changing Button Text to Edit
                btn.Text = "Submit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;
            }
            else
            {
                //Making the Labels Visible
                wednesdayEightAmLabel.IsVisible = true;
                wednesdayNineAmLabel.IsVisible = true;
                wednesdayTenAmLabel.IsVisible = true;
                wednesdayElevenAmLabel.IsVisible = true;
                wednesdayTwelvePmLabel.IsVisible = true;
                wednesdayOnePmLabel.IsVisible = true;
                wednesdayTwoPmLabel.IsVisible = true;
                wednesdayThreePmLabel.IsVisible = true;
                wednesdayFourPmLabel.IsVisible = true;
                wednesdayFivePmLabel.IsVisible = true;
                wednesdaySixPmLabel.IsVisible = true;


                //Making Entries Visible
                wednesdayEightAmEntry.IsVisible = false;
                wednesdayNineAmEntry.IsVisible = false;
                wednesdayTenAmEntry.IsVisible = false;
                wednesdayElevenAmEntry.IsVisible = false;
                wednesdayTwelvePmEntry.IsVisible = false;
                wednesdayOnePmEntry.IsVisible = false;
                wednesdayTwoPmEntry.IsVisible = false;
                wednesdayThreePmEntry.IsVisible = false;
                wednesdayFourPmEntry.IsVisible = false;
                wednesdayFivePmEntry.IsVisible = false;
                wednesdaySixPmEntry.IsVisible = false;

                //Changing Button Text to Submit
                btn.Text = "Edit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;

            }
        }
    }
}