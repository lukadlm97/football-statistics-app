﻿using FootballStatistics.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FootballStatistics.WPF.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public static readonly DependencyProperty LoginCommandProperty =
            DependencyProperty.Register("LoginCommand", typeof(ICommand), typeof(LoginView), new PropertyMetadata(null));

        public static readonly DependencyProperty CurrentViewModelCommandProperty =
            DependencyProperty.Register("CurrentViewModelCommand", typeof(ICommand), typeof(HomeView), new PropertyMetadata(null));
        public ICommand LoginCommand
        {
            get { return (ICommand)GetValue(LoginCommandProperty); }
            set { SetValue(LoginCommandProperty, value); }
        }
        public ICommand CurrentViewModelCommand
        {
            get { return (ICommand)GetValue(CurrentViewModelCommandProperty); }
            set { SetValue(CurrentViewModelCommandProperty, value); }
        }

        public LoginView()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender,RoutedEventArgs e)
        {
            if(LoginCommand != null)
            {
                string password = pbPassword.Password;
                LoginCommand.Execute(password);
            }
        }
       
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if(CurrentViewModelCommand != null)
            {
                CurrentViewModelCommand.Execute(ViewType.Home);
            }
        }
    }
}
