using codefirstapproachentityframework.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codefirstapproachentityframework
{
    public partial class Form1 : Form
    {
        employee model = new employee();
        DatabaseContext db = new DatabaseContext();
        public Form1()
        {
            InitializeComponent();
            bindGridView();
        }
        void bindGridView()
        {
            dataGridView1.DataSource = db.employees.ToList<employee>();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            model.name = nametextBox.Text;
            model.gender = gendercomboBox.SelectedItem.ToString();
            model.age = Convert.ToInt32(agetextBox.Text);
            model.designation = desigtextBox.Text;
            db.employees.Add(model);
           int a= db.SaveChanges();
            if(a>0)
            {
                MessageBox.Show("Data Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindGridView();
            }

            else
            {
                MessageBox.Show("Data Not Inserted!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
