using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Databese
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun(){
                id=1,
                urunAdi="1984",
                yazar="George Orwell",
                urunKategori="Aksiyon",
                stokAdet=10,
                urunResim=@"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\72-) Windows form - ComboBox kullanımı - Form tasarımı\project images\george.jpg",
                aciklama="Sovyet Rusya’ya bir eleştiri niteliğinde olan bu kitap, günümüz siyasetinin baskısı, toplumdaki adaletsizliği, insanların tek tipleştirilmek istenmesi, zihnin kontrolü ve bireyselliğin yok edilmesi gibi kavramlar üzerinde de duruyor. Ütopik olduğu kadar gerçekçi yönlere de yer veren roman, sizi yaşadığınız toplum düzeni içerisinde de düşünmeye davet ediyor. Önlem alınmadığı takdirde nerelere sürüklenebileceğimiz konusunda ipuçları veren bu romanı, elinizden bırakamayacaksınız.",
            },
            new Urun(){
                id=2,
                urunAdi="Beren ile Luthien",
                yazar="J.R.R. Tolkien",
                urunKategori="Macera",
                stokAdet= 11,
                urunResim=@"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\72-) Windows form - ComboBox kullanımı - Form tasarımı\project images\beren.jpg",
                aciklama="Tolkien’in yayımlanmayan metinlerinden derlenerek başlı başına bir kitap haline getirilen Beren ile Luthien’in destansı hikayesi Hobbit, Yüzüklerin Efendisi, Silmarillion ve Tolkien’in yarattığı Elfler, İnsanlar, Orklar ve Cücelerle dolu Orta Dünya hayranlarını bir kez daha bir araya getirecek.J.R.R. Tolkien’in İlk Çağ’daki destanları ve mitleri anlattığı Silmarillion’ın gelişiminde büyük bir rol oynayan Beren ile Luthien’in hikayesinin yazım sürecinde pek çok detay değişse de gölgelenen aşkları hep baki kaldı: Beren ölümlü bir İnsandı, Luthien ise ölümsüz bir Elf. Önemli bir Elf beyi olan babası, kızının Beren’le olmasına karşıydı ve eğer Luthien’le evlenmek istiyorsa Beren imkansız bir görevi yerine getirmek zorundaydı. Beren, Luthien ile birlikte kötülerin en kötüsü, Kara Düşman, Morgoth olarak da bilinen Melkor’dan en değerli mücevher Silmarili çalmaya çalışacaktı.",
            },
            new Urun(){
                 id=3,
                urunAdi="Ben Dünyanın En Akıllı İnsanıyım",
                yazar="Erdal Demirkıran",
                urunKategori="Kişisel Gelişim",
                stokAdet= 9,
                urunResim=@"C:\Users\Orkun YALINKILIÇ\Desktop\C# DERSLERİ\72-) Windows form - ComboBox kullanımı - Form tasarımı\project images\erdal.jpg",
                aciklama="Buraya özgeçmişimi yazmak isterdim ama benim özgeçmişim yok. CV'm de yok! Ben dünle değil, daha çok bugün ve yarınla ilgilenirim. Çünkü düne bakarsam yaşadığım negatif olayları referans alabilir ve hareket alanımı daraltabilirim. Örneğin mezun olduğum okul en iyisi değilse, en iyi okuldan mezun olan birini benden daha iyi görme gafletine düşebilirim. Oysa ben henüz hiçbir negatifliğe bulaşmayan bugün ve yarınla ilgilenirim. Bu beni daima en öne götürür. Çünkü geleceğimi şekillendiren dünün geyiği değil, yarının hayalleridir.Ben bugün en iyisi olduğuma eminim. Yarın da benden daha iyisi olmayacak. Göreceksin!",
            },
        };
    }
}
