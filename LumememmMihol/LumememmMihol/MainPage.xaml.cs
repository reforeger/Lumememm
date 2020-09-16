using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LumememmMihol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button_Click(object sender, EventArgs e)
        {
            int numb = 0;
            
        }
        private void backgroundcolor1(object sender, EventArgs e)
        {
            if (btn.Clicked == BackgroundColor)
            {
                large1.BackgroundColor.SetFilter();
            }


        }
    }
        
}
