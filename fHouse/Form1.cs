using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fHouse
{
    public partial class House : Form
    {
        public House(House t)
        {
            TheHouse = t;
            InitializeComponent();
        }

        public House TheHouse;

        private void btnOK_Click(object sender, EventArgs e)
        {
            TheHouse.Width = double.Parse(tbWidth.Text.Trim());
            TheHouse.Length = double.Parse(tbWidth.Text.Trim());
            TheHouse.Height = double.Parse(tbHeight.Text.Trim());
            TheHouse.Width = tbWidth.Text.Trim();
            TheHouse.Width = tbWidth.Text.Trim();
            TheHouse.Value = double.Parse(tbValue.Text.Trim());
            TheHouse.Price = double.Parse(tbPrice.Text.Trim());
            TheHouse.Width = tbWidth.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fHouse_Load(object sender, EventArgs e)
            if (TheHouse )
    }
}
