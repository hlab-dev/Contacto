namespace ContactManager.AppModules.ContactManagerModule
{
    partial class frmManageCustContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCustContacts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.tileButCloseForm = new MetroFramework.Controls.MetroTile();
            this.tileButNew = new MetroFramework.Controls.MetroTile();
            this.tileButEdit = new MetroFramework.Controls.MetroTile();
            this.tileButDelete = new MetroFramework.Controls.MetroTile();
            this.tileButRefresh = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtNumber = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileButCancel = new MetroFramework.Controls.MetroTile();
            this.tileButSave = new MetroFramework.Controls.MetroTile();
            this.tileLblContactDetails = new MetroFramework.Controls.MetroTile();
            this.dataGridContacts = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tileLblCustomerDisplay = new MetroFramework.Controls.MetroTile();
            this.metroPanel7.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.tileButCloseForm);
            this.metroPanel7.Controls.Add(this.tileButNew);
            this.metroPanel7.Controls.Add(this.tileButEdit);
            this.metroPanel7.Controls.Add(this.tileButDelete);
            this.metroPanel7.Controls.Add(this.tileButRefresh);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(3, 665);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(1021, 100);
            this.metroPanel7.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel7.TabIndex = 3;
            this.metroPanel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel7.UseStyleColors = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // tileButCloseForm
            // 
            this.tileButCloseForm.ActiveControl = null;
            this.tileButCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButCloseForm.Location = new System.Drawing.Point(848, 0);
            this.tileButCloseForm.Name = "tileButCloseForm";
            this.tileButCloseForm.Size = new System.Drawing.Size(173, 100);
            this.tileButCloseForm.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButCloseForm.TabIndex = 5;
            this.tileButCloseForm.Text = "Close";
            this.tileButCloseForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileButCloseForm.TileImage = ((System.Drawing.Image)(resources.GetObject("tileButCloseForm.TileImage")));
            this.tileButCloseForm.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileButCloseForm.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileButCloseForm.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileButCloseForm.UseSelectable = true;
            this.tileButCloseForm.UseTileImage = true;
            this.tileButCloseForm.Click += new System.EventHandler(this.tileButCloseForm_Click);
            // 
            // tileButNew
            // 
            this.tileButNew.ActiveControl = null;
            this.tileButNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileButNew.Location = new System.Drawing.Point(306, 0);
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
            // tileButEdit
            // 
            this.tileButEdit.ActiveControl = null;
            this.tileButEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileButEdit.Location = new System.Drawing.Point(204, 0);
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
            // tileButDelete
            // 
            this.tileButDelete.ActiveControl = null;
            this.tileButDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileButDelete.Location = new System.Drawing.Point(102, 0);
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
            // tileButRefresh
            // 
            this.tileButRefresh.ActiveControl = null;
            this.tileButRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileButRefresh.Location = new System.Drawing.Point(0, 0);
            this.tileButRefresh.Name = "tileButRefresh";
            this.tileButRefresh.Size = new System.Drawing.Size(102, 100);
            this.tileButRefresh.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileButRefresh.TabIndex = 6;
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
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.dataGridContacts);
            this.metroPanel1.Controls.Add(this.tileLblCustomerDisplay);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 70);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1021, 595);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel3.Controls.Add(this.tileLblContactDetails);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(432, 57);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(589, 538);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 481);
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
            this.metroLabel1.Size = new System.Drawing.Size(213, 43);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name and Surname";
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
            this.metroLabel2.Size = new System.Drawing.Size(213, 43);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Email Address";
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
            this.metroLabel3.Size = new System.Drawing.Size(213, 43);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Phone Number";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(222, 3);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Add customer contact name and surname here";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(364, 37);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Add customer contact name and surname here";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(222, 46);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Add email info here";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.Size = new System.Drawing.Size(364, 37);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Add email info here";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumber
            // 
            // 
            // 
            // 
            this.txtNumber.CustomButton.Image = null;
            this.txtNumber.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.txtNumber.CustomButton.Name = "";
            this.txtNumber.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumber.CustomButton.TabIndex = 1;
            this.txtNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumber.CustomButton.UseSelectable = true;
            this.txtNumber.CustomButton.Visible = false;
            this.txtNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNumber.Lines = new string[0];
            this.txtNumber.Location = new System.Drawing.Point(222, 89);
            this.txtNumber.MaxLength = 32767;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.PromptText = "Format (XXX) XXX-XXXX";
            this.txtNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumber.SelectedText = "";
            this.txtNumber.SelectionLength = 0;
            this.txtNumber.SelectionStart = 0;
            this.txtNumber.ShortcutsEnabled = true;
            this.txtNumber.ShowClearButton = true;
            this.txtNumber.Size = new System.Drawing.Size(364, 37);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.UseSelectable = true;
            this.txtNumber.WaterMark = "Format (XXX) XXX-XXXX";
            this.txtNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tileButCancel);
            this.panel1.Controls.Add(this.tileButSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(222, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 101);
            this.panel1.TabIndex = 6;
            // 
            // tileButCancel
            // 
            this.tileButCancel.ActiveControl = null;
            this.tileButCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileButCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileButCancel.Location = new System.Drawing.Point(160, 0);
            this.tileButCancel.Name = "tileButCancel";
            this.tileButCancel.Size = new System.Drawing.Size(102, 101);
            this.tileButCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.tileButCancel.TabIndex = 10;
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
            this.tileButSave.Location = new System.Drawing.Point(262, 0);
            this.tileButSave.Name = "tileButSave";
            this.tileButSave.Size = new System.Drawing.Size(102, 101);
            this.tileButSave.Style = MetroFramework.MetroColorStyle.Green;
            this.tileButSave.TabIndex = 9;
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
            // tileLblContactDetails
            // 
            this.tileLblContactDetails.ActiveControl = null;
            this.tileLblContactDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileLblContactDetails.Location = new System.Drawing.Point(0, 0);
            this.tileLblContactDetails.Name = "tileLblContactDetails";
            this.tileLblContactDetails.Size = new System.Drawing.Size(589, 57);
            this.tileLblContactDetails.TabIndex = 3;
            this.tileLblContactDetails.TabStop = false;
            this.tileLblContactDetails.Text = "Contact Details";
            this.tileLblContactDetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblContactDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblContactDetails.UseSelectable = true;
            // 
            // dataGridContacts
            // 
            this.dataGridContacts.AllowUserToAddRows = false;
            this.dataGridContacts.AllowUserToDeleteRows = false;
            this.dataGridContacts.AllowUserToOrderColumns = true;
            this.dataGridContacts.AllowUserToResizeRows = false;
            this.dataGridContacts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridContacts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridContacts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ContactName,
            this.Email,
            this.ContactNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridContacts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridContacts.EnableHeadersVisualStyles = false;
            this.dataGridContacts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridContacts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridContacts.Location = new System.Drawing.Point(0, 57);
            this.dataGridContacts.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridContacts.MultiSelect = false;
            this.dataGridContacts.Name = "dataGridContacts";
            this.dataGridContacts.ReadOnly = true;
            this.dataGridContacts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridContacts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridContacts.RowTemplate.Height = 24;
            this.dataGridContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContacts.Size = new System.Drawing.Size(432, 538);
            this.dataGridContacts.Style = MetroFramework.MetroColorStyle.Blue;
            this.dataGridContacts.TabIndex = 5;
            this.dataGridContacts.UseStyleColors = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ContactName
            // 
            this.ContactName.HeaderText = "Contact Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // tileLblCustomerDisplay
            // 
            this.tileLblCustomerDisplay.ActiveControl = null;
            this.tileLblCustomerDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileLblCustomerDisplay.Location = new System.Drawing.Point(0, 0);
            this.tileLblCustomerDisplay.Name = "tileLblCustomerDisplay";
            this.tileLblCustomerDisplay.Size = new System.Drawing.Size(1021, 57);
            this.tileLblCustomerDisplay.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLblCustomerDisplay.TabIndex = 4;
            this.tileLblCustomerDisplay.TabStop = false;
            this.tileLblCustomerDisplay.Text = "Customer - Xyz";
            this.tileLblCustomerDisplay.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileLblCustomerDisplay.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.tileLblCustomerDisplay.UseSelectable = true;
            this.tileLblCustomerDisplay.UseStyleColors = true;
            // 
            // frmManageCustContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 768);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel7);
            this.MinimumSize = new System.Drawing.Size(1027, 768);
            this.Name = "frmManageCustContacts";
            this.Padding = new System.Windows.Forms.Padding(3, 70, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Contacts";
            this.Load += new System.EventHandler(this.frmManageCustContacts_Load);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroTile tileButEdit;
        private MetroFramework.Controls.MetroTile tileButNew;
        private MetroFramework.Controls.MetroTile tileButDelete;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile tileLblCustomerDisplay;
        private MetroFramework.Controls.MetroGrid dataGridContacts;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtNumber;
        private MetroFramework.Controls.MetroTile tileLblContactDetails;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile tileButCancel;
        private MetroFramework.Controls.MetroTile tileButSave;
        private MetroFramework.Controls.MetroTile tileButCloseForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private MetroFramework.Controls.MetroTile tileButRefresh;
    }
}