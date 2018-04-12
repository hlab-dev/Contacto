using ContactManager.Classes.AppModels;
using ContactManager.Classes.DataLayer;
using System;
using System.Data;
using System.Windows.Forms;
using System.Dynamic;
using Newtonsoft.Json;
using System.Reflection;
using System.Collections.Generic;
using MetroFramework.Forms;
using MetroFramework;

namespace ContactManager.AppModules.ContactManagerModule
{
    public partial class ucContactManager : UserControl
    {

        private AuthDetails _loginDetails = null;
        private AppModuleCrudState _crudMode = AppModuleCrudState.Brows;
        private int _gridSelectedIndex = -1;
        private int _gridLastSelectedIndex = -1;
        private DataTable _customerRecords = null;
        private dynamic _currentSelectedRow = null;

        public ucContactManager(AuthDetails LoginDetails)
        {
            InitializeComponent();

            _loginDetails = LoginDetails;

            UpdateCRUDStateControls(AppModuleCrudState.Brows);
            LoadCustomerRecords();
        }

        private void LoadCustomerRecords()
        {
            if (_customerRecords != null)
            {
                _customerRecords.Dispose();
                _customerRecords = null;
            }

            _customerRecords = DatabaseUtil.produceDBInstance(_loginDetails.DefaultDBConnString).
                ExecuteProcedure("dbo.usp_Customer_List", Convert.ToString(_loginDetails.AuthID));

            if (_customerRecords != null)
            {
                dataGridCustomers.Columns.Clear();
                dataGridCustomers.DataSource = null;
                dataGridCustomers.Refresh();
                dataGridCustomers.DataSource = _customerRecords;
                dataGridCustomers.Refresh();
                _gridSelectedIndex = 0;
                UpdateInputFieldsByRowIndex(_gridSelectedIndex);
            } else
            {
                dataGridCustomers.Columns.Clear();
                dataGridCustomers.DataSource = null;
                dataGridCustomers.Refresh();
                _gridSelectedIndex = -1;
                UpdateInputFieldsByRowIndex(_gridSelectedIndex);
            }
        }

        public void UpdateInputFieldsByRowIndex(int RowIndex)
        {

            if (RowIndex < 0)
            {
                ClearInputFields();
                UpdateCRUDStateControls(AppModuleCrudState.Brows);
                return;
            }

            if (RowIndex > dataGridCustomers.Rows.Count)
            {
                ClearInputFields();
                UpdateCRUDStateControls(AppModuleCrudState.Brows);
                return;
            }

            DataTable table = dataGridCustomers.DataSource as DataTable;
            DataRow dataRow = table.NewRow();
            dataRow = ((DataRowView)dataGridCustomers.SelectedRows[0].DataBoundItem).Row;

            dynamic dataRowObj;
            dataRowObj = DataRowToObject(dataRow);
            _currentSelectedRow = dataRowObj;

            //string dataRowObjectStr = JsonConvert.SerializeObject((dataRowObj));

            if (dataRowObj != null)
            {
                txtCustomerName.Text = dataRowObj.CustomerName;
                txtLatitude.Text = Convert.ToString(dataRowObj.Latitude);
                txtLongtitude.Text = Convert.ToString(dataRowObj.Longitude);
            }else
            {
                ClearInputFields();
                UpdateCRUDStateControls(AppModuleCrudState.Brows);
                return;
            }

        }

        public dynamic DataRowToObject(DataRow dataRow)
        {

            var tmpObject = new ExpandoObject() as IDictionary<string, Object>;

            try
            {

                foreach (DataColumn column in dataRow.Table.Columns)
                {
                    object result = dataRow[column];
                    tmpObject.Add(column.ColumnName.Trim().Replace(" ", string.Empty), dataRow[column]);
                }

            }catch (Exception Ex)
            {
                return null;
            }

            return tmpObject;
        }

        private void tileButManageContacts_Click(object sender, EventArgs e)
        {
            if (_currentSelectedRow == null)
            {
                MetroMessageBox.Show(this, "No customer selected to view contacts!!");
                return;
            }

            CrudModuleDataInfo crudModuleDataInfo = new CrudModuleDataInfo();

            crudModuleDataInfo.AuthInfo = _loginDetails;
            crudModuleDataInfo.DataRow = _currentSelectedRow;
            crudModuleDataInfo.DisplayHeading = "Customer - "+txtCustomerName.Text.Trim();
            crudModuleDataInfo.ParentId = Convert.ToInt32(_currentSelectedRow.ID);

            frmManageCustContacts customerContacts = new frmManageCustContacts(crudModuleDataInfo);
            customerContacts.ShowDialog();
        }

