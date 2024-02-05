using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectBD.Library_Classes;
using ProiectBD.Search_Methods;

namespace ProiectBD
{
    //Formul contine o serie de campuri ce pot fi completate pentru a da insert/update/delete la linii din tabelele Adresa Livrare si Client
    //Metoda e de forta bruta. O varianta mai compexa si care ar putea fi generalizata pentru absolut toate tabelel ar fi fost greu de implementat.
    //Am ales sa ma incadrez in cerinta(min 2 tabele) pentru a salva timp 
    public partial class Modificare_Tabele : Form
    {
        public Modificare_Tabele()
        {
            InitializeComponent();
        }

        private void InsertAdresa_Click(object sender, EventArgs e)
        {
            Insert_Adresa db = new Insert_Adresa();
            db.InsertAdresa(int.Parse(textBox5.Text), textBox6.Text, int.Parse(textBox7.Text), textBox8.Text, int.Parse(textBox9.Text), textBox10.Text, textBox11.Text);
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void UpdateAdresa_Click(object sender, EventArgs e)
        {
            Insert_Adresa db = new Insert_Adresa();
            db.UpdateAdresa(int.Parse(textBox5.Text), textBox6.Text, int.Parse(textBox7.Text), textBox8.Text, int.Parse(textBox9.Text), textBox10.Text, textBox11.Text,textBox12.Text,int.Parse (textBox14.Text) );
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox14.Text = "";
        }

        private void DeleteAdresa_Click(object sender, EventArgs e)
        {
            Insert_Adresa db = new Insert_Adresa();
            db.DeleteAdresa(textBox12.Text ,int.Parse(textBox14.Text));
            textBox12.Text = "";
            textBox14.Text = "";
        }

        private void InsertClient_Click(object sender, EventArgs e)
        {
            Insert_Client db = new Insert_Client();
            db.InsertClient(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void UpdateClient_Click(object sender, EventArgs e)
        {
            Insert_Client db = new Insert_Client();
            db.UpdateClient(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox13.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox13.Text = "";
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            Insert_Client db = new Insert_Client();
            db.DeleteClient(textBox13.Text);
            textBox13.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
