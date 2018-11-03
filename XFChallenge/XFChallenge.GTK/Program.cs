using System;
using Gtk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace XFChallenge.GTK
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("Xamarin Forms Challenge");
            window.Show();

            Gtk.Application.Run();
        }
    }
}
