using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LumememmMihol
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absolute : ContentPage
    {
        public Absolute()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new Label { Text = "This is a snowman", FontSize = 20 },
                new Rectangle(118, 20, 200, 60)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.LightGray, CornerRadius = 90 },
                new Rectangle(135, 70, 150, 150)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.LightGray, CornerRadius = 120 },
                new Rectangle(100, 200, 220, 220)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Gray },
                new Rectangle(60, 420, 300, 100)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(180, 110, 10, 10)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(230, 110, 10, 10)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Orange, CornerRadius = 90 },
                new Rectangle(202, 140, 15, 15)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(180, 180, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(185, 185, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(190, 188, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(195, 190, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(200, 190, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(205, 190, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(210, 190, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(215, 190, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(220, 190, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(225, 188, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(230, 185, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(235, 180, 5, 5)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(202, 250, 20, 20)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(202, 300, 20, 20)
            );
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.Black, CornerRadius = 90 },
                new Rectangle(202, 350, 20, 20)
            );
            Label lbl = new Label { Text = "Buttons", FontSize = 20 };
            Button btn1 = new Button { Text = "Nothing" };
            btn1.Clicked += Btn1_Clicked;
            AbsoluteLayout.SetLayoutBounds(lbl, new Rectangle(0.0, 0.0, 200, 30));
            AbsoluteLayout.SetLayoutFlags(lbl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.0, 0.05, 100, 60));
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.PositionProportional);
            Content = absoluteLayout;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}