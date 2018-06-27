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
using Winforms = System.Windows.Forms;
using System.Diagnostics;

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
            Winforms.FolderBrowserDialog folderDialog = new Winforms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            Winforms.DialogResult result = folderDialog.ShowDialog();
          
            DirectoryInfo di = new DirectoryInfo(folderDialog.SelectedPath);
                int countdraw = 0;

                foreach (var fi in di.GetFiles())
                {
                    countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                    draw1count.Text = "已畫了" + (countdraw.ToString()) + "張圖，還差" + (60 - countdraw) + "張圖";
                if (MyProgress.Value < countdraw && countdraw <= 60)
                {
                    MyProgress.Value = countdraw;
                }
                else if (countdraw > 60)
                {
                    
                    MyProgress.Value = countdraw;
                    draw1count.Text = "完成";
                }
                MyProgress.Value = countdraw ;
            }

        }
            
           

        

        private void MyProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Winforms.FolderBrowserDialog folderDialog = new Winforms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            Winforms.DialogResult result = folderDialog.ShowDialog();

            DirectoryInfo di = new DirectoryInfo(folderDialog.SelectedPath);
            int countdraw = 0;

            foreach (var fi in di.GetFiles())
            {
                countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw2count.Text = "已畫了" + (countdraw.ToString()) + "張圖，還差" + (60 - countdraw) + "張圖";
                if (MyProgress1.Value < countdraw && countdraw <= 60)
                {
                    MyProgress1.Value = countdraw;
                }
                else if (countdraw > 60)
                {

                    MyProgress1.Value = countdraw;
                    draw2count.Text = "完成";
                }
                MyProgress1.Value = countdraw;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Winforms.FolderBrowserDialog folderDialog = new Winforms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            Winforms.DialogResult result = folderDialog.ShowDialog();

            DirectoryInfo di = new DirectoryInfo(folderDialog.SelectedPath);
            int countdraw = 0;
            foreach (var fi in di.GetFiles())
            {
                countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw3count.Text = "已畫了" + (countdraw.ToString()) + "張圖，還差" + (60 - countdraw) + "張圖";
                if (MyProgress2.Value < countdraw && countdraw <= 60)
                {
                    MyProgress2.Value = countdraw;
                }
                else if (countdraw > 60)
                {

                    MyProgress2.Value = countdraw;
                    draw3count.Text = "完成";
                }
                MyProgress2.Value = countdraw;
            }



        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Winforms.FolderBrowserDialog folderDialog = new Winforms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            Winforms.DialogResult result = folderDialog.ShowDialog();
          
            DirectoryInfo di = new DirectoryInfo(folderDialog.SelectedPath);
            int countdraw = 0;

            foreach (var fi in di.GetFiles())
            {
                countdraw = int.Parse(di.GetFiles("*.jpg").Length.ToString());
                draw4count.Text = "已畫了" + (countdraw.ToString()) + "張圖，還差" + (60 - countdraw) + "張圖";
                if (MyProgress3.Value < countdraw && countdraw <= 60)
                {
                    MyProgress3.Value = countdraw;
                }
                else if (countdraw > 60)
                {

                    MyProgress3.Value = countdraw;
                    draw4count.Text = "完成";
                }
                MyProgress3.Value = countdraw;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            

        }

        private void draw1count_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
