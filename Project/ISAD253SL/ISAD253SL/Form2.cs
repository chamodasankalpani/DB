using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISAD253SL
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fName, lName, address, username, password, cpassword;
            int telephone;

            fName = txtFName.Text;
            lName = txtLName.Text;
            address = txtAddress.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            cpassword = txtConfirmPassword.Text;
            telephone = int.Parse(txtTelephone.Text);


            ConnectionString cn = new ConnectionString();


            if (txtFName.Text == "")
            {
                MessageBox.Show("Please Enter First Name");
            }


            if (txtLName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name");
            }


            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Address");
            }



            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username");
            }


            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }


            if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Confirm Password");
            }



            if ( txtTelephone.Text == "")
            {
                MessageBox.Show("Please Enter Telephone");
            }



           if (password==cpassword)
            {
                SqlConnection con = new SqlConnection(@"Data Source=MSI\SAHANSQL;Initial Catalog=DBProject;Integrated Security=True");
                string qry = "insert into DBuser values('" + fName + "','" + lName + "','" + telephone + "','" + address + "','" + username + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Submission Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("Passwords Do Not Match Please Re-Enter !");
            }
        }

        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm2 = new frmLogin();
            this.Hide();
            frm2.Show(); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
