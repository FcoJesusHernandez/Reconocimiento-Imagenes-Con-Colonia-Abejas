using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconocimientoImagenes
{
    public partial class Dashboard : Form
    {
        colonia colonia_abejas;
        int generaciones;
        bool Graphic;
        Bitmap Img_Or_Bmp;
        Bitmap Img_Draw_Bmp;
        public Dashboard()
        {
            InitializeComponent();
            colonia_abejas = new colonia();
            generaciones = 0;
            Graphic = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximize_btn.Visible = false;
            Restore_btn.Visible = true;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restore_btn.Visible = false;
            Maximize_btn.Visible = true;
        }

        private void Menu_Sidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar_gradient.Width == 282)
            {
                Sidebar_gradient.Visible = false;
                Sidebar_gradient.Width = 68;
                Sidebar_Wrapper.Width = 90;
                Sidebar_line.Width = 52;
                Sidebar_Animation.Show(Sidebar_gradient);
            }
            else
            {
                Sidebar_gradient.Visible = false;
                Sidebar_gradient.Width = 282;
                Sidebar_Wrapper.Width = 300;
                Sidebar_line.Width = 276;
                Sidebar_Animation_Back.Show(Sidebar_gradient);
            }
        }

        private void Hidden_Show_Graphics(object sender, EventArgs e)
        {
            if (Graphic == false)
            {
                Graphic = true;
                Img_Draw_Pb.Hide();
                Img_Or_Pb.Hide();
                Panel_Chart.BackColor = Color.FromArgb(39, 41, 61);
                Graphic_Comp.Show();

            }
            else
            {
                Graphic = false;
                Img_Draw_Pb.Show();
                Img_Or_Pb.Show();
                Panel_Chart.BackColor = Color.Transparent;
                Graphic_Comp.Hide();
            }
            //Grafico.Hide();



        }
        public void Open_FileDialog(object sender, EventArgs e)
        {
            if (Graphic == true)
            {
                Hidden_Show_Graphics(sender, e);
            }
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (sender == Img_Or_btn)
                {
                    Img_Or_Bmp = new Bitmap(dlg.FileName);
                    Img_Or_Pb.Image = Img_Or_Bmp;
                }
                else
                {
                    Img_Draw_Bmp = new Bitmap(dlg.FileName);
                    Img_Draw_Pb.Image = Img_Draw_Bmp;
                }
            }
            dlg.Dispose();
        }

        

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();

            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(1, 10);
            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(2, 20);
            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(3, 30);
            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(4, 40);
            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(5, 50);
            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(6, 40);
            this.Graphic_Comp.Series["Chart_Graphic"].Points.AddXY(7, 50);
        }
    }
}