        private void ClearInputFields()
        {
            txtCustomerName.Text = "";
            txtLatitude.Text = "";
            txtLongtitude.Text = "";
        }

        private void EnableInputFields(bool EnableState)
        {
            txtCustomerName.Enabled = EnableState;
            txtLatitude.Enabled = EnableState;
            txtLongtitude.Enabled = EnableState;
        }

        public void UpdateRowSelectIndex(int RowIndex)
        {
            _gridSelectedIndex = RowIndex;

            try
            {
                UpdateInputFieldsByRowIndex(_gridSelectedIndex);
            }catch
            {
                _currentSelectedRow = null;
                return;
            }
        }

        private void UpdateCRUDStateControls(AppModuleCrudState crudState)
        {
            _crudMode = crudState;
            switch (crudState)
            {
                case AppModuleCrudState.Brows:
                    tileButSave.Visible = false;
                    tileButCancel.Visible = false;
                    pnlCustomerActions.Visible = true;
                    tileButDelete.Enabled = true;
                    tileButNew.Enabled = true;
                    tileButEdit.Enabled = true;
                    tileButRefresh.Enabled = true;
                    EnableInputFields(false);
                    dataGridCustomers.Enabled = true;

                    break;
                case AppModuleCrudState.New:
                    tileButSave.Visible = true;
                    tileButCancel.Visible = true;
                    pnlCustomerActions.Visible = false;
                    tileButDelete.Enabled = false;
                    tileButNew.Enabled = false;
                    tileButEdit.Enabled = false;
                    tileButRefresh.Enabled = false;
                    EnableInputFields(true);
                    ClearInputFields();
                    txtCustomerName.Focus();
                    dataGridCustomers.Enabled = false;
                    break;
                case AppModuleCrudState.Edit:
                    tileButSave.Visible = true;
                    tileButCancel.Visible = true;
                    pnlCustomerActions.Visible = false;
                    tileButDelete.Enabled = false;
                    tileButNew.Enabled = false;
                    tileButEdit.Enabled = false;
                    tileButRefresh.Enabled = false;
                    EnableInputFields(true);
                    txtCustomerName.Focus();
                    dataGridCustomers.Enabled = false;
                    break;
                case AppModuleCrudState.Delete:
                    break;
            }
        }

        private void tileButEdit_Click(object sender, EventArgs e)
        {

            if (_currentSelectedRow == null)
            {
                MetroMessageBox.Show(this,"No data selected to edit!!");
                return;
            }

            _gridLastSelectedIndex = _gridSelectedIndex;
            UpdateCRUDStateControls(AppModuleCrudState.Edit);
        }

        private void tileButNew_Click(object sender, EventArgs e)
        {
            UpdateCRUDStateControls(AppModuleCrudState.New);
        }

        private void tileButCancel_Click(object sender, EventArgs e)
        {

            if (_crudMode == AppModuleCrudState.New)
            {
                LoadCustomerRecords();
            }

            UpdateCRUDStateControls(AppModuleCrudState.Brows);
        }

        private bool ValidateCustomerInfo()
        {

            if(txtCustomerName.Text.Trim() == "" || txtLatitude.Text.Trim() == "" || txtLongtitude.Text.Trim() == "")
            {
                MetroMessageBox.Show(this,"Please make sure all required customer fields are populated!!");
                return false;
            }

            try
            {
                decimal testLongLatConversion = Convert.ToDecimal(txtLatitude.Text.Trim());
                testLongLatConversion = Convert.ToDecimal(txtLongtitude.Text.Trim());
            }
            catch(Exception Ex)
            {
                MetroMessageBox.Show(this, "Please make sure Longitude and Latitude are correctly specified!!");
                return false;
            }

            return true;
        }

