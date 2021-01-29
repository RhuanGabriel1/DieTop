﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hooks
{
    class Hooks 
    {
        //Validação de Caloria para Simulação RealTime
        public void RealTimeCal(string name1, string name2, string name3, string num1, string num2, string num3)
        {

            
                Console.WriteLine(name1);
                Console.WriteLine(num1);
            
                Console.WriteLine(name2);
                Console.WriteLine(num2 );
            
            
                Console.WriteLine(name3);
                Console.WriteLine(num3);
            
            


        }


        //Validação de Formulário
        public bool FormValidator(bool check, int call ,string text , string textDefault, int condition )
        {
            if (!check)
            {
                return false;
            }
                // 0 para < && 1 para > && 2 para ==
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
        public string AcceptOnlyNumbers(KeyPressEventArgs e,string texto )
        {
            if (e.KeyChar == (char)8)
            {
               
                return texto;

            }

            if (!char.IsNumber(e.KeyChar) )

            {
                e.Handled = true;
                return texto;

            }
            return texto;
        }
        //Accept only Letters
            public string AcceptOnlyLetters(KeyPressEventArgs e,string texto)
            {
            if (e.KeyChar == (char)8)
            {
                return texto;

            }
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')))
            {
                e.Handled = true;
                return texto;
            }
            return texto;
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
