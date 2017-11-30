using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BMI_Button_Click(object sender, EventArgs e)
        {
            Double height = double.Parse(height.Text);


            DisplayAlert("BMI", dHeight+":太りすぎ", "OK");
        }
    }
}
