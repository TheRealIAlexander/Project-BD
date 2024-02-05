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
    //Mentionez ca butonul pentru inregistrarea unui nou utilizator nu are ce cauta pe pagina de log in
    //Buttonul este functional insa acesta a fost pus acolo pentru a usura codul si ca sa nu pierd timp cu
    //crearea de "formuri" noi precum si crearea "legaturilor"
    public partial class Login : Form
    {
        List<Select_User> user = new List<Select_User>();
        List<Select_Password> password = new List<Select_Password>();
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Search_user db = new Search_user();
        
           if( !db.GetUser(userTextBox.Text).SequenceEqual(user) &&
            !db.GetPass(parolaTextBox.Text).SequenceEqual (password))
                {
                this.Hide();
                var form = new DashBoard();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Set_user_and_password  db = new Set_user_and_password ();
            db.InsertPerson(userTextBox.Text, parolaTextBox.Text);
            userTextBox.Text = "";
            parolaTextBox.Text = "";
        }
    }
}
