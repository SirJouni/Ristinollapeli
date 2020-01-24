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

namespace harjoitusTyoRistinolla
{
    public partial class Ristinolla : Form
    {
        
        int vuoro;
        int paikkojaJaljella;
        int[,] matriisi;
        string tiedosto;
        string etunimi;
        string sukunimi;
        string syntymavuosi;
        string nykyinenVoittaja;
        bool onkoPysahdyksessa;
        int aika;
        MenuIkkuna menu;
        public Ristinolla(MenuIkkuna menuIkkuna, string etu, string suku, string syntyma)
        {
            InitializeComponent();
            matriisi = new int[3, 3];
            vuoro = 1;
            paikkojaJaljella = 9;
            tiedosto = "C:\\temp\\ristinollaKayttajat.txt";
            menu = menuIkkuna;
            etunimi = etu;
            sukunimi = suku;
            syntymavuosi = syntyma;
            nykyinenVoittaja = "Ilmoitus asd";
            lblVuoro.Text = "Sinun vuorosi";
            onkoPysahdyksessa = false;
            aika = 0;
        }
        public string getVoittaja()
        {
            return nykyinenVoittaja;
        }
        public void alustaMatriisi() {
            //Jokaisen matriisin alkuarvo on nolla
            for (int i = 0; i < matriisi.GetLength(0); i++)
            {
                for (int a = 0; a < matriisi.GetLength(1); a++)
                {
                    matriisi[i, a] = 0;
                }
            }
        }
        
        public void vaihdaVuoroa()
        {
            //Vuoro 1 tarkoittaa etta ympyran vuoro. vuoro 2 on ristin vuoro
            vuoro++;
            if (vuoro > 2)
            {
                vuoro = 1;
            }
            if (vuoro == 1)
            {
                lblVuoro.Text = "Sinun vuorosi";
            }
            if (vuoro == 2)
            {
                lblVuoro.Text = "Vastustajan vuoro";
            }
            
            if (vuoro == 2 && menu.onkoAIvalittuna() == true) {
                lblVuoro.Text = "Tekoälyn vuoro";
                //poistaNapitKaytosta();
                //odotaVahanAikaa();
                //onkoPysahdyksessa = false;
                System.Threading.Thread.Sleep(1000);
                lblVuoro.Text = "Tekoälyn vuoro";
                string parasPysty;
                string parasPysty2;
                string parasPysty3;
                string parasVaaka;
                string parasVaaka2;
                string parasVaaka3;
                string suoritettavaSiirto = "";
                tarkistaPystysuoratTeko(out parasPysty, out parasPysty2, out parasPysty3);
                tarkistaVaakasuoratTeko(out parasVaaka, out parasVaaka2, out parasVaaka3);

                if (!parasPysty.Equals("")) {
                    suoritettavaSiirto = parasPysty;
                }
                else if (!parasVaaka.Equals("")) {
                    suoritettavaSiirto = parasVaaka;
                }
                
                else if (!parasPysty2.Equals(""))
                {
                    suoritettavaSiirto = parasPysty2;
                }
                else if (!parasVaaka2.Equals(""))
                {
                    suoritettavaSiirto = parasVaaka2;
                }
                else if (!parasPysty3.Equals(""))
                {
                    suoritettavaSiirto = parasPysty3;
                }
                else if (!parasVaaka3.Equals(""))
                {
                    suoritettavaSiirto = parasVaaka3;
                }
                
                else{
                    for (int i = 0; i < matriisi.GetLength(0); i++)
                    {
                        for (int a = 0; a < matriisi.GetLength(1); a++)
                        {
                            if (matriisi[i, a] == 0) {
                                suoritettavaSiirto = "btnRuutu" +i +"_" +a;
                            }
                        }
                    }
                }
                
                foreach (Control control in this.Controls.OfType<Button>()) {
                    //Button btn = (Button)control;
                    if (control.Name.Equals(suoritettavaSiirto)) {
                        ((Button)control).PerformClick();
                   }
                }

                
            }
        
        }

