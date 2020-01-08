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

namespace InterfacciaArrayString
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
        string file = "array.txt";
        string[] array = new string[5];
        int i = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string testo = txt_testo.Text;
            array[i] = testo;
            i++;
            txt_testo.Text = "";
            txt_testo.Focus();
            if(i == 5)
            {
                btn_inserisci.IsEnabled = false;
            }
        }
        string testo;
        //
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            for(int c = 0; c < array.Length; c++)
            {
                testo += $"posizione {c} : {array[c]} \n";
            }
            lblRis.Content = testo;
        }
        //
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(lblRis.Content);
            }
            
        }

    }
}
