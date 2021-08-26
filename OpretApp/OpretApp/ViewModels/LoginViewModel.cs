using OpretApp.Models;
using OpretApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OpretApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => {

                if (String.IsNullOrEmpty(User.Username) || String.IsNullOrEmpty(User.Password))
                {

                    await App.Current.MainPage.DisplayAlert("Error", "Los campos username y password no pueden estar vacios.", "OK");

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Bienvenido!", $"Hola, {User.Username}", "OK");
                    await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                }
            });

            SignUpCommand = new Command(async () => {

                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            });
                          
           
        }
       
    }
}
