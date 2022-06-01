using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace PasswordGenerator2
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        void OnLoad(object sender, RoutedEventArgs e)
        {

            var appSettings = ConfigurationManager.AppSettings;
            string version = appSettings["Version"] ?? "2.02";

            int year = DateTime.Now.Year;

            txtAbout.Text = "Copyright © 2017- " + year +  " TechElevator, Inc - A Stride Company" + System.Environment.NewLine +
                System.Environment.NewLine +
                "Version " + version +  System.Environment.NewLine +
                System.Environment.NewLine +
               "Permission is hereby granted, free of charge, to any person obtaining a copy of this" + System.Environment.NewLine +
               "software and associated documentation files(the \"Software\"), to deal in the Software without " + System.Environment.NewLine +
                "restriction, including without limitation the rights to use, copy, modify, merge, publish, " + System.Environment.NewLine +
                "distribute, sublicense, and/ or sell copies of the Software, and to permit persons to whom " + System.Environment.NewLine +
                "the Software is furnished to do so, subject to the following conditions:" + System.Environment.NewLine +
                 System.Environment.NewLine +
                "The above copyright notice and this permission notice shall be included in all copies or substantial " + System.Environment.NewLine +
                "portions of the Software." + System.Environment.NewLine +
                 System.Environment.NewLine +
                "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED " + System.Environment.NewLine +
                "TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO " + System.Environment.NewLine +
                "EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, " + System.Environment.NewLine +
                "WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH " + System.Environment.NewLine +
                "THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE." + System.Environment.NewLine +
                System.Environment.NewLine +
                "John Fulton" + System.Environment.NewLine +
                 System.Environment.NewLine;

            btnClose.Focus();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
