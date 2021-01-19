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


        //Accept onltNumbers
        public void AcceptOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

            }
        }
            //Accept only Letters
            public void AcceptOnlyLetters(KeyPressEventArgs e)
            {
                if (char.IsDigit(e.KeyChar))

                {
                    e.Handled = true;

                }
            }

        //ONLY FOR PASSWORD BOXES
        public void TurnItToPassword(TextBox textBox,string text)
        {
            if (textBox.Text != text)
            {
                textBox.PasswordChar = '*';
            }
            else
            {
                textBox.PasswordChar = default;
            }
        }
        public void ChangeInputTextClicked(TextBox textBox, string text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.TextAlign = HorizontalAlignment.Left;
            }
        }
        //If clicked button text === "", will turn all for default
        public void ChangeInputTextClickedNull(TextBox textBox, string text)
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
