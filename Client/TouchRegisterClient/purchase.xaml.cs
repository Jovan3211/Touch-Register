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
    /// Interaction logic for purchase.xaml
    /// </summary>
    public partial class purchase : UserControl
    {
        public purchase()
        {
            InitializeComponent();

            switch (Public_variables.language)
            {
                case "Srpski":
                    label_scanorwrite.Content = "Skenirajte proizvod ili upišite barkod.";
                    textBlock_removeselected.Text = "Da sklonite proizvod, selektujte ga u listi i pritisnite dugme 'Skloni proizvod'.";
                    textBlock1_ifwishcancel.Text = "Ako želite da prekinete kupovinu pritisnite crveno dugme 'Otkaži'.";
                    textBlock1_finishcontinue.Text = "Ako ste završili dodavanje proizvoda, pritisnite zeleno dugme.";
                    break;
                case "Deutsch":

                    break;
            }
        }

        private void Button_Cancel_TouchOrClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
