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
using System;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            int randomNumber = random.Next(1, 101); // Генерация случайного числа от 1 до 100
            RandomNumberTextBox.Text = randomNumber.ToString();
        }
    }
}