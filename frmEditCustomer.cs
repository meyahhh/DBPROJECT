using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public partial class frmEditCustomer : Form
    {
        long custid = 0;
        public frmEditCustomer(long customerID)
        {
            InitializeComponent();

            this.custid = customerID;

            this.btnSaveCust.Enabled = false;
        }
        public long custoid
        {
            get { return this.custid; }
            set { this.custid = value; }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnSaveCust.Enabled = true; ;
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true; // PUT THE DING OFF
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void txtCustAdd_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnSaveCust.Enabled = true; ;
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true; // PUT THE DING OFF
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void txtCustCon_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnSaveCust.Enabled = true; ;
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true; // PUT THE DING OFF
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            this.RefreshData();
            this.btnSaveCust.Enabled = false;
            this.txtEmail.Focus();
        }

        private void RefreshData()
        {
            String ccusname = "", ccusemail = "";
            String ccusaddress= "", ccuscontact = "";

            // load photo here
            this.GetCustomerPhotofromField();

            this.GetProfile(this.custid, ref ccusname, ref ccusemail, ref ccusaddress,
                 ref ccuscontact);

            this.txtCusName.Text = ccusname;

            this.txtEmail.Text = ccusemail;

            this.txtCustAdd.Text = ccusaddress;

            this.txtCustCon.Text = ccuscontact;

            this.btnSaveCust.Enabled = false;
        }

        private void GetProfile(long ciduser,
            ref String ccname, ref String ccemail, ref String ccaddress,
            ref String cccontact)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spGetCustomerProfile",
                    Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@custID", ciduser);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ccname = reader["nameCustomer"].ToString();
                    ccemail = reader["emailCustomer"].ToString();
                    ccaddress = reader["addressCustomer"].ToString();
                    cccontact = reader["contactCustomer"].ToString();

                }
                else csMessageBox.Show("No such Customer ID:" + this.custid.ToString() + " is found!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Globals.glCloseSqlConn();
        }

        void GetCustomerPhotofromField()
        {

            if (Globals.glOpenSqlConn())
            {
                String qrystr = "Select isnull(photoCustomer,'') as photo from dbo.customers where idCustomer=" + this.custid.ToString();
                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                SqlDataAdapter UserAdapter = new SqlDataAdapter(cmd);

                DataTable UserTable = new DataTable();
                UserAdapter.Fill(UserTable);

                if (UserTable.Rows[0][0] != null)
                {

                    //byte[] UserImg = (byte[])UserTable.Rows[0][0];
                    byte[] UserImg = (byte[])UserTable.Rows[0][0];
                    MemoryStream imgstream = new MemoryStream(UserImg);

                    if (imgstream.Length > 0)
                        this.pictBoxUser.Image = Image.FromStream(imgstream);
                }
                UserAdapter.Dispose();
            }
            Globals.glCloseSqlConn();
        }

        private void btnRefreshCust_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void SavePhototoField()
        {
            MemoryStream ms = new MemoryStream();
            this.pictBoxUser.Image.Save(ms, pictBoxUser.Image.RawFormat);
            byte[] img = ms.ToArray();

            if (Globals.glOpenSqlConn())
            {
                String qrystr = "update customers set photoCustomer=@img where idCustomer =" +
                    this.custid.ToString();

                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                cmd.Parameters.Add("@img", SqlDbType.Image); //MySqlDbType.Blob
                cmd.Parameters["@img"].Value = img;

                if (cmd.ExecuteNonQuery() == 1)
                    csMessageBox.Show("New photo is saved...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Globals.glCloseSqlConn();

        }

        private void btnLoadPhotoCust_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhoto = new OpenFileDialog();
            openPhoto.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (openPhoto.ShowDialog() == DialogResult.OK)
            {
                pictBoxUser.Image = Image.FromFile(openPhoto.FileName);
                this.SavePhototoField();
            }
        }

        private void ClearPhototoField()
        {
            if (Globals.glOpenSqlConn())
            {
                String qrystr = "update customers set photoCustomer=null where idCustomer =" +
                    this.custid.ToString();

                SqlCommand cmd = new SqlCommand(qrystr, Globals.sqlconn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    this.pictBoxUser.Image = null;

                    csMessageBox.Show("Customer photo is cleared...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Globals.glCloseSqlConn();
        }

        private void btnClearPhotoCust_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Customer photo is cleared...", "Information",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.ClearPhototoField();
            }
        }

        private void UpdateCustomer()
        {

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("spUpdateCustomers", Globals.sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cid", this.custid);
                cmd.Parameters.AddWithValue("@custname", this.txtCusName.Text);
                cmd.Parameters.AddWithValue("@custemail", this.txtEmail.Text);
                cmd.Parameters.AddWithValue("@custadd", this.txtCustAdd.Text);
                cmd.Parameters.AddWithValue("@custcontact", this.txtCustCon.Text);
                
                cmd.ExecuteNonQuery();
            }
            Globals.glCloseSqlConn();
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            if (this.txtCusName.Text.Trim() == "")
            {
                csMessageBox.Show("Please provide a valid login name.", "Empty Login Name",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.UpdateCustomer();
                this.btnSaveCust.Enabled = false;
                //Globals.gLoginName = this.txtLoginName.Text;
            }
        }
    }
}
