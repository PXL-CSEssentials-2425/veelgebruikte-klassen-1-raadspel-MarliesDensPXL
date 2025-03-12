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
        Random rnd = new Random();
        int teRadenGetal;
        int aantalBeurten = 0;

        public MainWindow()
        {
            InitializeComponent();

            teRadenGetal = rnd.Next(1, 101);
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            // te raden getal maken
         
            output2TextBox.Text = teRadenGetal.ToString();

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
            }
            else
            {
                //messagebox
            }
        }
        private void newButton_Click(object sender, RoutedEventArgs e)
        {
       
            teRadenGetal = rnd.Next(1, 101);
            aantalBeurten = 0;
        }
    }
}