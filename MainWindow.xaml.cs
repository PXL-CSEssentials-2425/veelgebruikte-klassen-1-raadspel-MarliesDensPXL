using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;

namespace Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd;
        int teRadenGetal;
        int aantalBeurten;

        public MainWindow()
        {
            InitializeComponent();

            // te raden getal maken
            rnd = new Random();
            teRadenGetal = rnd.Next(1, 101);
            aantalBeurten = 0;
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            bool isGuessed = false;
            while (!isGuessed)
            {
                string invoer = Microsoft.VisualBasic.Interaction.InputBox("Geef een getal tussen 0 en 100", "Raadspel");

                // controleren of getal geraden wordt
                if (int.TryParse(invoer, out int getal))
                {
                    aantalBeurten++;
                    if (getal < teRadenGetal)
                    {
                        MessageBox.Show("Raad hoger!", "Raadspel");

                    }
                    else if (getal > teRadenGetal)
                    {
                        MessageBox.Show("Raad lager!", "Raadspel");
                    }
                    else if (getal == teRadenGetal)
                    {
                        MessageBox.Show($"Proficiat! U hebt het getal geraden in {aantalBeurten.ToString()} beurten!", "Raadspel");
                        isGuessed = true;
                    }

                }
                else
                {
                    //messagebox
                    MessageBox.Show("Geef een geheel getal in!", "waarschuwing");

                }
            }
        }
      

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Ben je zeker dat je wil afsluiten?", "Bevestiging", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
            
        }
    }
}