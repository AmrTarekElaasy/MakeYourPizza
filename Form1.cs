using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeYourPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            ResetForm();

        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void gbWhereToEat_Enter(object sender, EventArgs e)
        {
        }

        void ResetForm()
        {
            //Size
            rbSmall.Checked = false;
            rbMeduim.Checked = false;
            rbLarg.Checked = false;

            //Crust Type
            rbThinCrust.Checked = false;
            rbThinkCrust.Checked = false;

            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;

            //Toppings
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

           


            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;

            labFinalCrustType.Text = "";
            labWhereToEat.Text = "";
            labTotalSalary.Text = "$0"; // Reset total salary to $0
        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

       
        bool CanOrderPizza()
        {
            bool _InpupIngbSize = false;
            bool _InpupIngbCrustType = false;
            bool _InpupIngbWhereToEat = false;

            if (rbSmall.Checked || rbMeduim.Checked || rbLarg.Checked) // Size selected
                _InpupIngbSize = true;
            
            if(rbThinCrust.Checked || rbThinkCrust.Checked) // Crust Type selected
                _InpupIngbCrustType = true;
            
            if(rbEatIn.Checked || rbTakeOut.Checked) // Where to eat selected
                _InpupIngbWhereToEat = true;
 
            if (_InpupIngbSize&& _InpupIngbCrustType&& _InpupIngbWhereToEat)
                return true;
            return false;

        }
        void OrderPizza()
        {
            if (CanOrderPizza())
            {
                if (MessageBox.Show("Are you sure you want to order the pizza?", "Confirm Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    // Logic to order pizza
                    MessageBox.Show("Pizza ordered successfully!");
                    gbSize.Enabled = false;
                    gbCrustType.Enabled = false;
                    gbWhereToEat.Enabled = false;
                    gbToppings.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please complete all selections before ordering.");
            }
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            OrderPizza();
        }

        private void gbSize_Enter(object sender, EventArgs e)
        {
        }

        private void gbCrustType_Enter(object sender, EventArgs e)
        {
        }

        void AddOrSubInTotalSalary(int num ,bool Add)
        {
            string sTotalSalry = labTotalSalary.Text.Substring(1);
            int TotalSalry =  Convert.ToInt32(sTotalSalry);
            if(Add)
            TotalSalry += num;
            else
                TotalSalry -= num;
            labTotalSalary.Text = "$";
            labTotalSalary.Text += TotalSalry.ToString();    
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, chkOnion.Checked);
            labFinalToppings.Text = GetSelectedToppings();

        }
        string GetSelectedToppings()
        {
            List<string> sToppings = new List<string>();
            if (chkExtraCheese.Checked) sToppings.Add("Extra Cheese");
            if (chkOnion.Checked) sToppings.Add("Onion");
            if (chkMushrooms.Checked) sToppings.Add("Mushrooms");
            if (chkOlives.Checked) sToppings.Add("Olives");
            if (chkTomatoes.Checked) sToppings.Add("Tomatoes");
            if (chkGreenPeppers.Checked) sToppings.Add("Green Peppers");
            return string.Join(", ", sToppings);
        }
        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, chkExtraCheese.Checked);
            labFinalToppings.Text = GetSelectedToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, chkOlives.Checked);
            labFinalToppings.Text = GetSelectedToppings();


        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, chkMushrooms.Checked);
            labFinalToppings.Text = GetSelectedToppings();


        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, chkTomatoes.Checked);
            labFinalToppings.Text = GetSelectedToppings();


        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, chkGreenPeppers.Checked);
            labFinalToppings.Text = GetSelectedToppings();


        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, rbSmall.Checked);
            labFinalSize.Text = "Small";
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(20, rbMeduim.Checked);
            labFinalSize.Text = "Meduim";

        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(30, rbLarg.Checked);
            labFinalSize.Text = "Larg";

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(10, rbThinCrust.Checked);
            labFinalCrustType.Text = "Thin Crust";

        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            AddOrSubInTotalSalary(20, rbThinkCrust.Checked);
            labFinalCrustType.Text = "Think Crust";

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            labWhereToEat.Text = "Eat In";
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            labWhereToEat.Text = "Take Out";

        }

        private void gpOrderSummary_Enter(object sender, EventArgs e)
        {

        }
    }
}
