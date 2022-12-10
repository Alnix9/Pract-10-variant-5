using System;
using System.Collections;
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

namespace Генеральский_практическая_10
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
        List<int> array = new List<int>();//Объявляем целочисленный коллекцию List
        private void CreateArray(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            array.Add(random.Next(-100,100));//Диапазон случайных чисел
            arrayList.ItemsSource = null;//Очищаем
            arrayList.ItemsSource = array;
        }
        private void FindQuantity(object sender, RoutedEventArgs e)
        {
            int newPositiveArray = array.Count(x => x > 0);//Положительные числа
            MessageBox.Show(newPositiveArray.ToString());//Выводим положительные числа
            int newNegativeArray = array.Count(x => x < 0);//Отрицательные числа
            MessageBox.Show(newNegativeArray.ToString());//Выводим отрицательные числа
        }
        private void About_Programm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5. Дан массив в диапазоне [-100;100] найти количество положительных и \r\nотрицательных.\r\n");
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
