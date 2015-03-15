using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapsSample
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MyPage();
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
    public class MyPage : ContentPage
    {
        public MyPage(){
            var map = new Map(               
              MapSpan.FromCenterAndRadius(   
                new Position(35.71, 139.81), 
                Distance.FromMiles(0.2))){  
                    IsShowingUser = true, // 現在地の表示／非表示
                    MapType = MapType.Street,//タイプ指定(Street/Satellite/Hybrid)
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

            //ピン表示のサンプル
            var pin = new Pin{
                Type = PinType.Place,//ピンの種類(Place以外を指定しても、特に変化が無い。　使用例も見つけられない)
                Position = new Position(35.71, 139.81), // 座標は、同じくスカイスリー
                Label = "東京スカイツリー",
                Address = "〒131-0045 東京都墨田区押上１丁目１−２"
            };
            map.Pins.Add(pin);
            
            //スライダーによる拡大縮小のサンプル
            var slider = new Slider(1, 18, 1);
            slider.ValueChanged += (s, e) =>{
                var zoomLevel = e.NewValue;
                var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
                map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            };

            Content = new StackLayout{
                //Children = { map }
                Children = { map,slider }
            };
        }

    }
}
