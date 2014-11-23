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

namespace structVSClass
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

        private void run_Click(object sender, RoutedEventArgs e)
        {
            
            var pointStruct = new PointStruct(1, 2);
            var pointClass = new PointClass(1, 2);
            
            outputBox.Text = "Originally the points were: " + pointStruct.x.ToString() + "," + pointStruct.y.ToString() + "\r\n";

            PointStruct.ModifyStruct(pointStruct);
            outputBox.Text += "Then the points were: " + pointStruct.x.ToString() + "," + pointClass.y.ToString() + "\r\n";


            outputBox.Text += "Originally the points were: " + pointClass.x.ToString() + "," + pointClass.y.ToString() + "\r\n";

            PointClass.ModifyClass(pointClass);
            outputBox.Text += "Then the points were: " + pointClass.x.ToString() + "," + pointClass.y.ToString() + "\r\n";

        }
    }
}
