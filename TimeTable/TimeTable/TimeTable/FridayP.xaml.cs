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
    public partial class FridayP : ContentPage
    {
        public FridayP()
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
                fridayEightAmLabel.IsVisible = false;
                fridayNineAmLabel.IsVisible = false;
                fridayTenAmLabel.IsVisible = false;
                fridayElevenAmLabel.IsVisible = false;
                fridayTwelvePmLabel.IsVisible = false;
                fridayOnePmLabel.IsVisible = false;
                fridayTwoPmLabel.IsVisible = false;
                fridayThreePmLabel.IsVisible = false;
                fridayFourPmLabel.IsVisible = false;
                fridayFivePmLabel.IsVisible = false;
                fridaySixPmLabel.IsVisible = false;


                //Making Entries Visible
                fridayEightAmEntry.IsVisible = true;
                fridayNineAmEntry.IsVisible = true;
                fridayTenAmEntry.IsVisible = true;
                fridayElevenAmEntry.IsVisible = true;
                fridayTwelvePmEntry.IsVisible = true;
                fridayOnePmEntry.IsVisible = true;
                fridayTwoPmEntry.IsVisible = true;
                fridayThreePmEntry.IsVisible = true;
                fridayFourPmEntry.IsVisible = true;
                fridayFivePmEntry.IsVisible = true;
                fridaySixPmEntry.IsVisible = true;


                //Changing Button Text to Edit
                btn.Text = "Submit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;
            }
            else
            {
                //Making the Labels Visible
                fridayEightAmLabel.IsVisible = true;
                fridayNineAmLabel.IsVisible = true;
                fridayTenAmLabel.IsVisible = true;
                fridayElevenAmLabel.IsVisible = true;
                fridayTwelvePmLabel.IsVisible = true;
                fridayOnePmLabel.IsVisible = true;
                fridayTwoPmLabel.IsVisible = true;
                fridayThreePmLabel.IsVisible = true;
                fridayFourPmLabel.IsVisible = true;
                fridayFivePmLabel.IsVisible = true;
                fridaySixPmLabel.IsVisible = true;


                //Making Entries Visible
                fridayEightAmEntry.IsVisible = false;
                fridayNineAmEntry.IsVisible = false;
                fridayTenAmEntry.IsVisible = false;
                fridayElevenAmEntry.IsVisible = false;
                fridayTwelvePmEntry.IsVisible = false;
                fridayOnePmEntry.IsVisible = false;
                fridayTwoPmEntry.IsVisible = false;
                fridayThreePmEntry.IsVisible = false;
                fridayFourPmEntry.IsVisible = false;
                fridayFivePmEntry.IsVisible = false;
                fridaySixPmEntry.IsVisible = false;


                //Change the Label Text to the Entry Text
                fridayEightAmLabel.Text = fridayEightAmEntry.Text;
                fridayNineAmLabel.Text = fridayNineAmEntry.Text;
                fridayTenAmLabel.Text = fridayTenAmEntry.Text;
                fridayElevenAmLabel.Text = fridayElevenAmEntry.Text;
                fridayTwelvePmLabel.Text = fridayTwelvePmEntry.Text;
                fridayOnePmLabel.Text = fridayOnePmEntry.Text;
                fridayTwoPmLabel.Text = fridayTwoPmEntry.Text;
                fridayThreePmLabel.Text = fridayThreePmEntry.Text;
                fridayFourPmLabel.Text = fridayFourPmEntry.Text;
                fridayFivePmLabel.Text = fridayFivePmEntry.Text;
                fridaySixPmLabel.Text = fridaySixPmEntry.Text;

                //Changing Button Text to Submit
                btn.Text = "Edit";
                //Incrementing Button Clicks
                submitEditClickedCounter++;

            }
        }
    }
}