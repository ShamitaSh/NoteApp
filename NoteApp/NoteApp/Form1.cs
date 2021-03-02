using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Title"].Width = 280;

            foreach (FontFamily font in FontFamily.Families)
            {
                Font.Items.Add(font.Name.ToString());
            }

            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    comboBox1.Items.Add(prop.Name);
                    
                }
            }

        }
       private void titlebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void messagebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            titlebox.Clear();
            messagebox.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(titlebox.Text, messagebox.Text);
            titlebox.Clear();
            messagebox.Clear();



        }

        private void read_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromName(comboBox1.Text);
            titlebox.ForeColor = color;
            messagebox.ForeColor = color;

        }

        private void Font_TextChanged(object sender, EventArgs e)
        {
            try
            {
                titlebox.Font = new Font(Font.Text, titlebox.Font.Size);
                messagebox.Font = new Font(Font.Text, messagebox.Font.Size);
            }
            catch { }
        }

        private void comboBox1_ForeColorChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                titlebox.Text = table.Rows[index].ItemArray[0].ToString();
                messagebox.Text = table.Rows[index].ItemArray[1].ToString();
            }

        }
    }
}
