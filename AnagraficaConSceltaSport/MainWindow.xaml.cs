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

namespace AnagraficaConSceltaSport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rdbCalcio.IsEnabled = false;
            rdbNuoto.IsEnabled = false;
            rdbPallavolo.IsEnabled = false;

            rdbJuventus.IsEnabled = false;
            rdbInter.IsEnabled = false;
            rdbAtalanta.IsEnabled = false;
            rdbMilan.IsEnabled = false;

            rdbIvan.IsEnabled = false;
            rdbLuca.IsEnabled = false;
            rdbSamuele.IsEnabled = false;
            rdbFilippo.IsEnabled = false;

            rdbMatt.IsEnabled = false;
            rdbPhepls.IsEnabled = false;
            rdbSun.IsEnabled = false;
            rdbAlain.IsEnabled = false;

           
        }

        private void btnContinua1_Click(object sender, RoutedEventArgs e)
        {

            if (txtNome.Text != "" && txtCognome.Text != "" && txtEtà.Text != "")
            {
                try
                {
                    int età = int.Parse(txtEtà.Text);
                    if (età < 20)
                    {
                        MessageBox.Show("Inserire un'età superiore di 20 anni ", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        rdbCalcio.IsEnabled = true;                        
                        rdbPallavolo.IsEnabled = true;
                        rdbNuoto.IsEnabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Inserire tutti i dati", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnContinua2_Click(object sender, RoutedEventArgs e)
        {
            if (rdbCalcio.IsChecked == true)
            {
                rdbJuventus.IsEnabled = true;
                rdbInter.IsEnabled = true;
                rdbAtalanta.IsEnabled = true;
                rdbMilan.IsEnabled = true;
            }         
            if (rdbPallavolo.IsChecked == true)
            {
                rdbIvan.IsEnabled = true;
                rdbLuca.IsEnabled = true;
                rdbSamuele.IsEnabled = true;
                rdbFilippo.IsEnabled = true;
            }
            if (rdbNuoto.IsChecked == true)
            {
                rdbMatt.IsEnabled = true;
                rdbPhepls.IsEnabled = true;
                rdbSun.IsEnabled = true;
                rdbAlain.IsEnabled = true;
            }
        }
    }
}
