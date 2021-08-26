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
    public class SignUpViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public User User { get; set; } = new User();
        public ICommand SignUpCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        public SignUpViewModel()
        {

            SignUpCommand = new Command(async () =>
            {
                if (!String.IsNullOrEmpty(User.Username) && !String.IsNullOrEmpty(User.Email) && !String.IsNullOrEmpty(User.Password) && !String.IsNullOrEmpty(User.ConfirmPassword))
                {
                    if (User.Password != User.ConfirmPassword)
                    {
                        await App.Current.MainPage.DisplayAlert("Error", "La contraseña no coincide.", "OK");
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Bienvenido!", $"Hola, {User.Username}", "OK");

                        await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                    }                                    

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Todos los campos son obligatorios.", "OK");
                }
                





            });
            
        }
        
       
      
    }
}
