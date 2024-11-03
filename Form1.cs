using System;
using System.Windows.Forms;



namespace CS311_Project3_MLC
{
    public partial class PizzaPlace : Form

    {
        public PizzaPlace()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        } //end btnCaclulate_Click

        public void Summarize()
        {
            Console.WriteLine("Summarize");
            //Get pizza price size
            decimal sizePrice = 0;
            switch (cboSize.SelectedItem.ToString())
            {
                case "Small": sizePrice = 2.00m; break;
                case "Medium": sizePrice = 5.00m; break;
                case "Large": sizePrice = 10.00m; break;
                case "X-Large": sizePrice = 15.00m; break;
                case "Ginormous": sizePrice = 20.00m; break;
            }

            //Get toppings price
            decimal toppingsPrice = 0;
            if (ckbPepperoni.Checked) toppingsPrice += 2.00m;
            if (ckbSausage.Checked) toppingsPrice += 2.00m;
            if (ckbCanadianBacon.Checked) toppingsPrice += 2.00m;
            if (ckbSpicyItalianSausage.Checked) toppingsPrice += 2.00m;
            if (ckbOnion.Checked) toppingsPrice += 1.00m;
            if (ckbGreenPepper.Checked) toppingsPrice += 1.00m;
            if (ckbBlackOlives.Checked) toppingsPrice += 1.00m;
            if (ckbGreenOlives.Checked) toppingsPrice += 1.00m;
            if (ckbBananaPeppers.Checked) toppingsPrice += 1.00m;
            if (ckbJalepeno.Checked) toppingsPrice += 1.00m;
            if (ckbExtraCheese.Checked) toppingsPrice += 1.00m;
            if (ckbMushroom.Checked) toppingsPrice += 1.00m;

            //Calculate subtotal, tax, and total
            decimal subtotal = sizePrice + toppingsPrice;
            decimal tax = subtotal * 0.06m;
            decimal total = subtotal + tax;

            //display subtotal, tax, and total is textboxes
            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");

            //Display order summary in the rich text box
            rtfOrderSummary.Text = $"Size: {cboSize.SelectedItem}\n" +
                                   $"Crust: {(rdoThin.Checked ? "Thin" : rdoThick.Checked ? "Thick" : rdoRegular.Checked ? "Regular" : rdoGlutenFree.Checked ? "Gluten Free" : "No crust selected")}\n" +
                                   $"Toppings:\n";
            if (ckbPepperoni.Checked) rtfOrderSummary.AppendText(" - Pepperoni\n");
            if (ckbSausage.Checked) rtfOrderSummary.AppendText(" - Sausage\n");
            if (ckbCanadianBacon.Checked) rtfOrderSummary.AppendText(" - Canadian Bacon\n");
            if (ckbSpicyItalianSausage.Checked) rtfOrderSummary.AppendText(" - Spicy Italian Sausage\n");
            if (ckbOnion.Checked) rtfOrderSummary.AppendText(" - Onion\n");
            if (ckbGreenPepper.Checked) rtfOrderSummary.AppendText(" - Green Peppers\n");
            if (ckbBlackOlives.Checked) rtfOrderSummary.AppendText(" - Black Olives\n");
            if (ckbGreenOlives.Checked) rtfOrderSummary.AppendText(" - Green Olives\n");
            if (ckbBananaPeppers.Checked) rtfOrderSummary.AppendText(" - Banana Peppers\n");
            if (ckbJalepeno.Checked) rtfOrderSummary.AppendText(" - Jalepeno\n");
            if (ckbExtraCheese.Checked) rtfOrderSummary.AppendText(" - Extra Cheese\n");
            if (ckbMushroom.Checked) rtfOrderSummary.AppendText(" - Mushroom\n");

        } //end sumarize

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Display a warning box
            DialogResult result = MessageBox.Show("Are you sure you would like to restart? Your order will be lost.", "Confirm Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If user confirms restarting, clear the form
            if (result == DialogResult.Yes)
            {
                ClearForm();
            }

        } //end btnClear_Click

        private void ClearForm()
        {
            //Reset the ComboBox for pizza size
            cboSize.SelectedIndex = -1;

            //Reset radio buttons for crust type
            rdoThin.Checked = false;
            rdoThick.Checked = false;
            rdoThick.Checked = false;
            rdoGlutenFree.Checked = false;

            //Uncheck all toppings checkboxes
            ckbPepperoni.Checked = false;
            ckbSausage.Checked = false;
            ckbCanadianBacon.Checked = false;
            ckbSpicyItalianSausage.Checked = false;
            ckbOnion.Checked = false;
            ckbGreenPepper.Checked = false;
            ckbBlackOlives.Checked = false;
            ckbGreenOlives.Checked = false;
            ckbBananaPeppers.Checked = false;
            ckbJalepeno.Checked = false;
            ckbExtraCheese.Checked = false;
            ckbMushroom.Checked = false;

            //Clear textboxes for the sub total, tax, and total
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();

            //Clear the order summary in the RichTextBox
            rtfOrderSummary.Clear();
        } //end clear form

        
    } //end class PizzaPlace
} //end namespace