        public void odotaVahanAikaa() {
            //Task.Delay(1500);
            //onkoPysahdyksessa = true;
            lblVuoro.Text = "Tekoälyn vuoro";
            System.Threading.Thread.Sleep(1500);
            //ajastin.Enabled = true;
            //ajastin.Start();
            
            //onkoPysahdyksessa = true;
            //lblVuoro.Text = "Jot";
            
        }
        public void poistaNapitKaytosta() {
            foreach (Control control in this.Controls.OfType<Button>())
            {
                control.Enabled = false;
            }
        }
        public void laitaNapitKayttoon() {
            foreach (Control control in this.Controls.OfType<Button>())
            {
                control.Enabled = true;
            }
        }
        public void alustaPeli() {
            //Poistetaan napista merkit ja laitetaan ne takaisin painettaviksi
            foreach (Control control in this.Controls.OfType<Button>()) {
                control.Paint -= piirraYmpyra_Paint;
                control.Paint -= piirraRisti_Paint;
                control.Enabled = true;
            }
            alustaMatriisi();
            paikkojaJaljella = 9;
            vuoro = 2;
        }
        public void lopetaPeli() {
            //Tekee uuden forms ikkunan
            PeliLoppu peliLoppuIkkuna = new PeliLoppu(this);
            peliLoppuIkkuna.ShowDialog();
            
        }

        public void lisaaTiedostoonTulos(string mika) {
            //Tiedostoon lisätään parametrina annetulla tuloksella yksi kappale tulosta
            string vaihdettavaRivi = "asd";
            string uusiRivi = "jotain";
            string[] kokoTiedosto = File.ReadAllLines(tiedosto);
            for (int rivi = 0; rivi < kokoTiedosto.Length; rivi++) {
                if (kokoTiedosto[rivi].StartsWith(etunimi + ";" + sukunimi + ";" + syntymavuosi))
                {
                    vaihdettavaRivi = kokoTiedosto[rivi];
                }

            }
            string[] riviPalikoina = vaihdettavaRivi.Split(';');
            int voitot = int.Parse(riviPalikoina[3]);
            int haviot = int.Parse(riviPalikoina[4]);
            int tasapelit = int.Parse(riviPalikoina[5]);
            if (mika.Equals("voitto")) {
                voitot++;
                uusiRivi = etunimi + ";" + sukunimi + ";" + syntymavuosi +";" +voitot
                    +";" +haviot +";" +tasapelit;
            }
            if (mika.Equals("havio"))
            {
                haviot++;
                uusiRivi = etunimi + ";" + sukunimi + ";" + syntymavuosi + ";" + voitot
                    + ";" + haviot + ";" + tasapelit;
            }
            if (mika.Equals("tasapeli"))
            {
                tasapelit++;
                uusiRivi = etunimi + ";" + sukunimi + ";" + syntymavuosi + ";" + voitot
                    + ";" + haviot + ";" + tasapelit;
            }
            for (int i = 0; i < kokoTiedosto.Length; i++)
            {
                if (kokoTiedosto[i].StartsWith(etunimi + ";" + sukunimi + ";" + syntymavuosi))
                {
                    kokoTiedosto[i] = uusiRivi;
                }

            }
            StreamWriter stw = new StreamWriter(tiedosto);
            for (int a = 0; a < kokoTiedosto.Length; a++)
            {
                stw.WriteLine(kokoTiedosto[a]);
            }
            stw.Close();
        }

        public string haeTiedostostaTulokset(string mika)
        {
            StreamReader str = new StreamReader(tiedosto);
            while (!str.EndOfStream) {
                string rivi = str.ReadLine();
                if (rivi.StartsWith(etunimi + ";" + sukunimi + ";" + syntymavuosi))
                {
                    str.Close();
                    string[] palat = rivi.Split(';');
                    if (mika.Equals("voitot")) {
                        return palat[3];
                    }
                    if (mika.Equals("haviot")) {
                        return palat[4];
                    }
                    if (mika.Equals("tasapelit"))
                    {
                        return palat[5];
                    }
                }
            }
            str.Close();
            return "error";

        }
        