        private bool UpdateCustomerInfo()
        {

            if (!ValidateCustomerInfo())
                return false;

            try
            {
                string UpdateParams = string.Format("{0}, {1}, '{2}', {3}, {4}",
                    _loginDetails.AuthID.ToString(),
                    _currentSelectedRow.ID.ToString(),
                    txtCustomerName.Text.Trim(),
                    Convert.ToDecimal(txtLatitude.Text.Trim()).ToString().Replace(",", "."),
                    Convert.ToDecimal(txtLongtitude.Text.Trim()).ToString().Replace(",", "."));

                var UpdateResult = DatabaseUtil.produceDBInstance(_loginDetails.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_Customer_Update",
                    UpdateParams);
            }catch(Exception Ex)
            {
                MetroMessageBox.Show(this,"Oops!! Something went wrong trying to update the customer!!");
                return false;
            }

            return true;
        }

        private bool AddCustomerInfo()
        {

            if (!ValidateCustomerInfo())
                return false;

            try
            {
                string NewParams = string.Format("{0}, '{1}', {2}, {3}",
                    _loginDetails.AuthID.ToString(),                    
                    txtCustomerName.Text.Trim(),
                    Convert.ToDecimal(txtLatitude.Text.Trim()).ToString().Replace(",", "."),
                    Convert.ToDecimal(txtLongtitude.Text.Trim()).ToString().Replace(",", "."));

                var AddNewResult = DatabaseUtil.produceDBInstance(_loginDetails.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_Customer_Add",
                    NewParams);
            }
            catch (Exception Ex)
            {
                MetroMessageBox.Show(this, "Oops!! Something went wrong trying to add the customer!!");
                return false;
            }

            return true;
        }

        private bool DeleteCustomerInfo()
        {

            var appDeleteResult = MetroMessageBox.Show(this, "Are you sure you want to delete the customer and all of it's contacts?", "Customer", MessageBoxButtons.YesNo);

            if (appDeleteResult == DialogResult.No)
                return true;

                try
            {
                string DeleteParams = string.Format("{0}, {1}",
                    _loginDetails.AuthID.ToString(),
                    _currentSelectedRow.ID.ToString());

                var DeleteContactsResult = DatabaseUtil.produceDBInstance(_loginDetails.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_Customer_Delete_Contacts",
                    DeleteParams);

                var DeleteCustomerResult = DatabaseUtil.produceDBInstance(_loginDetails.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_Customer_Delete",
                    DeleteParams);
            }
            catch (Exception Ex)
            {
                MetroMessageBox.Show(this, "Oops!! Something went wrong trying to delete the customer!!");
                return false;
            }

            return true;
        }

        private bool CustomerInfoCrudOpperation(AppModuleCrudState crudState)
        {

            switch (crudState)
            {
                case AppModuleCrudState.New:
                    return AddCustomerInfo();                    
                case AppModuleCrudState.Edit:
                    return UpdateCustomerInfo();
                case AppModuleCrudState.Delete:
                    return DeleteCustomerInfo();
            }

            return false;
        }

        private void tileButSave_Click(object sender, EventArgs e)
        {

            bool UpdateCreateCustomerResult = CustomerInfoCrudOpperation(_crudMode);

            if (!UpdateCreateCustomerResult)
            {
                txtCustomerName.Focus();
                return;
            }

            if (_crudMode == AppModuleCrudState.Delete)
            {
                UpdateCRUDStateControls(AppModuleCrudState.Brows);
                return;
            }

            if (_crudMode == AppModuleCrudState.New)
            {
                LoadCustomerRecords();
            }

            if (_crudMode == AppModuleCrudState.Edit)
            {
                LoadCustomerRecords();
            }

            UpdateCRUDStateControls(AppModuleCrudState.Brows);
        }

        private void dataGridCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //UpdateRowSelectIndex(e.RowIndex);
        }

        private void dataGridCustomers_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridCustomers.CurrentRow == null)
            {
                _currentSelectedRow = null;
                return;
            }

            int rowSelectedIndex = dataGridCustomers.CurrentRow.Index;

            if (rowSelectedIndex >= 0)
                UpdateRowSelectIndex(rowSelectedIndex);
        }

        private void tileButDelete_Click(object sender, EventArgs e)
        {

            if (_currentSelectedRow == null)
            {
                MetroMessageBox.Show(this, "No data selected to Delete!!");
                return;
            }

            bool crudResult = CustomerInfoCrudOpperation(AppModuleCrudState.Delete);
            LoadCustomerRecords();
        }

        private void tileButRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomerRecords();
        }
    }

    public class AppModuleCustomerContactsTabControl : MetroFramework.Controls.MetroTabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }
    }
}
