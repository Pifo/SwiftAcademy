namespace MovieStore
{
    partial class DVDsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label dvdNumberLabel;
            System.Windows.Forms.Label dvdIdLabel;
            System.Windows.Forms.Label availableLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DVDsForm));
            this.errorProviderDvd = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPageReturnDate = new System.Windows.Forms.TabPage();
            this.dataGridViewCustom = new System.Windows.Forms.DataGridView();
            this.tabPageUnavailable = new System.Windows.Forms.TabPage();
            this.dvdsDataGridViewUnavailable = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAvailableDvd = new System.Windows.Forms.TabPage();
            this.dvdsDataGridViewAvailable = new System.Windows.Forms.DataGridView();
            this.tabPageEditDvd = new System.Windows.Forms.TabPage();
            this.buttonEditDvd = new System.Windows.Forms.Button();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.dvdIdLabel1 = new System.Windows.Forms.Label();
            this.dvdNumberTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.tabPageShowDvd = new System.Windows.Forms.TabPage();
            this.buttonDelDvd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelDvd = new System.Windows.Forms.TextBox();
            this.bindingNavigatorShowAllDvds = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dvdsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageAddDvd = new System.Windows.Forms.TabPage();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.buttonAddDvd = new System.Windows.Forms.Button();
            this.tabControlDvd = new System.Windows.Forms.TabControl();
            this.tabPageDvdInfo = new System.Windows.Forms.TabPage();
            this.labelInfoPoster = new System.Windows.Forms.Label();
            this.labelInfoDirector = new System.Windows.Forms.Label();
            this.labelInfoActors = new System.Windows.Forms.Label();
            this.labelInfoYear = new System.Windows.Forms.Label();
            this.labelInfoRelease = new System.Windows.Forms.Label();
            this.labelInfoRuntime = new System.Windows.Forms.Label();
            this.labelInfoGenre = new System.Windows.Forms.Label();
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.labelDvdTitle = new System.Windows.Forms.Label();
            this.textBoxDvdTitle = new System.Windows.Forms.TextBox();
            this.pictureBoxInfoPoster = new System.Windows.Forms.PictureBox();
            this.textBoxInfoActors = new System.Windows.Forms.TextBox();
            this.dateTimePickerInfoRelease = new System.Windows.Forms.DateTimePicker();
            this.textBoxInfoYear = new System.Windows.Forms.TextBox();
            this.textBoxInfoDirector = new System.Windows.Forms.TextBox();
            this.textBoxInfoRuntime = new System.Windows.Forms.TextBox();
            this.textBoxInfoGenre = new System.Windows.Forms.TextBox();
            this.textBoxInfoTitle = new System.Windows.Forms.TextBox();
            this.dvdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            titleLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            dvdNumberLabel = new System.Windows.Forms.Label();
            dvdIdLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDvd)).BeginInit();
            this.tabPageReturnDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustom)).BeginInit();
            this.tabPageUnavailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvdsDataGridViewUnavailable)).BeginInit();
            this.tabPageAvailableDvd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvdsDataGridViewAvailable)).BeginInit();
            this.tabPageEditDvd.SuspendLayout();
            this.tabPageShowDvd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorShowAllDvds)).BeginInit();
            this.bindingNavigatorShowAllDvds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvdsDataGridView)).BeginInit();
            this.tabPageAddDvd.SuspendLayout();
            this.tabControlDvd.SuspendLayout();
            this.tabPageDvdInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(249, 194);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Title:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(249, 168);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(249, 142);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "Genre:";
            // 
            // dvdNumberLabel
            // 
            dvdNumberLabel.AutoSize = true;
            dvdNumberLabel.Location = new System.Drawing.Point(249, 116);
            dvdNumberLabel.Name = "dvdNumberLabel";
            dvdNumberLabel.Size = new System.Drawing.Size(70, 13);
            dvdNumberLabel.TabIndex = 4;
            dvdNumberLabel.Text = "Dvd Number:";
            // 
            // dvdIdLabel
            // 
            dvdIdLabel.AutoSize = true;
            dvdIdLabel.Location = new System.Drawing.Point(249, 57);
            dvdIdLabel.Name = "dvdIdLabel";
            dvdIdLabel.Size = new System.Drawing.Size(42, 13);
            dvdIdLabel.TabIndex = 2;
            dvdIdLabel.Text = "Dvd Id:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(249, 88);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(53, 13);
            availableLabel.TabIndex = 0;
            availableLabel.Text = "Available:";
            // 
            // errorProviderDvd
            // 
            this.errorProviderDvd.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDvd.ContainerControl = this;
            // 
            // tabPageReturnDate
            // 
            this.tabPageReturnDate.Controls.Add(this.dataGridViewCustom);
            this.tabPageReturnDate.Location = new System.Drawing.Point(4, 22);
            this.tabPageReturnDate.Name = "tabPageReturnDate";
            this.tabPageReturnDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReturnDate.Size = new System.Drawing.Size(714, 389);
            this.tabPageReturnDate.TabIndex = 4;
            this.tabPageReturnDate.Text = "Return Date";
            this.tabPageReturnDate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustom
            // 
            this.dataGridViewCustom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustom.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCustom.Name = "dataGridViewCustom";
            this.dataGridViewCustom.Size = new System.Drawing.Size(708, 383);
            this.dataGridViewCustom.TabIndex = 0;
            // 
            // tabPageUnavailable
            // 
            this.tabPageUnavailable.Controls.Add(this.dvdsDataGridViewUnavailable);
            this.tabPageUnavailable.Location = new System.Drawing.Point(4, 22);
            this.tabPageUnavailable.Name = "tabPageUnavailable";
            this.tabPageUnavailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUnavailable.Size = new System.Drawing.Size(714, 389);
            this.tabPageUnavailable.TabIndex = 3;
            this.tabPageUnavailable.Text = "Show Unavailable DVDs";
            this.tabPageUnavailable.UseVisualStyleBackColor = true;
            // 
            // dvdsDataGridViewUnavailable
            // 
            this.dvdsDataGridViewUnavailable.AutoGenerateColumns = false;
            this.dvdsDataGridViewUnavailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdsDataGridViewUnavailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19,
            this.Price});
            this.dvdsDataGridViewUnavailable.DataSource = this.dvdsBindingSource;
            this.dvdsDataGridViewUnavailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvdsDataGridViewUnavailable.Location = new System.Drawing.Point(3, 3);
            this.dvdsDataGridViewUnavailable.Name = "dvdsDataGridViewUnavailable";
            this.dvdsDataGridViewUnavailable.Size = new System.Drawing.Size(708, 383);
            this.dvdsDataGridViewUnavailable.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // tabPageAvailableDvd
            // 
            this.tabPageAvailableDvd.Controls.Add(this.dvdsDataGridViewAvailable);
            this.tabPageAvailableDvd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAvailableDvd.Name = "tabPageAvailableDvd";
            this.tabPageAvailableDvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAvailableDvd.Size = new System.Drawing.Size(714, 389);
            this.tabPageAvailableDvd.TabIndex = 2;
            this.tabPageAvailableDvd.Text = "Show Available DVDs";
            this.tabPageAvailableDvd.UseVisualStyleBackColor = true;
            // 
            // dvdsDataGridViewAvailable
            // 
            this.dvdsDataGridViewAvailable.AutoGenerateColumns = false;
            this.dvdsDataGridViewAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdsDataGridViewAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn13});
            this.dvdsDataGridViewAvailable.DataSource = this.dvdsBindingSource;
            this.dvdsDataGridViewAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvdsDataGridViewAvailable.Location = new System.Drawing.Point(3, 3);
            this.dvdsDataGridViewAvailable.Name = "dvdsDataGridViewAvailable";
            this.dvdsDataGridViewAvailable.Size = new System.Drawing.Size(708, 383);
            this.dvdsDataGridViewAvailable.TabIndex = 0;
            // 
            // tabPageEditDvd
            // 
            this.tabPageEditDvd.AutoScroll = true;
            this.tabPageEditDvd.Controls.Add(this.buttonEditDvd);
            this.tabPageEditDvd.Controls.Add(availableLabel);
            this.tabPageEditDvd.Controls.Add(this.availableCheckBox);
            this.tabPageEditDvd.Controls.Add(dvdIdLabel);
            this.tabPageEditDvd.Controls.Add(this.dvdIdLabel1);
            this.tabPageEditDvd.Controls.Add(dvdNumberLabel);
            this.tabPageEditDvd.Controls.Add(this.dvdNumberTextBox);
            this.tabPageEditDvd.Controls.Add(this.genreTextBox);
            this.tabPageEditDvd.Controls.Add(this.priceTextBox);
            this.tabPageEditDvd.Controls.Add(this.titleTextBox);
            this.tabPageEditDvd.Controls.Add(genreLabel);
            this.tabPageEditDvd.Controls.Add(priceLabel);
            this.tabPageEditDvd.Controls.Add(titleLabel);
            this.tabPageEditDvd.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditDvd.Name = "tabPageEditDvd";
            this.tabPageEditDvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditDvd.Size = new System.Drawing.Size(714, 389);
            this.tabPageEditDvd.TabIndex = 5;
            this.tabPageEditDvd.Text = "Edit Dvd";
            this.tabPageEditDvd.UseVisualStyleBackColor = true;
            // 
            // buttonEditDvd
            // 
            this.buttonEditDvd.Location = new System.Drawing.Point(325, 235);
            this.buttonEditDvd.Name = "buttonEditDvd";
            this.buttonEditDvd.Size = new System.Drawing.Size(104, 23);
            this.buttonEditDvd.TabIndex = 14;
            this.buttonEditDvd.Text = "Save";
            this.buttonEditDvd.UseVisualStyleBackColor = true;
            this.buttonEditDvd.Click += new System.EventHandler(this.buttonEditDvd_Click);
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.dvdsBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(325, 83);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availableCheckBox.TabIndex = 1;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // dvdIdLabel1
            // 
            this.dvdIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dvdsBindingSource, "DvdId", true));
            this.dvdIdLabel1.Location = new System.Drawing.Point(325, 57);
            this.dvdIdLabel1.Name = "dvdIdLabel1";
            this.dvdIdLabel1.Size = new System.Drawing.Size(104, 23);
            this.dvdIdLabel1.TabIndex = 3;
            this.dvdIdLabel1.Text = "label2";
            // 
            // dvdNumberTextBox
            // 
            this.dvdNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dvdsBindingSource, "DvdNumber", true));
            this.dvdNumberTextBox.Location = new System.Drawing.Point(325, 113);
            this.dvdNumberTextBox.Name = "dvdNumberTextBox";
            this.dvdNumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.dvdNumberTextBox.TabIndex = 5;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dvdsBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(325, 139);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(104, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dvdsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(325, 165);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(104, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dvdsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(325, 191);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(104, 20);
            this.titleTextBox.TabIndex = 13;
            // 
            // tabPageShowDvd
            // 
            this.tabPageShowDvd.AutoScroll = true;
            this.tabPageShowDvd.Controls.Add(this.buttonDelDvd);
            this.tabPageShowDvd.Controls.Add(this.label1);
            this.tabPageShowDvd.Controls.Add(this.textBoxDelDvd);
            this.tabPageShowDvd.Controls.Add(this.bindingNavigatorShowAllDvds);
            this.tabPageShowDvd.Controls.Add(this.dvdsDataGridView);
            this.tabPageShowDvd.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowDvd.Name = "tabPageShowDvd";
            this.tabPageShowDvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowDvd.Size = new System.Drawing.Size(714, 389);
            this.tabPageShowDvd.TabIndex = 1;
            this.tabPageShowDvd.Text = "Show All Dvds";
            this.tabPageShowDvd.UseVisualStyleBackColor = true;
            // 
            // buttonDelDvd
            // 
            this.buttonDelDvd.Location = new System.Drawing.Point(402, 294);
            this.buttonDelDvd.Name = "buttonDelDvd";
            this.buttonDelDvd.Size = new System.Drawing.Size(75, 23);
            this.buttonDelDvd.TabIndex = 7;
            this.buttonDelDvd.Text = "Delete Dvd";
            this.buttonDelDvd.UseVisualStyleBackColor = true;
            this.buttonDelDvd.Click += new System.EventHandler(this.buttonDelDvd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dvd Number:";
            // 
            // textBoxDelDvd
            // 
            this.textBoxDelDvd.Location = new System.Drawing.Point(286, 294);
            this.textBoxDelDvd.Name = "textBoxDelDvd";
            this.textBoxDelDvd.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelDvd.TabIndex = 5;
            // 
            // bindingNavigatorShowAllDvds
            // 
            this.bindingNavigatorShowAllDvds.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorShowAllDvds.BindingSource = this.dvdsBindingSource;
            this.bindingNavigatorShowAllDvds.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorShowAllDvds.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorShowAllDvds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorShowAllDvds.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorShowAllDvds.Location = new System.Drawing.Point(3, 361);
            this.bindingNavigatorShowAllDvds.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorShowAllDvds.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorShowAllDvds.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorShowAllDvds.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorShowAllDvds.Name = "bindingNavigatorShowAllDvds";
            this.bindingNavigatorShowAllDvds.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorShowAllDvds.Size = new System.Drawing.Size(708, 25);
            this.bindingNavigatorShowAllDvds.TabIndex = 1;
            this.bindingNavigatorShowAllDvds.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "0";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dvdsDataGridView
            // 
            this.dvdsDataGridView.AutoGenerateColumns = false;
            this.dvdsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dvdsDataGridView.DataSource = this.dvdsBindingSource;
            this.dvdsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvdsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dvdsDataGridView.Name = "dvdsDataGridView";
            this.dvdsDataGridView.Size = new System.Drawing.Size(708, 254);
            this.dvdsDataGridView.TabIndex = 0;
            // 
            // tabPageAddDvd
            // 
            this.tabPageAddDvd.AutoScroll = true;
            this.tabPageAddDvd.Controls.Add(this.comboBoxGenre);
            this.tabPageAddDvd.Controls.Add(this.checkBoxAvailable);
            this.tabPageAddDvd.Controls.Add(this.labelGenre);
            this.tabPageAddDvd.Controls.Add(this.textBoxPrice);
            this.tabPageAddDvd.Controls.Add(this.textBoxNumber);
            this.tabPageAddDvd.Controls.Add(this.textBoxTitel);
            this.tabPageAddDvd.Controls.Add(this.labelPrice);
            this.tabPageAddDvd.Controls.Add(this.labelAddress);
            this.tabPageAddDvd.Controls.Add(this.labelLast);
            this.tabPageAddDvd.Controls.Add(this.labelFirst);
            this.tabPageAddDvd.Controls.Add(this.buttonAddDvd);
            this.tabPageAddDvd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddDvd.Name = "tabPageAddDvd";
            this.tabPageAddDvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddDvd.Size = new System.Drawing.Size(714, 389);
            this.tabPageAddDvd.TabIndex = 0;
            this.tabPageAddDvd.Text = "Add Dvd";
            this.tabPageAddDvd.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Action ",
            "Comedy",
            "Documentary ",
            "Horror ",
            "Thriller ",
            "Fantasy ",
            "Sport "});
            this.comboBoxGenre.Location = new System.Drawing.Point(284, 168);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(101, 21);
            this.comboBoxGenre.TabIndex = 4;
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(286, 96);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAvailable.TabIndex = 2;
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(207, 171);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 34;
            this.labelGenre.Text = "Genre:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(284, 131);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrice_Validating);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(286, 57);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 1;
            this.textBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumber_Validating);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(286, 20);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitel.TabIndex = 0;
            this.textBoxTitel.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTitel_Validating);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(207, 134);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 32;
            this.labelPrice.Text = "Price:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(207, 97);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(53, 13);
            this.labelAddress.TabIndex = 30;
            this.labelAddress.Text = "Available:";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Location = new System.Drawing.Point(207, 60);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(70, 13);
            this.labelLast.TabIndex = 28;
            this.labelLast.Text = "Dvd Number:";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(207, 23);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(33, 13);
            this.labelFirst.TabIndex = 26;
            this.labelFirst.Text = "Ttitle:";
            // 
            // buttonAddDvd
            // 
            this.buttonAddDvd.Location = new System.Drawing.Point(285, 213);
            this.buttonAddDvd.Name = "buttonAddDvd";
            this.buttonAddDvd.Size = new System.Drawing.Size(100, 30);
            this.buttonAddDvd.TabIndex = 5;
            this.buttonAddDvd.Text = "Add New Dvd";
            this.buttonAddDvd.UseVisualStyleBackColor = true;
            this.buttonAddDvd.Click += new System.EventHandler(this.buttonAddDvd_Click);
            // 
            // tabControlDvd
            // 
            this.tabControlDvd.Controls.Add(this.tabPageAddDvd);
            this.tabControlDvd.Controls.Add(this.tabPageShowDvd);
            this.tabControlDvd.Controls.Add(this.tabPageEditDvd);
            this.tabControlDvd.Controls.Add(this.tabPageAvailableDvd);
            this.tabControlDvd.Controls.Add(this.tabPageUnavailable);
            this.tabControlDvd.Controls.Add(this.tabPageReturnDate);
            this.tabControlDvd.Controls.Add(this.tabPageDvdInfo);
            this.tabControlDvd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDvd.Location = new System.Drawing.Point(0, 0);
            this.tabControlDvd.Name = "tabControlDvd";
            this.tabControlDvd.SelectedIndex = 0;
            this.tabControlDvd.Size = new System.Drawing.Size(722, 415);
            this.tabControlDvd.TabIndex = 0;
            this.tabControlDvd.Click += new System.EventHandler(this.tabControlDvd_Click);
            // 
            // tabPageDvdInfo
            // 
            this.tabPageDvdInfo.Controls.Add(this.labelInfoPoster);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoDirector);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoActors);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoYear);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoRelease);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoRuntime);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoGenre);
            this.tabPageDvdInfo.Controls.Add(this.labelInfoTitle);
            this.tabPageDvdInfo.Controls.Add(this.buttonShowInfo);
            this.tabPageDvdInfo.Controls.Add(this.labelDvdTitle);
            this.tabPageDvdInfo.Controls.Add(this.textBoxDvdTitle);
            this.tabPageDvdInfo.Controls.Add(this.pictureBoxInfoPoster);
            this.tabPageDvdInfo.Controls.Add(this.textBoxInfoActors);
            this.tabPageDvdInfo.Controls.Add(this.dateTimePickerInfoRelease);
            this.tabPageDvdInfo.Controls.Add(this.textBoxInfoYear);
            this.tabPageDvdInfo.Controls.Add(this.textBoxInfoDirector);
            this.tabPageDvdInfo.Controls.Add(this.textBoxInfoRuntime);
            this.tabPageDvdInfo.Controls.Add(this.textBoxInfoGenre);
            this.tabPageDvdInfo.Controls.Add(this.textBoxInfoTitle);
            this.tabPageDvdInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageDvdInfo.Name = "tabPageDvdInfo";
            this.tabPageDvdInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDvdInfo.Size = new System.Drawing.Size(714, 389);
            this.tabPageDvdInfo.TabIndex = 6;
            this.tabPageDvdInfo.Text = "Dvd Info";
            this.tabPageDvdInfo.UseVisualStyleBackColor = true;
            // 
            // labelInfoPoster
            // 
            this.labelInfoPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoPoster.Location = new System.Drawing.Point(478, 40);
            this.labelInfoPoster.Name = "labelInfoPoster";
            this.labelInfoPoster.Size = new System.Drawing.Size(106, 23);
            this.labelInfoPoster.TabIndex = 18;
            this.labelInfoPoster.Text = "Poster";
            this.labelInfoPoster.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelInfoDirector
            // 
            this.labelInfoDirector.AutoSize = true;
            this.labelInfoDirector.Location = new System.Drawing.Point(146, 182);
            this.labelInfoDirector.Name = "labelInfoDirector";
            this.labelInfoDirector.Size = new System.Drawing.Size(47, 13);
            this.labelInfoDirector.TabIndex = 17;
            this.labelInfoDirector.Text = "Director:";
            // 
            // labelInfoActors
            // 
            this.labelInfoActors.AutoSize = true;
            this.labelInfoActors.Location = new System.Drawing.Point(146, 208);
            this.labelInfoActors.Name = "labelInfoActors";
            this.labelInfoActors.Size = new System.Drawing.Size(40, 13);
            this.labelInfoActors.TabIndex = 16;
            this.labelInfoActors.Text = "Actors:";
            // 
            // labelInfoYear
            // 
            this.labelInfoYear.AutoSize = true;
            this.labelInfoYear.Location = new System.Drawing.Point(146, 78);
            this.labelInfoYear.Name = "labelInfoYear";
            this.labelInfoYear.Size = new System.Drawing.Size(32, 13);
            this.labelInfoYear.TabIndex = 15;
            this.labelInfoYear.Text = "Year:";
            // 
            // labelInfoRelease
            // 
            this.labelInfoRelease.AutoSize = true;
            this.labelInfoRelease.Location = new System.Drawing.Point(146, 107);
            this.labelInfoRelease.Name = "labelInfoRelease";
            this.labelInfoRelease.Size = new System.Drawing.Size(61, 13);
            this.labelInfoRelease.TabIndex = 14;
            this.labelInfoRelease.Text = "Realeased:";
            // 
            // labelInfoRuntime
            // 
            this.labelInfoRuntime.AutoSize = true;
            this.labelInfoRuntime.Location = new System.Drawing.Point(146, 130);
            this.labelInfoRuntime.Name = "labelInfoRuntime";
            this.labelInfoRuntime.Size = new System.Drawing.Size(49, 13);
            this.labelInfoRuntime.TabIndex = 13;
            this.labelInfoRuntime.Text = "Runtime:";
            // 
            // labelInfoGenre
            // 
            this.labelInfoGenre.AutoSize = true;
            this.labelInfoGenre.Location = new System.Drawing.Point(146, 156);
            this.labelInfoGenre.Name = "labelInfoGenre";
            this.labelInfoGenre.Size = new System.Drawing.Size(39, 13);
            this.labelInfoGenre.TabIndex = 12;
            this.labelInfoGenre.Text = "Genre:";
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Location = new System.Drawing.Point(146, 52);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(30, 13);
            this.labelInfoTitle.TabIndex = 11;
            this.labelInfoTitle.Text = "Title:";
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(424, 282);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(207, 23);
            this.buttonShowInfo.TabIndex = 10;
            this.buttonShowInfo.Text = "Show Info";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // labelDvdTitle
            // 
            this.labelDvdTitle.AutoSize = true;
            this.labelDvdTitle.Location = new System.Drawing.Point(218, 289);
            this.labelDvdTitle.Name = "labelDvdTitle";
            this.labelDvdTitle.Size = new System.Drawing.Size(62, 13);
            this.labelDvdTitle.TabIndex = 9;
            this.labelDvdTitle.Text = "Movie Title:";
            // 
            // textBoxDvdTitle
            // 
            this.textBoxDvdTitle.Location = new System.Drawing.Point(286, 284);
            this.textBoxDvdTitle.Name = "textBoxDvdTitle";
            this.textBoxDvdTitle.Size = new System.Drawing.Size(120, 20);
            this.textBoxDvdTitle.TabIndex = 8;
            // 
            // pictureBoxInfoPoster
            // 
            this.pictureBoxInfoPoster.Location = new System.Drawing.Point(440, 66);
            this.pictureBoxInfoPoster.Name = "pictureBoxInfoPoster";
            this.pictureBoxInfoPoster.Size = new System.Drawing.Size(191, 178);
            this.pictureBoxInfoPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoPoster.TabIndex = 7;
            this.pictureBoxInfoPoster.TabStop = false;
            // 
            // textBoxInfoActors
            // 
            this.textBoxInfoActors.Location = new System.Drawing.Point(214, 205);
            this.textBoxInfoActors.Multiline = true;
            this.textBoxInfoActors.Name = "textBoxInfoActors";
            this.textBoxInfoActors.Size = new System.Drawing.Size(201, 39);
            this.textBoxInfoActors.TabIndex = 6;
            // 
            // dateTimePickerInfoRelease
            // 
            this.dateTimePickerInfoRelease.Location = new System.Drawing.Point(214, 101);
            this.dateTimePickerInfoRelease.Name = "dateTimePickerInfoRelease";
            this.dateTimePickerInfoRelease.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerInfoRelease.TabIndex = 5;
            // 
            // textBoxInfoYear
            // 
            this.textBoxInfoYear.Location = new System.Drawing.Point(214, 75);
            this.textBoxInfoYear.Name = "textBoxInfoYear";
            this.textBoxInfoYear.Size = new System.Drawing.Size(201, 20);
            this.textBoxInfoYear.TabIndex = 4;
            // 
            // textBoxInfoDirector
            // 
            this.textBoxInfoDirector.Location = new System.Drawing.Point(214, 179);
            this.textBoxInfoDirector.Name = "textBoxInfoDirector";
            this.textBoxInfoDirector.Size = new System.Drawing.Size(201, 20);
            this.textBoxInfoDirector.TabIndex = 3;
            // 
            // textBoxInfoRuntime
            // 
            this.textBoxInfoRuntime.Location = new System.Drawing.Point(214, 127);
            this.textBoxInfoRuntime.Name = "textBoxInfoRuntime";
            this.textBoxInfoRuntime.Size = new System.Drawing.Size(201, 20);
            this.textBoxInfoRuntime.TabIndex = 2;
            // 
            // textBoxInfoGenre
            // 
            this.textBoxInfoGenre.Location = new System.Drawing.Point(214, 153);
            this.textBoxInfoGenre.Name = "textBoxInfoGenre";
            this.textBoxInfoGenre.Size = new System.Drawing.Size(201, 20);
            this.textBoxInfoGenre.TabIndex = 1;
            // 
            // textBoxInfoTitle
            // 
            this.textBoxInfoTitle.Location = new System.Drawing.Point(214, 49);
            this.textBoxInfoTitle.Name = "textBoxInfoTitle";
            this.textBoxInfoTitle.Size = new System.Drawing.Size(201, 20);
            this.textBoxInfoTitle.TabIndex = 0;
            // 
            // dvdsBindingSource
            // 
            this.dvdsBindingSource.DataSource = typeof(MovieStore.Dvd);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DvdId";
            this.dataGridViewTextBoxColumn1.HeaderText = "DvdId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DvdNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "DvdNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Available";
            this.dataGridViewTextBoxColumn4.HeaderText = "Available";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RentId";
            this.dataGridViewTextBoxColumn7.HeaderText = "RentId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DvdId";
            this.dataGridViewTextBoxColumn9.HeaderText = "DvdId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Title";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DvdNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "DvdNumber";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn14.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn13.HeaderText = "Price";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DvdId";
            this.dataGridViewTextBoxColumn12.HeaderText = "DvdId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn15.HeaderText = "Title";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DvdNumber";
            this.dataGridViewTextBoxColumn16.HeaderText = "DvdNumber";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn19.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // rentsBindingSource
            // 
            this.rentsBindingSource.DataSource = typeof(MovieStore.Rent);
            // 
            // DVDsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 415);
            this.Controls.Add(this.tabControlDvd);
            this.Name = "DVDsForm";
            this.Text = "DVDs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DVDsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDvd)).EndInit();
            this.tabPageReturnDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustom)).EndInit();
            this.tabPageUnavailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvdsDataGridViewUnavailable)).EndInit();
            this.tabPageAvailableDvd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvdsDataGridViewAvailable)).EndInit();
            this.tabPageEditDvd.ResumeLayout(false);
            this.tabPageEditDvd.PerformLayout();
            this.tabPageShowDvd.ResumeLayout(false);
            this.tabPageShowDvd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorShowAllDvds)).EndInit();
            this.bindingNavigatorShowAllDvds.ResumeLayout(false);
            this.bindingNavigatorShowAllDvds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvdsDataGridView)).EndInit();
            this.tabPageAddDvd.ResumeLayout(false);
            this.tabPageAddDvd.PerformLayout();
            this.tabControlDvd.ResumeLayout(false);
            this.tabPageDvdInfo.ResumeLayout(false);
            this.tabPageDvdInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dvdsBindingSource;
        private System.Windows.Forms.BindingSource rentsBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderDvd;
        private System.Windows.Forms.TabControl tabControlDvd;
        private System.Windows.Forms.TabPage tabPageAddDvd;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Button buttonAddDvd;
        private System.Windows.Forms.TabPage tabPageShowDvd;
        private System.Windows.Forms.Button buttonDelDvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelDvd;
        private System.Windows.Forms.BindingNavigator bindingNavigatorShowAllDvds;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvdsDataGridView;
        private System.Windows.Forms.TabPage tabPageEditDvd;
        private System.Windows.Forms.Button buttonEditDvd;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Label dvdIdLabel1;
        private System.Windows.Forms.TextBox dvdNumberTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TabPage tabPageAvailableDvd;
        private System.Windows.Forms.DataGridView dvdsDataGridViewAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TabPage tabPageUnavailable;
        private System.Windows.Forms.DataGridView dvdsDataGridViewUnavailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.TabPage tabPageReturnDate;
        private System.Windows.Forms.DataGridView dataGridViewCustom;
        private System.Windows.Forms.TabPage tabPageDvdInfo;
        private System.Windows.Forms.TextBox textBoxInfoYear;
        private System.Windows.Forms.TextBox textBoxInfoDirector;
        private System.Windows.Forms.TextBox textBoxInfoRuntime;
        private System.Windows.Forms.TextBox textBoxInfoGenre;
        private System.Windows.Forms.TextBox textBoxInfoTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerInfoRelease;
        private System.Windows.Forms.TextBox textBoxInfoActors;
        private System.Windows.Forms.PictureBox pictureBoxInfoPoster;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.Label labelDvdTitle;
        private System.Windows.Forms.TextBox textBoxDvdTitle;
        private System.Windows.Forms.Label labelInfoDirector;
        private System.Windows.Forms.Label labelInfoActors;
        private System.Windows.Forms.Label labelInfoYear;
        private System.Windows.Forms.Label labelInfoRelease;
        private System.Windows.Forms.Label labelInfoRuntime;
        private System.Windows.Forms.Label labelInfoGenre;
        private System.Windows.Forms.Label labelInfoTitle;
        private System.Windows.Forms.Label labelInfoPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}