﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DO_AN2
{
    public partial class FRPMatHang : Form
    {
        string idUser;
        public FRPMatHang(string name)
        {
            InitializeComponent();
            this.idUser = name;
        }

        private void FRPMatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            new AdminDashboard(this.idUser).Show();
            this.Hide();
        }
    }
}
