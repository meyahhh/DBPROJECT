﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPROJECT
{
    public partial class frmCustomers : Form
    {
        DataTable DTable;

        SqlDataAdapter DAdapter;
        SqlCommand Dcommand;
        BindingSource DBindingSource;

        Boolean CancelUpdates;

        int idcolumn = 0;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void BindMainGrid()
        {
            this.CancelUpdates = true;

            if (Globals.glOpenSqlConn())
            {
                this.Dcommand = new SqlCommand("spGetAllCustomers", Globals.sqlconn);
                this.DAdapter = new SqlDataAdapter(this.Dcommand);

                this.DTable = new DataTable();
                this.DAdapter.Fill(DTable);
                this.DBindingSource = new BindingSource();
                this.DBindingSource.DataSource = DTable;

                dgvCustomers.DataSource = this.DBindingSource;
                this.bNavCustomers.BindingSource = this.DBindingSource;
            }
            this.CancelUpdates = false;
        }

        private void FormatGrid()
        {
            this.dgvCustomers.Columns["idCustomer"].Visible = false;

            this.dgvCustomers.Columns["idCustomer"].HeaderText = "Customer ID";
            this.dgvCustomers.Columns["nameCustomer"].HeaderText = "Customer Name";
            this.dgvCustomers.Columns["addressCustomer"].HeaderText = "Address";
            this.dgvCustomers.Columns["emailCustomer"].HeaderText = "Email";
            this.dgvCustomers.Columns["contactCustomer"].HeaderText = "Contact Number";

            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvCustomers.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.BindMainGrid();
            this.FormatGrid();
        }

        private void dgvCustomers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(String.Format("{0,10}", (e.RowIndex + 1).ToString()),
                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvCustomers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvCustomers.FirstDisplayedCell.RowIndex;
            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvCustomers.DisplayedRowCount(true);

            Graphics Graphics = dgvCustomers.CreateGraphics();

            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvCustomers.Font).Width);
            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvCustomers.Font).Width);

            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);

            dgvCustomers.RowHeadersWidth = rowHeaderWitdh + 40;
        }

        private void dgvCustomers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow row = this.dgvCustomers.CurrentRow;

            String name = row.Cells["nameCustomer"].Value.ToString().Trim();
            bool cancel = true;

            DataGridViewRow rw = this.dgvCustomers.CurrentRow;
            String n = rw.Cells["nameCustomer"].Value.ToString().Trim();

            if (row.Cells[idcolumn].Value != DBNull.Value && csMessageBox.Show("Delete the customer:" + name, "Please confirm.",

                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                if (Globals.glOpenSqlConn())
                {
                    SqlCommand cmd = new SqlCommand("dbo.spCustomersDelete", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cid", Convert.ToInt64(rw.Cells["idCustomer"].Value));
                    cmd.ExecuteNonQuery();

                    e.Cancel = false;
                }
                Globals.glCloseSqlConn();
            }
            e.Cancel = true;
        }

        private void dgvCustomers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            long custid = 0;
            long newcustid;

            if (this.CancelUpdates == false && this.dgvCustomers.CurrentRow != null)
            {
                if (Globals.glOpenSqlConn())
                {

                    DataGridViewRow row = dgvCustomers.CurrentRow;

                    if (row.Cells[this.idcolumn].Value == DBNull.Value)
                        custid = 0;

                    else
                        custid = Convert.ToInt64(row.Cells[this.idcolumn].Value);



                    String nameCustomer = row.Cells["nameCustomer"].Value == DBNull.Value ? ""
                        : row.Cells["nameCustomer"].Value.ToString().ToUpper();
                    String addressCustomer = row.Cells["addressCustomer"].Value == DBNull.Value ? ""
                        : row.Cells["addressCustomer"].Value.ToString();
                    String emailCustomer = row.Cells["emailCustomer"].Value == DBNull.Value ? ""
                        : row.Cells["emailCustomer"].Value.ToString(); 
                    String contactCustomer = row.Cells["contactCustomer"].Value == DBNull.Value ? ""
                        : row.Cells["contactCustomer"].Value.ToString();

                   

                    if (row.Cells["nameCustomer"].Value == DBNull.Value)
                    {
                        csMessageBox.Show("Please encode a valid customer name", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        dgvCustomers.CancelEdit();
                    }
                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("spCustomersAddEdit", Globals.sqlconn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@cid", custid);
                            cmd.Parameters.AddWithValue("@nameCustomer", nameCustomer);
                            cmd.Parameters.AddWithValue("@addressCustomer", addressCustomer);
                            cmd.Parameters.AddWithValue("@emailCustomer", emailCustomer);
                            cmd.Parameters.AddWithValue("@contactCustomer", contactCustomer);
                            

                            SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                            DataTable dt = new DataTable();

                            dAdapt.Fill(dt);

                            newcustid = long.Parse(dt.Rows[0][0].ToString());
                            // save it to the grid
                            if (custid == 0)
                                row.Cells["idCustomer"].Value = newcustid;

                        }
                        catch (Exception ex)
                        {
                            if (ex.Message != "There is no row at position 0.")
                            {
                                csMessageBox.Show("Exception Error:" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }


                        }
                    }
                    Globals.glCloseSqlConn();
                }
                Globals.glCloseSqlConn();
            }
        }

        private Boolean SearchName(String searchVal)
        {
            bool resultVal = false;
            int rowIndex = -1;

            searchVal = searchVal.Trim().ToUpper();
            if (searchVal != "")
            {
                this.bNavCustomers.MoveFirstItem.PerformClick();

                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    try
                    {
                        if (row.Cells["nameCustomer"].Value.ToString().StartsWith(searchVal))
                        {
                            rowIndex = row.Index;
                            dgvCustomers.Rows[row.Index].Selected = true;
                            resultVal = true;
                            break;
                        }
                        this.bNavCustomers.MoveNextItem.PerformClick();
                    }
                    catch
                    {
                        break;
                    }
                } // foreach
                if (!resultVal)
                    csMessageBox.Show("Record not found.", "Search Result",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // if
            return resultVal;
        }

        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            String searchVal = txtSearchCustomers.Text.Trim().ToUpper();

            if (this.SearchName(searchVal))
            {
                this.txtSearchCustomers.Clear();
                this.txtSearchCustomers.Focus();

            }
            else
            {
                this.txtSearchCustomers.Focus();
            }

        }

        private frmEditCustomer EditCustomerfrm;
        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            long ccid;

            DataGridViewRow row = dgvCustomers.CurrentRow;

            if (row.Cells[this.idcolumn].Value == DBNull.Value)
                ccid = 0;
            else
                ccid = Convert.ToInt64(row.Cells[this.idcolumn].Value);


            if (ccid != 0)
            {
                EditCustomerfrm = new frmEditCustomer(ccid);
                EditCustomerfrm.MdiParent = this.MdiParent;
                EditCustomerfrm.Show();

            }
        }
    }
 }


