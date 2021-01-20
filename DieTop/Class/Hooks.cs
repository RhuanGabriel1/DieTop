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


        public bool FormValidator(bool check, int call ,string text , string textDefault, int condition )
        {
            if (check == false)
            {
                return false;
            }
                // 0 para < && 1 para >
               else if (call == 0)
                {
                    if (text.Length < condition && text != textDefault)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (call == 1)
                {
                    if (text.Length > condition && text != textDefault)
                    {
                    return true;
                    }
                    else
                    {

                    return false;
                    }
                }
                else if (call == 2 && text != textDefault)
                {
                    if (text.Length == condition)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                
            }
           

        }

        //Accept only Numbers
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
