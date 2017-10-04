using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Week6Examples
{
    public partial class MapSamplePage : ContentPage
    {
        public MapSamplePage()
        {
            InitializeComponent();
            //MySampleMap.MoveToRegion(new MapSpan(new Position(33.1307785, -117.1601826), 33.1307785, -117.1601826 ));
            var initialMapLocation = MapSpan.FromCenterAndRadius(new Position(33.1307785, -117.1601826), Distance.FromMiles(1));
            MySampleMap.MoveToRegion(initialMapLocation);


			PlaceAMarker();
        }

        private void PlaceAMarker()
        {
            var position = new Position(33.1307785, -117.1601826); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "custom pin",
				Address = "custom detail info"
			};
            MySampleMap.Pins.Add(pin);
        }
    }
}
