using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceInceleme
{
    public partial class Servisim : ServiceBase
    {
        public Timer t;

        public Servisim()
        {
            InitializeComponent();
            t = new Timer(30000); // 30sn
            t.Elapsed += T_Elapsed;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Burada SQL'e bağlanacağız ve kayıt oluşturacağız
            DAL d = new DAL();
            d.OlayGunluguYeniKayit("Servis Çalıştı", DateTime.Now); // Her 30sn de bir
        }

        /*
        * Başlama
        * Pause  bunlar sanal oldugu için override edebiliyoruz...
        * Continue
        * Stop
        * OnShutDown
        */
        protected override void OnStart(string[] args)
        {
            //Servisimiz çalıştığı zaman çalışacak olan kod bloğumuz
            t.Start();
        }
        protected override void OnStop()
        {
            //Servisimiz pause edildiği zaman çalışacak olan kod bloğumuz
            t.Stop();
        }

        protected override void OnPause()
        {
            //Servisimiz pause işleminden devam ettirildiği zaman çalışacak olan kod bloğumuz
            t.Stop();
        }
        protected override void OnContinue()
        {
            //Servisimiz durdurulduğu zaman çalışacak olan kod bloğumuz
            t.Start();
        }
        protected override void OnShutdown()
        {
            //Servisimiz shut-down edildiği zaman çalışacak olan kod bloğumuz
            t.Stop();
        }
    }
}
