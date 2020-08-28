using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Z13_DI
{
    public class RectangleGenerator : IControlGenerator
    {
        public FrameworkElement Generate()
        {
            return new Rectangle
            {
                Width = 200,
                Height = 20,
                Fill = new SolidColorBrush(Colors.Violet),
                Margin = new Thickness(0, 5, 0, 5)
            };
        }
    }
}
