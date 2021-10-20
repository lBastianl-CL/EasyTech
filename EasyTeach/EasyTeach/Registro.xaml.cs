using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyTeach
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            InitApp();
            btnregistrar.Clicked += Btnregistrar_Clicked;
        }

        private void Btnregistrar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Buscador());
        }

        void InitApp()
        {
            List<String> opcion = new List<string>
            {
                "Tutor",
                "Estudiante"
            };
            foreach (var opciones in opcion)
            {
                tutoroestudiante.Items.Add(opciones);
            }
        }

        private void Tutoroestudiante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}