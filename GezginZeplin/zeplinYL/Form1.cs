using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace zeplinYL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[,] sehirKomsu = new int[81, 10];//Komsuluk Matrisi
        static int[] gidilebilirNext = new int[10];
        static double[,] sehirLatlong = new double[81, 4];//Lat-Long ve Rakım Matrisi
        static double egim;
        static bool ilkSehir = false, sonSehir = false;
        static int yolcuSayisi;
        static int egimMax = 30 + (50 - yolcuSayisi);
        static int sehirBaslangıc;
        static int sehirBitis;
        static int[] yol = new int[80];
        static int[,] sehirKoordinat = new int[81, 3];
        
        public static void DosyaIslem()
        {
            OpenFileDialog file = new OpenFileDialog();
            //Komsuluk Dosya Okuma İşlemleri
            string komsulukTxt = @"D:\Yazlab\komsuluk.txt";
            FileStream komsulukFS = new FileStream(komsulukTxt, FileMode.Open, FileAccess.Read);
            StreamReader komsulukSR = new StreamReader(komsulukFS);
            string komsu = komsulukSR.ReadLine();
            int sehir = 0;
            int sayac = 0;
            int sira = 0;

            while (komsu != null)
            {
                string karakter;
                int komsuPlaka;
                int komsuSira = 0;//i. komşu
                karakter = komsu.Substring(sira + sayac, 1);
                while (karakter != null)
                {

                    karakter = komsu.Substring(sira + sayac, 1);
                    if (karakter != ",")
                    {
                        sayac++;
                    }
                    else
                    {
                        komsuPlaka = Convert.ToInt32(komsu.Substring(sira, sayac));
                        sehirKomsu[sehir, komsuSira] = komsuPlaka;
                        sira = sira + sayac + 1;
                        komsuSira++;
                        sayac = 0;
                    }
                    if (sira + sayac == komsu.Length) break;
                }
                komsuPlaka = Convert.ToInt32(komsu.Substring(sira, sayac));
                sehirKomsu[sehir, komsuSira] = komsuPlaka;
                komsuSira = 0;
                sira = 0;
                sayac = 0;
                sehir++;
                komsu = komsulukSR.ReadLine();
            }
            //Lat-Long Dosya Okuma İşlemleri
            string latlongTxt = @"D:\Yazlab\latlong.txt";
            FileStream latlongFS = new FileStream(latlongTxt, FileMode.Open, FileAccess.Read);
            StreamReader latlongSR = new StreamReader(latlongFS);
            string latlong = latlongSR.ReadLine();
            sehir = 0;
            sayac = 0;
            sira = 0;
            while (latlong != null)
            {
                string karakter = null;
                int tur = 0;
                double latDeger = 0;
                double longDeger = 0;
                int sehirPlaka;
                int rakimDeger = 0;
                karakter = latlong.Substring(sira + sayac, 1);
                while (karakter != null)
                {
                    karakter = latlong.Substring(sira + sayac, 1);
                    if (karakter != ",")
                    {
                        sayac++;
                    }
                    else if (karakter == "," && tur == 0)
                    {
                        latDeger = Convert.ToDouble(latlong.Substring(sira, sayac));
                        sehirLatlong[sehir, 1] = latDeger;
                        sira = sira + sayac + 1;
                        tur++;
                        sayac = 0;
                    }
                    else if (karakter == "," && tur == 1)
                    {
                        longDeger = Convert.ToDouble(latlong.Substring(sira, sayac));
                        sehirLatlong[sehir, 2] = longDeger;
                        sira = sira + sayac + 1;
                        tur++;
                        sayac = 0;
                    }
                    else if (karakter == "," && tur == 2)
                    {
                        sehirPlaka = Convert.ToInt32(latlong.Substring(sira, sayac));
                        sehirLatlong[sehir, 0] = sehirPlaka;
                        sira = sira + sayac + 1;
                        tur++;
                        sayac = 0;
                    }
                    else if (karakter == "," && tur == 3)
                    {
                        rakimDeger = Convert.ToInt32(latlong.Substring(sira, sayac));
                        sehirLatlong[sehir, 3] = rakimDeger;
                        sira = sira + sayac + 1;
                        tur++;
                        sayac = 0;
                        System.Console.WriteLine(rakimDeger);
                    }
                    if (sira + sayac == latlong.Length) break;
                }
                rakimDeger = Convert.ToInt32(latlong.Substring(sira, sayac));
                sehirLatlong[sehir, 3] = rakimDeger;
                tur = 0;
                sayac = 0;
                sira = 0;
                sehir++;
                latlong = latlongSR.ReadLine();
            }
            string koordinatTxt = @"D:\Yazlab\koordinat.txt";
            FileStream koordinatFS = new FileStream(koordinatTxt, FileMode.Open, FileAccess.Read);
            StreamReader koordinatSR = new StreamReader(koordinatFS);
            string koordinat = koordinatSR.ReadLine();
            sayac = 0;
            sehir = 0;
            int siraxy = 0;
            while (koordinat != null)
            {
                string karakter;
                int X;
                int Y;
                int next=0;
                
                karakter = koordinat.Substring(siraxy + sayac, 1);
                while (karakter != null)
                {
                    karakter = koordinat.Substring(siraxy + sayac, 1);
                    if (karakter != ",")
                    {
                        sayac++;
                    }
                    else if(karakter == "," && next == 0)
                    {
                        X = Convert.ToInt32(koordinat.Substring(siraxy, sayac));
                        sehirKoordinat[sehir,0] = X;
                        siraxy = siraxy + sayac + 1;
                        next++;
                        sayac = 0;
                    }
                    if (siraxy + sayac == koordinat.Length) break;
                }
                Y = Convert.ToInt32(koordinat.Substring(siraxy, sayac));
                sehirKoordinat[sehir, 1] = Y;
                siraxy = 0;
                sayac = 0;
                sehir++;
                koordinat = koordinatSR.ReadLine();
            }

        }
        private void BtnProb1_Click(object sender, EventArgs e)
        { 
            DosyaIslem();
            Problem1();
        }
        private void BtnProb2_Click(object sender, EventArgs e)
        {
            DosyaIslem();
            Problem2();
        }
        private void CbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nereden;
            nereden = CbNereden.SelectedIndex+1;
            sehirBaslangıc = nereden;
        }
        private void CbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nereye;
            nereye = CbNereye.SelectedIndex + 1;
            sehirBitis = nereye;
        }
        private void Problem2()
        {
            double[,] cozum2 = new double[46, 102];
            double toplamMaliyet;
            label1.ResetText();
            for (int k = 10; k >= 50; k=k+10)
            {
                yolcuSayisi = k;
                EnKısaYol(Graf(), sehirBaslangıc, sehirBitis);
                toplamMaliyet = 0;
                for(int i = 0; i < yol.Length - 1; i++)
                {
                    if (yol[i + 1] == 0) break;
                    toplamMaliyet = toplamMaliyet + Maliyet(yol[i], yol[i + 1]);
                    label2.Text = label2.Text + "/n" + Maliyet(yol[i], yol[i + 1]);
                }
                cozum2[k/10, 0] = toplamMaliyet;
                cozum2[k/10, 1] = yolcuSayisi;
                for (int l = 0; l < yol.Length; l++)
                {
                    if (yol[l] == 0) break;
                    cozum2[k/10, l + 2] = yol[l];
                }
                for (int y = 0; y < 80; y++)
                {
                    if (yol[y] == 0) break;
                    label1.Text = label1.Text + "->" + Convert.ToString(yol[y]);
                }
                label1.Text = label1.Text + "/n";
            }
            /*for (int y = 0; y < 80; y++)
            {
                if (yol[y] == 0) break;
                label1.Text = label1.Text + "->" + Convert.ToString(yol[y]);
            }*/


            cozumList.Items.Add(sehirBaslangıc + "--" + sehirBitis);
            for (int j = 0; j <5; j++)
            {
                cozumList.Items.Add(cozum2[j, 1] + "  " + cozum2[j, 0]);

            }
            Graphics grafik = panel1.CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.DarkOrange, 2);
            for (int i = 0; i < yol.Length - 1; i++)
            {
                if (yol[i + 1] == 0) break;
                int x1, x2, y1, y2;
                int sehir1 = yol[i] - 1;
                int sehir2 = yol[i + 1] - 1;
                x1 = sehirKoordinat[sehir1, 0];
                x2 = sehirKoordinat[sehir2, 0];
                y1 = sehirKoordinat[sehir1, 1];
                y2 = sehirKoordinat[sehir2, 1];
                Point nokta1 = new Point(x1, y1);
                Point nokta2 = new Point(x2, y2);
                grafik.DrawLine(kalem, nokta1, nokta2);
            }

        }
        private void Problem1()
        {
            double[,] cozum1 = new double[46,102];
            double toplamMaliyet=0;
            label1.ResetText();
            label2.ResetText();
            for (int k = 45; k >= 0; k--)
            {
                yolcuSayisi = k+5;
                double[,] newG = Graf();
                EnKısaYol(Graf(), sehirBaslangıc, sehirBitis);
                toplamMaliyet = 0;
                for (int i = 0; i < yol.Length - 1; i++)
                {
                    if (yol[i + 1] == 0||yol[i+1]>81) break;
                    toplamMaliyet = toplamMaliyet + newG[yol[i],yol[i+1]];
                }
                cozum1[45-k, 0] = toplamMaliyet;
                cozum1[45-k, 1] = yolcuSayisi;
                for (int l = 0; l < yol.Length; l++)
                {
                    if (yol[l] == 0) break;
                    cozum1[45-k, l+2] = yol[l];
                }
                
            }
            label2.Text = Convert.ToString(Maliyet(6, 26));
            for (int y = 0; y < 80; y++)
            {
                if (yol[y] == 0) break;
                label1.Text = label1.Text +"->"+ Convert.ToString(yol[y]);
            }
                

            cozumList.Items.Add(sehirBaslangıc + "--" + sehirBitis);
            for (int j = 0; j <= 45; j++)
            {
                cozumList.Items.Add(cozum1[j, 1] + "  "+cozum1[j, 0]);
                
            }
            Graphics grafik = panel1.CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.DarkOrange, 2);
            for(int i = 0; i < yol.Length-1; i++)
            {
                if (yol[i+1] == 0) break;
                int x1,x2,y1,y2;
                int sehir1 = yol[i]-1;
                int sehir2 = yol[i + 1]-1;
                x1 = sehirKoordinat[sehir1, 0];
                x2 = sehirKoordinat[sehir2, 0];
                y1 = sehirKoordinat[sehir1, 1];
                y2 = sehirKoordinat[sehir2, 1];
                Point nokta1 = new Point(x1, y1);
                Point nokta2 = new Point(x2, y2);
                grafik.DrawLine(kalem, nokta1, nokta2);
            }
            
        }
        public static Boolean Gidilebilir(int sehirNow, int sehirMaybe)
        
        {
            if (sehirMaybe == 0)
            {
                return false;
            }
            if (Egim(sehirNow, sehirMaybe) < egimMax)
            {
                return true;
            }
            else return false;
        }
        public static double Egim(int sehirNow, int sehirNext)
        {
            double rakimFark;
            double rakimNow = sehirLatlong[sehirNow - 1, 3];
            double rakimNext = sehirLatlong[sehirNext - 1, 3];
            double mesafe = Mesafe(sehirNow, sehirNext);
            rakimFark = Math.Abs(rakimNow - rakimNext);
            if (ilkSehir == true)
            {
                rakimFark = rakimFark + 50;
                ilkSehir = false;
            }

            if (sonSehir == true)
            {
                rakimFark = rakimFark + 50;
                sonSehir = false;
            }
            double egimRadyan = Math.Atan((rakimFark / mesafe));
            egim = egimRadyan * (180 / Math.PI);
            return egim;
        }
        private static double Yol(int sehirNow, int sehirNext)
        {
            double rakimFark;
            double rakimNow = sehirLatlong[sehirNow - 1, 3];
            double rakimNext = sehirLatlong[sehirNext - 1, 3];
            rakimFark = Math.Abs(rakimNow - rakimNext);
            if (sehirNow == sehirBaslangıc)
                ilkSehir = true;
            if (sehirNext == sehirBitis)
                sonSehir = true;
            if (ilkSehir == true)
            {
                rakimFark = rakimFark + 50;
                ilkSehir = false;
            }

            if (sonSehir == true)
            {
                rakimFark = rakimFark + 50;
                sonSehir = false;
            }

            return Math.Sqrt(Math.Pow(Mesafe(sehirNow, sehirNext), 2) + Math.Pow(rakimFark / 1000, 2));
        }
        private static double Mesafe(int sehirNow, int sehirNext)
        {

            double latNow = sehirLatlong[sehirNow - 1, 1];
            double latNext = sehirLatlong[sehirNext - 1, 1];
            double longNow = sehirLatlong[sehirNow - 1, 2];
            double longNext = sehirLatlong[sehirNext - 1, 2];
            double latFark = Math.Abs(latNow - latNext);
            double longFark = Math.Abs(longNow - longNext);
            double dist = Math.Sin(deg2rad(latNow)) * Math.Sin(deg2rad(latNext)) + Math.Cos(deg2rad(latNow)) * Math.Cos(deg2rad(latNext)) * Math.Cos(deg2rad(longFark));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            dist = dist * 1.609344;//mesafe KM cinsinden 
            return dist;
        }

        //Latitude ve Longitude ile mesafe hesaplama ve aşağıdaki derece radyan dönüşümleri https://www.geodatasource.com/developers/c-sharp sitesinden alıntıdır***
        private static double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private static double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }
        //***
        public static double Maliyet(int sehirNow, int sehirNext)
        {
            double maliyet;
            maliyet = Yol(sehirNow, sehirNext) * 10;
            return maliyet;
        }

        static double[] deger = new double[82];
        static double[] roadValue = new double[82];
        private static double EnKısaYol(double[,] G, int sehirIlk, int sehirSon)
        {
            int[] before = new int[82];
            double[] check = new double[82];
            int x, y, rank;
            double z, minRoad;
            for (x = 1; x < 82; x++)
            {
                roadValue[x] = int.MaxValue;
                before[x] = -1;
            }
            rank = sehirIlk;
            check[rank] = 1;
            roadValue[rank] = 0;
            while (check[sehirSon] == 0)
            {
                minRoad = int.MaxValue;
                y = 0;
                for (x = 1; x < 82; x++)
                {
                    z = roadValue[rank] + G[rank, x];
                    if (z < roadValue[x] && check[x] == 0)
                    {
                        roadValue[x] = z;
                        before[x] = rank;
                    }
                    if (minRoad > roadValue[x] && check[x] == 0)
                    {
                        minRoad = roadValue[x];
                        y = x;
                    }

                }
                rank = y;
                check[rank] = 1;
            }
            rank = sehirSon;
            int[] visited = new int[82];

            for (int a = 0; a < 82; a++)
            {
                visited[a] = 100;
            }

            int b = 0;
            while (rank != -1)
            {
                visited[b] = rank;
                rank = before[rank];
                b++;
            }
            int next = 0;
            for (int m = 81; m >= 0; m--)
            {
                if (visited[m] != 100 && visited[m] != 0)
                {
                    yol[next] = visited[m];
                    next++;

                }
            }

            return roadValue[sehirSon];
        }

        public static double[,] Graf()
        {
            double m;
            double[,] G = new double[82, 82];
            for (int i = 0; i < 82; i++)
            {
                for (int j = 0; j < 82; j++)
                {
                    G[i, j] = int.MaxValue;
                }
            }
            for (int i = 1; i < 82; i++)
            {
                G[i, i] = 0;
                for (int j = 1; j < 10; j++)
                {
                    if (sehirKomsu[i - 1, j] == 0)
                        continue;

                    m = Maliyet(i, sehirKomsu[i - 1, j]);
                    G[i, sehirKomsu[i - 1, j]] = m;
                    if (Gidilebilir(i, sehirKomsu[i - 1, j]) == false)
                        G[i, sehirKomsu[i - 1, j]] = int.MaxValue;
                }

            }
            return G;
        }
        
    }
}