        public void laskePelinTilaa(object sender)
        {
            //Laittaa että nappia ei voi painaa uudestaan
            ((Button)sender).Enabled = false;
            paikkojaJaljella--;
            //if (paikkojaJaljella == 0) {
            //    lisaaTiedostoonTulos("tasapeli");
            //    lopetaPeli();
            //}

        }
        public void laitaMatriisiin(object sender, int luku) {
            //Ottaa napin nimesta sen sijainnin ja laittaa sen matriisiin
            string nimi = ((Button)sender).Name;
            string[] pala = nimi.Split('_');
            string jotain = pala[0].Replace("btnRuutu", "");
            int eka = int.Parse(jotain);
            int toka = int.Parse(pala[1]);
            matriisi[eka, toka] = luku;
            //((Button)sender).Text = eka.ToString() +"." +toka.ToString();
            //((Button)sender).Text = matriisi[eka, toka].ToString();
        }
        public void tarkistaPystysuorat() {
            int nollia = 0;
            int rasteja = 0;
            //Tarkastetaan onko pystysuorilla riveillä kolmen sarjaa
            for (int a = 0; a < matriisi.GetLength(0); a++) {
                for (int i = 0; i < matriisi.GetLength(1); i++)
                {
                    if (matriisi[a, i] != 0)
                    {
                        if (matriisi[a, i] == 1)
                            nollia++;
                        if (matriisi[a, i] == 2)
                            rasteja++;
                        
                        if (nollia == 3)
                        {
                            nykyinenVoittaja = "Voitit pelin!";
                            lisaaTiedostoonTulos("voitto");
                            lopetaPeli();
                        }
                        if (rasteja == 3)
                        {
                            nykyinenVoittaja = "Hävisit pelin!";
                            lisaaTiedostoonTulos("havio");
                            lopetaPeli();
                        }
                        
                    }
                }
                nollia = 0;
                rasteja = 0;
            }
            
        }
        public void tarkistaVaakasuorat()
        {
            int nollia = 0;
            int rasteja = 0;
            //Tarkistetaan onko kolme samaa numeroa peräkkäin vaakasuorilla riveillä
            for (int a = 0; a < matriisi.GetLength(1); a++)
            {
                for (int i = 0; i < matriisi.GetLength(0); i++)
                {
                    if (matriisi[i, a] == 1)
                        nollia++;
                    if (matriisi[i, a] == 2)
                        rasteja++;

                    if (nollia == 3)
                    {
                        nykyinenVoittaja = "Voitit pelin!";
                        lisaaTiedostoonTulos("voitto");
                        lopetaPeli();
                    }
                    if (rasteja == 3)
                    {
                        nykyinenVoittaja = "Hävisit pelin!";
                        lisaaTiedostoonTulos("havio");
                        lopetaPeli();
                    }
                }
                nollia = 0;
                rasteja = 0;
            }
        }
        public void tarkastaVinottain()
        {
            //Tarkistaa onko kolme peräkkäistä arvoa vinossa
            int nollia = 0;
            int rasteja = 0;
            for (int i = 0; i < matriisi.GetLength(0); i++)
            {
                if (matriisi[i, i] == 1)
                    nollia++;
                if (matriisi[i, i] == 2)
                    rasteja++;

                if (nollia == 3)
                {
                    nykyinenVoittaja = "Voitit pelin!";
                    lisaaTiedostoonTulos("voitto");
                    lopetaPeli();
                }
                if (rasteja == 3)
                {
                    nykyinenVoittaja = "Hävisit pelin!";
                    lisaaTiedostoonTulos("havio");
                    lopetaPeli();
                }
            }
            nollia = 0;
            rasteja = 0;
            
        }
        public void tarkistaToisestaVinosta() {
            //Tarkistaa onko kolme peräkkäistä arvoa vinossa, toisesta suunnasta
            int nollia = 0;
            int rasteja = 0;

            int p = matriisi.GetLength(1) -1;
            for (int a = 0; a < matriisi.GetLength(0); a++)
            {
                if (matriisi[a, p] == 1)
                    nollia++;
                if (matriisi[a, p] == 2)
                    rasteja++;

                if (nollia == 3)
                {
                    nykyinenVoittaja = "Voitit pelin!";
                    lisaaTiedostoonTulos("voitto");
                    lopetaPeli();
                }
                if (rasteja == 3)
                {
                    nykyinenVoittaja = "Hävisit pelin!";
                    lisaaTiedostoonTulos("havio");
                    lopetaPeli();
                }
                p--;
            }
        }

