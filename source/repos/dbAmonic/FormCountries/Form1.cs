using MisClases;

namespace FormCountries
{
    public partial class Form1 : Form
    {
        int segundos = 10;
        int intentosF = 0;
        UserDAO userDAO = new UserDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            UserDAO usuario = new UserDAO();


            bool acceso = usuario.Login(

                textUsername.Text,
                textPassword.Text


            );

            if (acceso)
            {
                MessageBox.Show("Bienvenido");
                Amonic form = new Amonic();
                form.Show();
                this.Hide();
            }
            else
            {
                intentosF++;
                if (intentosF >= 3)
                {
                    segundos = 10;
                    labelsegundos.Visible = true;
                    labelsegundos.Text = "Espere " + segundos + " " + "segundos";
                    btnLogin.Enabled = false;
                    timer1.Start();

                }
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            labelsegundos.Text = "Espere " + segundos + " " + "segundos";
            if (segundos <= 0)
            {
                timer1.Stop();
                btnLogin.Enabled = true;
                labelsegundos.Text = "";
                labelsegundos.Visible = false;
                intentosF = 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';

        }
    }
}


