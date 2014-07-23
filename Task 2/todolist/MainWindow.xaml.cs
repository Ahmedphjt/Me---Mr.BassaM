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
        }

        protected void ButtonClick(object sender, RoutedEventArgs e)
        {
            

            if (NewTodo.Text == String.Empty)
            {
                MessageBox.Show("Helpful message !! ");
            }

            else
            {
                String input = NewTodo.Text;
                CheckBox checkbox = new CheckBox();
                checkbox.Content = input;
                List.Items.Add(checkbox);
            }      


            
            

        }


    }
}