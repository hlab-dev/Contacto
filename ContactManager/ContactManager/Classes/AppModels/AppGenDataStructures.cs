using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MetroFramework;
using MetroFramework.Controls;
using System.Dynamic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactManager.Classes.AppModels
{

    public enum AppWorkspaceViewType
    {
        Login,
        AppMenu,
        AppModule
    }

    public enum AppModuleCrudState
    {
        New,
        Edit,
        Delete,
        Brows
    }

    public class AuthDetails
    {
        public int AuthID { get; set; }
        public string RolePolicy { get; set; }
        public string DefaultDBConnString { get; set; }
    }

    public class CrudModuleDataInfo
    {
        public AuthDetails AuthInfo { get; set; }
        public int ParentId { get; set; }
        public dynamic DataRow { get; set; }
        public string DisplayHeading { get; set; }
    }

    public class CrudModeNotificationArgs: EventArgs
    {
        private AppModuleCrudState _crudMode;
        private int _currentSelectedRow = -1;
        private dynamic _rowData = null;

        public AppModuleCrudState SelectedCrudMode { get { return this._crudMode; } set { this._crudMode = value; } } 
        public int CurrentSelectedIndex { get { return this._currentSelectedRow; } set { this._currentSelectedRow = value; } }
        public dynamic RowData { get { return this._rowData; } set { this._rowData = value; } }
    }

    public class AppDataGridCrudInfoHelper
    {
        private AppModuleCrudState _crudMode = AppModuleCrudState.Brows;
        private DataTable _dataRecords = null;
        
        public event CrudModeNotification onCrudModeNotification;
        public delegate void CrudModeNotification(AppDataGridCrudInfoHelper sender, CrudModeNotificationArgs e);

        public event DataRowNotification onRowDataNotification;
        public delegate void DataRowNotification(AppDataGridCrudInfoHelper sender, CrudModeNotificationArgs e);

        public AuthDetails LoginDetails { get; set; } = null;
        public AppModuleCrudState CrudMode { get { return _crudMode; } set { SetCrudControls(value); } }
        public int GridSelectedIndex = -1;
        public int GridLastSelectedIndex = -1;
        public DataTable DataRecords { get { return _dataRecords; } set { SetDataRecords(value); } }
        public dynamic CurrentSelectedRow = null;
        public int CurrentRecordID = -1;
        public MetroGrid RefDataGrid = null;
        public MetroTile RefButRefresh = null;
        public MetroTile RefButDelete = null;
        public MetroTile RefButEdit = null;
        public MetroTile RefButNew = null;
        public MetroTile RefButSave = null;
        public MetroTile RefButCancel = null;

        public void Activate()
        {
            if (RefDataGrid != null)
            {
                RefDataGrid.SelectionChanged += dataGridReference_SelectionChanged;
            }
        }

        private void SetDataRecords(DataTable DataRecordsSource)
        {
            if (_dataRecords != null)
            {
                _dataRecords.Dispose();
                _dataRecords = null;
            }

            if (DataRecordsSource != null)
            {
                _dataRecords = DataRecordsSource;

                RefDataGrid.Columns.Clear();
                RefDataGrid.DataSource = null;
                RefDataGrid.Refresh();
                RefDataGrid.DataSource = DataRecords;
                RefDataGrid.Refresh();
                GridSelectedIndex = 0;
            }
            else
            {
                _dataRecords = null;
                RefDataGrid.Columns.Clear();
                RefDataGrid.DataSource = null;
                RefDataGrid.Refresh();
                GridSelectedIndex = -1;
            }
        }

        public void SetCrudControls(AppModuleCrudState CrudModeSelected)
        {
            try
            {

                _crudMode = CrudModeSelected;

                if (onCrudModeNotification != null)
                {
                    CrudModeNotificationArgs crudNotifyArgs = new CrudModeNotificationArgs();
                    crudNotifyArgs.SelectedCrudMode = _crudMode;

                    onCrudModeNotification(this, crudNotifyArgs);

                }

                    switch (CrudMode)
                {
                    case AppModuleCrudState.Brows:
                        RefButSave.Visible = false;
                        RefButCancel.Visible = false;
                        RefButDelete.Enabled = true;
                        RefButNew.Enabled = true;
                        RefButEdit.Enabled = true;
                        RefButRefresh.Enabled = true;
                        RefDataGrid.Enabled = true;

                        break;
                    case AppModuleCrudState.New:
                        RefButSave.Visible = true;
                        RefButCancel.Visible = true;
                        RefButDelete.Enabled = false;
                        RefButNew.Enabled = false;
                        RefButEdit.Enabled = false;
                        RefButRefresh.Enabled = false;
                        RefDataGrid.Enabled = false;
                        break;
                    case AppModuleCrudState.Edit:
                        RefButSave.Visible = true;
                        RefButCancel.Visible = true;
                        RefButDelete.Enabled = false;
                        RefButNew.Enabled = false;
                        RefButEdit.Enabled = false;
                        RefButRefresh.Enabled = false;
                        RefDataGrid.Enabled = false;
                        break;
                    case AppModuleCrudState.Delete:
                        break;
                }
            }
            catch (Exception Ex)
            {
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
            }
            catch (Exception Ex)
            {
                return null;
            }

            return tmpObject;
        }

        public void UpdateRowSelectIndex(int RowIndex)
        {

            CurrentSelectedRow = null;

            if (RefDataGrid.DataSource == null)
                return;

            if (RowIndex < 0)
            {
                SetCrudControls(AppModuleCrudState.Brows);
                return;
            }

            if (RowIndex > RefDataGrid.Rows.Count)
            {
                SetCrudControls(AppModuleCrudState.Brows);
                return;
            }

            try
            {
                DataTable table = RefDataGrid.DataSource as DataTable;
                DataRow dataRow = table.NewRow();

                try
                {
                    dataRow = ((DataRowView)RefDataGrid.SelectedRows[0].DataBoundItem).Row;
                }catch(Exception Ex)
                { return; }

                dynamic dataRowObj;
                dataRowObj = DataRowToObject(dataRow);
                CurrentSelectedRow = dataRowObj;

                if (dataRowObj != null)
                {
                    if (onRowDataNotification != null)
                    {
                        CrudModeNotificationArgs crudNotifyArgs = new CrudModeNotificationArgs();
                        crudNotifyArgs.SelectedCrudMode = _crudMode;
                        crudNotifyArgs.RowData = dataRowObj;
                        crudNotifyArgs.CurrentSelectedIndex = this.GridSelectedIndex;

                        onRowDataNotification(this, crudNotifyArgs);

                    }
                }
                //string dataRowObjectStr = JsonConvert.SerializeObject((dataRowObj));

                if (dataRowObj == null)
                {
                    SetCrudControls(AppModuleCrudState.Brows);
                    return;
                }
            }catch(Exception Ex)
            {
                SetCrudControls(AppModuleCrudState.Brows);
                CurrentSelectedRow = null;
                return;
            }
        }

        public void dataGridReference_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (RefDataGrid.CurrentRow == null)
                {
                    this.CurrentSelectedRow = null;
                    return;
                }

                int rowSelectedIndex = RefDataGrid.CurrentRow.Index;
                this.CurrentSelectedRow = rowSelectedIndex;

                if (rowSelectedIndex >= 0)
                {
                    UpdateRowSelectIndex(this.CurrentSelectedRow);
                }

            }
            catch(Exception Ex)
            {
                this.CurrentSelectedRow = null;
            }


        }

    }

    public class RegexUtilities
    {
        bool invalid = false;

        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper);
            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,
                   @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                   RegexOptions.IgnoreCase);
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
