using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hooks
{
     class Hooks
    {
        public void ChangeInputTextClicked(TextBox textBox, String text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.TextAlign = HorizontalAlignment.Left;
            }
        }
        //If clicked button text === "", will turn all for default
        public void ChangeInputTextClickedNull(TextBox textBox, String text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Silver;
                textBox.TextAlign = HorizontalAlignment.Center;
            }
        }
        //Will Return Datas
    }
}