        public void btnPaina_Click(object sender, EventArgs e)
        {
            //Kun nappia painetaan, piirretaan nappiin kuva ja sen laitetaan arvo 
            //matriisiin. lopuksi tarkistetaan onko peli loppunut, takrista metodeilla
            Button btn = (Button)sender;
            if (vuoro == 2 && menu.onkoAIvalittuna() == true)
            {
                lblVuoro.Text = "Tekoälyn vuoro";
            }
            if (vuoro == 1)
            {
                laitaMatriisiin(sender, vuoro);
                btn.Paint += new PaintEventHandler(this.piirraYmpyra_Paint);
                laskePelinTilaa(sender);
                tarkistaPystysuorat();
                tarkistaVaakasuorat();
                tarkastaVinottain();
                tarkistaToisestaVinosta();
                
                if (paikkojaJaljella == 0)
                {
                    nykyinenVoittaja = "Tasapeli!";
                    lisaaTiedostoonTulos("tasapeli");
                    
                    lopetaPeli();
                }
                if (menu.onkoAIvalittuna() == true)
                {
                    lblVuoro.Text = "Tekoälyn vuoro";
                }
                vaihdaVuoroa();
            }
            else if(vuoro == 2)
            {
                laitaMatriisiin(sender, vuoro);
                btn.Paint += new PaintEventHandler(this.piirraRisti_Paint);
                laskePelinTilaa(sender);
                tarkistaPystysuorat();
                tarkistaVaakasuorat();
                tarkastaVinottain();
                tarkistaToisestaVinosta();
                
                if (paikkojaJaljella == 0) 
                {
                    nykyinenVoittaja = "Tasapeli!";
                    lisaaTiedostoonTulos("tasapeli");
                    
                    lopetaPeli();
                }
                vaihdaVuoroa();
            }
            
        }

        public void piirraRisti_Paint(object sender, PaintEventArgs e)
        {
            //piirretaan rasti nappiin
            Button button = (Button) sender;
            Pen myPen = new Pen(System.Drawing.Color.Red, 5);
            e.Graphics.DrawLine(myPen, 0, 0, button.Width, button.Height);
            e.Graphics.DrawLine(myPen, 0, button.Height, button.Width, 0);

        }
        public void piirraYmpyra_Paint(object sender, PaintEventArgs e)
        {
            //piiretaan nolla nappiin
            Button button = (Button)sender;
            Pen myPen = new Pen(System.Drawing.Color.Green, 5);
            Rectangle suorakulmio = new Rectangle(4 , 4, (button.Width-10), button.Height-10);
            e.Graphics.DrawEllipse(myPen, suorakulmio);

        }

