using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S9_Gestures.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S9_Gestures.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
    
        public List<Tipo> Tipos = new List<Tipo>();

        public Home()
        {
            InitializeComponent();
            this.Tipos = new List<Tipo>();
            Tipo tipos = new Tipo()
            {
                Nombre = "Tap",
               
            };

            this.Tipos.Add(tipos);
            tipos = new Tipo()
            {
                Nombre = "Pan", 
            };
            this.Tipos.Add(tipos);
            tipos = new Tipo()
            {
                Nombre = "Swipe",
            };
            this.Tipos.Add(tipos);
            tipos = new Tipo()
            {
                Nombre = "Pinch",
            };

           
            
            
        }
    }
}