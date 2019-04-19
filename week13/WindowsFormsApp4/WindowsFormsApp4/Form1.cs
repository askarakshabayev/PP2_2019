﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] buttons = new Button[10,10];
        int d = 70;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(d, d);
                    buttons[i, j].Location = new Point(j * 70, i * 70);
                    buttons[i, j].Text = i + " " + j;
                    buttons[i, j].Click += Button_Clicked;
                    Controls.Add(buttons[i, j]);
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string[] text = button.Text.Split();
            int x = int.Parse(text[0]);
            int y = int.Parse(text[1]);
            //MessageBox.Show(x + " " + y);
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (i == x || j == y)
                        buttons[i, j].BackColor = Color.Red;
                    

        }
    }
}
