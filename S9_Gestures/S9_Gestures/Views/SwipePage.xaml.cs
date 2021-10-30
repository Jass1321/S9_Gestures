using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S9_Gestures.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipePage : ContentPage
    {
        public SwipePage()
        {
            InitializeComponent();
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            string direction = e.Direction.ToString();

            if (direction == "Right")
                ((BoxView)sender).BackgroundColor = Color.HotPink;
            if (direction == "Left")
                ((BoxView)sender).BackgroundColor = Color.Purple;
            if (direction == "Up")
                ((BoxView)sender).BackgroundColor = Color.DarkSeaGreen;
            if (direction == "Down")
                ((BoxView)sender).BackgroundColor = Color.DeepSkyBlue;
            _label.Text = $"You swiped: {e.Direction.ToString()}";
        }
    }
}