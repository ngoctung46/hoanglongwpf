﻿using System;
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

namespace WpfApp1.Controls
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserNameTextBox.Text != "hoanglong" && PasswordTextBox.Text != "kshoanglong")
            {
                StatusTextBlock.Text = "Invalid Username or Password. Please try again!";
            }
            else
            {
                new MainWindow().Show();
                var parent = Window.GetWindow(this) as LoginWindow;
                parent?.Close();
            }
        }
    }
}