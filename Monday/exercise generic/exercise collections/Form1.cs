using System;
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
    struct Employee
    {
        public string name;
        public double salary;
    }


    public partial class Form1 : Form
    {
        List<Employee> arr = new List<Employee>();
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp.name = txtName.Text;
            emp.salary = double.Parse(txtSalary.Text);
            arr.Add(emp);
            x = arr.Count - 1;
            txtName.Text = "";
            txtSalary.Clear();
            txtName.Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                x--;
                txtName.Text = arr[x].name;
                txtSalary.Text = arr[x].salary.ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (x < arr.Count-1)
            {
                x++;
                txtName.Text = arr[x].name;
                txtSalary.Text = arr[x].salary.ToString();
            }
            else
            {
                MessageBox.Show("end of list");
            }
        }
    }
}
