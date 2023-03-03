using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PDC03_MODULE2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();
        public ObservableCollection<employee> Employees { get { return employees; } }


        public activity5()
        {
            InitializeComponent();


            {
                lst.ItemsSource = employees;

                employees.Add(new employee { DisplayNameAttribute = "Juan Dela Cruz", Position = "President", profileimage = "image1.jpg" });
                employees.Add(new employee { DisplayNameAttribute = "Peter", Position = "Vice President", profileimage = "image2.jpg" });
                employees.Add(new employee { DisplayNameAttribute = "Mary", Position = "Secretary", profileimage = "image3.jpg" });
            }
        }
    }
}