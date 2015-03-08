using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsSample {
    public class App : Application {
        public App() {
            MainPage = new MyPage();
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }

    public class MyPage : ContentPage
    {
        public MyPage() {
            var x = MapSpan.FromCenterAndRadius(new Position(35.71, 139.81), Distance.FromMiles(0.2));

            var map = new Map(
                MapSpan.FromCenterAndRadius(new Position(35.71, 139.81), Distance.FromMiles(0.2))){
                            IsShowingUser = true,//現在位置の表示
                            //HeightRequest = 100,
                            //WidthRequest = 960,
                            VerticalOptions = LayoutOptions.FillAndExpand
                        };
            Content = new StackLayout {
                Children = { map }
            };
        }
    }
}