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
        MessageHelper messageHelper = new MessageHelper();
        public string[] selectedFilePath;
        string directoryName;
        string fileName, fromFile;
        string toFile;
        FileInfo fi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            openFileDialog1.Multiselect = true;

            selectedFilePath = openFileDialog1.FileNames;

            foreach (var item in selectedFilePath)
            {
                listBoxFirstFile.Items.Add(item);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (panelManuel.Enabled)
            {
                this.manuelChange();
            }

            if (panelManuel2.Enabled)
            {
                this.manuelChange2();
            }

            if (panelAuto1.Enabled)
            {
                this.autoChange1();
            }

            if (panelAuto2.Enabled)
            {
                this.autoChange2();
            }

            if (panelAuto3.Enabled)
            {
                this.autoChange3();
            }
        }

        /// <summary>
        /// Manuel isim değiştirme işlemleri
        /// </summary>
        private void manuelChange()
        {
            try
            {
                if (checkBoxManuel.Checked)
                {
                    if (txtManuel.Text != string.Empty && listBoxFirstFile.Items.Count != 0)
                    {
                        string selectedRecord = listBoxFirstFile.SelectedItem.ToString();

                        if (File.Exists(selectedRecord))
                        {
                            File.Move(selectedRecord, txtManuel.Text + txtManuelExtension.Text);
                            messageHelper.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");

                            //Değişen hali listBox'a yazılır.
                            listBoxChangeFile.Items.Add(txtManuel.Text);
                            listBoxFirstFile.Items.Clear();
                        }
                        else
                        {
                            messageHelper.messageErrorShow("Başarısız terkar deneyin.", "HATA");
                        }
                    }
                    else
                    {
                        messageHelper.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            catch (Exception ex)
            {
                messageHelper.messageErrorShow(ex.Message, "Hata");
            }
        }

        /// <summary>
        /// Otomatik isim değiştirme işlemleri 1
        /// </summary>
        private void autoChange1()
        {
            try
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
                        messageHelper.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");
                        cbAutoChange1.Text = string.Empty;
                        listBoxFirstFile.Items.Clear();
                    }
                    else
                    {
                        messageHelper.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            catch (Exception ex)
            {
                messageHelper.messageErrorShow(ex.Message, "Hata");
            }
        }

        /// <summary>
        /// Otomatik isim değiştirme işlemleri 2
        /// </summary>
        private void autoChange2()
        {
            try
            {
                if (checkBoxAutoChange2.Checked)
                {
                    if (cbAutoChange2.Text != string.Empty && listBoxFirstFile.Items.Count != 0)
                    {
                        int autoChangeValue = Convert.ToInt32(cbAutoChange2.Text);
                        int listItemIndexOf;
                        string fromFile, toFile, toFile2;
                        string subStrFile, subStrFile2;

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
                        messageHelper.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");
                        cbAutoChange2.Text = string.Empty;
                        listBoxFirstFile.Items.Clear();
                    }
                    else
                    {
                        messageHelper.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            catch (Exception ex)
            {
                messageHelper.messageErrorShow(ex.Message, "Hata");
            }
        }

        /// <summary>
        /// Otomatik isim değiştirme işlemleri 3
        /// </summary>
        private void autoChange3()
        {
            try
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

                        messageHelper.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");

                        listBoxFirstFile.Items.Clear();
                        cbAutoChange3.Text = string.Empty;
                        autoChangeValue = 0;
                    }
                    else
                    {
                        messageHelper.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            catch (Exception ex)
            {
                messageHelper.messageErrorShow(ex.Message, "Hata");
            }
            
        }

        /// <summary>
        /// Manuel isim değiştirme işlemleri 2
        /// </summary>
        private void manuelChange2()
        {
            try
            {
                if (checkBoxManuel2.Checked)
                {
                    int autoChangeValue = Convert.ToInt32(cbManuel2Change.Text);

                    if (cbManuel2Change.Text != string.Empty && listBoxFirstFile.Items.Count != 0)
                    {
                        //Seçili dosyalarda dönüp, sırayla dosya isimlerinin başına sayacı yazar.
                        foreach (string item in listBoxFirstFile.Items)
                        {
                            fi = new FileInfo(item);
                            fromFile = fi.FullName;
                            fileName = fi.Name;
                            directoryName = fi.DirectoryName;
                            string fiExtension = fi.Extension;

                            toFile = txtManuel2.Text.ToString() + txtManuelExtension2.Text + autoChangeValue;
                            toFile = directoryName + @"\" + toFile + fiExtension;

                            File.Move(fromFile, toFile);

                            autoChangeValue++;
                            listBoxChangeFile.Items.Add(toFile);
                        }
                        messageHelper.messageInformationShow("Dosya isimleri Başarılı bir şekilde değiştirildi.", "Bilgi");
                        cbAutoChange1.Text = string.Empty;
                        listBoxFirstFile.Items.Clear();
                    }
                    else
                    {
                        messageHelper.messageErrorShow("Boş geçtiniz", "HATA");
                    }
                }
            }
            catch (Exception ex)
            {
                messageHelper.messageErrorShow(ex.Message, "Hata");
            }
        }

        private void listBoxFirstFile_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtManuelTextWrite();
        }

        /// <summary>
        /// Manuel değişim ile ilgili TextBox'lar doldurulur.
        /// </summary>
        private void txtManuelTextWrite()
        {
            string fileExtension = string.Empty;
            
            if (listBoxFirstFile.SelectedIndex == -1)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "SEÇİM YAPMADINIZ";
            }
            else
            {
                lblWarning.Visible = false;
                lblWarning.Text = "";

                //En sonda ki .(nokta) işaretinin indexi alınıyor.
                int lastIndexChar = listBoxFirstFile.SelectedItem.ToString().LastIndexOf(".");

                //Dosya tam yolu ve adı txtManuel TextBox'ına yazılır.
                string baseFile = listBoxFirstFile.SelectedItem.ToString().Substring(0, lastIndexChar);
                txtManuel.Text = baseFile;

                //Dosya uzantısı txtManuelExtension TextBox'ına yazılır.
                fileExtension = listBoxFirstFile.SelectedItem.ToString().Substring(lastIndexChar);
                txtManuelExtension.Text = fileExtension;
            }
        }

        private void outlookLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:semihcelikol@outlook.com");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            messageHelper.messageInformationShow("Ücretsiz Dosya isimlerini değiştirme programıdır.\nVersion 3\nsemihcelikol.com", "HAKKINDA");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxFirstFile.Items.Clear();
            listBoxChangeFile.Items.Clear();
            txtManuel.Clear();
            txtManuel2.Clear();
            txtManuelExtension2.Clear();
        }

        private void btnInformatin1_Click(object sender, EventArgs e)
        {
            messageHelper.messageInformationShow("Seçtiğiniz dosyaların başına, seçtiğiniz sayıdan başlayarak, seçilen dosya kadar o sayıyı dosya isminin başına koyup ekler.\n\nÖrneğin 1'i seçtiğiniz ve 10 tane dosyanız var. Bu dosyaların başına 1'den başlayıp 1dosya,2dosya,3dosya... yaparak 10dosya yazıp bitirir.", "Nedir ?");
        }

        private void btnInformatin2_Click(object sender, EventArgs e)
        {
            messageHelper.messageInformationShow("Seçtiğiniz dosyaların sonuna, seçtiğiniz sayıdan başlayarak, seçilen dosya kadar o sayıyı dosya isminin sonuna koyup ekler.\n\nÖrneğin 1'i seçtiğiniz ve 10 tane dosyanız var. Bu dosyaların başına 1'den başlayıp dosya1,dosy2a,dosya3... yaparak dosya10 yazıp bitirir.", "Nedir ?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxManuel.Checked = true;
            panelManuel.Enabled = true;
            panelManuel2.Enabled = false;

            panelAuto1.Enabled = false;
            panelAuto2.Enabled = false;
            panelAuto3.Enabled = false;
        }

        private void checkBoxManuel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManuel.Checked)
            {
                panelManuel2.Enabled = false;
                panelAuto1.Enabled = false;
                panelAuto2.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelManuel2.Enabled = true;
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
                panelManuel2.Enabled = false;
                panelAuto2.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelManuel2.Enabled = true;
                panelAuto2.Enabled = true;
                panelAuto3.Enabled = true;
            }
        }

        private void checkBoxAutoChange2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoChange2.Checked)
            {
                panelManuel.Enabled = false;
                panelManuel2.Enabled = false;
                panelAuto1.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelManuel2.Enabled = true;
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
                panelManuel2.Enabled = false;
                panelAuto1.Enabled = false;
                panelAuto2.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelManuel2.Enabled = true;
                panelAuto1.Enabled = true;
                panelAuto2.Enabled = true;
            }
        }

        private void listBoxFirstFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listBoxFirstFile.SelectedIndex != -1)
            {
                if (e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Delete
                || e.KeyChar == (char)Keys.Escape)
                {
                    listBoxFirstFile.Items.RemoveAt(listBoxFirstFile.SelectedIndex);
                }
            }
        }

        private void listBoxFirstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFirstFile.SelectedIndex != -1)
            {
                this.txtManuelTextWrite();
            }
        }

        private void checkBoxManuel2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManuel2.Checked)
            {
                panelManuel.Enabled = false;
                panelAuto1.Enabled = false;
                panelAuto2.Enabled = false;
                panelAuto3.Enabled = false;
            }
            else
            {
                panelManuel.Enabled = true;
                panelAuto1.Enabled = true;
                panelAuto2.Enabled = true;
                panelAuto3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageHelper.messageInformationShow("Örneğin Dosya ismi:AA, Ayraç:_ ve Başlangıç sayısı :1 ise AA_1,AA_2.. şeklinde ilerleyerek tüm isimleri değiştirir.", "Nedir ?");
        }

        private void btnInformatin3_Click(object sender, EventArgs e)
        {
            messageHelper.messageInformationShow("Seçilen tüm dosyalarda dönüp, mevcut ismi siler ve seçtiğiniz sayıdan başlayarak dosya adına sıralı olarak sayıyı yazar.\n\nÖrneğin 1'i seçtiğiniz ve 10 tane dosyanız var.Bu dosya adlarını 1'den başlayıp 1,2,3.. yaparak 10 yazıp bitirir.", "Nedir ?");
        }
    }
}
