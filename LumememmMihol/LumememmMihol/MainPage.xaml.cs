using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LumememmMihol
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        readonly Random random1;
        public MainPage()
        {
            
        }
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            stext.Text = "Standart colors";
            small.BackgroundColor = Color.White;
            big.BackgroundColor = Color.White;
            under.BackgroundColor = Color.Gray;
        }
        private void Btn_Clicked(object sender, EventArgs e)
        {
            stext.Text = "The stand is randomly painted";
            Color randomColor1 = Color.FromRgb(random1.Next(256), random1.Next(256), random1.Next(256));
            under.BackgroundColor = randomColor1;
        }

        private void Inv_Clicked(object sender, EventArgs e)
        {
            stext.Text = "Snowman is invisble";
            small.Opacity = 0;
            small.BorderColor = Color.White;
            big.Opacity = 0;
            big.BorderColor = Color.White;
        }

        private void Vis_Clicked(object sender, EventArgs e)
        {
            stext.Text = "Snowman is visible";
            small.Opacity = 1;
            small.BorderColor = Color.Gray;
            big.Opacity = 1;
            big.BorderColor = Color.Gray;
        }

        private void Ran_Clicked(object sender, EventArgs e)
        {
            stext.Text = "The snowman is randomly painted";
            Color randomColor2 = Color.FromRgb(random1.Next(256), random1.Next(256), random1.Next(256));
            Color randomColor3 = Color.FromRgb(random1.Next(256), random1.Next(256), random1.Next(256));
            small.BackgroundColor = randomColor2;
            big.BackgroundColor = randomColor3;
        }
    }
}