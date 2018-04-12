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
using ContactManager.AppModules.ContactManagerModule;
using ContactManager.Classes.AppModels;
using ContactManager.Classes.DataLayer;

namespace ContactManager
{
    public partial class frmContactoMain : MetroForm
    {
        private string _brandName = "Contacto";
        private UserControl _appModuleControl = null;
        private AuthDetails _loginDetails = null;
        private string _defaultDBConnStr = Properties.Settings.Default.DBDefaultConn.Trim();

        public frmContactoMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this._appModuleControl = null;

            ActivateAppOptionControls(AppWorkspaceViewType.Login);
        }

        private void tileButCloseApp_Click(object sender, EventArgs e)
        {
            var appExitResult = MetroMessageBox.Show(this,"Are you sure you want to exit the app?","App Exit",MessageBoxButtons.YesNo);

            if (appExitResult == DialogResult.Yes)
                this.Close();
        }

        private void tileLblUserName_Click(object sender, EventArgs e)
        {
            tlLoginInputGrid.Focus();
            txtLoginUserName.Focus();
            txtLoginUserName.Select();
            txtLoginUserName.Refresh();
            txtLoginUserName.Invalidate();
            this.Refresh();
        }

        private void tileLblUserPassword_Click(object sender, EventArgs e)
        {
            tlLoginInputGrid.Focus();
            txtLoginUserPassword.Focus();
            txtLoginUserPassword.Select();
            txtLoginUserPassword.Refresh();
            txtLoginUserPassword.Invalidate();
            this.Refresh();
        }

        private void frmContactoMain_Activated(object sender, EventArgs e)
        {
            txtLoginUserName.ShowClearButton = true;
            txtLoginUserPassword.ShowClearButton = true;
        }

        private void tileButLogin_Click(object sender, EventArgs e)
        {

            if (txtLoginUserName.Text.Trim() == "" || txtLoginUserPassword.Text.Trim() == "")
            {
                MetroMessageBox.Show(this, "Please make sure both user name and password are input correctly.");
                ActivateAppOptionControls(AppWorkspaceViewType.Login);
                return;
            }

            try
            {
                var databaseInst = DatabaseUtil.produceDBInstance(_defaultDBConnStr);
                var dataReqResult = databaseInst.ExecuteProcedure("dbo.usp_AuthenticateUser",
                    string.Format("'{0}', '{1}'", txtLoginUserName.Text.Trim(),
                        txtLoginUserPassword.Text.Trim()));
                databaseInst = null;

                if (dataReqResult == null)
                {
                    MetroMessageBox.Show(this, "Cant login. Please make sure your login credentials are correct.");
                    ActivateAppOptionControls(AppWorkspaceViewType.Login);
                    return;
                }

                _loginDetails = new AuthDetails();
                _loginDetails.AuthID = Convert.ToInt32(dataReqResult.Rows[0][0]);
                _loginDetails.RolePolicy = dataReqResult.Rows[0][1].ToString();
                _loginDetails.DefaultDBConnString = _defaultDBConnStr;

                dataReqResult.Dispose();
                dataReqResult = null;

                ActivateAppOptionControls(AppWorkspaceViewType.AppMenu);
            }catch(Exception ex)
            {
                ActivateAppOptionControls(AppWorkspaceViewType.Login);
            }
        }

        private void tileButLogout_Click(object sender, EventArgs e)
        {
            ActivateAppOptionControls(AppWorkspaceViewType.Login);
        }

        private void SetAppTitle(string Title)
        {
            this.Text = this._brandName + " - "+ Title;
            this.Refresh();
        }

        private void tileButMainMenu_Click(object sender, EventArgs e)
        {
            UnloadAppModule();
        }

        private void ActivateAppOptionControls(AppWorkspaceViewType WorkspaceViewtype, string TitleName="")
        {
            switch (WorkspaceViewtype)
            {
                case AppWorkspaceViewType.Login:
                    tabAppView.SelectedTab = appViewLogin;
                    tileButLogout.Visible = false;
                    tileButMainMenu.Visible = false;
                    if (TitleName.Trim() == "")
                        SetAppTitle("Login");
                    else SetAppTitle(TitleName);

                    txtLoginUserName.Text = "";
                    txtLoginUserPassword.Text = "";
                    tlLoginInputGrid.Focus();
                    txtLoginUserName.Focus();
                    txtLoginUserName.Select();
                    txtLoginUserName.Refresh();
                    txtLoginUserName.Invalidate();

                    _loginDetails = null;
                    this.Refresh();
                    break;
                case AppWorkspaceViewType.AppMenu:
                    tabAppView.SelectedTab = appViewMainMenu;
                    tileButLogout.Visible = true;
                    tileButMainMenu.Visible = true;
                    if (TitleName.Trim() == "")
                        SetAppTitle("App Menu");
                    else SetAppTitle(TitleName);
                    break;
                case AppWorkspaceViewType.AppModule:
                    tabAppView.SelectedTab = appViewModule;
                    tileButLogout.Visible = true;
                    tileButMainMenu.Visible = true;
                    SetAppTitle(TitleName);
                    break;
            }
        }

        private void LoadAppModule(ref UserControl AppUserControl, string DisplayText)
        {
            if (AppUserControl == null)
                return;

            if (this._appModuleControl != null)
            {
                this.pnlAppModuleHost.Controls.Remove(this._appModuleControl);
                this._appModuleControl.Dispose();
                this._appModuleControl = null;
            }

            this._appModuleControl = AppUserControl;

            pnlAppModuleHost.Controls.Add(this._appModuleControl);
            this._appModuleControl.Dock = DockStyle.Fill;

            ActivateAppOptionControls(AppWorkspaceViewType.AppModule, DisplayText);
        }

        private void UnloadAppModule()
        {
            if (this._appModuleControl == null)
                return;

            this.pnlAppModuleHost.Controls.Remove(this._appModuleControl);

            this._appModuleControl.Dispose();
            this._appModuleControl = null;

            ActivateAppOptionControls(AppWorkspaceViewType.AppMenu);
        }

        private void tileButModCustomerContacts_Click(object sender, EventArgs e)
        {
            UserControl appModule = new ucContactManager(this._loginDetails);
            this.LoadAppModule(ref appModule, "Customer Contacts");
        }

        private void tileButModConfig_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"Not implemented yet.");
        }
    }

    class AppViewTabControl : TabControl
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
