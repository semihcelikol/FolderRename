using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GeneralProcesses generalProcesses = new GeneralProcesses();
        public string[] selectedFilePath;
        string directoryName;
        string fileName, fromFile;
        string toFile;
        FileInfo fi;

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            openFileDialog1.Multiselect = true;

            selectedFilePath = openFileDialog1.FileNames;

            string[] file = selectedFilePath;

            for (int i = 0; i < file.Length; i++)
            {
                listBoxFirstFile.Items.Add(file[i]);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            #region Manuel isim değiştirme işlemleri
            //Manuel isim değiştirme işlemleri
            if (panelManuel.Enabled)
            {
                if (checkBoxManuel.Checked)
                {
                    if (txtManuel.Text != string.Empty && listBoxFirstFile.Items.Count != 0)
                    {
                        string selectedRecord = listBoxFirstFile.SelectedItem.ToString();

                        if (File.Exists(selectedRecord))
                        {
                            File.Move(selectedRecord, txtManuel.Text);
                            generalProcesses.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");
                            listBoxChangeFile.Items.Add(txtManuel.Text);
                            listBoxFirstFile.Items.Clear();
                        }
                        else
                        {
                            generalProcesses.messageErrorShow("Başarısız terkar deneyin.", "HATA");
                        }
                    }
                    else
                    {
                        generalProcesses.messageErrorShow("Boş geçtiniz","HATA");
                    }
                }
            }
            //
            #endregion

            #region Otomatik isim değiştirme işlemleri 1
            //Otomatik isim değiştirme işlemleri 1
            if (panelAuto1.Enabled)
            {
                if (checkBoxAutoChange1.Checked)
                {
                    int autoChangeValue = Convert.ToInt32(cbAutoChange1.Text);

                    if (cbAutoChange1.Text != string.Empty && listBoxFirstFile.Items.Count != 0)
                    {
                        //Seçili dosyalarda dönüp, sırayla dosya isimlerinin başına sayacı yazar.
                        foreach (string item in listBoxFirstFile.Items)
                        {
                            fi = new FileInfo(item);
                            fromFile = fi.FullName;
                            fileName = fi.Name;
                            directoryName = fi.DirectoryName;

                            toFile = autoChangeValue.ToString() + fileName;
                            toFile = directoryName + @"\" + toFile;

                            File.Move(fromFile, toFile);

                            autoChangeValue++;
                            listBoxChangeFile.Items.Add(toFile);
                        }
                        generalProcesses.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");
                        cbAutoChange1.Text = string.Empty;
                        listBoxFirstFile.Items.Clear();
                    }
                    else
                    {
                        generalProcesses.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            //
            #endregion

            #region Otomatik isim değiştirme işlemleri 2
            //Otomatik isim değiştirme işlemleri 2
            if (panelAuto2.Enabled)
            {
                if (checkBoxAutoChange2.Checked)
                {
                    if (cbAutoChange2.Text != string.Empty && listBoxFirstFile.Items.Count != 0 )
                    {
                        int autoChangeValue = Convert.ToInt32(cbAutoChange2.Text);
                        int listItemIndexOf;
                        string fromFile, toFile, toFile2;
                        string subStrFile,subStrFile2;

                        //Seçili dosyalarda dönüp, sırayla dosya isimlerinin başına sayacı yazar.
                        foreach (string item2 in listBoxFirstFile.Items)
                        {
                            fromFile = item2;

                            //dosya da ki son slash işaretinin indexi alınır.
                            listItemIndexOf = fromFile.LastIndexOf("\\");
                            
                            //listItemIndexOf + 1 ekleyip son slahtan sonra ki dosya adını alıyoruz.
                            subStrFile = fromFile.Substring(1 + listItemIndexOf).ToString();
                            //Slash ile Nokta arasında ki veri alınır.
                            subStrFile2 = subStrFile.Substring(1, subStrFile.IndexOf(".") - 1).ToString();

                            //son slash'tan sonra dosya adı geliyor, dosya adının önüne sayacı yazıyoruz.
                            toFile = subStrFile2 + autoChangeValue;

                            //eski dosya adını, yeni dosya adı ile değiştiriyoruz.
                            toFile2 = fromFile.Replace(subStrFile2, toFile);

                            //Yeni dosya adlı verimizi, eski dosyamızın olduğu yere taşıyoruz.
                            File.Move(fromFile, toFile2);

                            listBoxChangeFile.Items.Add(toFile2);
                            autoChangeValue++;
                        }
                        generalProcesses.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");
                        cbAutoChange2.Text = string.Empty;
                        listBoxFirstFile.Items.Clear();
                    }
                    else
                    {
                        generalProcesses.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            //
            #endregion

            #region Otomatik isim değiştirme işlemleri 3
            //Otomatik isim değiştirme işlemleri 3
            if (panelAuto3.Enabled)
            {
                if (checkBoxAutoChange3.Checked)
                {
                    int autoChangeValue = Convert.ToInt32(cbAutoChange3.Text);

                    if (cbAutoChange3.Text != string.Empty && listBoxFirstFile.Items.Count != 0)
                    {
                        //Seçili dosyalarda dönüp, sırayla dosya isimlerine sayacı yazar.
                        foreach (string item3 in listBoxFirstFile.Items)
                        {
                            fi = new FileInfo(item3);
                            fromFile = fi.FullName;
                            directoryName = fi.DirectoryName;
                            
                            toFile = autoChangeValue.ToString() + fi.Extension;
                            toFile = directoryName + @"\" + toFile;

                            File.Move(fromFile, toFile);

                            autoChangeValue++;
                            listBoxChangeFile.Items.Add(toFile);
                        }

                        generalProcesses.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");

                        listBoxFirstFile.Items.Clear();
                        cbAutoChange3.Text = string.Empty;
                        autoChangeValue = 0;
                    }
                    else
                    {
                        generalProcesses.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            //
            #endregion
        }

        private void listBoxFirstFile_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxFirstFile.SelectedIndex == -1)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "SEÇİM YAPMADINIZ";
            }
            else
            {
                lblWarning.Visible = false;
                lblWarning.Text = "";
                string secilenkayit = listBoxFirstFile.SelectedItem.ToString();
                txtManuel.Text = secilenkayit;
            }
        }

        private void outlookLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:semihcelikol@outlook.com");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generalProcesses.messageInformationShow("Ücretsiz Dosya isimlerini değiştirme programıdır.\nVersion 3\nsemihcelikol.com", "HAKKINDA");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxFirstFile.Items.Clear();
            listBoxChangeFile.Items.Clear();
            txtManuel.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            generalProcesses.messageInformationShow("Seçtiğiniz dosyaların başına, seçtiğiniz sayıdan başlayarak, seçilen dosya kadar o sayıyı dosya isminin başına koyup ekler.\n\nÖrneğin 1'i seçtiğiniz ve 10 tane dosyanız var. Bu dosyaların başına 1'den başlayıp 1dosya,2dosya,3dosya... yaparak 10dosya yazıp bitirir.", "Nedir ?");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            generalProcesses.messageInformationShow("Seçtiğiniz dosyaların sonuna, seçtiğiniz sayıdan başlayarak, seçilen dosya kadar o sayıyı dosya isminin sonuna koyup ekler.\n\nÖrneğin 1'i seçtiğiniz ve 10 tane dosyanız var. Bu dosyaların başına 1'den başlayıp dosya1,dosy2a,dosya3... yaparak dosya10 yazıp bitirir.", "Nedir ?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxManuel.Checked = true;
            panelManuel.Enabled = true;

            panelAuto1.Enabled = false;
            panelAuto2.Enabled = false;
            panelAuto3.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManuel.Checked)
            {
                panelAuto1.Enabled = false;
                panelAuto2.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelAuto1.Enabled = true;
                panelAuto2.Enabled = true;
                panelAuto3.Enabled = true;
            }
        }

        private void checkBoxAutoChange1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoChange1.Checked)
            {
                panelManuel.Enabled = false;
                panelAuto2.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelAuto2.Enabled = true;
                panelAuto3.Enabled = true;
            }
        }

        private void checkBoxAutoChange2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoChange2.Checked)
            {
                panelManuel.Enabled = false;
                panelAuto1.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelAuto1.Enabled = true;
                panelAuto3.Enabled = true;
            }
        }

        private void linkLabelWebUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://semihcelikol.com");
        }

        private void checkBoxAutoChange3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoChange3.Checked)
            {
                panelManuel.Enabled = false;
                panelAuto1.Enabled = false;
                panelAuto2.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelAuto1.Enabled = true;
                panelAuto2.Enabled = true;
            }
        }

        private void btnInformatin3_Click(object sender, EventArgs e)
        {
            generalProcesses.messageInformationShow("Seçilen tüm dosyalarda dönüp, mevcut ismi siler ve seçtiğiniz sayıdan başlayarak dosya adına sıralı olarak sayıyı yazar.\n\nÖrneğin 1'i seçtiğiniz ve 10 tane dosyanız var.Bu dosya adlarını 1'den başlayıp 1,2,3.. yaparak 10 yazıp bitirir.", "Nedir ?");
        }
    }
}
