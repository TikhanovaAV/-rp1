using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaaaa
{
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }
        public Agent agent { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (agent == null)
            {
                agentBindingSource.AddNew();

                Text = " Добавление нового клиента ";
            }
            else
            {
                agentBindingSource.Add(agent);
                iDTextBox.ReadOnly = true;
                Text = " Корректировка клиента " + agent.ID;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (agent == null)
            {
                agent = (Agent)agentBindingSource.List[0];
                db.Agent.Add(agent);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ошибка " + ex.InnerException.InnerException.Message);
            }
        }

        private void agentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
          
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
