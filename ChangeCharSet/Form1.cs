using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChangeCharSet
{
    public partial class Form1 : Form
    {
        String folderPath = "";
        public Form1()
        {
            InitializeComponent();
             foreach( EncodingInfo ei in Encoding.GetEncodings() ) 
             {
                 Encoding e = ei.GetEncoding();
                 Encode it = new Encode(e.CodePage, e.EncodingName);
                 comboBox1.Items.Add(it);
                 if (e.CodePage == Encoding.UTF8.CodePage)
                 {
                     comboBox1.SelectedItem = it;
                 }
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderPath))
            {
              //  searchFloder(folderPath);
            }
            if (File.Exists(folderPath))
            {
                changefile(folderPath);
            }
        }
        //扫描charset和pageEncoding
        public void ChangCharsetjsp(string file)
        {
            FileEncoder ide = new FileEncoder();
            Encoding defencode = ide.GetEncodingName(new System.IO.FileInfo(file));
            textBox2.Text += folderPath + "原编码:" + defencode.EncodingName;
            Encode sen = (Encode)comboBox1.SelectedItem;
            Encoding eing = Encoding.GetEncoding(sen.Id);
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader objReader = new StreamReader(fs, defencode);
            StringBuilder MyStringBuilder = new StringBuilder();
            string sLine = "";
            String wantfindstr = "charset=";
            String wantfindstr1 ="pageEncoding=\"";
            int linnum = 0;
            while ((sLine = objReader.ReadLine()) != null)
            {
                linnum++;
                int fomchar = 0;
                if ((fomchar = sLine.IndexOf(wantfindstr)) > 0)
                {
                    String charsetend = sLine.Substring(fomchar + wantfindstr.Length);
                    sLine = sLine.Substring(0, fomchar + wantfindstr.Length) + eing.BodyName + charsetend.Substring(charsetend.IndexOf("\""));
                    textBox2.Text += file + "   第" + linnum + "行.." + "\n";
                }
                if ((fomchar = sLine.IndexOf(wantfindstr1)) > 0)
                {
                    String charsetend = sLine.Substring(fomchar + wantfindstr1.Length);
                    sLine = sLine.Substring(0, fomchar + wantfindstr1.Length) + eing.BodyName + charsetend.Substring(charsetend.IndexOf("\""));
                    textBox2.Text += file + "   第" + linnum + "行.." + "\n";
                }
                MyStringBuilder.AppendLine(sLine);
            }
            objReader.Close();
            fs.Close();
            fs = new FileStream(file, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, eing);

            //开始写入
            sw.Write(MyStringBuilder.ToString());
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
        //扫描charset
        public void ChangCharset(string file)
        {
            FileEncoder ide = new FileEncoder();
            Encoding defencode = ide.GetEncodingName(new System.IO.FileInfo(file));
            textBox2.Text += folderPath + "原编码:" + defencode.EncodingName;
            Encode sen = (Encode)comboBox1.SelectedItem;
            Encoding eing = Encoding.GetEncoding(sen.Id);
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader objReader = new StreamReader(fs, defencode);
            StringBuilder MyStringBuilder = new StringBuilder();
            string sLine = "";
            String wantfindstr = "charset=";
            int linnum = 0;
            while ((sLine = objReader.ReadLine()) != null)
            {
                linnum++;
                int fomchar = 0;
                if ((fomchar = sLine.IndexOf(wantfindstr)) > 0)
                {
                    String charsetend = sLine.Substring(fomchar + wantfindstr.Length);
                    sLine = sLine.Substring(0, fomchar + wantfindstr.Length) + eing.BodyName + charsetend.Substring(charsetend.IndexOf("\""));
                    textBox2.Text += file + "   第" + linnum + "行.." + "\n";
                }
                MyStringBuilder.AppendLine(sLine);
            }
            objReader.Close();
            fs.Close();
            fs = new FileStream(file, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, eing);

            //开始写入
            sw.Write(MyStringBuilder.ToString());
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
        //只转换一下编码
        public void ChangEncoding(string file)
        {
            FileEncoder ide = new FileEncoder();
            Encoding defencode = ide.GetEncodingName(new System.IO.FileInfo(file));
            textBox2.Text += folderPath + "原编码:" + defencode.EncodingName;
            Encode sen = (Encode)comboBox1.SelectedItem;
            Encoding eing = Encoding.GetEncoding(sen.Id);
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader objReader = new StreamReader(fs, defencode);
            StringBuilder MyStringBuilder = new StringBuilder();
            string sLine = "";
            int linnum = 0;
            while ((sLine = objReader.ReadLine()) != null)
            {
                linnum++;
                MyStringBuilder.AppendLine(sLine);
            }
            objReader.Close();
            fs.Close();
            fs = new FileStream(file, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, eing);
            //开始写入
            sw.Write(MyStringBuilder.ToString());
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
        void changefile(string file)
        {
                       
            if (Path.GetExtension(file).Equals(".jsp") && chbjsp.Checked)
            {
                ChangCharsetjsp(file);
                textBox2.Text += "ChangCharsetjsp" + file + "\n";
            }
            if (Path.GetExtension(file).Equals(".html") && chbhtml.Checked)
            {
                ChangCharset(file);
                textBox2.Text += "ChangCharsetjsp" + file + "\n";
            }
            if (Path.GetExtension(file).Equals(".htm") && chbhtm.Checked)
            {
                ChangCharset(file);
                textBox2.Text += "ChangCharsetjsp" + file + "\n";
            }
            if (Path.GetExtension(file).Equals(".java") && chbjava.Checked)
            {
                ChangEncoding(file);
                textBox2.Text += "ChangCharsetjava" + file + "\n";
            }
            if (Path.GetExtension(file).Equals(".js") && chbjs.Checked)
            {
                ChangEncoding(file);
                textBox2.Text += "ChangCharsetjava" + file + "\n";
            }
            if (Path.GetExtension(file).Equals(".css") && chbcss.Checked)
            {
                ChangEncoding(file);
                textBox2.Text += "ChangCharsetjava" + file + "\n";
            }
            if (Path.GetExtension(file).Equals(".xml") && chbxml.Checked)
            {
                ChangEncoding(file);
                textBox2.Text += "ChangCharsetjava" + file + "\n";
            }
        }
        void searchFloder(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            foreach (string file in files)
            {
                changefile(file);
            }
            string[] folders = Directory.GetDirectories(folder);
            foreach (string fold in folders)
            {
                searchFloder(fold);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            folderPath = folderDlg.SelectedPath;
            textBox1.Text = folderPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = openFileDialog.FileName;
            }
            textBox1.Text = folderPath;
        }
    }
}
