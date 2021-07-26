using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemoWithWinforms
{
    public partial class Form1 : Form
    {
        EmpProfileBL empprofilebl = new EmpProfileBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = Convert.ToInt32(txtCode.Text);
            emp.EmpName = txtName.Text;
            emp.DateOfBirth = dtpDob.Value;
            empprofilebl.SaveEmployee()
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
