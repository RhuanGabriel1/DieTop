using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hooks
{
    class Hooks 
    {
        //Validação de Caloria para Simulação RealTime
        public void RealTimeCal(string aliName1, string aliName2, string aliName3, int cal1, int cal2, int cal3,Label comidaName1,Label comidaName2, 
            Label comidaName3,Label comidaCal1,Label comidaCal2, Label comidaCal3 ,Label caloriesTotal)
        {

            DieTop.Class.UserVar user = new DieTop.Class.UserVar();



            if (aliName1 != "Nada" && cal1 != 0)
            {
                comidaName1.Visible = true;
                comidaCal1.Visible = true;
                comidaName1.Text = aliName1;
                comidaCal1.Text = cal1.ToString();

            }
            else
            {
                comidaName1.Visible = false;
                comidaCal1.Visible = false;
                
            }
            if (aliName2 != "Nada" && cal2 != 0)
            {
                comidaName2.Visible = true;
                comidaCal2.Visible = true;
                comidaName2.Text = aliName2;
                comidaCal2.Text = cal2.ToString();


            }
            else
            {
                comidaName2.Visible = false;
                comidaCal2.Visible = false;
             

            }
            if (aliName3 != "Nada" && cal3 != 0)
            {
                comidaName3.Visible = true;
                comidaCal3.Visible = true;
                comidaName3.Text = aliName3;
                comidaCal3.Text = cal3.ToString();


            }
            else
            {
                comidaName3.Visible = false;
                comidaCal3.Visible = false;
             

            }


            int total = cal1 + cal2 + cal3;
            string getCalories = user.Caloria_restante;

            int convert = int.Parse(getCalories) - total;




            caloriesTotal.Text = convert + "";

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
