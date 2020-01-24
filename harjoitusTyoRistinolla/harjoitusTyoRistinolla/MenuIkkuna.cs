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

    public partial class MenuIkkuna : Form
    {
        string tiedosto;
        public MenuIkkuna()
        {
            InitializeComponent();
            checkBoxLocal.Enabled = false;
            checkBoxAI.Enabled = false;
            checkBoxLocal.Checked = true;
            tiedosto = "c://temp//ristinollaKayttajat.txt";
            //tbEtunimi.Select();
        }

        public bool onkoAIvalittuna() {
            if (checkBoxAI.Checked) {
                return true;
            }
            return false;
        }


        public bool IsValid()
        {
            foreach (Control c in errorProvider1.ContainerControl.Controls)
                if (errorProvider1.GetError(c) != "")
                    return false;
            return true;
        }
        private void btnPelaa_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (IsValid())
            {
                tallennaNimi();
                this.Hide();
                Ristinolla ristinollaIkkuna = new Ristinolla(this, tbEtunimi.Text
                    ,tbSukunimi.Text, tbSyntymaaika.Text);
                ristinollaIkkuna.ShowDialog();
                this.Show();
            }
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            checkBoxLocal.Checked = true;
            checkBoxAI.Checked = false;
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            checkBoxAI.Checked = true;
            checkBoxLocal.Checked = false;
        }

        public void tallennaNimi() {
            if (File.Exists(tiedosto) == false) {
                File.Create(tiedosto);
            }
            string etunimi = tbEtunimi.Text;
            string sukunimi = tbSukunimi.Text;
            string syntymavuosi = tbSyntymaaika.Text;

            if (NimiTiedostossa(tiedosto, etunimi, sukunimi, syntymavuosi) == false)
            {
                StreamWriter stw = new StreamWriter(tiedosto, true);
                stw.WriteLine(etunimi +";" +sukunimi +";" +syntymavuosi +";" +"0" + ";" + "0" + ";" + "0");
                stw.Close();
            }
        }
        public bool NimiTiedostossa(string tiedosto, string etunimi, string sukunimi, string syntymavuosi) {
            StreamReader str = new StreamReader(tiedosto);
            while (!str.EndOfStream) {
                string rivi = str.ReadLine();
                if (rivi.StartsWith(etunimi +";" +sukunimi +";" +syntymavuosi)) {
                    str.Close();
                    return true;
                }
            }
            str.Close();
            return false;
        }
        
        private void tbEtunimi_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            errorProvider1.SetError(textBox, "");
        }

        private void tbEtunimi_Validating(object sender, CancelEventArgs e)
        {
            if (this.ActiveControl.Equals(sender))
                return;

            TextBox textBox = (TextBox)sender;
            string errorMsg = "Kenttä on tyhjä";
            if (textBox.Text.Length == 0)
            {
                e.Cancel = true;
                //textBox.Select(0, textBox.Text.Length);
                this.errorProvider1.SetError(textBox, errorMsg);
            }
        }
    }
}
