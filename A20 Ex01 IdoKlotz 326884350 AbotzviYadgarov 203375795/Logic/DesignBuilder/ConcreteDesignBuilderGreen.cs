using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.UI;

namespace A20_Ex01_IdoKlotz_326884350_AbotzviYadgarov_203375795.Logic.DesignBuilder
{
    public class ConcreteDesignBuilderGreen : DesignBuilder
    {
        private FormDesign m_DesignForm = new FormDesign();

        public override void SetBackgroundColor()
        {
            Color col = ColorTranslator.FromHtml("#BAD472");
            m_DesignForm.BackColor = col;
        }

        public override void SetButtonsColor()
        {
            Color col = ColorTranslator.FromHtml("#A16F1B");
            m_DesignForm.SetButtonColor(col);
        }

        public override void SetListboxColor()
        {
            Color col = ColorTranslator.FromHtml("#E1F692");
            m_DesignForm.SetListBoxBackcolor(col);
        }

        public override Form GetResult()
        {
            return m_DesignForm;
        }
    }
}
