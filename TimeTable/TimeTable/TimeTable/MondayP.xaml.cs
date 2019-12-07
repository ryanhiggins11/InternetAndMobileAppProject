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
    public partial class MondayP : ContentPage
    {
        public MondayP()
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
                mondayEightAmLabel.IsVisible = false;
                mondayNineAmLabel.IsVisible = false;
                mondayTenAmLabel.IsVisible = false;
                mondayElevenAmLabel.IsVisible = false;
                mondayTwelvePmLabel.IsVisible = false;
                mondayOnePmLabel.IsVisible = false;
                mondayTwoPmLabel.IsVisible = false;
                mondayThreePmLabel.IsVisible = false;
                mondayFourPmLabel.IsVisible = false;
                mondayFivePmLabel.IsVisible = false;
                mondaySixPmLabel.IsVisible = false;

                //Making Entries Visible
                mondayEightAmEntry.IsVisible = true;
                mondayNineAmEntry.IsVisible = true;
                mondayTenAmEntry.IsVisible = true;
                mondayElevenAmEntry.IsVisible = true;
                mondayTwelvePmEntry.IsVisible = true;
                mondayOnePmEntry.IsVisible = true;
                mondayTwoPmEntry.IsVisible = true;
                mondayThreePmEntry.IsVisible = true;
                mondayFourPmEntry.IsVisible = true;
                mondayFivePmEntry.IsVisible = true;
                mondaySixPmEntry.IsVisible = true;
                //Changing Button Text to Edit
                btn.Text = "Submit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;
            }
            else
            {
                //Making the Labels Visible
                mondayEightAmLabel.IsVisible = true;
                mondayNineAmLabel.IsVisible = true;
                mondayTenAmLabel.IsVisible = true;
                mondayElevenAmLabel.IsVisible = true;
                mondayTwelvePmLabel.IsVisible = true;
                mondayOnePmLabel.IsVisible = true;
                mondayTwoPmLabel.IsVisible = true;
                mondayThreePmLabel.IsVisible = true;
                mondayFourPmLabel.IsVisible = true;
                mondayFivePmLabel.IsVisible = true;
                mondaySixPmLabel.IsVisible = true;

                //Making Entries Visible
                mondayEightAmEntry.IsVisible = false;
                mondayNineAmEntry.IsVisible = false;
                mondayTenAmEntry.IsVisible = false;
                mondayElevenAmEntry.IsVisible = false;
                mondayTwelvePmEntry.IsVisible = false;
                mondayOnePmEntry.IsVisible = false;
                mondayTwoPmEntry.IsVisible = false;
                mondayThreePmEntry.IsVisible = false;
                mondayFourPmEntry.IsVisible = false;
                mondayFivePmEntry.IsVisible = false;
                mondaySixPmEntry.IsVisible = false;

                //Change the Label Text to the Entry Text
                mondayEightAmLabel.Text = mondayEightAmEntry.Text;
                mondayNineAmLabel.Text = mondayNineAmEntry.Text;
                mondayTenAmLabel.Text = mondayTenAmEntry.Text;
                mondayElevenAmLabel.Text = mondayElevenAmEntry.Text;
                mondayTwelvePmLabel.Text = mondayTwelvePmEntry.Text;
                mondayOnePmLabel.Text = mondayOnePmEntry.Text;
                mondayTwoPmLabel.Text = mondayTwoPmEntry.Text;
                mondayThreePmLabel.Text = mondayThreePmEntry.Text;
                mondayFourPmLabel.Text = mondayFourPmEntry.Text;
                mondayFivePmLabel.Text = mondayFivePmEntry.Text;
                mondaySixPmLabel.Text = mondaySixPmEntry.Text;

                //Changing Button Text to Submit
                btn.Text = "Edit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;

            }
        }
    }
}