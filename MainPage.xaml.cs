using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace evaluation_final
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            t6.Text = t1.Text;
            t7.Text = t2.Text;
            t8.Text = t3.Text;
            t9.Text = t4.Text;
            t10.Text = t5.Text;
            t11.Text = (Convert.ToInt32(t4.Text) - Convert.ToInt32(t3.Text)).ToString();
            t12.Text=(Convert.ToInt32(t11.Text) * Convert.ToInt32(t5.Text)).ToString();
           

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t6.Text = "";
            t7.Text = "";
            t8.Text = "";
            t9.Text = "";
            t10.Text = "";
            t11.Text = "";
            t12.Text = "";

        }
    }
}
