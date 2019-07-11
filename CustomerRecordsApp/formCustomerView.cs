﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerRecordsApp.Data.Access;
using System.Reflection;
using CustomerRecordsApp.InputForms;

namespace CustomerRecordsApp
{
    public partial class formCustomerView : Form
    {
        DataTable customerTable = Customer.getCustomerTable();
        //DataTable filteredTable = new DataTable();
        Customer currentCustomer = new Customer();
        List<Customer> modifiedCustomers = new List<Customer>();
        public formCustomerView()
        {
            Initialize();
        }

        public void Initialize()
        {
            try
            {
                InitializeComponent();
                dgvCustomerData.DataSource = customerTable;
                dgvCustomerData.Columns["Roster_ID"].Visible = false;
                dgvCustomerData.Columns["PY_ID"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception: {ex}");
            }
            

            //TODO: any additional things that might need to happen here?            
        }


        #region ///////////////      Private Methods   /////////////////////////

        public void RefreshCustomers()
        {
            dgvCustomerData.DataSource = null;
            customerTable = Customer.getCustomerTable();
            dgvCustomerData.DataSource = customerTable;
            dgvCustomerData.Columns["Roster_ID"].Visible = false;
            dgvCustomerData.Columns["PY_ID"].Visible = false;
        }

        private void CustomerRowToObject(DataRow row, Customer customer)
        {
            PropertyInfo[] customerProperties = typeof(Customer).GetProperties();

            foreach (var property in customerProperties)
            {
                var rowVal = row[$"{property.Name}"];
                if (rowVal.GetType() == typeof(DBNull))
                {
                    rowVal = null;
                }
                property.SetValue(customer, rowVal);
            }
            // The above code should be able to utilize reflection to avoid all the stuff below.

            //customer.Customer_ID = (int?)row["Customer_ID"];
            //customer.FirstName = row["FirstName"].ToString();
            //customer.MiddleInitial = row["MiddleInitial"].ToString();
            //customer.LastName = row["LastName"].ToString();
            //customer.DOB = (DateTime?)row["DOB"];
            //customer.PhoneNumber = row["PhoneNumber"].ToString();
            //customer.StreetAddress = row["StreetAddress"].ToString();
            //customer.CityName = row["CityName"].ToString();
            //customer.StateName = row["StateName"].ToString();
            //customer.Zip = row["Zip"].ToString();
            //customer.ISIS_ID = (int?)row["ISIS_ID"];
        }
        
        private void ClearDirtyRows()
        {
            foreach (Customer cust in modifiedCustomers)
            {
                DataGridViewRow row = dgvCustomerData.Rows.Cast<DataGridViewRow>() // find the matching gridview row for a given Customer_ID.
                                                .Where(r => r.Cells["Customer_ID"].Value as int? == cust.Customer_ID)
                                                .First();
                row.DefaultCellStyle.BackColor = DefaultBackColor;
            }
            modifiedCustomers.Clear();
        }

        #endregion ///////////////      Private Methods   /////////////////////////

        #region ///////////////      Form Events   /////////////////////////

        private void BtAdd_Click(object sender, EventArgs e)
        {
            //TODO: Create and integrate a form to add a new Customer/Client.
            using (formNewCustomer newCustomer = new formNewCustomer())
            {
                newCustomer.ShowDialog();
            }
            //MessageBox.Show(
            //    "Not Yet Available",
            //    "Sorry! That feature has not yet been implemented or is not fully functional.",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            //// TODO: Implement this
            //throw new NotImplementedException();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            foreach (Customer customer in modifiedCustomers)
            {
                Customer.updateCustomer(customer);
            }
            ClearDirtyRows(); // clears the selection collection and resets rows to default colors.
        }

        private void DgvCustomerData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Int32.TryParse(dgvCustomerData.SelectedRows[0].Cells["Customer_ID"].Value.ToString(), out int customerID))
            {
                formCustomerDetailView detailView = new formCustomerDetailView(customerID);
                detailView.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Couldn't find the CustomerID for the selected record.",
                                "CustomerID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DgvCustomerData_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (gridView.IsCurrentCellDirty)
            {
                gridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DataRowView currentRowView = (DataRowView)gridView.Rows[e.RowIndex].DataBoundItem;
                DataRow currentRow = currentRowView.Row;
                Customer modifiedCustomer = new Customer();
                CustomerRowToObject(currentRow, modifiedCustomer);
                Customer match = modifiedCustomers.Where(cust => cust.Customer_ID == modifiedCustomer.Customer_ID).FirstOrDefault();
                if (modifiedCustomers.Contains(match)) // if we captured this customer before, delete the previous snapshot.
                {
                    modifiedCustomers.Remove(match);
                }
                modifiedCustomers.Add(modifiedCustomer); // add the new changes to the queue regardless.

                gridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aqua;
                if (!btUpdate.Enabled)
                {
                    btUpdate.Enabled = true;
                }
            }
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            RefreshCustomers();
        }

        private void DgvCustomerData_SelectionChanged(object sender, EventArgs e)
        {
            DataRow currentRow = null;
            if (dgvCustomerData.SelectedRows.Count > 0)
            try
            {
                // The following fails on datarow.select() results (array of DataRow objects)
                if (dgvCustomerData.SelectedRows[0].DataBoundItem.GetType() == typeof(DataRowView))
                {
                    DataRowView currentRowView = (DataRowView)dgvCustomerData.SelectedRows[0].DataBoundItem;
                    currentRow = currentRowView.Row;
                }
                else if (dgvCustomerData.SelectedRows[0].DataBoundItem.GetType() == typeof(DataRow))
                    {
                        currentRow = (DataRow)dgvCustomerData.SelectedRows[0].DataBoundItem;
                    }

                CustomerRowToObject(currentRow, currentCustomer);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception: {ex}");
            }
        }

        private void BtViewAlerts_Click(object sender, EventArgs e)
        {
            if (dgvCustomerData.SelectedRows.Count > 0)
            {
                if (Int32.TryParse(dgvCustomerData.SelectedRows[0].Cells["Customer_ID"].Value.ToString(), out int customerID))
                {
                    using (formAlertView alertForm = new formAlertView(currentCustomer))
                    {
                        alertForm.ShowDialog();
                    }
                }
            }            
        }

        private void TbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {                        
            // could not get in-memory search to work, so I'm doing a sql search instead.
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                MessageBox.Show(
                "Sorry! That feature has not yet been implemented or is not fully functional.",
                "Not Yet Available",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                //string searchString = tbSearch.Text;
                //dgvCustomerData.DataSource = CustomerRoster.getFilteredCustomerList(searchString);
            }
        }

        #endregion ///////////////      Form Events   /////////////////////////        

    }
}
