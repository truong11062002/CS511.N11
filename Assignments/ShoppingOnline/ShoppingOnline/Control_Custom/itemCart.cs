﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline.Control_Custom
{
    public partial class itemCart : UserControl
    {
        public itemCart()
        {
            InitializeComponent();
        }

        public itemCart(string id): this()
        {

        }
    }
}
