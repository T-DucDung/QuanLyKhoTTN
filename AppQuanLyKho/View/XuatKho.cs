﻿using AppQuanLyKho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKho.View
{
    public partial class PhieuXuat : Form
    {
        List<SanPham> danhSachSanPham;
        public PhieuXuat()
        {
            InitializeComponent();
            danhSachSanPham = new List<SanPham>();
        }
    }
}
