using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using ContactManager.Classes.AppModels;
using ContactManager.Classes.DataLayer;
using System.Text.RegularExpressions;

namespace ContactManager.AppModules.ContactManagerModule
{
    public partial class frmManageCustContacts : MetroForm
    {
        private CrudModuleDataInfo _providerInfo = null;
        private AppDataGridCrudInfoHelper _appDataGridCrudInfoHelper = new AppDataGridCrudInfoHelper();
        private dynamic _SelecteddataRow = null;


        public frmManageCustContacts(CrudModuleDataInfo ProviderInfo)
        {
            InitializeComponent();

            _providerInfo = ProviderInfo;
            tileLblCustomerDisplay.Text = _providerInfo.DisplayHeading;

            _appDataGridCrudInfoHelper.RefButCancel = tileButCancel;
            _appDataGridCrudInfoHelper.RefButSave = tileButSave;
            _appDataGridCrudInfoHelper.RefButRefresh = tileButRefresh;
            _appDataGridCrudInfoHelper.RefButEdit = tileButEdit;
            _appDataGridCrudInfoHelper.RefButNew = tileButNew;
            _appDataGridCrudInfoHelper.RefButDelete = tileButDelete;
            _appDataGridCrudInfoHelper.RefDataGrid = dataGridContacts;
            _appDataGridCrudInfoHelper.LoginDetails = ProviderInfo.AuthInfo;
        }

        private void LoadContactData()
        {
            _appDataGridCrudInfoHelper.DataRecords = DatabaseUtil.produceDBInstance(_appDataGridCrudInfoHelper.LoginDetails.DefaultDBConnString).
                ExecuteProcedure("dbo.usp_CustomerContact_List", string.Format("{0} , {1}",
                Convert.ToString(_appDataGridCrudInfoHelper.LoginDetails.AuthID),
                Convert.ToString(_providerInfo.ParentId)));

            if (_appDataGridCrudInfoHelper.GridSelectedIndex == -1)
            {
                ClearInputFields();
            }

        }

        private void ClearInputFields()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtNumber.Text = "";
        }

        private void EnableInputFields(bool EnableState)
        {
            txtName.Enabled = EnableState;
            txtEmail.Enabled = EnableState;
            txtNumber.Enabled = EnableState;
        }

        private void rowDataNotification(object sender, CrudModeNotificationArgs e)
        {
            var Test = e.SelectedCrudMode;

            if (e.RowData != null)
            {
                _SelecteddataRow = e.RowData;

                txtName.Text = e.RowData.ContactName;
                txtEmail.Text = e.RowData.Email;
                txtNumber.Text = e.RowData.Number;
            }

        }

        private void crudModeNotification(object sender, CrudModeNotificationArgs e)
        {
            var Test = e.SelectedCrudMode;

            switch (e.SelectedCrudMode)
            {
                case AppModuleCrudState.Brows:
                    EnableInputFields(false);
                    break;
                case AppModuleCrudState.New:
                    EnableInputFields(true);
                    ClearInputFields();
                    break;
                case AppModuleCrudState.Edit:
                    EnableInputFields(true);
                    break;
                case AppModuleCrudState.Delete:
                    break;
            }
        }

        private void tileButCloseForm_Click(object sender, EventArgs e)
        {
            var appCloseResult = MetroMessageBox.Show(this, "Are you sure you want to close the customer contact manager?", "Customer Contact", MessageBoxButtons.YesNo);

            if (appCloseResult == DialogResult.Yes)
                this.Close();
        }

        private void tileButCancel_Click(object sender, EventArgs e)
        {
            LoadContactData();
            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.Brows;
        }

