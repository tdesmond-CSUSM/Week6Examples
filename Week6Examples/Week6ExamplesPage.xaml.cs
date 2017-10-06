using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Week6Examples
{
    public partial class Week6ExamplesPage : ContentPage
    {
        public Week6ExamplesPage()
        {
            InitializeComponent();

            PopulatePicker();
        }

        private void PopulatePicker()
        {
            Dictionary<string, Color> nameToColor = new Dictionary<string, Color>()
            {
            { "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Gray", Color.Gray }, { "Green", Color.Green },
            { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
            { "Navy", Color.Navy }, { "Olive", Color.Olive },
            { "Purple", Color.Purple }, { "Red", Color.Red },
            { "Silver", Color.Silver }, { "Teal", Color.Teal },
            { "White", Color.White }, { "Yellow", Color.Yellow }
          };


            foreach (var item in nameToColor)
            {
                SamplePicker.Items.Add(item.Key);
            }

            SamplePicker.SelectedIndex = 0;
        }

        void Handle_NavigateToMapSample(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MapSamplePage());
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Code to handle user making index changes in picker
        }
    }
}
