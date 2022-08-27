using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Manipulação e visualisação de arquivos

namespace Auditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
            }
            catch (Exception)
            { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            
            label1.Text = folderBrowserDialog1.SelectedPath;
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            String[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            listBox1.Items.AddRange(files);

            DirectoryInfo dir_files = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
            foreach (var fil in files2)
            {
                listBox2.Items.Add(fil.Name);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            label1.Text = folderBrowserDialog1.SelectedPath;
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            String[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.bmp");
            listBox1.Items.AddRange(files);
            files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
            listBox1.Items.AddRange(files);
            files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.png");
            listBox1.Items.AddRange(files);

            DirectoryInfo dir_files = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] files2 = dir_files.GetFiles("*.bmp", SearchOption.TopDirectoryOnly);
            foreach (var fil in files2){ listBox2.Items.Add(fil.Name);}
            files2 = dir_files.GetFiles("*.png", SearchOption.TopDirectoryOnly);
            foreach (var fil in files2) { listBox2.Items.Add(fil.Name); }
            files2 = dir_files.GetFiles("*.jpg", SearchOption.TopDirectoryOnly);
            foreach (var fil in files2) { listBox2.Items.Add(fil.Name); 
    
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(folderBrowserDialog1.SelectedPath + "\\" + listBox2.SelectedItem.ToString());
            }
            catch (Exception)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] diretorios = Directory.GetDirectories( @"Y:\CFTV\AM_Contagem\2022\08-Agosto\14");

            foreach (var diretori in diretorios) 
            { 
            listBox1.Items.Add("*"+ diretorios);
            }
        }

        private string[] Getfiles(string path)
        {
            return Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        }

        private void Btn_Verificador_Click(object sender, EventArgs e)
        {
            //Verificador de pastas existente
            if (Directory.Exists(@"D:\Users\50036490\OneDrive - ArcelorMittal\Desktop\BRM-PABLO\154693"))
                MessageBox.Show("Pasta existente");
            else
                MessageBox.Show("Nãso existe");

        }
    }
}
