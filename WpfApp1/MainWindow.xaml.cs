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
using System.Collections;

namespace WpfApp1
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
        //int[] number = new int[5];
        int number;
        int i;
        ArrayList myAL = new ArrayList();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int itemCount = Convert.ToInt32(text1.Text);
                if (itemCount > 0)
                {
                    Random rnd1 = new Random();
                    list1.Items.Clear();
                    for (i = 1; i <= itemCount; i++)
                    {
                        number = -100 + rnd1.Next(200);
                        myAL.Add(number);
                        list1.Items.Add(number);
                    }
                }
                else MessageBox.Show("Введите целое число больше нуля!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число!!!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int itemCount = Convert.ToInt32(text1.Text);
                if (itemCount > 0)
                {
                    Random rnd1 = new Random();
                    list1.Items.Clear();
                    list1.Items.Add("Исходный массив");
                    for (i = 1; i <= itemCount; i++)
                    {
                        number = -100 + rnd1.Next(200);
                        myAL.Add(number);
                        list1.Items.Add(number);
                    }
                    myAL.Sort();
                    list1.Items.Add("Отсортированный массив");

                    foreach (int elem in myAL)
                    {
                        list1.Items.Add(elem);
                    }
                }
                else MessageBox.Show("Введите целое число больше нуля!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число!!!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.SaveFileDialog myDialog = new Microsoft.Win32.SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in list1.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int kol = 0;
            int itemCount = Convert.ToInt32(text1.Text);
            int a = itemCount - 1;
            for (i = 1; i < a; i++)
            {
                if (((int)myAL[i] > (int)myAL[i - 1]) && ((int)myAL[i] > (int)myAL[i + 1]))
                { 
                kol++;// list1.Items.Add("1"); 
                }
                //int c = (int)myAL[i -1];
                //int b = (int)myAL[i+1];
                //list1.Items.Add(c+" _"+(int)myAL[i] + " _" + b);
            }
            list1.Items.Add("Дан массив из n чисел.\n Сколько элементов массива больше своих «соседей»,\n т.е. предыдущего и последующего. Первый и последний \nэлементы не рассматривать.");
            list1.Items.Add("Ответ:" + kol);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int itemCount = Convert.ToInt32(text1.Text);
            for (i=0;i< itemCount;i++)
            {
                if ((int)myAL[i] > 25)
                {
                    list1.Items.Add("Для массива из n чисел найти номер \nпервого элемента, большего 25.");
                       list1.Items.Add("Ответ:" + i);
                    break;
                }
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int itemCount = Convert.ToInt32(text1.Text);
            int t, sum = 0;
            t = (int)myAL[1];
            for(i=1;i<itemCount;i++)
            {
                if ((int)myAL[i] > t) sum += (int)myAL[i];
            }
            list1.Items.Add("В массиве из n чисел найти сумму элементов \nбольших, чем второй элемент этого массива.");
            list1.Items.Add("Ответ:" + sum);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(" Для массива из n чисел найти номер первого \nэлемента большего K, где K вводится в отдельном \nдочернем или диалоговом окне.");
            Window1 f = new Window1(); // создаем
            f.ShowDialog(); // показываем
            //f.Show(); // или так показываем
            //int itemCount = Convert.ToInt32(text_ok.Text);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            list1.Items.Add("В массиве из n чисел найти сумму элементов \nбольших, чем K-ый по счету элемент этого массива, \nгде K вводится в отдельном дочернем или \nдиалоговом окне.");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            list1.Items.Add("Дан массив из n чисел. Выделите, те элементы \nмассива, что больше своих «соседей», т.е. \nпредыдущего и последующего. Первый и последний \nэлементы не рассматривать.");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            AboutBox1 r = new AboutBox1();
            r.ShowDialog();
        }
    }
}
