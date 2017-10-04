using Xamarin.Forms;

namespace Week6Examples
{
    public partial class Week6ExamplesPage : ContentPage
    {
        public Week6ExamplesPage()
        {
            InitializeComponent();
        }

        void Handle_NavigateToMapSample(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MapSamplePage());
        }
    }
}
