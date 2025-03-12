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
       
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            // te raden getal maken
            Random rnd = new Random();
            int teRadenGetal = rnd.Next(1, 101);
            output2TextBox.Text = teRadenGetal.ToString();

            // controleren of getal geraden wordt
            int.TryParse(numberTextBox.Text, out int getal);

            while (getal != teRadenGetal)
            {
                if (getal < teRadenGetal)
                {
                    output1TextBox.Text = "Raad hoger!";
                }
                else if (getal > teRadenGetal)
                {
                    output1TextBox.Text = "Raad lager!";
                }
            }


            if (getal == teRadenGetal)
            {
                output1TextBox.Text = "Proficiat! U hebt het getal geraden!";
            }
        }
        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            // te raden getal maken
            Random rnd = new Random();
            int teRadenGetal = rnd.Next(1, 101);
        }
    }
}