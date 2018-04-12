namespace ContactManager
{
    partial class frmContactoMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactoMain));
            this.pnlAppNavBar = new MetroFramework.Controls.MetroPanel();
            this.tileButLogout = new MetroFramework.Controls.MetroTile();
            this.tileButCloseApp = new MetroFramework.Controls.MetroTile();
            this.tileButMainMenu = new MetroFramework.Controls.MetroTile();
            this.pnlAppWorkSpace = new MetroFramework.Controls.MetroPanel();
            this.tabAppView = new ContactManager.AppViewTabControl();
            this.appViewLogin = new System.Windows.Forms.TabPage();
            this.tlLoginCanvasGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlLoginInputGrid = new System.Windows.Forms.TableLayoutPanel();
            this.tileButLogin = new MetroFramework.Controls.MetroTile();
            this.txtLoginUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginUserPassword = new MetroFramework.Controls.MetroTextBox();
            this.tileLblUserName = new MetroFramework.Controls.MetroTile();
            this.tileLblUserPassword = new MetroFramework.Controls.MetroTile();
            this.appViewMainMenu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tileButModCustomerContacts = new MetroFramework.Controls.MetroTile();
            this.tileButModConfig = new MetroFramework.Controls.MetroTile();
            this.appViewModule = new System.Windows.Forms.TabPage();
            this.pnlAppModuleHost = new System.Windows.Forms.Panel();
            this.pnlAppNavBar.SuspendLayout();
            this.pnlAppWorkSpace.SuspendLayout();
            this.tabAppView.SuspendLayout();
            this.appViewLogin.SuspendLayout();
            this.tlLoginCanvasGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlLoginInputGrid.SuspendLayout();
            this.appViewMainMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.appViewModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppNavBar
            // 
            this.pnlAppNavBar.BackColor = System.Drawing.Color.Gray;
            this.pnlAppNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlAppNavBar.Controls.Add(this.tileButLogout);
            this.pnlAppNavBar.Controls.Add(this.tileButCloseApp);
            this.pnlAppNavBar.Controls.Add(this.tileButMainMenu);
            this.pnlAppNavBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAppNavBar.HorizontalScrollbarBarColor = true;
            this.pnlAppNavBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAppNavBar.HorizontalScrollbarSize = 10;
            this.pnlAppNavBar.Location = new System.Drawing.Point(3, 644);
            this.pnlAppNavBar.Name = "pnlAppNavBar";
            this.pnlAppNavBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlAppNavBar.Size = new System.Drawing.Size(1021, 121);
            this.pnlAppNavBar.Style = MetroFramework.MetroColorStyle.Silver;
            this.pnlAppNavBar.TabIndex = 0;
            this.pnlAppNavBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlAppNavBar.UseStyleColors = true;
            this.pnlAppNavBar.VerticalScrollbarBarColor = false;
            this.pnlAppNavBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAppNavBar.VerticalScrollbarSize = 10;
            // 
            // tileButLogout
            // 
            this.tileButLogout.ActiveControl = null;
            this.tileButLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButLogout.Location = new System.Drawing.Point(670, 5);
            this.tileButLogout.Name = "tileButLogout";
            this.tileButLogout.Size = new System.Drawing.Size(173, 111);
            this.tileButLogout.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButLogout.TabIndex = 2;
            this.tileButLogout.Text = "Logout";
            this.tileButLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileButLogout.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButLogout.TileImage")));
            this.tileButLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileButLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButLogout.UseSelectable = true;
            this.tileButLogout.UseTileImage = true;
            this.tileButLogout.Visible = false;
            this.tileButLogout.Click += new System.EventHandler(this.tileButLogout_Click);
            // 
            // tileButCloseApp
            // 
            this.tileButCloseApp.ActiveControl = null;
            this.tileButCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButCloseApp.Location = new System.Drawing.Point(843, 5);
            this.tileButCloseApp.Name = "tileButCloseApp";
            this.tileButCloseApp.Size = new System.Drawing.Size(173, 111);
            this.tileButCloseApp.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButCloseApp.TabIndex = 3;
            this.tileButCloseApp.Text = "Close";
            this.tileButCloseApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileButCloseApp.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButCloseApp.TileImage")));
            this.tileButCloseApp.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButCloseApp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileButCloseApp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButCloseApp.UseSelectable = true;
            this.tileButCloseApp.UseTileImage = true;
            this.tileButCloseApp.Click += new System.EventHandler(this.tileButCloseApp_Click);
            // 
            // tileButMainMenu
            // 
            this.tileButMainMenu.ActiveControl = null;
            this.tileButMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileButMainMenu.Location = new System.Drawing.Point(5, 5);
            this.tileButMainMenu.Name = "tileButMainMenu";
            this.tileButMainMenu.Size = new System.Drawing.Size(159, 111);
            this.tileButMainMenu.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButMainMenu.TabIndex = 1;
            this.tileButMainMenu.Text = "Menu";
            this.tileButMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileButMainMenu.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButMainMenu.TileImage")));
            this.tileButMainMenu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButMainMenu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileButMainMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButMainMenu.UseSelectable = true;
            this.tileButMainMenu.UseTileImage = true;
            this.tileButMainMenu.Visible = false;
            this.tileButMainMenu.Click += new System.EventHandler(this.tileButMainMenu_Click);
            // 
            // pnlAppWorkSpace
            // 
            this.pnlAppWorkSpace.Controls.Add(this.tabAppView);
            this.pnlAppWorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppWorkSpace.HorizontalScrollbarBarColor = true;
            this.pnlAppWorkSpace.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlAppWorkSpace.HorizontalScrollbarSize = 10;
            this.pnlAppWorkSpace.Location = new System.Drawing.Point(3, 70);
            this.pnlAppWorkSpace.Name = "pnlAppWorkSpace";
            this.pnlAppWorkSpace.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pnlAppWorkSpace.Size = new System.Drawing.Size(1021, 574);
            this.pnlAppWorkSpace.TabIndex = 1;
            this.pnlAppWorkSpace.VerticalScrollbarBarColor = false;
            this.pnlAppWorkSpace.VerticalScrollbarHighlightOnWheel = false;
            this.pnlAppWorkSpace.VerticalScrollbarSize = 10;
            // 
            // tabAppView
            // 
            this.tabAppView.Controls.Add(this.appViewLogin);
            this.tabAppView.Controls.Add(this.appViewMainMenu);
            this.tabAppView.Controls.Add(this.appViewModule);
            this.tabAppView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAppView.Location = new System.Drawing.Point(3, 10);
            this.tabAppView.Margin = new System.Windows.Forms.Padding(5);
            this.tabAppView.Name = "tabAppView";
            this.tabAppView.SelectedIndex = 0;
            this.tabAppView.Size = new System.Drawing.Size(1015, 561);
            this.tabAppView.TabIndex = 2;
            // 
            // appViewLogin
            // 
            this.appViewLogin.Controls.Add(this.tlLoginCanvasGrid);
            this.appViewLogin.Location = new System.Drawing.Point(4, 25);
            this.appViewLogin.Name = "appViewLogin";
            this.appViewLogin.Padding = new System.Windows.Forms.Padding(3);
            this.appViewLogin.Size = new System.Drawing.Size(1007, 532);
            this.appViewLogin.TabIndex = 0;
            this.appViewLogin.Text = "Login";
            this.appViewLogin.UseVisualStyleBackColor = true;
            // 
            // tlLoginCanvasGrid
            // 
            this.tlLoginCanvasGrid.BackColor = System.Drawing.Color.DimGray;
            this.tlLoginCanvasGrid.ColumnCount = 3;
            this.tlLoginCanvasGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.96966F));
            this.tlLoginCanvasGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.66044F));
            this.tlLoginCanvasGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.3699F));
            this.tlLoginCanvasGrid.Controls.Add(this.panel1, 1, 1);
            this.tlLoginCanvasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlLoginCanvasGrid.Location = new System.Drawing.Point(3, 3);
            this.tlLoginCanvasGrid.Name = "tlLoginCanvasGrid";
            this.tlLoginCanvasGrid.RowCount = 3;
            this.tlLoginCanvasGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.24771F));
            this.tlLoginCanvasGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.88073F));
            this.tlLoginCanvasGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.87156F));
            this.tlLoginCanvasGrid.Size = new System.Drawing.Size(1001, 526);
            this.tlLoginCanvasGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.tlLoginInputGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(182, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 293);
            this.panel1.TabIndex = 0;
            // 
            // tlLoginInputGrid
            // 
            this.tlLoginInputGrid.BackColor = System.Drawing.Color.DimGray;
            this.tlLoginInputGrid.ColumnCount = 2;
            this.tlLoginInputGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlLoginInputGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlLoginInputGrid.Controls.Add(this.tileButLogin, 1, 2);
            this.tlLoginInputGrid.Controls.Add(this.txtLoginUserName, 1, 0);
            this.tlLoginInputGrid.Controls.Add(this.txtLoginUserPassword, 1, 1);
            this.tlLoginInputGrid.Controls.Add(this.tileLblUserName, 0, 0);
            this.tlLoginInputGrid.Controls.Add(this.tileLblUserPassword, 0, 1);
            this.tlLoginInputGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlLoginInputGrid.Location = new System.Drawing.Point(0, 0);
            this.tlLoginInputGrid.Margin = new System.Windows.Forms.Padding(0);
            this.tlLoginInputGrid.Name = "tlLoginInputGrid";
            this.tlLoginInputGrid.RowCount = 3;
            this.tlLoginInputGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlLoginInputGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlLoginInputGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlLoginInputGrid.Size = new System.Drawing.Size(621, 293);
            this.tlLoginInputGrid.TabIndex = 0;
            // 
            // tileButLogin
            // 
            this.tileButLogin.ActiveControl = null;
            this.tileButLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButLogin.Location = new System.Drawing.Point(203, 235);
            this.tileButLogin.Name = "tileButLogin";
            this.tileButLogin.Size = new System.Drawing.Size(415, 55);
            this.tileButLogin.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButLogin.TabIndex = 3;
            this.tileButLogin.Text = "Log Into My Workspace";
            this.tileButLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileButLogin.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileButLogin.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButLogin.UseSelectable = true;
            this.tileButLogin.Click += new System.EventHandler(this.tileButLogin_Click);
            // 
            // txtLoginUserName
            // 
            // 
            // 
            // 
            this.txtLoginUserName.CustomButton.Image = null;
            this.txtLoginUserName.CustomButton.Location = new System.Drawing.Point(307, 2);
            this.txtLoginUserName.CustomButton.Name = "";
            this.txtLoginUserName.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txtLoginUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginUserName.CustomButton.TabIndex = 1;
            this.txtLoginUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginUserName.CustomButton.UseSelectable = true;
            this.txtLoginUserName.CustomButton.Visible = false;
            this.txtLoginUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginUserName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLoginUserName.Lines = new string[0];
            this.txtLoginUserName.Location = new System.Drawing.Point(203, 3);
            this.txtLoginUserName.MaxLength = 32767;
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.PasswordChar = '\0';
            this.txtLoginUserName.PromptText = "Type in your user name";
            this.txtLoginUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginUserName.SelectedText = "";
            this.txtLoginUserName.SelectionLength = 0;
            this.txtLoginUserName.SelectionStart = 0;
            this.txtLoginUserName.ShortcutsEnabled = true;
            this.txtLoginUserName.Size = new System.Drawing.Size(415, 110);
            this.txtLoginUserName.TabIndex = 1;
            this.txtLoginUserName.UseSelectable = true;
            this.txtLoginUserName.WaterMark = "Type in your user name";
            this.txtLoginUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLoginUserPassword
            // 
            // 
            // 
            // 
            this.txtLoginUserPassword.CustomButton.Image = null;
            this.txtLoginUserPassword.CustomButton.Location = new System.Drawing.Point(307, 2);
            this.txtLoginUserPassword.CustomButton.Name = "";
            this.txtLoginUserPassword.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txtLoginUserPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginUserPassword.CustomButton.TabIndex = 1;
            this.txtLoginUserPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginUserPassword.CustomButton.UseSelectable = true;
            this.txtLoginUserPassword.CustomButton.Visible = false;
            this.txtLoginUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginUserPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLoginUserPassword.Lines = new string[0];
            this.txtLoginUserPassword.Location = new System.Drawing.Point(203, 119);
            this.txtLoginUserPassword.MaxLength = 32767;
            this.txtLoginUserPassword.Name = "txtLoginUserPassword";
            this.txtLoginUserPassword.PasswordChar = '#';
            this.txtLoginUserPassword.PromptText = "Type in your user password";
            this.txtLoginUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginUserPassword.SelectedText = "";
            this.txtLoginUserPassword.SelectionLength = 0;
            this.txtLoginUserPassword.SelectionStart = 0;
            this.txtLoginUserPassword.ShortcutsEnabled = true;
            this.txtLoginUserPassword.Size = new System.Drawing.Size(415, 110);
            this.txtLoginUserPassword.TabIndex = 2;
            this.txtLoginUserPassword.UseSelectable = true;
            this.txtLoginUserPassword.WaterMark = "Type in your user password";
            this.txtLoginUserPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUserPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileLblUserName
            // 
            this.tileLblUserName.ActiveControl = null;
            this.tileLblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLblUserName.Location = new System.Drawing.Point(3, 3);
            this.tileLblUserName.Name = "tileLblUserName";
            this.tileLblUserName.Size = new System.Drawing.Size(194, 110);
            this.tileLblUserName.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLblUserName.TabIndex = 3;
            this.tileLblUserName.Text = "User Name";
            this.tileLblUserName.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileLblUserName.TileImage = ((System.Drawing.Image)(resources.GetObject("tileLblUserName.TileImage")));
            this.tileLblUserName.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileLblUserName.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblUserName.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblUserName.UseSelectable = true;
            this.tileLblUserName.UseTileImage = true;
            this.tileLblUserName.Click += new System.EventHandler(this.tileLblUserName_Click);
            // 
            // tileLblUserPassword
            // 
            this.tileLblUserPassword.ActiveControl = null;
            this.tileLblUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLblUserPassword.Location = new System.Drawing.Point(3, 119);
            this.tileLblUserPassword.Name = "tileLblUserPassword";
            this.tileLblUserPassword.Size = new System.Drawing.Size(194, 110);
            this.tileLblUserPassword.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLblUserPassword.TabIndex = 4;
            this.tileLblUserPassword.Text = "Password";
            this.tileLblUserPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tileLblUserPassword.TileImage = ((System.Drawing.Image)(resources.GetObject("tileLblUserPassword.TileImage")));
            this.tileLblUserPassword.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileLblUserPassword.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblUserPassword.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblUserPassword.UseSelectable = true;
            this.tileLblUserPassword.UseTileImage = true;
            this.tileLblUserPassword.Click += new System.EventHandler(this.tileLblUserPassword_Click);
            // 
            // appViewMainMenu
            // 
            this.appViewMainMenu.Controls.Add(this.tableLayoutPanel1);
            this.appViewMainMenu.Location = new System.Drawing.Point(4, 25);
            this.appViewMainMenu.Name = "appViewMainMenu";
            this.appViewMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.appViewMainMenu.Size = new System.Drawing.Size(1007, 532);
            this.appViewMainMenu.TabIndex = 1;
            this.appViewMainMenu.Text = "Menu";
            this.appViewMainMenu.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.367561F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.61494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.017503F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.274232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.74232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.747045F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 526);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(56, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 430);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Controls.Add(this.tileButModCustomerContacts);
            this.flowLayoutPanel1.Controls.Add(this.tileButModConfig);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(891, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tileButModCustomerContacts
            // 
            this.tileButModCustomerContacts.ActiveControl = null;
            this.tileButModCustomerContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButModCustomerContacts.Location = new System.Drawing.Point(3, 3);
            this.tileButModCustomerContacts.Name = "tileButModCustomerContacts";
            this.tileButModCustomerContacts.Size = new System.Drawing.Size(260, 150);
            this.tileButModCustomerContacts.TabIndex = 0;
            this.tileButModCustomerContacts.Text = "Customer Contacts";
            this.tileButModCustomerContacts.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButModCustomerContacts.TileImage")));
            this.tileButModCustomerContacts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButModCustomerContacts.UseSelectable = true;
            this.tileButModCustomerContacts.UseTileImage = true;
            this.tileButModCustomerContacts.Click += new System.EventHandler(this.tileButModCustomerContacts_Click);
            // 
            // tileButModConfig
            // 
            this.tileButModConfig.ActiveControl = null;
            this.tileButModConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButModConfig.Location = new System.Drawing.Point(269, 3);
            this.tileButModConfig.Name = "tileButModConfig";
            this.tileButModConfig.Size = new System.Drawing.Size(201, 150);
            this.tileButModConfig.TabIndex = 2;
            this.tileButModConfig.Text = "Settings";
            this.tileButModConfig.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButModConfig.TileImage")));
            this.tileButModConfig.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButModConfig.UseSelectable = true;
            this.tileButModConfig.UseTileImage = true;
            this.tileButModConfig.Click += new System.EventHandler(this.tileButModConfig_Click);
            // 
            // appViewModule
            // 
            this.appViewModule.Controls.Add(this.pnlAppModuleHost);
            this.appViewModule.Location = new System.Drawing.Point(4, 25);
            this.appViewModule.Name = "appViewModule";
            this.appViewModule.Size = new System.Drawing.Size(1007, 532);
            this.appViewModule.TabIndex = 2;
            this.appViewModule.Text = "Module";
            this.appViewModule.UseVisualStyleBackColor = true;
            // 
            // pnlAppModuleHost
            // 
            this.pnlAppModuleHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAppModuleHost.Location = new System.Drawing.Point(0, 0);
            this.pnlAppModuleHost.Name = "pnlAppModuleHost";
            this.pnlAppModuleHost.Size = new System.Drawing.Size(1007, 532);
            this.pnlAppModuleHost.TabIndex = 0;
            // 
            // frmContactoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 768);
            this.Controls.Add(this.pnlAppWorkSpace);
            this.Controls.Add(this.pnlAppNavBar);
            this.MinimumSize = new System.Drawing.Size(1027, 768);
            this.Name = "frmContactoMain";
            this.Padding = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Contacto - Login";
            this.Activated += new System.EventHandler(this.frmContactoMain_Activated);
            this.pnlAppNavBar.ResumeLayout(false);
            this.pnlAppWorkSpace.ResumeLayout(false);
            this.tabAppView.ResumeLayout(false);
            this.appViewLogin.ResumeLayout(false);
            this.tlLoginCanvasGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlLoginInputGrid.ResumeLayout(false);
            this.appViewMainMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.appViewModule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlAppNavBar;
        private MetroFramework.Controls.MetroPanel pnlAppWorkSpace;
        private System.Windows.Forms.TabPage appViewLogin;
        private System.Windows.Forms.TabPage appViewMainMenu;
        private AppViewTabControl tabAppView;
        private System.Windows.Forms.TabPage appViewModule;
        private MetroFramework.Controls.MetroTile tileButMainMenu;
        private MetroFramework.Controls.MetroTile tileButLogout;
        private MetroFramework.Controls.MetroTile tileButCloseApp;
        private System.Windows.Forms.TableLayoutPanel tlLoginCanvasGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlLoginInputGrid;
        private MetroFramework.Controls.MetroTile tileButLogin;
        private MetroFramework.Controls.MetroTile tileLblUserName;
        private MetroFramework.Controls.MetroTile tileLblUserPassword;
        private MetroFramework.Controls.MetroTextBox txtLoginUserName;
        private MetroFramework.Controls.MetroTextBox txtLoginUserPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile tileButModCustomerContacts;
        private MetroFramework.Controls.MetroTile tileButModConfig;
        private System.Windows.Forms.Panel pnlAppModuleHost;
    }
}

