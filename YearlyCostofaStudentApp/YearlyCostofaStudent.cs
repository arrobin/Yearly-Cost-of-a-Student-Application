using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearlyCostofaStudentApp
{
    public partial class YearlyCostofaStudent : Form
    {
        public YearlyCostofaStudent()
        {
            InitializeComponent();
        }

        double totalAmount;
        
        private void totalAmountButton_Click(object sender, EventArgs e)
        {

            if (discountCheckBox.Checked==true)
            {
                if (selectClassComboBox.Text == "Class 1" || selectClassComboBox.Text == "Class 2" || selectClassComboBox.Text == "Class 3" || selectClassComboBox.Text == "Class 4" || selectClassComboBox.Text == "Class 5")
                {
                    if (selectClassComboBox.Text == "Class 1" || selectClassComboBox.Text == "Class 2")
                    {

                        totalAmount = 10000 + (500 * 12) - ((10000 + (500 * 12))*0.05);
                    }
                    if (selectClassComboBox.Text == "Class 3" || selectClassComboBox.Text == "Class 5" || selectClassComboBox.Text == "Class 4")
                    {
                        totalAmount = 10000 + (1000 * 12) - ((10000 + (1000 * 12))*0.05);
                    }
                }
                if (selectClassComboBox.Text == "Class 6" || selectClassComboBox.Text == "Class 8" || selectClassComboBox.Text == "Class 7")
                {

                    totalAmount = 12000 + (1500 * 12) - ((12000 + (1500 * 12))*0.05);

                }
                if (selectClassComboBox.Text == "Class 9" || selectClassComboBox.Text == "Class 10" || selectClassComboBox.Text == "Class 11" || selectClassComboBox.Text == "Class 12")
                {
                    if (selectClassComboBox.Text == "Class 9" || selectClassComboBox.Text == "Class 10")
                    {
                        totalAmount = 15000 + (2000 * 12) - ((15000 + (2000 * 12))*0.05);
                    }
                    if (selectClassComboBox.Text == "Class 11" || selectClassComboBox.Text == "Class 12")
                    {
                        totalAmount = 15000 + (2700 * 12) - ((15000 + (2700 * 12))*0.05);
                    }
                }

                MessageBox.Show("Total Amount = " + totalAmount);
            }
            else
            {
                if (selectClassComboBox.Text == "Class 1" || selectClassComboBox.Text == "Class 2" || selectClassComboBox.Text == "Class 3" || selectClassComboBox.Text == "Class 4" || selectClassComboBox.Text == "Class 5")
                {
                    if (selectClassComboBox.Text == "Class 1" || selectClassComboBox.Text == "Class 2")
                    {

                        totalAmount = 10000 + (500 * 12);
                    }
                    if (selectClassComboBox.Text == "Class 3" || selectClassComboBox.Text == "Class 5")
                    {
                        totalAmount = 10000 + (1000 * 12);
                    }
                }
                if (selectClassComboBox.Text == "Class 6" || selectClassComboBox.Text == "Class 8" || selectClassComboBox.Text == "Class 7")
                {

                    totalAmount = 12000 + (1500 * 12);

                }
                if (selectClassComboBox.Text == "Class 9" || selectClassComboBox.Text == "Class 10" ||
                    selectClassComboBox.Text == "Class 11" || selectClassComboBox.Text == "Class 12")
                {
                    if (selectClassComboBox.Text == "Class 9" || selectClassComboBox.Text == "Class 10")
                    {
                        totalAmount = 15000 + (2000*12);
                    }
                    if (selectClassComboBox.Text == "Class 11" || selectClassComboBox.Text == "Class 12")
                    {
                        totalAmount = 15000 + (2700*12);
                    }
                }
                MessageBox.Show("Total Amount = " + totalAmount);
            }
        }


    }
}
