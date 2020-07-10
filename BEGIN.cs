using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLOT_MACHINE_FINAL
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
        InitializeComponent();
        }

        //************************************** GLOBAIS

        private static bool maxnormal = false;
        private static Random aleatorio = new Random();

        private static List<List<Image>> listaCompleta = new List<List<Image>>();
        private static List<PictureBox> slots = new List<PictureBox>();
        private static int[] slotnumeros;

        private static int escolhaTema = 0; //theme frutas se não for escolhido nada.
        private static int dificuldade = 3; //2 para testar
        public static int creditos = 1000;
        private static int aposta;
        private static int layout = 3;

        private static SqlConnection connection;
        public static aviso avisowindow = new aviso();


        //************************************** EFEITO DROP SHADOW 

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {

            get{

            CreateParams cp = base.CreateParams;
            cp.ClassStyle = CS_DropShadow;
            return cp;

            }

        }


        //************************************** CHECK SQL LIGAÇÃO VISUAL

        private void ligacao()
        {
            if(connection.State == ConnectionState.Open) 
                sqlconnection.ForeColor = Color.YellowGreen;
            else if(connection.State == ConnectionState.Closed)
                sqlconnection.ForeColor = Color.DarkRed;
        }


        //************************************** CONTROLOS TOPO 

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizebutton_Click(object sender, EventArgs e)
        {
            maxnormal = !maxnormal;

            if(maxnormal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //************************************** ON LOAD

        private void MAIN_Load(object sender, EventArgs e)
        {

        // Nova ligação estática SQL - com ligação dinâmica à root da pasta
    
        connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" 
        + Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))
        + @"\jackpotdatabase.mdf;Integrated Security=True;Persist Security Info=False");


            //sql check inicial
            connection.Open();
            ligacao();
            connection.Close();


            // Criação das listas para aguentar os recursos
            List<Image> frutas    = new List<Image>();
            List<Image> mar       = new List<Image>();
            List<Image> teste     = new List<Image>();
            List<Image> exotico   = new List<Image>();

             //Ciclo para carregar os recursos através de conversão para bitmap 
             for(int i = 0; i < 8; ++i){

                 frutas.Add((Bitmap)Properties.Resources.ResourceManager.GetObject(Convert.ToString(i)));
                 mar.Add((Bitmap)Properties.Resources.ResourceManager.GetObject(Convert.ToString(i+ 9)));


             }
                    
            listaCompleta.Add(frutas);
            listaCompleta.Add(mar);
            //listaCompleta.Add(gemas);
           


            foreach(PictureBox pb in panelplay.Controls.OfType<PictureBox>().Where(x => x.Name.StartsWith("slot")))
                slots.Add(pb);

            creditslabel.Text = creditos.ToString();

        }

        //************************************** SCROLL OPCOES

   
        private void MAIN_Shown(object sender, EventArgs e)
        {

        }

   

        //************************************** BOTÕES MENU PRINCIPAL

        private void buttonstart_Click(object sender, EventArgs e)
        {
        /*
        SqlCommand sc;
        string sql = "insert into jogos values(getdate(), 'G', 400, 800, 3, null)";

        connection.Open();

        sc = new SqlCommand(sql, connection);
        sc.ExecuteNonQuery();  
        sc.Dispose();

        connection.Close();
        */

            menuplaybutton.Visible    = true;
            menuaboutbutton.Visible   = true;
            menustatsbutton.Visible   = true;
            menuoptionsbutton.Visible = true;
            menuselected.Visible      = true;
            menuhomebutton.Visible    = true;

            panelmain.BringToFront();
        }




        //************************************** JOGO

        private void playslotmachine_Click(object sender, EventArgs e)
        {

            if(check3slot.Checked == false && check4slot.Checked == false && check9slot.Checked == false)
                check3slot.Checked = true;

            if(betbutton100.Toggled == false && betbutton200.Toggled == false && betbutton300.Toggled == false && betbutton500.Toggled == false )
                betwarning.Visible = true;
            else if (creditos < aposta) 
                moneywarning.Visible = true;
            else{
                
                moneywarning.Visible = false;
                betwarning.Visible = false;
                
             
            slotmachinelogic();
            
          
            }

            if(creditos <= 0)
                avisowindow.Show(); 

        }

        //************************************** LÓGICA DO JOGO


        private void slotmachinelogic()
        {

            bool[] vitorias = new bool[] {false,false,false,false,false,false};
            

            foreach(PictureBox pb in slots.Where(x => x.Name.StartsWith("slot")))
                        pb.BackColor = Color.Transparent;
            



            for(int i = 0; i < 50; ++i) { 

                System.Threading.Thread.Sleep(80);
                
                if(check3slot.Value){

                slot3.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade)); //0-index 
                slot4.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot5.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));

                }

                if(check4slot.Value){

                slot9.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade)); 
                slot1.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot4.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot7.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));

                }


                if(check9slot.Value){

                slot0.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade)); 
                slot1.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot2.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot3.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot4.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot5.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot6.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot7.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));
                slot8.Image = listaCompleta.ElementAt(escolhaTema).ElementAt(aleatorio.Next(dificuldade));

                }

                this.Update();
            }

            //Condições de Vitória


                if(slot3.Image == slot4.Image && slot3.Image == slot5.Image && check3slot.Value == true ){
                
                    slot3.BackColor = Color.CadetBlue;        
                    slot4.BackColor = Color.CadetBlue;         
                    slot5.BackColor = Color.CadetBlue;         

                    vitorias[0] = true;
                }

                if(slot9.Image == slot1.Image && slot9.Image == slot4.Image && slot9.Image == slot7.Image && check4slot.Value == true){
                
                    slot9.BackColor = Color.CadetBlue;        
                    slot1.BackColor = Color.CadetBlue;         
                    slot4.BackColor = Color.CadetBlue;
                    slot7.BackColor = Color.CadetBlue;


                    vitorias[1] = true;
                }


            if(check9slot.Value){

                if (slot8.Image == slot4.Image && slot8.Image == slot0.Image) { 
                
                    slot8.BackColor = Color.CadetBlue;        
                    slot4.BackColor = Color.CadetBlue;         
                    slot0.BackColor = Color.CadetBlue;

                    vitorias[2] = true;

                }
        

                if (slot7.Image == slot4.Image && slot7.Image == slot1.Image) { 

                    slot7.BackColor = Color.CadetBlue;        
                    slot4.BackColor = Color.CadetBlue;         
                    slot1.BackColor = Color.CadetBlue;

                    vitorias[3] = true;

                }


                if (slot6.Image == slot4.Image && slot6.Image == slot2.Image) { 

                    slot6.BackColor = Color.CadetBlue;        
                    slot4.BackColor = Color.CadetBlue;         
                    slot2.BackColor = Color.CadetBlue;

                    vitorias[4] = true;

                }

                if (slot3.Image == slot4.Image && slot3.Image == slot5.Image) { 

                    slot3.BackColor = Color.CadetBlue;        
                    slot4.BackColor = Color.CadetBlue;         
                    slot5.BackColor = Color.CadetBlue;

                    vitorias[5] = true;
                }
            }

            int multiplica = 0;
            char tipojogo;
            int quantia;

            foreach(bool cvitoria in vitorias)
                if(cvitoria)
                    multiplica++;

            if(creditos <= 0)
                 avisowindow.Show(); 

            if (multiplica > 0) { 
                creditos += aposta * (dificuldade + multiplica);
                tipojogo = 'G';
                quantia = aposta * (dificuldade + multiplica);
            }
            else
            {
                 creditos -= aposta;
                 tipojogo = 'P'; 
                 quantia = aposta;
            }

            SqlCommand sc = new SqlCommand("usp_jogos", connection);
            sc.CommandType = CommandType.StoredProcedure;

            connection.Open();
            ligacao();

            sc.Parameters.AddWithValue("@tipojogo", SqlDbType.Char).Value = tipojogo;
            sc.Parameters.AddWithValue("@aposta", SqlDbType.Int).Value = aposta;
            sc.Parameters.AddWithValue("@quantia", SqlDbType.Int).Value = quantia;
            sc.Parameters.AddWithValue("@modojogo", SqlDbType.SmallInt).Value = layout;
            sc.Parameters.AddWithValue("@id_jogador", SqlDbType.Int).Value = DBNull.Value;

            sc.ExecuteNonQuery();
            sc.Dispose();

            connection.Close();

            creditslabel.Text = creditos.ToString(); 
        }

        public void creditslabeltext(string myText)
        {
            this.creditslabel.Text = myText;
        }


        //************************************** APOSTA

        private void betbutton100_Click(object sender, EventArgs e)
        {
            aposta = 100;
        }

        private void betbutton200_Click(object sender, EventArgs e)
        {
            aposta = 200;
        }

        private void betbutton300_Click(object sender, EventArgs e)
        {
            aposta = 300;
        }

        private void betbutton500_Click(object sender, EventArgs e)
        {
            aposta = 500;
        }

        //************************************** TIPO JOGO

        public string LabelText
        {
            get
            {
            return this.creditslabel.Text;
            }
            set
            {
            this.creditslabel.Text = value;
            }
        }


        private void check3slot_OnValuechange(object sender, EventArgs e)
        {
            if(check3slot.Checked) { 
                check4slot.Checked = false;  
                check9slot.Checked = false;

                slotnumeros = new int[] {3,4,5};
                layout = 3;
      
                foreach(PictureBox pb in slots)
                    pb.Visible = false;

                for(int i = 0; i < 3; i++)
                    foreach(PictureBox pb in slots.Where(x => x.Name.Equals("slot" + slotnumeros[i])))
                        pb.Visible = true;
            }  
        }

             
        private void check4slot_OnValuechange(object sender, EventArgs e)
        {
            if(check4slot.Checked) { 
                check3slot.Checked = false;  
                check9slot.Checked = false;

                    
               slotnumeros = new int[] {9,1,4,7};
               layout = 4;

      
                foreach(PictureBox pb in slots)
                    pb.Visible = false;

                for(int i = 0; i < 4; i++)
                    foreach(PictureBox pb in slots.Where(x => x.Name.Equals("slot" + slotnumeros[i])))
                        pb.Visible = true;
            }
        }

        private void check9slot_OnValuechange(object sender, EventArgs e)
        {
            if(check9slot.Checked) { 
                check3slot.Checked = false;  
                check4slot.Checked = false;

                 layout = 9;

                foreach(PictureBox pb in slots.Where(x => x.Name.StartsWith("slot")))
                    pb.Visible = true;

                slot9.Visible = false;
            }
        }



        //************************************** BOTOES MENU

        private void menuplaybutton_Click(object sender, EventArgs e)
        {
            panelplay.BringToFront();
            menuselected.Left = menuplaybutton.Left + 15;
        }


        private void menuoptionsbutton_Click(object sender, EventArgs e)
        {
            paneloptions.BringToFront();
            menuselected.Left = menuoptionsbutton.Left + 15;

        }

        private void menuhomebutton_Click(object sender, EventArgs e)
        {
            panelmain.BringToFront();
            menuselected.Left = menuhomebutton.Left + 15;

        }

        private void menustatsbutton_Click(object sender, EventArgs e)
        {
            panelestats.BringToFront();
            menuselected.Left = menustatsbutton.Left + 15;

            testelabel.Text = "";

            //proc para highscore
            connection.Open();
            SqlCommand highscore = new SqlCommand("usp_highscore", connection);
            SqlCommand jogos = new SqlCommand("usp_jogos_stats", connection);

            highscore.CommandType = CommandType.StoredProcedure;
            jogos.CommandType = CommandType.StoredProcedure;
          

            using (SqlDataReader reader = highscore.ExecuteReader())
                while (reader.Read())
                    testelabel.Text += "\n"+reader.GetValue(0).ToString();


            using (SqlDataReader readerII = jogos.ExecuteReader()){
                while (readerII.Read()) { 

                wongameslabel.Text = readerII.GetValue(0).ToString();
                playedgameslabel.Text = readerII.GetValue(1).ToString();
                lostgameslabel.Text = readerII.GetValue(2).ToString();
                moneyspentlabel.Text = readerII.GetValue(3).ToString();
                moneyearned.Text = readerII.GetValue(4).ToString();
                moneylostbutton.Text = readerII.GetValue(5).ToString();
                }
            }

            connection.Close();
        }

        private void menuaboutbutton_Click(object sender, EventArgs e)
        {
            panelabout.BringToFront();
            menuselected.Left = menuaboutbutton.Left + 15;
        }


        //************************************** MEDIA

        private void githubbutton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BlameSafeguard");
        }


        //************************************** PAINEL OPCOES

        private void temafrutas_Click(object sender, EventArgs e)
        {
            temafrutas.BackColor = Color.AliceBlue;
            escolhaTema = 0;
        }

        private void themesea_Click(object sender, EventArgs e)
        {
            themesea.BackColor = Color.AliceBlue;
            escolhaTema = 1;
        }

        private void easy_Click(object sender, EventArgs e)
        {
            dificuldade = 2;
        }

        private void medium_Click(object sender, EventArgs e)
        {
            dificuldade = 5;
        }

        private void hard_Click(object sender, EventArgs e)
        {
            dificuldade = 7;
        }



        private void languagedropdown_SelectedIndexChanged(object sender, EventArgs e) //TRADUÇÃO AQUI
        {

        }

        private void panelestats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayRED_Click(object sender, EventArgs e)
        {

            foreach(Bunifu.Framework.UI.BunifuGradientPanel pb in this.Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"))){

                pb.GradientBottomLeft = Color.Red;
                pb.GradientBottomRight = Color.FromArgb(252, 18, 18);
                pb.GradientTopLeft = Color.Red;
                pb.GradientTopRight = Color.DarkRed;

                //avisowindow
            }
        }

        private void bluetheme_Click(object sender, EventArgs e)
        {
            foreach(Bunifu.Framework.UI.BunifuGradientPanel pb in this.Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"))){

                pb.GradientBottomLeft = Color.Cyan;
                pb.GradientBottomRight = Color.Aqua;
                pb.GradientTopLeft = Color.Cyan;
                pb.GradientTopRight = Color.Teal;
            }

        }

        private void purpletheme_Click(object sender, EventArgs e)
        {
            foreach(Bunifu.Framework.UI.BunifuGradientPanel pb in this.Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"))){

                pb.GradientBottomLeft = Color.Purple;
                pb.GradientBottomRight = Color.DarkMagenta;
                pb.GradientTopLeft = Color.Purple;
                pb.GradientTopRight = Color.FromArgb(64, 0, 64);
            }
        }

        private void goldtheme_Click(object sender, EventArgs e)
        {
            foreach(Bunifu.Framework.UI.BunifuGradientPanel pb in this.Controls.OfType<Panel>().Where(x => x.Name.StartsWith("panel"))){

                pb.GradientBottomLeft = Color.Goldenrod;
                pb.GradientBottomRight = Color.Gold;
                pb.GradientTopLeft = Color.Goldenrod;
                pb.GradientTopRight = Color.Yellow;
            }
        }

        private void musictoggle_SwitchedChanged(object sender)
        {
        if (musictoggle.Switched)
            labelonoff.Text = "ON";
        else
            labelonoff.Text = "OFF";
        }

        private void labelonoff_Click(object sender, EventArgs e)
        {

        }



        //************************************** PAINEL OPCOES



        private void loginbutton_Click(object sender, EventArgs e)
        {
             if(paneluserregister.Visible) {
                paneluserregister.Visible = false;
                loginpanel.Visible = true;
             } else
                loginpanel.Visible = true;


        }

        private void saveprofile_Click(object sender, EventArgs e)
        {
           if(loginpanel.Visible) {
                loginpanel.Visible = false;
                paneluserregister.Visible = true;
             } else
                paneluserregister.Visible = true;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
           
            if(registername.Text.StartsWith(" ") || registeremail.Text.StartsWith(" "))
                userwarning.Text = "User or Password Empty";
            else if(password1.Text != password2.Text)
                userwarning.Text = "Passwords do not match";
            else
            {

                string nome = registername.Text;
                string email = registeremail.Text;
                string password = EncryptString(password1.Text);
                
                
                SqlCommand regista = new SqlCommand("usp_regista", connection);
                regista.CommandType = CommandType.StoredProcedure;

                connection.Open();
                ligacao();

                regista.Parameters.AddWithValue("@nome", SqlDbType.NVarChar).Value = nome;
                regista.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = email;
                regista.Parameters.AddWithValue("@palavrapass", SqlDbType.VarChar).Value = password;
                regista.Parameters.AddWithValue("@creditos", SqlDbType.SmallInt).Value = creditos;

                regista.ExecuteNonQuery();
                regista.Dispose();

                connection.Close();

                userwarning.Text = "You are registered";
            }
            
        }


        public string EncryptString(string Message)
        {
            string Passphrase = "SLOT";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string
            return Convert.ToBase64String(Results);
        }


        public string DecryptString(string Message)
        {
            string Passphrase = "SLOT";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }




        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
        if (loginemail.Text.StartsWith(" ") || loginpassword.Text.StartsWith(" "))
            loginwarning.Text = "User or Password Empty";
        else
        {
            
            connection.Open();

            SqlCommand userstats = new SqlCommand("usp_stats_utilizador", connection);
            userstats.CommandType = CommandType.StoredProcedure;

            userstats.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = loginemail.Text;

             using (SqlDataReader reader = userstats.ExecuteReader()){
                while (reader.Read()) { 

                usergamesplayed.Text = reader.GetValue(0).ToString();
                usergameswon.Text = reader.GetValue(1).ToString();
                usergameslost. Text = reader.GetValue(2).ToString();


        }
            }

             connection.Dispose();
             connection.Close();
             loginpanel.Visible = false;
        }


        }
    }
}
