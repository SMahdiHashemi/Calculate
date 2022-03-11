using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*private void button2_Click(object sender, EventArgs e)
        {
            
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salary = float.Parse(txtSalary.Text); 
            float count = float.Parse(txtCount.Text);

            float tax = CalculateTax(salary);
            txtTax.Text = tax.ToString();

            float insurance = CalculateInsurance(salary);
            txtInsurance.Text = insurance.ToString();

            float overTime = CalculateOvertime(count, salary);
            txtOvertime.Text = overTime.ToString(); 

           
            txtPureSalary.Text = (salary - (tax + insurance) + overTime).ToString();



        }


        private float CalculateTax(float salary)
        {
            float tax = salary * 0.09f;
            return tax;
        }

        private float CalculateInsurance(float salary)
        {
            float insurance = salary * 0.07f;
            return insurance;
        } 

        private float CalculateOvertime(float salary, float count)
        {
            float salaryPerHour = salary / 180;
            float salaryPerOvertime = salaryPerHour * 1.4f;
            float totale = salaryPerOvertime * count;
            return totale;
        }

    }
}
