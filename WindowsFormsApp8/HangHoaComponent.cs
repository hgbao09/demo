using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class HangHoaComponent : UserControl
    {
        public HangHoaComponent(Form1 HomeDisplay)
        {
            InitializeComponent();
            this.HomeDisplay = HomeDisplay;
        }
        private Form1 HomeDisplay;
        public HangHoa hh;
        public void SetProductInfo(HangHoa hh)
        {
            tenhang.Text = hh.ten_hang;
            dongia.Text = hh.don_gia.ToString();
            soluong.Text = hh.so_luong.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
