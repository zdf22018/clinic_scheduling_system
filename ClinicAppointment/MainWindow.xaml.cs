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

namespace ClinicAppointment
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

        /*
         * btLogInClick pops up different window all depending on 
         * what user entered as type, so we do conditional statements 
         * here
         */
        private void btLogIn_Click(object sender, RoutedEventArgs e)
        {
            var comboBoxItem = cbProfile.Items[cbProfile.SelectedIndex] as ComboBoxItem;
            string selectedProfile = comboBoxItem.Content.ToString().ToLower();
            if (selectedProfile == "" || selectedProfile == "please select your type")
            {
                return;
            }
            else if (selectedProfile == "doctor")
            {
                //TODO: more code to add to cope with database
                Doctor.MainWindow newForm = new Doctor.MainWindow();

                newForm.Show();  // or newForm.ShowDialog();
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            //no dialog pops out
            DialogResult = false;
            //safely exit app
            Environment.Exit(0);
        }
    }
}
