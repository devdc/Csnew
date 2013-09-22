using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_collections
{
    public partial class Form1 : Form
    {
        public struct employee
        {
            public string name;
            public double salary;
        }

        public List<employee> EmployeeList = new List<employee>();
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            employee emp;

            emp.name   = txtName.Text;
            emp.salary = double.Parse(txtSalary.Text);

            EmployeeList.Add(emp);


            x = EmployeeList.Count - 1;

            txtName.Text = "";
            txtSalary.Clear();
            txtName.Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x--;
                txtName.Text   = EmployeeList[x].name;
                txtSalary.Text = EmployeeList[x].salary.ToString();
            }
            else
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (x < EmployeeList.Count - 1)
            {
                x++;
                txtName.Text   = EmployeeList[x].name;
                txtSalary.Text = EmployeeList[x].salary.ToString();
            }
            else
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
