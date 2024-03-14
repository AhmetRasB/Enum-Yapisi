using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum TurkishCities
        {
            XXXXX,
            ADANA,
            ADIYAMAN,
            AFYONKARAHISAR,
            AĞRI,
            AMASYA,
            ANKARA,
            ANTALYA,
            ARTVİN,
            AYDIN,
            BALIKESİR,
            BİLECİK,
            BİNGÖL,
            BİTLİS,
            BOLU,
            BURDUR,
            BURSA,
            ÇANAKKALE,
            ÇANKIRI,
            ÇORUM,
            DENİZLİ,
            DİYARBAKIR,
            EDİRNE,
            ELAZIĞ,
            ERZİNCAN,
            ERZURUM,
            ESKİŞEHİR,
            GAZİANTEP,
            GİRESUN,
            GÜMÜŞHANE,
            HAKKARİ,
            HATAY,
            ISPARTA,
            MERSİN,
            İSTANBUL,
            İZMİR,
            KARS,
            KASTAMONU,
            KAYSERİ,
            KIRKLARELİ,
            KIRŞEHİR,
            KOCAELİ,
            KONYA,
            KÜTAHYA,
            MALATYA,
            MANİSA,
            KAHRAMANMARAŞ,
            MARDİN,
            MUĞLA,
            MUŞ,
            NEVŞEHİR,
            NİĞDE,
            ORDU,
            RİZE,
            SAKARYA,
            SAMSUN,
            SİİRT,
            SİNOP,
            SİVAS,
            TEKİRDAĞ,
            TOKAT,
            TRABZON,
            TUNCELİ,
            ŞANLIURFA,
            UŞAK,
            VAN,
            YOZGAT,
            ZONGULDAK,
            AKSARAY ,
            BAYBURT,
            KARAMAN,
            KIRIKKALE,
            BATMAN ,
            ŞIRNAK,
            BARTIN,
            ARDAHAN,
            IĞDIR,
            YALOVA,
            KARABÜK,
            KİLİS,
            OSMANİYE,
            DÜZCE
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            TurkishCities sehir;
            sehir = (TurkishCities)plaka;
            label1.Text = sehir.ToString();
        }
    }
}
