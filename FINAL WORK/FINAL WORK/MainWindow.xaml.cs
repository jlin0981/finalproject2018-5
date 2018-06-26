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
using System.Collections.ObjectModel;
using System.IO;
using System.Collections;

namespace FINAL_WORK
{
    
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void draw1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\james\Documents\finalproject2018-5\臨摹");
            int countdraw = 0;

            foreach (var fi in di.GetFiles())
            {
                countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw1count.Text = "已畫了" + (countdraw.ToString()) + "張圖，還差" + (60 - countdraw) + "張圖";

            }
            if (MyProgress.Value < countdraw)
                MyProgress.Value += countdraw;
            else ;

        }

        private void MyProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\james\Documents\finalproject2018-5\骨架");
            int countdraw = 0;

            foreach (var fi in di.GetFiles())
            {
                countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw2count.Text = "已畫了"+ (countdraw.ToString()) +"張圖，還差"+(60-countdraw)+"張圖" ;

            }
            if (MyProgress1.Value < countdraw)
                MyProgress1.Value += countdraw;
            else;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\james\Documents\finalproject2018-5\直線");
            int countdraw = 0;

            foreach (var fi in di.GetFiles())
            {
                countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw3count.Text = "已畫了" + (countdraw.ToString()) + "張圖，還差" + (60 - countdraw) + "張圖";

            }
            if (MyProgress2.Value < countdraw)
                MyProgress2.Value += countdraw;
            else;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\james\Documents\finalproject2018-5\光影");
            int countdraw3 = 0;

            foreach (var fi in di.GetFiles())
            {
                countdraw3 = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw4count.Text = "已畫了" + (countdraw3.ToString()) + "張圖，還差" + (60 - countdraw3) + "張圖";

            }
            if (MyProgress3.Value < countdraw3)
                MyProgress3.Value += countdraw3;
            else;
        }
    }
}
