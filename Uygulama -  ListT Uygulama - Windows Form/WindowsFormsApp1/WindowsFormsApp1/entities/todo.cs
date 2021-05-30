using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.entities
{
    public class todo
    {
        public Guid id { get; set; }
        public string baslik { get; set; }
        public string kisaAciklama { get; set; }
        public string aciklama { get; set; }
        public int onemDerece { get; set; }
        public string durumAciklama { get; set; }
        public DateTime olusturmaTarih { get; set; }
    }
}
