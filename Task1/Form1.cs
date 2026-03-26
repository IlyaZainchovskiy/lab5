using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const decimal PriceVanilla = 30.0m;
        private const decimal PriceChocolate = 35.0m;
        private const decimal PricePistachio = 45.0m;
        private const decimal PriceFruit = 25.0m;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну кількість порцій (ціле додатне число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pricePerPortion = 0;

            if (rbVanilla.Checked) pricePerPortion = PriceVanilla;
            else if (rbChocolate.Checked) pricePerPortion = PriceChocolate;
            else if (rbPistachio.Checked) pricePerPortion = PricePistachio;
            else if (rbFruit.Checked) pricePerPortion = PriceFruit;

            decimal totalCost = pricePerPortion * quantity;

            if (quantity > 20)
            {
                decimal discount = totalCost * 0.05m;
                totalCost -= discount;
                lblResult.Text = $"До сплати: {totalCost:F2} грн\n(застосовано знижку 5%)";
            }
            else
            {
                lblResult.Text = $"До сплати: {totalCost:F2} грн";
            }
        }
    }
}
