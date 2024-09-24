using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class fHouse : Form
    {
        public fHouse(House t)
        {
            TheHouse = t;
            InitializeComponent();
        }

        public House TheHouse;

        private void btnOK_Click(object sender, EventArgs e)
        {
            TheHouse.Width = double.Parse(tbWidth.Text.Trim());
            TheHouse.Length = double.Parse(tbLenght.Text.Trim());
            TheHouse.Height = double.Parse(tbHeight.Text.Trim());
            TheHouse.Room = int.Parse(tbRoom.Text.Trim());
            TheHouse.Floor = int.Parse(tbFloor.Text.Trim());
            TheHouse.Value = double.Parse(tbValue.Text.Trim());
            TheHouse.Price = double.Parse(tbPrice.Text.Trim());
            TheHouse.HasForniture = chbHasForniture.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fHouse_Load(object sender, EventArgs e)
        {
            if (TheHouse != null)
            {
                tbWidth.Text = TheHouse.Width.ToString();
                tbLenght.Text = TheHouse.Length.ToString();
                tbHeight.Text = TheHouse.Height.ToString();
                tbRoom.Text = TheHouse.Room.ToString();
                tbFloor.Text = TheHouse.Floor.ToString();
                tbValue.Text = TheHouse.Value.ToString();
                tbPrice.Text = TheHouse.Price.ToString();
                chbHasForniture.Checked = TheHouse.HasForniture;
            }
        }
    }
}
