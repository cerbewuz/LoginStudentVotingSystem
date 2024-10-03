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

namespace LoginStudentVotingSystem
{
    /// <summary>
    /// Interaction logic for DashboardForm.xaml
    /// </summary>
    public partial class DashboardForm : Window
    {
        public DashboardForm(string loggedUserName)
        {
            InitializeComponent();
        }
    }
}
