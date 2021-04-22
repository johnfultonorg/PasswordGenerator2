using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordGenerator2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rbPronouncable.IsChecked = true;
            btnGenerate.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            btnCopy.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {
            Window about = new About();
            about.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Password newPassword = new Password();
            Password.PasswordType thisType;
            if ((bool)rbSimple.IsChecked)
            {
                thisType = Password.PasswordType.Simple;
            }
            else if ((bool)rbPronouncable.IsChecked)
            {
                thisType = Password.PasswordType.Pronouncable;
            }
            else
            {
                thisType = Password.PasswordType.Xkcd;
            }


            string result = newPassword.getPassword(thisType, (bool)cbNumber.IsChecked,
                (bool)cbCapital.IsChecked, (bool)cbSpecial.IsChecked);

            tbDisplay.Text += result + "\r\n";
            tbDisplay.ScrollToEnd();

            tbThis.Text = result;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
           Clipboard.SetText(tbThis.Text);
        }

    }
}
