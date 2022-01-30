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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Course_Management
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<string> tspNames = new List<string>
            {
                "USSL","Data Park","TCL IT","PNTL"
            };
            this.tspName.ItemsSource = tspNames;
            this.ctspName.ItemsSource = tspNames;

            List<string> courseNames = new List<string>
            {
                "ESAD-CS", "WPSI", "GAVE", "ESAD–J2EE"
            };
            this.coursename.ItemsSource = courseNames;
            this.ccourseName.ItemsSource = courseNames;


            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
        }
    }
}
