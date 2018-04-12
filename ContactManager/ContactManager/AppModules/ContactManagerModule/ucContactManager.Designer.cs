using ContactManager.AppModules.ContactManagerModule;

namespace ContactManager.AppModules.ContactManagerModule
{
    partial class ucContactManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContactManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tileLblCustomer = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tabCustomerContactsCRUD = new ContactManager.AppModules.ContactManagerModule.AppModuleCustomerContactsTabControl();
            this.modViewCustomers = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtLatitude = new MetroFramework.Controls.MetroTextBox();
            this.txtLongtitude = new MetroFramework.Controls.MetroTextBox();
            this.pnlCustomerActions = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tileButManageContacts = new MetroFramework.Controls.MetroTile();
            this.tileLblActions = new MetroFramework.Controls.MetroTile();
            this.tileLblCustomerDetails = new MetroFramework.Controls.MetroTile();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.tileButCancel = new MetroFramework.Controls.MetroTile();
            this.tileButSave = new MetroFramework.Controls.MetroTile();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dataGridCustomers = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.tileButDelete = new MetroFramework.Controls.MetroTile();
            this.tileButEdit = new MetroFramework.Controls.MetroTile();
            this.tileButNew = new MetroFramework.Controls.MetroTile();
            this.tileButRefresh = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tabCustomerContactsCRUD.SuspendLayout();
            this.modViewCustomers.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCustomerActions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.metroPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tileLblCustomer);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1163, 58);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tileLblCustomer
            // 
            this.tileLblCustomer.ActiveControl = null;
            this.tileLblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLblCustomer.Location = new System.Drawing.Point(0, 0);
            this.tileLblCustomer.Name = "tileLblCustomer";
            this.tileLblCustomer.Size = new System.Drawing.Size(1163, 58);
            this.tileLblCustomer.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLblCustomer.TabIndex = 2;
            this.tileLblCustomer.TabStop = false;
            this.tileLblCustomer.Text = "Customers";
            this.tileLblCustomer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblCustomer.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tabCustomerContactsCRUD);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 58);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1163, 623);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tabCustomerContactsCRUD
            // 
            this.tabCustomerContactsCRUD.Controls.Add(this.modViewCustomers);
            this.tabCustomerContactsCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCustomerContactsCRUD.Location = new System.Drawing.Point(0, 0);
            this.tabCustomerContactsCRUD.Name = "tabCustomerContactsCRUD";
            this.tabCustomerContactsCRUD.SelectedIndex = 0;
            this.tabCustomerContactsCRUD.Size = new System.Drawing.Size(1163, 623);
            this.tabCustomerContactsCRUD.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabCustomerContactsCRUD.TabIndex = 2;
            this.tabCustomerContactsCRUD.UseSelectable = true;
            // 
            // modViewCustomers
            // 
            this.modViewCustomers.Controls.Add(this.metroPanel3);
            this.modViewCustomers.Controls.Add(this.metroPanel4);
            this.modViewCustomers.HorizontalScrollbarBarColor = false;
            this.modViewCustomers.HorizontalScrollbarHighlightOnWheel = false;
            this.modViewCustomers.HorizontalScrollbarSize = 0;
            this.modViewCustomers.Location = new System.Drawing.Point(4, 38);
            this.modViewCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.modViewCustomers.Name = "modViewCustomers";
            this.modViewCustomers.Size = new System.Drawing.Size(1155, 581);
            this.modViewCustomers.TabIndex = 0;
            this.modViewCustomers.Text = "Customers";
            this.modViewCustomers.VerticalScrollbarBarColor = false;
            this.modViewCustomers.VerticalScrollbarHighlightOnWheel = false;
            this.modViewCustomers.VerticalScrollbarSize = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel3.Controls.Add(this.tileLblCustomerDetails);
            this.metroPanel3.Controls.Add(this.metroPanel8);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(449, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(706, 581);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLatitude, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLongtitude, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlCustomerActions, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 424);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 43);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 43);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(142, 43);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Latitude";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 43);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Longtitude";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(151, 3);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Add customer name and surname here";
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.ShowClearButton = true;
            this.txtCustomerName.Size = new System.Drawing.Size(552, 37);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Add customer name and surname here";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLatitude
            // 
            // 
            // 
            // 
            this.txtLatitude.CustomButton.Image = null;
            this.txtLatitude.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtLatitude.CustomButton.Name = "";
            this.txtLatitude.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtLatitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLatitude.CustomButton.TabIndex = 1;
            this.txtLatitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLatitude.CustomButton.UseSelectable = true;
            this.txtLatitude.CustomButton.Visible = false;
            this.txtLatitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLatitude.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLatitude.Lines = new string[0];
            this.txtLatitude.Location = new System.Drawing.Point(151, 46);
            this.txtLatitude.MaxLength = 32767;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.PasswordChar = '\0';
            this.txtLatitude.PromptText = "Add location info here";
            this.txtLatitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLatitude.SelectedText = "";
            this.txtLatitude.SelectionLength = 0;
            this.txtLatitude.SelectionStart = 0;
            this.txtLatitude.ShortcutsEnabled = true;
            this.txtLatitude.ShowClearButton = true;
            this.txtLatitude.Size = new System.Drawing.Size(552, 37);
            this.txtLatitude.TabIndex = 4;
            this.txtLatitude.UseSelectable = true;
            this.txtLatitude.WaterMark = "Add location info here";
            this.txtLatitude.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLatitude.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLongtitude
            // 
            // 
            // 
            // 
            this.txtLongtitude.CustomButton.Image = null;
            this.txtLongtitude.CustomButton.Location = new System.Drawing.Point(516, 1);
            this.txtLongtitude.CustomButton.Name = "";
            this.txtLongtitude.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtLongtitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLongtitude.CustomButton.TabIndex = 1;
            this.txtLongtitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLongtitude.CustomButton.UseSelectable = true;
            this.txtLongtitude.CustomButton.Visible = false;
            this.txtLongtitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLongtitude.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtLongtitude.Lines = new string[0];
            this.txtLongtitude.Location = new System.Drawing.Point(151, 89);
            this.txtLongtitude.MaxLength = 32767;
            this.txtLongtitude.Name = "txtLongtitude";
            this.txtLongtitude.PasswordChar = '\0';
            this.txtLongtitude.PromptText = "Add location info here";
            this.txtLongtitude.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLongtitude.SelectedText = "";
            this.txtLongtitude.SelectionLength = 0;
            this.txtLongtitude.SelectionStart = 0;
            this.txtLongtitude.ShortcutsEnabled = true;
            this.txtLongtitude.ShowClearButton = true;
            this.txtLongtitude.Size = new System.Drawing.Size(552, 37);
            this.txtLongtitude.TabIndex = 5;
            this.txtLongtitude.UseSelectable = true;
            this.txtLongtitude.WaterMark = "Add location info here";
            this.txtLongtitude.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLongtitude.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlCustomerActions
            // 
            this.pnlCustomerActions.Controls.Add(this.flowLayoutPanel1);
            this.pnlCustomerActions.Controls.Add(this.tileLblActions);
            this.pnlCustomerActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerActions.HorizontalScrollbarBarColor = true;
            this.pnlCustomerActions.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCustomerActions.HorizontalScrollbarSize = 10;
            this.pnlCustomerActions.Location = new System.Drawing.Point(151, 189);
            this.pnlCustomerActions.Name = "pnlCustomerActions";
            this.pnlCustomerActions.Size = new System.Drawing.Size(552, 232);
            this.pnlCustomerActions.TabIndex = 6;
            this.pnlCustomerActions.VerticalScrollbarBarColor = true;
            this.pnlCustomerActions.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCustomerActions.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tileButManageContacts);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(552, 175);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tileButManageContacts
            // 
            this.tileButManageContacts.ActiveControl = null;
            this.tileButManageContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButManageContacts.Location = new System.Drawing.Point(13, 13);
            this.tileButManageContacts.Name = "tileButManageContacts";
            this.tileButManageContacts.Size = new System.Drawing.Size(168, 76);
            this.tileButManageContacts.TabIndex = 0;
            this.tileButManageContacts.Text = "Manage Contacts";
            this.tileButManageContacts.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButManageContacts.TileImage")));
            this.tileButManageContacts.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButManageContacts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileButManageContacts.UseSelectable = true;
            this.tileButManageContacts.UseTileImage = true;
            this.tileButManageContacts.Click += new System.EventHandler(this.tileButManageContacts_Click);
            // 
            // tileLblActions
            // 
            this.tileLblActions.ActiveControl = null;
            this.tileLblActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileLblActions.Location = new System.Drawing.Point(0, 0);
            this.tileLblActions.Name = "tileLblActions";
            this.tileLblActions.Size = new System.Drawing.Size(552, 57);
            this.tileLblActions.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLblActions.TabIndex = 4;
            this.tileLblActions.TabStop = false;
            this.tileLblActions.Text = "Actions";
            this.tileLblActions.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblActions.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblActions.UseSelectable = true;
            this.tileLblActions.UseStyleColors = true;
            // 
            // tileLblCustomerDetails
            // 
            this.tileLblCustomerDetails.ActiveControl = null;
            this.tileLblCustomerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileLblCustomerDetails.Location = new System.Drawing.Point(0, 0);
            this.tileLblCustomerDetails.Name = "tileLblCustomerDetails";
            this.tileLblCustomerDetails.Size = new System.Drawing.Size(706, 57);
            this.tileLblCustomerDetails.TabIndex = 3;
            this.tileLblCustomerDetails.TabStop = false;
            this.tileLblCustomerDetails.Text = "Customer Details";
            this.tileLblCustomerDetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblCustomerDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblCustomerDetails.UseSelectable = true;
            // 
            // metroPanel8
            // 
            this.metroPanel8.Controls.Add(this.tileButCancel);
            this.metroPanel8.Controls.Add(this.tileButSave);
            this.metroPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(0, 481);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(706, 100);
            this.metroPanel8.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel8.TabIndex = 2;
            this.metroPanel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel8.UseStyleColors = true;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // tileButCancel
            // 
            this.tileButCancel.ActiveControl = null;
            this.tileButCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButCancel.Location = new System.Drawing.Point(502, 0);
            this.tileButCancel.Name = "tileButCancel";
            this.tileButCancel.Size = new System.Drawing.Size(102, 100);
            this.tileButCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.tileButCancel.TabIndex = 6;
            this.tileButCancel.Text = "Cancel";
            this.tileButCancel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileButCancel.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButCancel.TileImage")));
            this.tileButCancel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButCancel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButCancel.UseSelectable = true;
            this.tileButCancel.UseStyleColors = true;
            this.tileButCancel.UseTileImage = true;
            this.tileButCancel.Click += new System.EventHandler(this.tileButCancel_Click);
            // 
            // tileButSave
            // 
            this.tileButSave.ActiveControl = null;
            this.tileButSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButSave.Location = new System.Drawing.Point(604, 0);
            this.tileButSave.Name = "tileButSave";
            this.tileButSave.Size = new System.Drawing.Size(102, 100);
            this.tileButSave.Style = MetroFramework.MetroColorStyle.Green;
            this.tileButSave.TabIndex = 5;
            this.tileButSave.Text = "Save";
            this.tileButSave.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileButSave.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButSave.TileImage")));
            this.tileButSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButSave.UseSelectable = true;
            this.tileButSave.UseStyleColors = true;
            this.tileButSave.UseTileImage = true;
            this.tileButSave.Click += new System.EventHandler(this.tileButSave_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dataGridCustomers);
            this.metroPanel4.Controls.Add(this.metroPanel7);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel4.HorizontalScrollbarBarColor = false;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(449, 581);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToOrderColumns = true;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.Latitude,
            this.Longitude});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomers.EnableHeadersVisualStyles = false;
            this.dataGridCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridCustomers.MultiSelect = false;
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.ReadOnly = true;
            this.dataGridCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCustomers.RowTemplate.Height = 24;
            this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomers.Size = new System.Drawing.Size(449, 481);
            this.dataGridCustomers.Style = MetroFramework.MetroColorStyle.Blue;
            this.dataGridCustomers.TabIndex = 3;
            this.dataGridCustomers.UseStyleColors = true;
            this.dataGridCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomers_RowEnter);
            this.dataGridCustomers.SelectionChanged += new System.EventHandler(this.dataGridCustomers_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.tileButDelete);
            this.metroPanel7.Controls.Add(this.tileButEdit);
            this.metroPanel7.Controls.Add(this.tileButNew);
            this.metroPanel7.Controls.Add(this.tileButRefresh);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 481);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(449, 100);
            this.metroPanel7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel7.TabIndex = 2;
            this.metroPanel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel7.UseStyleColors = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // tileButDelete
            // 
            this.tileButDelete.ActiveControl = null;
            this.tileButDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButDelete.Location = new System.Drawing.Point(143, 0);
            this.tileButDelete.Name = "tileButDelete";
            this.tileButDelete.Size = new System.Drawing.Size(102, 100);
            this.tileButDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileButDelete.TabIndex = 2;
            this.tileButDelete.Text = "Delete";
            this.tileButDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileButDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButDelete.TileImage")));
            this.tileButDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButDelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButDelete.UseSelectable = true;
            this.tileButDelete.UseStyleColors = true;
            this.tileButDelete.UseTileImage = true;
            this.tileButDelete.Click += new System.EventHandler(this.tileButDelete_Click);
            // 
            // tileButEdit
            // 
            this.tileButEdit.ActiveControl = null;
            this.tileButEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButEdit.Location = new System.Drawing.Point(245, 0);
            this.tileButEdit.Name = "tileButEdit";
            this.tileButEdit.Size = new System.Drawing.Size(102, 100);
            this.tileButEdit.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileButEdit.TabIndex = 4;
            this.tileButEdit.Text = "Edit";
            this.tileButEdit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileButEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButEdit.TileImage")));
            this.tileButEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButEdit.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButEdit.UseSelectable = true;
            this.tileButEdit.UseStyleColors = true;
            this.tileButEdit.UseTileImage = true;
            this.tileButEdit.Click += new System.EventHandler(this.tileButEdit_Click);
            // 
            // tileButNew
            // 
            this.tileButNew.ActiveControl = null;
            this.tileButNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButNew.Location = new System.Drawing.Point(347, 0);
            this.tileButNew.Name = "tileButNew";
            this.tileButNew.Size = new System.Drawing.Size(102, 100);
            this.tileButNew.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileButNew.TabIndex = 3;
            this.tileButNew.Text = "New";
            this.tileButNew.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileButNew.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButNew.TileImage")));
            this.tileButNew.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButNew.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButNew.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButNew.UseSelectable = true;
            this.tileButNew.UseStyleColors = true;
            this.tileButNew.UseTileImage = true;
            this.tileButNew.Click += new System.EventHandler(this.tileButNew_Click);
            // 
            // tileButRefresh
            // 
            this.tileButRefresh.ActiveControl = null;
            this.tileButRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileButRefresh.Location = new System.Drawing.Point(0, 0);
            this.tileButRefresh.Name = "tileButRefresh";
            this.tileButRefresh.Size = new System.Drawing.Size(102, 100);
            this.tileButRefresh.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButRefresh.TabIndex = 7;
            this.tileButRefresh.Text = "Refresh";
            this.tileButRefresh.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tileButRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButRefresh.TileImage")));
            this.tileButRefresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButRefresh.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileButRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButRefresh.UseSelectable = true;
            this.tileButRefresh.UseStyleColors = true;
            this.tileButRefresh.UseTileImage = true;
            this.tileButRefresh.Click += new System.EventHandler(this.tileButRefresh_Click);
            // 
            // ucContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ucContactManager";
            this.Size = new System.Drawing.Size(1163, 681);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.tabCustomerContactsCRUD.ResumeLayout(false);
            this.modViewCustomers.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlCustomerActions.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.metroPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabPage modViewCustomers;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroGrid dataGridCustomers;
        private MetroFramework.Controls.MetroTile tileButDelete;
        private MetroFramework.Controls.MetroTile tileButEdit;
        private MetroFramework.Controls.MetroTile tileButNew;
        private MetroFramework.Controls.MetroTile tileButCancel;
        private MetroFramework.Controls.MetroTile tileButSave;
        private ContactManagerModule.AppModuleCustomerContactsTabControl tabCustomerContactsCRUD;
        private MetroFramework.Controls.MetroTile tileLblCustomer;
        private MetroFramework.Controls.MetroTile tileLblCustomerDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTextBox txtLatitude;
        private MetroFramework.Controls.MetroTextBox txtLongtitude;
        private MetroFramework.Controls.MetroPanel pnlCustomerActions;
        private MetroFramework.Controls.MetroTile tileLblActions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile tileButManageContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private MetroFramework.Controls.MetroTile tileButRefresh;
    }
}
