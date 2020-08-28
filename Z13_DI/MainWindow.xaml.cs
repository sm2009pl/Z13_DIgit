using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Z13_DI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IPanelFiller panelFiller { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            this.Hide();
        }
        public MainWindow(IPanelFiller panelFillerOut) : this()
        {
            panelFiller = panelFillerOut;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            panelFiller.Fill(Panel);
        }
    }
}
