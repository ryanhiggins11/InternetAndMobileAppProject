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
    public partial class TuesdayP : ContentPage
    {
        public TuesdayP()
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
                tuesdayEightAmLabel.IsVisible = false;
                tuesdayNineAmLabel.IsVisible = false;
                tuesdayTenAmLabel.IsVisible = false;
                tuesdayElevenAmLabel.IsVisible = false;
                tuesdayTwelvePmLabel.IsVisible = false;
                tuesdayOnePmLabel.IsVisible = false;
                tuesdayTwoPmLabel.IsVisible = false;
                tuesdayThreePmLabel.IsVisible = false;
                tuesdayFourPmLabel.IsVisible = false;
                tuesdayFivePmLabel.IsVisible = false;
                tuesdaySixPmLabel.IsVisible = false;

                //Making Entries Visible
                tuesdayEightAmEntry.IsVisible = true;
                tuesdayNineAmEntry.IsVisible = true;
                tuesdayTenAmEntry.IsVisible = true;
                tuesdayElevenAmEntry.IsVisible = true;
                tuesdayTwelvePmEntry.IsVisible = true;
                tuesdayOnePmEntry.IsVisible = true;
                tuesdayTwoPmEntry.IsVisible = true;
                tuesdayThreePmEntry.IsVisible = true;
                tuesdayFourPmEntry.IsVisible = true;
                tuesdayFivePmEntry.IsVisible = true;
                tuesdaySixPmEntry.IsVisible = true;
                //Changing Button Text to Edit
                btn.Text = "Submit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;
            }
            else
            {
                //Making the Labels Visible
                tuesdayEightAmLabel.IsVisible = true;
                tuesdayNineAmLabel.IsVisible = true;
                tuesdayTenAmLabel.IsVisible = true;
                tuesdayElevenAmLabel.IsVisible = true;
                tuesdayTwelvePmLabel.IsVisible = true;
                tuesdayOnePmLabel.IsVisible = true;
                tuesdayTwoPmLabel.IsVisible = true;
                tuesdayThreePmLabel.IsVisible = true;
                tuesdayFourPmLabel.IsVisible = true;
                tuesdayFivePmLabel.IsVisible = true;
                tuesdaySixPmLabel.IsVisible = true;

                //Making Entries Visible
                tuesdayEightAmEntry.IsVisible = false;
                tuesdayNineAmEntry.IsVisible = false;
                tuesdayTenAmEntry.IsVisible = false;
                tuesdayElevenAmEntry.IsVisible = false;
                tuesdayTwelvePmEntry.IsVisible = false;
                tuesdayOnePmEntry.IsVisible = false;
                tuesdayTwoPmEntry.IsVisible = false;
                tuesdayThreePmEntry.IsVisible = false;
                tuesdayFourPmEntry.IsVisible = false;
                tuesdayFivePmEntry.IsVisible = false;
                tuesdaySixPmEntry.IsVisible = false;

                //Change the Label Text to the Entry Text
                tuesdayEightAmLabel.Text = tuesdayEightAmEntry.Text;
                tuesdayNineAmLabel.Text = tuesdayNineAmEntry.Text;
                tuesdayTenAmLabel.Text = tuesdayTenAmEntry.Text;
                tuesdayElevenAmLabel.Text = tuesdayElevenAmEntry.Text;
                tuesdayTwelvePmLabel.Text = tuesdayTwelvePmEntry.Text;
                tuesdayOnePmLabel.Text = tuesdayOnePmEntry.Text;
                tuesdayTwoPmLabel.Text = tuesdayTwoPmEntry.Text;
                tuesdayThreePmLabel.Text = tuesdayThreePmEntry.Text;
                tuesdayFourPmLabel.Text = tuesdayFourPmEntry.Text;
                tuesdayFivePmLabel.Text = tuesdayFivePmEntry.Text;
                tuesdaySixPmLabel.Text = tuesdaySixPmEntry.Text;

                //Changing Button Text to Submit
                btn.Text = "Edit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;

            }
        }
    }
}