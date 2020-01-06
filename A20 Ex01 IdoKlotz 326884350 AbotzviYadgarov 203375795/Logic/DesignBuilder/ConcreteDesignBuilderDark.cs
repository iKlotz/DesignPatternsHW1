using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.UI;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic.DesignBuilder
{
    class ConcreteDesignBuilderDark : DesignBuilder
    {
        public FormDesign m_DesignForm = new FormDesign();


        public override void SetBackgroundColor()
        {
            Color col = ColorTranslator.FromHtml("#393f4d");
            m_DesignForm.BackColor = col;
        }

        public override void SetButtonsColor()
        {
            Color col = ColorTranslator.FromHtml("#d4d4dc");
            m_DesignForm.SetButtonColor(col);
        }

        public override void SetListboxColor()
        {
            Color col = ColorTranslator.FromHtml("#fceed1");
            m_DesignForm.SetListBoxBackcolor(col);
        }

        public override Form GetResult()
        {
            return m_DesignForm;
        }

    }
}
