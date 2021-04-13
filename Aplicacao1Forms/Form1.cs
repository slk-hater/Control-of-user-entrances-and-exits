using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao1Forms
{
    public partial class Form1 : Form
    {
        string name, surname, locale, sex;
        sbyte age;

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] words = listBox1.SelectedItem.ToString().Split(',');
                nameBox.Text = words[0];
                surnameBox.Text = words[1].TrimStart();
                localeBox.Text = words[2].TrimStart();
                ageBox.Text = words[3].TrimStart().Replace(" anos", "");
                sexBox.Text = words[4].TrimStart().Replace("asculino", "").Replace("eminino", "");
            }
        }

        private void clearSelectedBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            ClearBoxesText();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ClearBoxesText();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void submeterBtn_Click(object sender, EventArgs e)
        {
            string sAge, sSex = "";
            name = nameBox.Text.Substring(0, nameBox.Text.Length);
            surname = surnameBox.Text.Substring(0, surnameBox.Text.Length);
            locale = localeBox.Text.Substring(0, localeBox.Text.Length);
            sbyte.TryParse(ageBox.Text.Substring(0, ageBox.Text.Length), out age);
            char.TryParse(sexBox.Text.Substring(0, sexBox.Text.Length), out char s);
            sex = s.ToString().ToUpper();
            ClearBoxesText();
            sAge = age + " anos";
            if (sex == "M") sSex = "Masculino";
            else if (sex == "F") sSex = "Feminino";
            listBox1.Items.Add($"{name}, {surname}, {locale}, {sAge}, {sSex}, {DateTime.Now}");
        }
        public void ClearBoxesText()
        {
            nameBox.Clear();
            surnameBox.Clear();
            localeBox.Clear();
            ageBox.Clear();
            sexBox.Clear();
        }
    }
}
