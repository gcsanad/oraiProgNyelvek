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
using System.IO;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Nyelv> lista = new List<Nyelv>
            {
                new Nyelv("C#",false,2001,Nyelvcsaladok.objektumorientált,false,5),
                new Nyelv("C++",false,1983,Nyelvcsaladok.objektumorientált,false,7),
                new Nyelv("python",false,2001,Nyelvcsaladok.objektumorientált,true,1),
                new Nyelv("rust",false,2015,Nyelvcsaladok.objektumorientált,false,8)

            };
            dgAdatok.ItemsSource = lista;
        }

        private void btRogzites_Click(object sender, RoutedEventArgs e)
        {
            int fordito;
            if (rbFordito.IsChecked == true)
            {
                fordito = 0;
            }
            else
            {
                fordito = 1;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "csv";
            sfd.Filter = "CSV fájl (*.csv) | *.csv";
            sfd.Title = "Adja meg a névsor nevét!";
            int szint;

            if (rbMagas.IsChecked == true)
            {
                szint = 0;
            }
            else
            {
                szint = 1;
            }
            if (sfd.ShowDialog() == true)
            {
                StreamWriter mentes = new(sfd.FileName);
                string szoveg = tbNyelvNeve.Text + ";" + Convert.ToString(fordito) + ";" + Convert.ToString(cbNyelv.SelectedIndex) + ";" + Convert.ToString(szint) + ";" + Convert.ToString(sliNep.Value);
                mentes.WriteLine(szoveg);
            }
        }
    }
}
