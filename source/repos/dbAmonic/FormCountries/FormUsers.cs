using MisClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace FormCountries
{
    public partial class Amonic : Form
    {
        private List<Users> ListaUsers;
        public Amonic()
        {
            InitializeComponent();


        }

        private void Amonic_Load(object sender, EventArgs e)
        {

            UserDAO dao = new UserDAO();
            OfficesDAO officesDAO = new OfficesDAO();


            ListaUsers = dao.ObtenerUsers();

            dataUsers.DataSource = ListaUsers;



            dataUsers.Columns["Password"].Visible = false;
            dataUsers.Columns["UserID"].Visible = false;
            dataUsers.Columns["Active"].Visible = false;
            dataUsers.Columns["BirthDate"].Visible = false;

            PintarFilas();
            comboOffices.Items.Add("All Offices");


            foreach (Offices oficina in officesDAO.ObtenerOffices())
            {
                comboOffices.Items.Add(oficina.Title);
            }
            comboOffices.SelectedIndex = 0;
        }

        private void OcultarColumnas()
        {
            dataUsers.Columns["Password"].Visible = false;
            dataUsers.Columns["UserID"].Visible = false;
            dataUsers.Columns["Active"].Visible = false;
            dataUsers.Columns["BirthDate"].Visible = false;
        }
        private void comboOffices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOffices.Text == "All Offices")
            {
                dataUsers.DataSource = null;
                dataUsers.DataSource = ListaUsers;

                OcultarColumnas();
                PintarFilas();
                return;
            }

            var filtrados = ListaUsers
                .Where(u => u.TitleOffices == comboOffices.Text)
                .ToList();

            dataUsers.DataSource = null;
            dataUsers.DataSource = filtrados;

            OcultarColumnas();
            PintarFilas();
        }

        private void PintarFilas()
        {
            foreach (DataGridViewRow fila in dataUsers.Rows)
            {
                if (fila.Cells["Active"].Value != null)
                {
                    bool activo = Convert.ToBoolean(fila.Cells["Active"].Value);

                    if (activo)
                    {
                        fila.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

            }

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddUser form = new AddUser();
            form.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
