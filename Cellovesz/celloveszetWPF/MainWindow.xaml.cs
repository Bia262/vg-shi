using Cellovesz;
using System.IO;
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

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<cellovo> cellovesek = new List<cellovo>();
        public MainWindow()
        {
            InitializeComponent();

            string[] adatok = File.ReadAllLines("lovesek.csv");
            

            foreach (var sor in adatok)
            {
                cellovesek.Add(new cellovo(sor));
            }

            dataGrid.ItemsSource = cellovesek;
        }

        private void Hozzaadas(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(Loves1Box.Text) >= 0 && int.Parse(Loves1Box.Text) <= 99 &&
                int.Parse(Loves2Box.Text) >= 0 && int.Parse(Loves2Box.Text) <= 99 &&
                int.Parse(Loves3Box.Text) >= 0 && int.Parse(Loves3Box.Text) <= 99 &&
                int.Parse(Loves4Box.Text) >= 0 && int.Parse(Loves4Box.Text) <= 99)
                {
                    cellovesek.Add(new cellovo($"{NevBox.Text};{Loves1Box.Text};{Loves2Box.Text};{Loves3Box.Text};{Loves4Box.Text}"));
                    dataGrid.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Nem megfelelő értékek!");
                }
            }
            catch
            {
                MessageBox.Show("Nem megfelelő értékek!");
            }
        }

        private void Mentes(object sender, RoutedEventArgs e)
        {
            try
            {
                string tartalom = "";
                foreach (var item in cellovesek)
                {
                    tartalom += $"{item.Nev};{item.ElsoLoves};{item.MasodikLoves};{item.HarmadikLoves};{item.NegyedikLoves}\n";
                }
                File.WriteAllText("cellovo2.csv", tartalom);
                MessageBox.Show("Sikeres mentés!");
            }
            catch
            {
                MessageBox.Show("Hiba történt a mentés során!");
            }
        }
    }
}