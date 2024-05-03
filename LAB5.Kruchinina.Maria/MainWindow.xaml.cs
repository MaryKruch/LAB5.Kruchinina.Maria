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

namespace LAB5.Kruchinina.Maria
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получ введ строку
                string input = txtInput.Text;

                // Проверяем на пустую строку
                if (string.IsNullOrEmpty(input))
                {
                    throw new Exception("Строка не может быть пустой");
                }

                MessageBox.Show("Ввод данных принят: " + input);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                MessageBox.Show("Finally block выполнен.");
            }
        }
    }
}