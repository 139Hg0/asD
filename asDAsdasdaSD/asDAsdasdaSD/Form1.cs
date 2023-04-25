using asDAsdasdaSD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asDAsdasdaSD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_testDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.demo_testDataSet.User);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (demo_testEntities context = new demo_testEntities()) 
            
            {
                var asd = context.User.FirstOrDefault(ddd => ddd.Login == textBox1.Text && ddd.Password == textBox2.Text);
                if (asd != null) 
                
                {
                    MessageBox.Show(asd.Name);
                }
            }
        }
    }
}
