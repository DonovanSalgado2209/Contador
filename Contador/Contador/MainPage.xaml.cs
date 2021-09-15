using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contador
{
    public partial class MainPage : ContentPage
    {
        int _contador;
        string _mensaje;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            _contador = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             if (button1 == null)
            
                button1 = ((Button)sender);
            
            _contador++;
            _mensaje = "Me presionaste {0} veces";
            button1.Text = String.Format(_mensaje, _contador);
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            _mensaje = "Presioname";
            if (button1 != null)
            {
                button1.Text = _mensaje;
                _contador = 0;
            }
        }
    }
}
