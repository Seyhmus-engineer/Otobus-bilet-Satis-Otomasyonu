using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTobüs_BileT_Rezervasyon_SiTtemi
{
    public partial class Form2 : Form
    {
        static OTobüs_BileT_Rezervasyon_SiTtemiEntities2 db = new OTobüs_BileT_Rezervasyon_SiTtemiEntities2();
        private int cSeferID = 0;
        private int cBusID = 0;
        private List<int> doluKolTuklar = new List<int>();

        public Form2()
        {
            InitializeComponent();
        }

        private DateTime tarih;
        private string nereden;
        private string nereye;

        public Form2(string nereden, string nereye, DateTime tarih)
        {
            InitializeComponent();
            this.nereden = nereden;
            this.nereye = nereye;
            this.tarih = tarih;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var sehir = db.dbsehirTable.FirstOrDefault(x => x.sehir1 == nereden && x.sehir2 == nereye);
            if (sehir != null)
            {
                int sehirId;
                sehirId = sehir.sehirID;
                var s = db.dbseferTable.FirstOrDefault(x => x.sehirID == sehirId &&
                    x.daTe.HasValue &&
                    x.daTe.Value.Year == tarih.Year &&
                    x.daTe.Value.Month == tarih.Month &&
                    x.daTe.Value.Day == tarih.Day);

                dbsehirTable dbseh = new dbsehirTable();
                if (s != null)
                {
                    cSeferID = (int)s.seferID;
                    cBusID = (int)s.busID;

                    if (s.fiyaT.HasValue)
                    {
                        label7.Text = s.fiyaT.Value.ToString();
                    }
                    else
                        label7.Text = "Fiyat bilgisi yok.";

                    if (s.daTe.HasValue)
                        label8.Text = s.daTe.Value.Date.ToShortDateString();
                    else
                        label8.Text = "Tarih bilgisi yok.";

                    DoluKolTuklar();
                    RadioAyarla();
                }
                else
                {
                    MessageBox.Show("Bu şehirler ve tarih için sefer bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Şehir eşleşmesi bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Dispose();
            db = new OTobüs_BileT_Rezervasyon_SiTtemiEntities2();

            int seciliKoltuk = SeciliKolTukNumarasi();
            if (seciliKoltuk == 0)
            {
                MessageBox.Show("Lütfen bir koltuk seçiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dbmusTeriTable dbmus = new dbmusTeriTable();
            dbmus.m_ad = textBox1.Text;
            dbmus.m_soyad = textBox2.Text;
            dbmus.cinsiyeT = comboBox1.Text == "Erkek" ? true : false;
            if (long.TryParse(textBox4.Text, out long phone))
                dbmus.phone = phone;
            else
            {
                MessageBox.Show("Geçersiz telefon numarası.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (long.TryParse(textBox6.Text, out long kimlik))
                dbmus.kimlikno = kimlik;
            else
            {
                MessageBox.Show("Geçersiz kimlik numarası.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dbmus.mail = textBox5.Text;

            db.dbmusTeriTable.Add(dbmus);
            db.SaveChanges();

            dberzervasyonTable rezervasyon = new dberzervasyonTable();
            rezervasyon.seferID = cSeferID;
            rezervasyon.m_ID = dbmus.m_ID;
            rezervasyon.kolTuknumara = (byte?)seciliKoltuk;

            var sefer = db.dbseferTable.FirstOrDefault(x => x.seferID == cSeferID);
            var kasaNesnesi = db.dbkasaTable.FirstOrDefault();

            if (sefer != null && sefer.fiyaT.HasValue && kasaNesnesi != null)
            {
                decimal fiyat = sefer.fiyaT.Value;

                if (kasaNesnesi.Kasa.Value >= fiyat)
                {
                    kasaNesnesi.Kasa -= fiyat;
                    rezervasyon.ucreT = fiyat;
                }
                else
                {
                    MessageBox.Show("Yetersiz bakiye. İşlem gerçekleştirilemedi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Sefer bilgisi veya kasa bilgisi eksik.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (sefer != null)
            {
                rezervasyon.rezervasyonTarihi = sefer.daTe.Value;
            }
            db.dberzervasyonTable.Add(rezervasyon);
            db.SaveChanges();

            MessageBox.Show($"Rezervasyon başarıyla tamamlandı!\nKoltuk No: {seciliKoltuk}\nMüşteri: {textBox1.Text} {textBox2.Text}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            TemizleForm();
            DoluKolTuklar();
            RadioAyarla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DoluKolTuklar()
        {
            var doluKolTukListesi = db.dberzervasyonTable
                .Where(x => x.seferID == cSeferID)
                .Select(x => x.kolTuknumara)
                .ToList();

            doluKolTuklar.Clear();
            foreach (var kolTuk in doluKolTukListesi)
            {
                if (kolTuk.HasValue)
                {
                    doluKolTuklar.Add(kolTuk.Value);
                }
            }
        }

        private void RadioAyarla()
        {
            var otobus = db.dboTobusTable.FirstOrDefault(x => x.busID == cBusID);
            if (otobus != null && otobus.kolTuksayisi.HasValue)
            {
                int koltukSayisi = otobus.kolTuksayisi.Value;

                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        if (radioButton.Tag != null && int.TryParse(radioButton.Tag.ToString(), out int koltukNo))
                        {
                            if (koltukNo <= koltukSayisi)
                            {
                                radioButton.Visible = true;

                                if (doluKolTuklar.Contains(koltukNo))
                                {
                                    var rezervasyon = db.dberzervasyonTable
                                        .FirstOrDefault(x => x.kolTuknumara == koltukNo && x.seferID == cSeferID);

                                    if (rezervasyon != null)
                                    {
                                        var dbmus = db.dbmusTeriTable
                                            .FirstOrDefault(x => x.m_ID == rezervasyon.m_ID);

                                        if (dbmus != null)
                                        {
                                            radioButton.Enabled = false;
                                            radioButton.Text = $"{koltukNo}";

                                            if (dbmus.cinsiyeT == true)
                                            {
                                                radioButton.BackColor = Color.LightBlue;
                                            }
                                            else
                                            {
                                                radioButton.BackColor = Color.LightPink;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    radioButton.Enabled = true;
                                    radioButton.Text = $"{koltukNo}";
                                    radioButton.BackColor = Color.Green;
                                }
                            }
                            else
                            {
                                radioButton.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private int SeciliKolTukNumarasi()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    if (radioButton.Tag != null && int.TryParse(radioButton.Tag.ToString(), out int koltukNo))
                    {
                        return koltukNo;
                    }
                }
            }
            return 0;
        }

        private void TemizleForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.SelectedIndex = -1;

            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }
    }
}