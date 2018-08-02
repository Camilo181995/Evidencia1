using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoViews
{
    public partial class control : ContentPage
    {
        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var estado = this.swtEstado.IsToggled;
            if(this.swtEstado.IsToggled)
            {
                DisplayAlert("Switch", "Estoy encendido", "Aceptar");
            }
            else{
                DisplayAlert("Switch", "Estoy Apagado", "Aceptar");
            }
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            labCambio.Text = slider.Value.ToString();
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            DisplayAlert("Cambiando", "Este texto esta cambiando", "Aceptar");
        }

        public control()
        {
            InitializeComponent();
        }
        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var elementosSeleccionados = picker.SelectedItem.ToString();
            DisplayAlert("Seleccionado", elementosSeleccionados, "Ok");

        }
        void btnSimular_Clicked(object sender,System.EventArgs e){

            var progreso = progressNum.Progress;
            if( progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);
            }
            else
            {
                progressNum.ProgressTo(1, 300, Easing.Linear);   
            }

        }
        void Handle_SeachButtonPressed(object sender,System.EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando Rsultados", "Aceptar");
        }

        void stepEvent(object sender,Xamarin.Forms.ValueChangedEventArgs e)
        {
            lbDisplay.Text = steeper.Value.ToString();
        }
       
    }
   
}
