using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KhoHang kho = new KhoHang();
            kho.ds_san_pham.Add(new DienTu("DT01", "Quat may", 7, 150000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DoGiaDung("GD01", "Chao chong dinh", 9, 100000));
            kho.ds_san_pham.Add(new DoGiaDung("GD02", "Ban an", 3, 500000));
            kho.ds_san_pham.Add(new ThucPham("TP01", "Ga nguyen con", 12, 80000));
            kho.ds_san_pham.Add(new ThucPham("TP02", "Nuoc ngot", 20, 10000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));
            kho.ds_san_pham.Add(new DienTu("DT02", "Noi com dien", 6, 250000));


            foreach (HangHoa hh in kho.ds_san_pham)
            {
                HangHoaComponent hh_component = new HangHoaComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                flowLayoutPanel1.Controls.Add(hh_component);
            }

        }
        bool sidebarExpand = true;

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            
            else 
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }

            }
                
            
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
