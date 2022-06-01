using System;
using System.Windows;
using System.Windows.Controls.Primitives;

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
            txtCount.Text = "12";
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

            int countAsInt = 0;

            if (int.TryParse(txtCount.Text, out countAsInt))
            {
                int.TryParse(txtCount.Text, out countAsInt);
            }
            else
            {
                countAsInt = 0;
            }

            
            string result = newPassword.getPassword(thisType, (bool)cbNumber.IsChecked,
                (bool)cbCapital.IsChecked, (bool)cbSpecial.IsChecked, countAsInt);

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