        private bool ValidateCustomerInfo()
        {

            if (txtName.Text.Trim() == "" || txtEmail.Text.Trim() == "" || txtNumber.Text.Trim() == "")
            {
                MetroMessageBox.Show(this, "Please make sure all required customer contact fields are populated!!");
                return false;
            }

            RegexUtilities RegexMailVerifier = new RegexUtilities();

            if (!RegexMailVerifier.IsValidEmail(txtEmail.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Please make sure the email address is in the correct format!!");
                return false;
            }

            bool MatchNumberFormat = Regex.IsMatch(txtNumber.Text.Trim(),
                   @"^\(\d{3}\) \d{3}-\d{4}$",
                   RegexOptions.IgnoreCase);

            if (!MatchNumberFormat)
            {
                MetroMessageBox.Show(this, "Please make sure the phone number is in the correct exact format (XXX) XXX-XXXX !!");
                return false;
            }

            return true;
        }

        private bool UpdateCustomerContactInfo()
        {

            if (!ValidateCustomerInfo())
                return false;

            try
            {
                string UpdateParams = string.Format("{0}, {1}, '{2}', '{3}', '{4}'",
                    _providerInfo.ParentId.ToString(),
                    _SelecteddataRow.ID.ToString(),
                    txtName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtNumber.Text.Trim()
                    );

                var UpdateResult = DatabaseUtil.produceDBInstance(_providerInfo.AuthInfo.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_CustomerContact_Update",
                    UpdateParams);
            }
            catch (Exception Ex)
            {
                MetroMessageBox.Show(this, "Oops!! Something went wrong trying to update the customer contact!!");
                return false;
            }

            return true;
        }

        private bool AddCustomerContactInfo()
        {

            if (!ValidateCustomerInfo())
                return false;

            try
            {
                string NewParams = string.Format("{0}, '{1}', '{2}', '{3}'",
                    _providerInfo.ParentId.ToString(),
                    txtName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtNumber.Text.Trim());

                var UpdateResult = DatabaseUtil.produceDBInstance(_providerInfo.AuthInfo.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_CustomerContact_Add",
                    NewParams);
            }
            catch (Exception Ex)
            {
                MetroMessageBox.Show(this, "Oops!! Something went wrong trying to add the customer contact!!");
                return false;
            }

            return true;
        }

        private bool DeleteCustomerContactInfo()
        {

            try
            {
                string DeleteParams = string.Format("{0}, {1}",
                    _providerInfo.ParentId.ToString(),
                    _SelecteddataRow.ID.ToString());

                var UpdateResult = DatabaseUtil.produceDBInstance(_providerInfo.AuthInfo.DefaultDBConnString).
                    ExecuteProcedure("dbo.usp_CustomerContact_Delete",
                    DeleteParams);
            }
            catch (Exception Ex)
            {
                MetroMessageBox.Show(this, "Oops!! Something went wrong trying to delete the customer contact!!");
                return false;
            }

            return true;
        }

        private bool CustomerContactInfoCrudOpperation(AppModuleCrudState crudState)
        {

            switch (_appDataGridCrudInfoHelper.CrudMode)
            {
                case AppModuleCrudState.New:
                    return AddCustomerContactInfo();
                case AppModuleCrudState.Edit:
                    return UpdateCustomerContactInfo();
                case AppModuleCrudState.Delete:
                    return DeleteCustomerContactInfo();
            }

            return false;
        }

        private void tileButSave_Click(object sender, EventArgs e)
        {

            bool UpdateCreateCustomerContactResult = CustomerContactInfoCrudOpperation(_appDataGridCrudInfoHelper.CrudMode);

            if (!UpdateCreateCustomerContactResult)
            {
                txtName.Focus();
                return;
            }

            LoadContactData();
            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.Brows;
        }

        private void tileButRefresh_Click(object sender, EventArgs e)
        {
            LoadContactData();
            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.Brows;
        }

        private void tileButDelete_Click(object sender, EventArgs e)
        {

            if (_appDataGridCrudInfoHelper.CurrentSelectedRow == null)
            {
                MetroMessageBox.Show(this, "No data selected to delete!!");
                return;
            }

            var appDeleteResult = MetroMessageBox.Show(this, "Are you sure you want to delete the selected customer contact?", "Customer Contact", MessageBoxButtons.YesNo);

            if (appDeleteResult == DialogResult.No)
                return;

            DeleteCustomerContactInfo();

            if (_appDataGridCrudInfoHelper.CurrentSelectedRow == null)
            {
                ClearInputFields();
            }

            LoadContactData();
            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.Brows;
        }

        private void tileButEdit_Click(object sender, EventArgs e)
        {

            if (_appDataGridCrudInfoHelper.CurrentSelectedRow == null)
            {
                MetroMessageBox.Show(this, "No data selected to edit!!");
                return;
            }

            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.Edit;
            txtName.Focus();
        }

        private void tileButNew_Click(object sender, EventArgs e)
        {
            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.New;
            txtName.Focus();
        }

        private void frmManageCustContacts_Load(object sender, EventArgs e)
        {
            _appDataGridCrudInfoHelper.Activate();

            _appDataGridCrudInfoHelper.onCrudModeNotification += crudModeNotification;
            _appDataGridCrudInfoHelper.onRowDataNotification += rowDataNotification;

            _appDataGridCrudInfoHelper.CrudMode = AppModuleCrudState.Brows;
            LoadContactData();
        }
    }
}
