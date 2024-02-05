using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectBD.Rezultate;
using ProiectBD.Search_Methods;

namespace ProiectBD
{
    //Butoanele care contin in text "...din ziua" necesita introducerea unui string de forma date
    //conversia se face automat atata timp cat avem suficiente cifre pentru an/luna/ziua
    //Butoanele care incep cu "Angajatul..." sau "Clientul..." necesita introducerea numelui persoanei in cauza.
    //Atentie! Se cere Numele si doar Numele
    //Butoanele care nu se regasesc mai sus nu au nevoie de date de la utilizator, ele servesc o functie de calcul sau afisare
    //a bazei de date
    public partial class DashBoard : Form
    {
        List<Adresele_de_livrare_in_ziua> adrese1 = new List<Adresele_de_livrare_in_ziua>();
        List<Angajatii_si_Clientii_din_ziua> angajati1 = new List<Angajatii_si_Clientii_din_ziua>();
        List<Angajatul_si_coletele_sale> angajati2 = new List<Angajatul_si_coletele_sale>();
        List<Incasarile_din_ziua> number1 = new List<Incasarile_din_ziua>();
        List<Depozite_cu_pachete_urgente> adrese2 = new List<Depozite_cu_pachete_urgente>();
        List<Clientul_si_coletele_sale> client1 = new List<Clientul_si_coletele_sale>();
        List <Colete_Intarziate  > colet1 = new List<Colete_Intarziate>();
        List <Angajatii_cu_un_traseu_mai_mare_decat_media> angajati3 = new List<Angajatii_cu_un_traseu_mai_mare_decat_media >();
        public DashBoard()
        {
            InitializeComponent();

            Display_ListBox.DataSource = adrese1;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = angajati1;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = angajati2;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = number1;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = adrese2;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = client1;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = colet1;
            Display_ListBox.DisplayMember = "INFO";
            Display_ListBox.DataSource = angajati3;
            Display_ListBox.DisplayMember = "INFO";

        }

     
         private void Button1_Click(object sender, EventArgs e)
        {
            Search_by_Date db = new Search_by_Date();
            adrese1 = db.GetList1(SearchTextBox.Text);

            Display_ListBox.DataSource = adrese1;
            Display_ListBox.DisplayMember = "INFO";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Search_by_Date2 db2 = new Search_by_Date2();
            angajati1 = db2.GetList2(SearchTextBox.Text);

            Display_ListBox.DataSource = angajati1;
            Display_ListBox.DisplayMember = "INFO";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Search_by_angajat db3 = new Search_by_angajat();
            angajati2 = db3.GetList3(SearchTextBox.Text);

            Display_ListBox.DataSource = angajati2;
            Display_ListBox.DisplayMember = "INFO";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Search_by_Date3 db4 = new Search_by_Date3();
            number1 = db4.GetList4(SearchTextBox.Text);

            Display_ListBox.DataSource = number1;
            Display_ListBox.DisplayMember = "INFO";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Return_Data1 db5 = new Return_Data1();
            adrese2 = db5.GetList5();

            Display_ListBox.DataSource = adrese2;
            Display_ListBox.DisplayMember = "INFO";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Search_by_client db6 = new Search_by_client ();
              client1 = db6.GetList6(SearchTextBox.Text);

            Display_ListBox.DataSource = client1;
            Display_ListBox.DisplayMember = "INFO";

        }

        private void adauga_in_tabele_Click(object sender, EventArgs e)
        {
            var form = new Modificare_Tabele();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search_colete_intarziate  db = new Search_colete_intarziate ();
            colet1 = db.GetList7();

            Display_ListBox.DataSource = colet1;
            Display_ListBox.DisplayMember = "INFO";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Search_best_from_average db =new Search_best_from_average ();
            angajati3 = db.GetList8();

            Display_ListBox.DataSource = angajati3;
            Display_ListBox.DisplayMember = "INFO";
        }
    }
}
