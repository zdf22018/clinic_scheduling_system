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
using System.Windows.Shapes;

namespace ProjectDotNet2JQDF
{
    /// <summary>
    /// Interaction logic for DoctorProfileDlg.xaml
    /// </summary>
    public partial class DoctorProfileDlg : Window
    {
        public DoctorProfileDlg()
        {
            InitializeComponent();
            List<Patient> items = new List<Patient>();
            items.Add(new Patient() { Name = "John Doe", Age = 42, Address = "123 market St", HealthCardNo=299289312, DiseaseCode="A0101" });
            items.Add(new Patient() { Name = "Jane Doe", Age = 39, Address = "243 Boul Beaubien",  HealthCardNo = 299103303, DiseaseCode = "B0105" });
            items.Add(new Patient() { Name = "Sammy Doe", Age = 7, Address = "6570 Ave Rosemont",  HealthCardNo = 299975066, DiseaseCode = "A0151" });
            lvUsers.ItemsSource = items;
        }

        public class Patient
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public string Address { get; set; }

            public int HealthCardNo { get; set; }

            public String DiseaseCode { get; set; }
        }
    }
}
