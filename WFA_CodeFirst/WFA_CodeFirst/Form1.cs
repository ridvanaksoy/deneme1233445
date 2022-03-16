using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_CodeFirst.Models.Context;

namespace WFA_CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OzBilgeAdamEntities db = new OzBilgeAdamEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
