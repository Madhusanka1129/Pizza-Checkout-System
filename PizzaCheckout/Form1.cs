using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCheckout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void AttachEventHandlers()
        {
            // Size selection events
            smallRibbon.CheckedChanged += UpdateOrderDetails;
            MediumRibbon.CheckedChanged += UpdateOrderDetails;
            largeRibbon.CheckedChanged += UpdateOrderDetails;
            supreneRibbon.CheckedChanged += UpdateOrderDetails;

            // Topping selection events
            extraCheesecheckBox.CheckedChanged += UpdateOrderDetails;
            greenPappercheckBox.CheckedChanged += UpdateOrderDetails;
            anchoviedcheckBox.CheckedChanged += UpdateOrderDetails;
            olivecheckBox.CheckedChanged += UpdateOrderDetails;
            pepperonicheckBox.CheckedChanged += UpdateOrderDetails;
            jalapenocheckBox.CheckedChanged += UpdateOrderDetails;
            baconcheckBox.CheckedChanged += UpdateOrderDetails;
            mushoomscheckBox.CheckedChanged += UpdateOrderDetails;
            italianSausagecheckBox.CheckedChanged += UpdateOrderDetails;
            humcheckBox.CheckedChanged += UpdateOrderDetails;
            orioncheckBox.CheckedChanged += UpdateOrderDetails;
        }

        private void UpdateOrderDetails(object sender, EventArgs e)
        {
            decimal pizzaPrice = 0;
            string pizzaSize = "";

            if (smallRibbon.Checked)
            {
                pizzaSize = "Small";
                pizzaPrice = 7.95m;
            }
            else if (MediumRibbon.Checked)
            {
                pizzaSize = "Medium";
                pizzaPrice = 11.95m;
            }
            else if (largeRibbon.Checked)
            {
                pizzaSize = "Large";
                pizzaPrice = 14.95m;
            }
            else if (supreneRibbon.Checked)
            {
                pizzaSize = "Supreme";
                pizzaPrice = 18.95m;
            }

            pizzaTextBox.Text = pizzaSize;

            decimal toppingsPrice = 0;
            List<string> selectedToppings = new List<string>();

            if (extraCheesecheckBox.Checked)
            {
                selectedToppings.Add("Extra Cheese");
                toppingsPrice += 0.95m;
            }
            if (greenPappercheckBox.Checked)
            {
                selectedToppings.Add("Ground Beef");
                toppingsPrice += 0.95m;
            }
            if (anchoviedcheckBox.Checked)
            {
                selectedToppings.Add("Anchovies");
                toppingsPrice += 0.95m;
            }
            if (olivecheckBox.Checked)
            {
                selectedToppings.Add("Olive");
                toppingsPrice += 0.95m;
            }
            if (pepperonicheckBox.Checked)
            {
                selectedToppings.Add("Pepperoni");
                toppingsPrice += 0.95m;
            }
            if (jalapenocheckBox.Checked)
            {
                selectedToppings.Add("Jalapeno");
                toppingsPrice += 0.95m;
            }
            if (baconcheckBox.Checked)
            {
                selectedToppings.Add("Bacon");
                toppingsPrice += 0.95m;
            }
            if (mushoomscheckBox.Checked)
            {
                selectedToppings.Add("Mushrooms");
                toppingsPrice += 0.95m;
            }
            if (italianSausagecheckBox.Checked)
            {
                selectedToppings.Add("Italian Sausage");
                toppingsPrice += 0.95m;
            }
            if (humcheckBox.Checked)
            {
                selectedToppings.Add("Ham");
                toppingsPrice += 0.95m;
            }
            if (orioncheckBox.Checked)
            {
                selectedToppings.Add("Onion");
                toppingsPrice += 0.95m;
            }
            if (greenPappercheckBox.Checked)
            {
                selectedToppings.Add("Green Pepper");
                toppingsPrice += 0.95m;
            }

            toppingsTexBox.Text = $"{selectedToppings.Count} toppings ({toppingsPrice:C})";

            // Calculate totals
            decimal subTotal = pizzaPrice + toppingsPrice;
            decimal taxRate = subTotal * 0.12m; // 12% tax
            decimal total = subTotal + taxRate;

            subTotalTexBox.Text = subTotal.ToString("C");
            taxtTexBox.Text = taxRate.ToString("C");
            totalTexBox.Text = total.ToString("C");
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            String name, telNumberPartOne, telNumberPartTwo, address, cheque_CC;

            name = nameTexBox.Text;
            telNumberPartOne = telNoTexBox01.Text;
            telNumberPartTwo = telNoTexBox02.Text;
            address = addressTexBox.Text;
            cheque_CC = chequeTexBox.Text;

            String telephoneNumber = telNumberPartOne + "-" + telNumberPartTwo;

            String payment = "";
            if (visaRibbonButton.Checked)
            {
                payment = "Visa";
            }
            else if (masterCardRibbon.Checked)
            {
                payment = "Master Card";
            }
            else if (chequeRibbon.Checked)
            {
                payment = "Cheque";
            }
            else if (cashRibbon.Checked)
            {
                payment = "Cash";
            }

            String pizzaSize = "";
            decimal pizzaPrice = 0;
            if (smallRibbon.Checked)
            {
                pizzaSize = "Small";
                pizzaPrice = 7.95m;
            }
            else if (MediumRibbon.Checked)
            {
                pizzaSize = "Medium";
                pizzaPrice = 11.95m;
            }
            else if (largeRibbon.Checked)
            {
                pizzaSize = "Large";
                pizzaPrice = 14.95m;
            }
            else if (supreneRibbon.Checked)
            {
                pizzaSize = "Supreme";
                pizzaPrice = 18.95m;
            }

            List<String> selectedToppings = new List<String>();
            decimal toppingsPrice = 0;

            if (extraCheesecheckBox.Checked)
            {
                selectedToppings.Add("Extra Cheese");
                toppingsPrice += 0.95m;
            }
            if (greenPappercheckBox.Checked)
            {
                selectedToppings.Add("Ground Beef");
                toppingsPrice += 0.95m;
            }
            if (anchoviedcheckBox.Checked)
            {
                selectedToppings.Add("Anchovies");
                toppingsPrice += 0.95m;
            }
            if (olivecheckBox.Checked)
            {
                selectedToppings.Add("Olive");
                toppingsPrice += 0.95m;
            }
            if (pepperonicheckBox.Checked)
            {
                selectedToppings.Add("Pepperoni");
                toppingsPrice += 0.95m;
            }
            if (jalapenocheckBox.Checked)
            {
                selectedToppings.Add("Jalapeno");
                toppingsPrice += 0.95m;
            }
            if (baconcheckBox.Checked)
            {
                selectedToppings.Add("Bacon");
                toppingsPrice += 0.95m;
            }
            if (mushoomscheckBox.Checked)
            {
                selectedToppings.Add("Mushrooms");
                toppingsPrice += 0.95m;
            }
            if (italianSausagecheckBox.Checked)
            {
                selectedToppings.Add("Italian Sausage");
                toppingsPrice += 0.95m;
            }
            if (humcheckBox.Checked)
            {
                selectedToppings.Add("Ham");
                toppingsPrice += 0.95m;
            }
            if (orioncheckBox.Checked)
            {
                selectedToppings.Add("Onion");
                toppingsPrice += 0.95m;
            }
            if (greenPappercheckBox.Checked)
            {
                selectedToppings.Add("Green Pepper");
                toppingsPrice += 0.95m;
            }

            decimal subTotal = pizzaPrice + toppingsPrice;
            decimal taxRate = subTotal * 0.12m;     //Assume 12% tax
            decimal total = subTotal + taxRate;

            pizzaTextBox.Text = pizzaPrice.ToString("C");
            toppingsTexBox.Text = toppingsPrice.ToString("C");
            subTotalTexBox.Text = subTotal.ToString("C");
            taxtTexBox.Text = taxRate.ToString("C");
            totalTexBox.Text = total.ToString("C");

            String toppingsList = selectedToppings.Count > 0 ? String.Join("\n                 ", selectedToppings) : "No Toppings Selected";

            String message =
                $"Sold To: {name}\n" +
                $"Address: {address}\n" +
                $"Telephone: {telephoneNumber}\n\n" +
                $"Paid by: {payment}\n\n" +
                $"Pizza Size: {pizzaSize}\n" +
                "Toppings:\n                 " + toppingsList + "\n\n" +
                $"Pizza Price: {pizzaPrice:C}\n" +
                $"Toppings: {selectedToppings.Count} items ({toppingsPrice:C})\n" +
                $"SubTotal: {subTotal:C}\n" +
                $"Taxes (12%): {taxRate:C}\n" +
                $"Total: {total:C}\n";

            MessageBox.Show(message, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            // Clear customer information
            nameTexBox.Clear();
            telNoTexBox01.Clear();
            telNoTexBox02.Clear();
            addressTexBox.Clear();
            chequeTexBox.Clear();

            // Clear payment options
            visaRibbonButton.Checked = false;
            masterCardRibbon.Checked = false;
            chequeRibbon.Checked = false;
            cashRibbon.Checked = false;

            // Clear pizza size selection
            smallRibbon.Checked = false;
            MediumRibbon.Checked = false;
            largeRibbon.Checked = false;
            supreneRibbon.Checked = false;

            // Clear toppings
            extraCheesecheckBox.Checked = false;
            greenPappercheckBox.Checked = false;
            anchoviedcheckBox.Checked = false;
            olivecheckBox.Checked = false;
            pepperonicheckBox.Checked = false;
            jalapenocheckBox.Checked = false;
            baconcheckBox.Checked = false;
            mushoomscheckBox.Checked = false;
            italianSausagecheckBox.Checked = false;
            humcheckBox.Checked = false;
            orioncheckBox.Checked = false;

            // Clear order summary
            pizzaTextBox.Clear();
            toppingsTexBox.Clear();
            subTotalTexBox.Clear();
            taxtTexBox.Clear();
            totalTexBox.Clear();
        }

        private void sizeGroupBox_Enter(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void smallRibbon_CheckedChanged(object sender, EventArgs e)
        {
            if (smallRibbon.Checked)
            {
                pizzaTextBox.Text = "Small";
            }
        }
    }
}