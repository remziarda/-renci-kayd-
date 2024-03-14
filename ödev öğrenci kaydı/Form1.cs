using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_öğrenci_kaydı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable ogrenciTablosu;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && radioButton1.Checked || radioButton2.Checked)
            {
                ogrenciTablosu.Rows.Add(textBox1.Text, textBox2.Text, (radioButton1.Checked) ? ("Erkek") : ("Kadın"));
                MessageBox.Show("Öğrenci kaydı yapıldı!");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciTablosu = new DataTable();
            ogrenciTablosu.Columns.Add("Öğrenci Adı", typeof(String));
            ogrenciTablosu.Columns.Add("Öğrenci Soyadı", typeof(String));
            ogrenciTablosu.Columns.Add("Öğrenci Cinsiyeti", typeof(String));
            dataGridView1.DataSource = ogrenciTablosu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırı al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // DataGridView'den seçili satırı kaldır
                dataGridView1.Rows.Remove(selectedRow);

                MessageBox.Show("Öğrenci kaydı silindi!");
            }
            else
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçin.");
            }
        }

        }
    }

