using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.UI
{
    public partial class FormDesign : Form
    {
        public FormDesign()
        {
            InitializeComponent();
        } 

        public void SetButtonColor(Color i_Color)
        {
            loginButton.BackColor = i_Color;
            publishPostButton.BackColor = i_Color;
        }

        public void SetListBoxBackcolor(Color i_Color)
        {
            listBox1.BackColor = i_Color;
            eventsListBox.BackColor = i_Color;
            postBox.BackColor = i_Color;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
                
        }

        public void FormDesign_Load(object sender, EventArgs e)
        {
       
        }
    }
}
