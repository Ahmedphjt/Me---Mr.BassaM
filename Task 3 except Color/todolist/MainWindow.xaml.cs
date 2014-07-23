using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Converters;
using System.Windows.Automation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;



namespace todolist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen; // start the form in the middle os screen 

            ComboBox compo = new ComboBox();
            Compo.Items.Remove("Compo");
            Compo.Items.Add("Low");
            Compo.Items.Add("Medium");
            Compo.Items.Add("High");
            

           
        }

        protected void ButtonClick(object sender, RoutedEventArgs e)
        {
             

            // is the the user enter an empty text or white space 

            
            string N = NewTodo.Text;
            if (String.IsNullOrWhiteSpace(N))
            {
                MessageBox.Show("Please Enter a Valid Text Name ");
            }
                // handle priority 
            else if (Compo.SelectedItem==null)
            {
                MessageBox.Show("Please Enter the priority ");
            }

            else
            {
                String input = NewTodo.Text;
                CheckBox checkbox = new CheckBox();
                checkbox.Content = input;
                List.Items.Add(checkbox);
                NewTodo.Clear();
            }

            Compo.SelectedIndex = Compo.Items.IndexOf("Low");
            
            

        }

       
    }
}