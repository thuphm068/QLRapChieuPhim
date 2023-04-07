﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace QLRapChieuPhim.Extensions
{
        public static class MyExtensions
        {

            public static void Init(this TextBox textBox, string prompt)
            {
                textBox.Text = prompt;
                bool wma = true;
                textBox.ForeColor = Color.Gray;
                textBox.GotFocus += (source, ex) =>
                {
                    if (((TextBox)source).ForeColor == Color.Black)
                        return;
                    if (wma)
                    {
                        wma = false;
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }
                };

                textBox.LostFocus += (source, ex) =>
                {
                    TextBox t = ((TextBox)source);
                    if (t.Text.Length == 0)
                    {
                        t.Text = prompt;
                        t.ForeColor = Color.Gray;
                        return;
                    }
                    if (!wma && string.IsNullOrEmpty(textBox.Text))
                    {
                        wma = true;
                        textBox.Text = prompt;
                        textBox.ForeColor = Color.Gray;
                    }
                };
                textBox.TextChanged += (source, ex) =>
                {
                    if (((TextBox)source).Text.Length > 0)
                    {
                        textBox.ForeColor = Color.Black;
                    }
                };
            }
        }
    }
      
