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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            House house = new House();
            fHouse ft = new fHouse(house);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbHousesInfo.Text +=
                    string.Format("Ширина: {0} м. Довжина: {1} м. Висота: {2} м. Кількість кімнат: {3}." +
                    " Кількість поверхів: {4}. Ціна опалення: {5} грн. Ціна за кв м: {6} грн. {7}." +
                    " Ціна будинку: {8}. Ціна за опалення: {9}\r\n",
                    house.Width, house.Length, house.Height, house.Room, house.Floor, house.Value, house.Price,
                    house.HasForniture ? "Є меблі та техніка" : " Немає меблів та техніки", house.GetCost(), house.Heating());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
                Application.Exit();
        }
    }
}
