﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TextboxTextSafe(string result)
        {
            findusts.Text = result.ToString();
        }


        delegate string setfind(string setfindv);
        public string setfindv;
        setfindv = TextboxTextSafe();
    }
}
