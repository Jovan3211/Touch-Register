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

namespace Cash_Register___Purchase
{
    /// <summary>
    /// Interaction logic for language.xaml
    /// </summary>
    public partial class language : UserControl
    {
        public language()
        {
            InitializeComponent();
        }

        private void Button_English_OnMouseDownOrTouchDown(object sender, RoutedEventArgs e)
        {
            hideset("English");
        }

        private void Button_Srpski_OnMouseDownOrTouchDown(object sender, RoutedEventArgs e)
        {
            hideset("Srpski");
        }

        private void Button_Deutsch_OnMouseDownOrTouchDown(object sender, RoutedEventArgs e)
        {
            hideset("Deutsch");
        }

        private void hideset(string lang)
        {
            Public_variables.language = lang;
            this.Visibility = Visibility.Hidden;
        }
    }
}