        public void tarkistaPystysuoratTeko(out string parasSiirto,
            out string toiseksiParasSiirto, out string kolmanneksiParasSiirto)
        {
            //Tekoälyn oma tarkistus joka palauttaa parhaimmat rivit mitä 
            //kannattaa siirtää tekoälyn vuoron tullen
            parasSiirto = "";
            toiseksiParasSiirto = "";
            kolmanneksiParasSiirto = "";
            int tyhjia = 0;
            int nollia = 0;
            int rasteja = 0;
            string tyhjanSijainti = "ei sijaintia";
            //Tarkastetaan onko pystysuorilla riveillä kolmen sarjaa
            for (int a = 0; a < matriisi.GetLength(0); a++)
            {
                for (int i = 0; i < matriisi.GetLength(1); i++)
                {
                    if (matriisi[a, i] == 0)
                    {
                        tyhjanSijainti = "btnRuutu" + a + "_" + i;
                        tyhjia++;
                    }
                        if (matriisi[a, i] == 1)
                            nollia++;
                        if (matriisi[a, i] == 2)
                            rasteja++;

                        if (nollia == 3)
                        {
                            nykyinenVoittaja = "Voitit pelin!";
                            lisaaTiedostoonTulos("voitto");
                            lopetaPeli();
                        }
                        if (rasteja == 3)
                        {
                            nykyinenVoittaja = "Hävisit pelin!";
                            lisaaTiedostoonTulos("havio");
                            lopetaPeli();
                        }
                        if (rasteja == 2)
                        {
                            parasSiirto = tyhjanSijainti;
                        }
                        if (nollia == 2 && tyhjia == 1)
                        {
                            toiseksiParasSiirto = tyhjanSijainti;
                        }
                        if (tyhjia == 3)
                        {
                            kolmanneksiParasSiirto = tyhjanSijainti;
                        }
                        if (rasteja == 1) {
                            kolmanneksiParasSiirto = tyhjanSijainti;
                        }
                        if (matriisi[1,1] == 0) {
                            kolmanneksiParasSiirto = "btnRuutu1_1";
                        }

                }
                nollia = 0;
                rasteja = 0;
                tyhjia = 0;
            }

        }

        public void tarkistaVaakasuoratTeko(out string parasSiirto,
            out string toiseksiParasSiirto, out string kolmanneksiParasSiirto)
        {
            //Tekoälyn oma tarkistus joka palauttaa parhaimmat rivit mitä 
            //kannattaa siirtää tekoälyn vuoron tullen
            parasSiirto = "";
            toiseksiParasSiirto = "";
            kolmanneksiParasSiirto = "";
            int tyhjia = 0;
            int nollia = 0;
            int rasteja = 0;
            string tyhjanSijainti = "ei sijaintia";
            
            for (int a = 0; a < matriisi.GetLength(1); a++)
            {
                for (int i = 0; i < matriisi.GetLength(0); i++)
                {
                    if (matriisi[i, a] == 0)
                    {
                        tyhjanSijainti = "btnRuutu" + i + "_" + a;
                        tyhjia++;
                    }
                    if (matriisi[i, a] == 1)
                        nollia++;
                    if (matriisi[i, a] == 2)
                        rasteja++;

                    if (nollia == 3)
                    {
                        nykyinenVoittaja = "Voitit pelin!";
                        lisaaTiedostoonTulos("voitto");
                        lopetaPeli();
                    }
                    if (rasteja == 3)
                    {
                        nykyinenVoittaja = "Hävisit pelin!";
                        lisaaTiedostoonTulos("havio");
                        lopetaPeli();
                    }
                    if (rasteja == 2)
                    {
                        parasSiirto = tyhjanSijainti;
                    }
                    if (nollia == 2 && tyhjia == 1)
                    {
                        toiseksiParasSiirto = tyhjanSijainti;
                    }
                    if (tyhjia == 3)
                    {
                        kolmanneksiParasSiirto = tyhjanSijainti;
                    }
                    if (rasteja == 1)
                    {
                        kolmanneksiParasSiirto = tyhjanSijainti;
                    }
                }
                nollia = 0;
                rasteja = 0;
                tyhjia = 0;
            }
        }

        private void ajastin_Tick(object sender, EventArgs e)
        {
            //aina kun sekunti menee laitetaan aika muuttujaan yksi arvo lisaa
            aika++;
            if (aika > 1) {
                onkoPysahdyksessa = false;
                aika = 0;
            }
        }
        public void lopetaAjastus()
        {
            onkoPysahdyksessa = false;
            
        }
    }
}
