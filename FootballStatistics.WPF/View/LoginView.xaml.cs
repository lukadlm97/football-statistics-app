using FootballStatistics.Domain.Models.Enum;
using FootballStatistics.Domain.Services.AuthenticationService;
using FootballStatistics.WPF.Authenticators;
using FootballStatistics.WPF.Commands;
using FootballStatistics.WPF.State.Navigators;
using FootballStatistics.WPF.ViewModels;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
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

        
       

        public ICommand LoginCommand
        {
            get { return (ICommand)GetValue(LoginCommandProperty); }
            set { SetValue(LoginCommandProperty, value); }
        }
        public ICommand RegisterCommand
        {
            get;
            internal set;
        }
        private void CreateRegisterCommand()
        {
        
        }
       
        public LoginView()
        {
            InitializeComponent();
            cmbUserRole.ItemsSource = Enum.GetValues(typeof(UserRoles)).Cast<UserRoles>();      
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
            if(reg_panel.Visibility == Visibility.Hidden)
            {
                reg_panel.Visibility = Visibility.Visible;
            }
            else
            {
                reg_panel.Visibility = Visibility.Hidden;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
