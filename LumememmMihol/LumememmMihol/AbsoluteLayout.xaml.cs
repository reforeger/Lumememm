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
    public partial class AbsoluteLayout : ContentPage
    {
        {
            
            int x = 10; // позиция координаты X на странице
            int y = 10; // позиция координаты Y на странице
            Point point = new Point(x, y);
            int width = 100; // ширина блока элемента
            int height = 80;    // высота блока элемента
            Rectangle rect = new Rectangle(x, y, width, height);
            public MainPage()
            {
                AbsoluteLayout absoluteLayout = new AbsoluteLayout();

                BoxView boxView = new BoxView { Color = Color.LightBlue };
                Label headerLbl = new Label { Text = "Xamarin Forms", FontSize = 20 };
                Label contentLbl = new Label { Text = "Welcome to Xamarin World!", FontSize = 16 };

                // определяем позицию и размеры для BoxView
                AbsoluteLayout.SetLayoutBounds(boxView, new Rectangle(70, 70, 200, 70));
                // определяем позицию и размеры для первой метки
                AbsoluteLayout.SetLayoutBounds(headerLbl, new Rectangle(110, 90, 150, 60));
                // определяем позицию и размеры для второй метки
                AbsoluteLayout.SetLayoutBounds(contentLbl, new Rectangle(70, 150, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Content = absoluteLayout;
            }
        }

        private static void SetLayoutBounds(BoxView boxView, Rectangle rectangle)
        {
            throw new NotImplementedException();
        }
        {
            public MainPage()
            {
                AbsoluteLayout absoluteLayout = new AbsoluteLayout();
                absoluteLayout.Children.Add(
                    new BoxView { Color = Color.LightBlue },
                    new Rectangle(70, 70, 200, 70)
                );
                absoluteLayout.Children.Add(
                    new Label { Text = "Xamarin Forms", FontSize = 20 },
                    new Rectangle(110, 90, 150, 60)
                );
                absoluteLayout.Children.Add(
                    new Label { Text = "Welcome to Xamarin World!", FontSize = 16 },
                    new Point(70, 150)
                );
                Content = absoluteLayout;
            }
        }
    }
}