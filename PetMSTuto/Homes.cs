using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMSTuto
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            CountOverallVaccination();
            CountTodayVaccination();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }
       
        private void CountOverallVaccination()
        {

        }

        private void CountTodayVaccination()
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCreateNew_Click(object sender, EventArgs e)
        {
            AddData Obj = new AddData();
            Obj.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddData Obj = new AddData();
            Obj.Show();
        }

        private void lbCreateNew_Click(object sender, EventArgs e)
        {
            AddData Obj = new AddData();
            Obj.Show();
        }

    }
}
