using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReconocimientoImagenes
{
    public partial class Form1 : Form
    {
        colonia colonia_abejas;
        int generaciones;

        public Form1()
        {
            InitializeComponent();
            colonia_abejas = new colonia();
        }
    }
}
