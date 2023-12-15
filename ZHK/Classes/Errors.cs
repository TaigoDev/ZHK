﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ZHK.Classes
{
    public static class Errors
    {
        public static void CheckIsEmpty(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i] is TextBox)
                {

                    if (string.IsNullOrEmpty(((TextBox)controls[i]).Text))
                    {
                        MessageBox.Show($"{controls[i].Name} не заполнен", "ОШИБКА");
                        throw new Exception();
                    }
                }
                if (controls[i] is ComboBox)
                {
                    if (((ComboBox)controls[i]).SelectedItem == null)
                    {
                        MessageBox.Show($"{controls[i].Name} не заполнен", "ОШИБКА");
                        throw new Exception();
                    }
                }
            }
        }

        public static bool CheckNotNegative(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
               if (CheckIsNumber(controls))
               {
                    if (Convert.ToInt32(((TextBox)controls[i]).Text) < 0)
                    {
                        MessageBox.Show($"{controls[i].Name} отрицательное число", "ОШИБКА");
                        throw new Exception();
                    }
               }
            }
            return true;
        }


        public static bool CheckIsNumber(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i] is TextBox)
                {
                    try
                    {
                        int temp = Convert.ToInt32(((TextBox)controls[i]).Text);
                    }
                    catch
                    {
                        MessageBox.Show($"{controls[i].Name} не число", "ОШИБКА");
                        throw new Exception();
                    }
                }
            }
            return true; 
        }

        public static bool IsNatural(params Control[] controls)
        {
            for (int i = 0; i < controls.Length; i++)
            {
                if (CheckNotNegative(controls))
                {
                    if (Convert.ToInt32(((TextBox)controls[i]).Text) % 1 != 0)
                    {
                        MessageBox.Show($"{controls[i].Name} не натуральное число", "ОШИБКА");
                        throw new Exception();
                    }
                    
                }
            }
            return true;
        }
    }
}
