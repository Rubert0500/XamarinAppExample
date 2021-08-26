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
    public class HomeViewModel
    {
        public MenuOption BarsAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();        
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            BarsAndHotelsMenuOption.Title = "Bar and Hotels";
            BarsAndHotelsMenuOption.Image = "beerIcon.png";
            BarsAndHotelsMenuOption.Subtitle = "42 Place";

            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "fineDiningIcon.png";
            FineDiningMenuOption.Subtitle = "15 Place";

            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "cafesIcon.png";
            CafesMenuOption.Subtitle = "28 Place";

            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "nearbyIcon.png";
            NearbyMenuOption.Subtitle = "34 Place";

            FastFoodMenuOption.Title = "Fast Foods";
            FastFoodMenuOption.Image = "fastFoodIcon.png";
            FastFoodMenuOption.Subtitle = "29 Place";

            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "izzaIcon.png";
            FeaturedFoodsMenuOption.Subtitle = "21 Place";
        }

    }
}
