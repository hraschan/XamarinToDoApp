using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinToDoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InputField_TextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);

        }

        private void InputFieldShowcase_Completed(object sender, EventArgs e)
        {
            Console.WriteLine("Enter Pressed");
            Label newTodo = new Label();
            newTodo.Text = InputFieldShowcase.Text;
            ToDoListShowcase.Children.Add(newTodo);
            InputFieldShowcase.Text = "";
            InputFieldShowcase.Focus();

        }
    }
}
