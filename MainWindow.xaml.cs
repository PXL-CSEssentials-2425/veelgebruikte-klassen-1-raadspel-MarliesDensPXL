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
                          
            // controleren of getal geraden wordt
            if (int.TryParse(numberTextBox.Text, out int getal))
            {
                aantalBeurten++;
                if (getal < teRadenGetal)
                {
                    output1TextBox.Text = "Raad hoger!";
                }
                else if (getal > teRadenGetal)
                {
                    output1TextBox.Text = "Raad lager!";
                } 
                else if (getal == teRadenGetal)
                {
                    output1TextBox.Text = "Proficiat! U hebt het getal geraden!";
                }
                output2TextBox.Text = $"Je hebt {aantalBeurten.ToString()} keer geraden";
            }
            else
            {
                //messagebox
                MessageBox.Show("Geef een geheel getal in!", "waarschuwing");
                numberTextBox.Clear();
            }
        }
        private void newButton_Click(object sender, RoutedEventArgs e)
        {
       
            teRadenGetal = rnd.Next(1, 101);
            aantalBeurten = 0;
            numberTextBox.Clear();
            output1TextBox.Clear();
            output2TextBox.Clear();
            numberTextBox.Focus();
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