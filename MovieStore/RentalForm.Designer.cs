namespace MovieStore
{
    partial class RentalForm
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
            System.Windows.Forms.Label userIdLabel1;
            System.Windows.Forms.Label chargeLabel;
            System.Windows.Forms.Label dueDateLabel;
            System.Windows.Forms.Label overduedDaysLabel;
            System.Windows.Forms.Label rentIdLabel;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label userIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            this.tabControlRental = new System.Windows.Forms.TabControl();
            this.tabPageAddRental = new System.Windows.Forms.TabPage();
            this.buttonAddRental = new System.Windows.Forms.Button();
            this.labelDvdNumber = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxDvdNumber = new System.Windows.Forms.TextBox();
            this.textBoxUserNumber = new System.Windows.Forms.TextBox();
            this.tabPageShowRental = new System.Windows.Forms.TabPage();
            this.rentsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageEditRental = new System.Windows.Forms.TabPage();
            this.buttonEditRent = new System.Windows.Forms.Button();
            this.chargeTextBox = new System.Windows.Forms.TextBox();
            this.dueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.overduedDaysTextBox = new System.Windows.Forms.TextBox();
            this.rentIdLabel1 = new System.Windows.Forms.Label();
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userIdLabel2 = new System.Windows.Forms.Label();
            this.userIdTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPageRentalDelete = new System.Windows.Forms.TabPage();
            this.textBoxDelNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelRental = new System.Windows.Forms.Button();
            this.tabPageShowCharges = new System.Windows.Forms.TabPage();
            this.dataGridViewShowCharges = new System.Windows.Forms.DataGridView();
            this.rentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.errorProviderRental = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPageShowRentalWithoutCharges = new System.Windows.Forms.TabPage();
            this.dataGridViewWithoutCharges = new System.Windows.Forms.DataGridView();
            this.rentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userIdLabel1 = new System.Windows.Forms.Label();
            chargeLabel = new System.Windows.Forms.Label();
            dueDateLabel = new System.Windows.Forms.Label();
            overduedDaysLabel = new System.Windows.Forms.Label();
            rentIdLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            this.tabControlRental.SuspendLayout();
            this.tabPageAddRental.SuspendLayout();
            this.tabPageShowRental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).BeginInit();
            this.tabPageEditRental.SuspendLayout();
            this.tabPageRentalDelete.SuspendLayout();
            this.tabPageShowCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingNavigator)).BeginInit();
            this.rentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRental)).BeginInit();
            this.tabPageShowRentalWithoutCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithoutCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel1
            // 
            userIdLabel1.AutoSize = true;
            userIdLabel1.Location = new System.Drawing.Point(333, 489);
            userIdLabel1.Name = "userIdLabel1";
            userIdLabel1.Size = new System.Drawing.Size(44, 13);
            userIdLabel1.TabIndex = 26;
            userIdLabel1.Text = "User Id:";
            // 
            // chargeLabel
            // 
            chargeLabel.AutoSize = true;
            chargeLabel.Location = new System.Drawing.Point(230, 242);
            chargeLabel.Name = "chargeLabel";
            chargeLabel.Size = new System.Drawing.Size(44, 13);
            chargeLabel.TabIndex = 27;
            chargeLabel.Text = "Charge:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new System.Drawing.Point(230, 165);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(56, 13);
            dueDateLabel.TabIndex = 29;
            dueDateLabel.Text = "Due Date:";
            // 
            // overduedDaysLabel
            // 
            overduedDaysLabel.AutoSize = true;
            overduedDaysLabel.Location = new System.Drawing.Point(230, 216);
            overduedDaysLabel.Name = "overduedDaysLabel";
            overduedDaysLabel.Size = new System.Drawing.Size(84, 13);
            overduedDaysLabel.TabIndex = 31;
            overduedDaysLabel.Text = "Overdued Days:";
            // 
            // rentIdLabel
            // 
            rentIdLabel.AutoSize = true;
            rentIdLabel.Location = new System.Drawing.Point(230, 108);
            rentIdLabel.Name = "rentIdLabel";
            rentIdLabel.Size = new System.Drawing.Size(45, 13);
            rentIdLabel.TabIndex = 33;
            rentIdLabel.Text = "Rent Id:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(230, 191);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(68, 13);
            returnDateLabel.TabIndex = 35;
            returnDateLabel.Text = "Return Date:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(230, 131);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(44, 13);
            userIdLabel.TabIndex = 37;
            userIdLabel.Text = "User Id:";
            // 
            // tabControlRental
            // 
            this.tabControlRental.Controls.Add(this.tabPageAddRental);
            this.tabControlRental.Controls.Add(this.tabPageShowRental);
            this.tabControlRental.Controls.Add(this.tabPageShowRentalWithoutCharges);
            this.tabControlRental.Controls.Add(this.tabPageEditRental);
            this.tabControlRental.Controls.Add(this.tabPageRentalDelete);
            this.tabControlRental.Controls.Add(this.tabPageShowCharges);
            this.tabControlRental.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRental.Location = new System.Drawing.Point(0, 0);
            this.tabControlRental.Name = "tabControlRental";
            this.tabControlRental.SelectedIndex = 0;
            this.tabControlRental.Size = new System.Drawing.Size(857, 472);
            this.tabControlRental.TabIndex = 0;
            this.tabControlRental.Click += new System.EventHandler(this.tabControlRental_Click);
            // 
            // tabPageAddRental
            // 
            this.tabPageAddRental.Controls.Add(this.buttonAddRental);
            this.tabPageAddRental.Controls.Add(this.labelDvdNumber);
            this.tabPageAddRental.Controls.Add(this.labelCardNumber);
            this.tabPageAddRental.Controls.Add(this.textBoxDvdNumber);
            this.tabPageAddRental.Controls.Add(this.textBoxUserNumber);
            this.tabPageAddRental.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddRental.Name = "tabPageAddRental";
            this.tabPageAddRental.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRental.Size = new System.Drawing.Size(849, 446);
            this.tabPageAddRental.TabIndex = 0;
            this.tabPageAddRental.Text = "Add Rental";
            this.tabPageAddRental.UseVisualStyleBackColor = true;
            // 
            // buttonAddRental
            // 
            this.buttonAddRental.Location = new System.Drawing.Point(364, 193);
            this.buttonAddRental.Name = "buttonAddRental";
            this.buttonAddRental.Size = new System.Drawing.Size(100, 23);
            this.buttonAddRental.TabIndex = 4;
            this.buttonAddRental.Text = "Add Rental";
            this.buttonAddRental.UseVisualStyleBackColor = true;
            this.buttonAddRental.Click += new System.EventHandler(this.buttonAddRental_Click);
            // 
            // labelDvdNumber
            // 
            this.labelDvdNumber.AutoSize = true;
            this.labelDvdNumber.Location = new System.Drawing.Point(261, 140);
            this.labelDvdNumber.Name = "labelDvdNumber";
            this.labelDvdNumber.Size = new System.Drawing.Size(70, 13);
            this.labelDvdNumber.TabIndex = 3;
            this.labelDvdNumber.Text = "Dvd Number:";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(261, 77);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(97, 13);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "User Card Number:";
            // 
            // textBoxDvdNumber
            // 
            this.textBoxDvdNumber.Location = new System.Drawing.Point(364, 137);
            this.textBoxDvdNumber.Name = "textBoxDvdNumber";
            this.textBoxDvdNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxDvdNumber.TabIndex = 1;
            this.textBoxDvdNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDvdNumber_Validating);
            // 
            // textBoxUserNumber
            // 
            this.textBoxUserNumber.Location = new System.Drawing.Point(364, 74);
            this.textBoxUserNumber.Name = "textBoxUserNumber";
            this.textBoxUserNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserNumber.TabIndex = 0;
            this.textBoxUserNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserNumber_Validating);
            // 
            // tabPageShowRental
            // 
            this.tabPageShowRental.Controls.Add(this.rentsDataGridView);
            this.tabPageShowRental.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowRental.Name = "tabPageShowRental";
            this.tabPageShowRental.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowRental.Size = new System.Drawing.Size(849, 446);
            this.tabPageShowRental.TabIndex = 1;
            this.tabPageShowRental.Text = "Show All Rentals";
            this.tabPageShowRental.UseVisualStyleBackColor = true;
            // 
            // rentsDataGridView
            // 
            this.rentsDataGridView.AutoGenerateColumns = false;
            this.rentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rentsDataGridView.DataSource = this.rentsBindingSource;
            this.rentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.rentsDataGridView.Name = "rentsDataGridView";
            this.rentsDataGridView.Size = new System.Drawing.Size(843, 440);
            this.rentsDataGridView.TabIndex = 0;
            // 
            // tabPageEditRental
            // 
            this.tabPageEditRental.AutoScroll = true;
            this.tabPageEditRental.Controls.Add(this.buttonEditRent);
            this.tabPageEditRental.Controls.Add(chargeLabel);
            this.tabPageEditRental.Controls.Add(this.chargeTextBox);
            this.tabPageEditRental.Controls.Add(dueDateLabel);
            this.tabPageEditRental.Controls.Add(this.dueDateDateTimePicker);
            this.tabPageEditRental.Controls.Add(overduedDaysLabel);
            this.tabPageEditRental.Controls.Add(this.overduedDaysTextBox);
            this.tabPageEditRental.Controls.Add(rentIdLabel);
            this.tabPageEditRental.Controls.Add(this.rentIdLabel1);
            this.tabPageEditRental.Controls.Add(returnDateLabel);
            this.tabPageEditRental.Controls.Add(this.returnDateDateTimePicker);
            this.tabPageEditRental.Controls.Add(userIdLabel);
            this.tabPageEditRental.Controls.Add(this.userIdLabel2);
            this.tabPageEditRental.Controls.Add(userIdLabel1);
            this.tabPageEditRental.Controls.Add(this.userIdTextBox1);
            this.tabPageEditRental.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditRental.Name = "tabPageEditRental";
            this.tabPageEditRental.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditRental.Size = new System.Drawing.Size(849, 446);
            this.tabPageEditRental.TabIndex = 4;
            this.tabPageEditRental.Text = "Edit Rental";
            this.tabPageEditRental.UseVisualStyleBackColor = true;
            // 
            // buttonEditRent
            // 
            this.buttonEditRent.Location = new System.Drawing.Point(363, 289);
            this.buttonEditRent.Name = "buttonEditRent";
            this.buttonEditRent.Size = new System.Drawing.Size(115, 23);
            this.buttonEditRent.TabIndex = 39;
            this.buttonEditRent.Text = "Save";
            this.buttonEditRent.UseVisualStyleBackColor = true;
            this.buttonEditRent.Click += new System.EventHandler(this.buttonEditRent_Click);
            // 
            // chargeTextBox
            // 
            this.chargeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "Charge", true));
            this.chargeTextBox.Location = new System.Drawing.Point(320, 239);
            this.chargeTextBox.Name = "chargeTextBox";
            this.chargeTextBox.Size = new System.Drawing.Size(200, 20);
            this.chargeTextBox.TabIndex = 28;
            // 
            // dueDateDateTimePicker
            // 
            this.dueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentsBindingSource, "DueDate", true));
            this.dueDateDateTimePicker.Location = new System.Drawing.Point(320, 161);
            this.dueDateDateTimePicker.Name = "dueDateDateTimePicker";
            this.dueDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dueDateDateTimePicker.TabIndex = 30;
            // 
            // overduedDaysTextBox
            // 
            this.overduedDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "OverduedDays", true));
            this.overduedDaysTextBox.Location = new System.Drawing.Point(320, 213);
            this.overduedDaysTextBox.Name = "overduedDaysTextBox";
            this.overduedDaysTextBox.Size = new System.Drawing.Size(200, 20);
            this.overduedDaysTextBox.TabIndex = 32;
            // 
            // rentIdLabel1
            // 
            this.rentIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "RentId", true));
            this.rentIdLabel1.Location = new System.Drawing.Point(320, 108);
            this.rentIdLabel1.Name = "rentIdLabel1";
            this.rentIdLabel1.Size = new System.Drawing.Size(200, 13);
            this.rentIdLabel1.TabIndex = 34;
            this.rentIdLabel1.Text = "label2";
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentsBindingSource, "ReturnDate", true));
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(320, 187);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDateDateTimePicker.TabIndex = 36;
            // 
            // userIdLabel2
            // 
            this.userIdLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "UserId", true));
            this.userIdLabel2.Location = new System.Drawing.Point(320, 131);
            this.userIdLabel2.Name = "userIdLabel2";
            this.userIdLabel2.Size = new System.Drawing.Size(200, 13);
            this.userIdLabel2.TabIndex = 38;
            this.userIdLabel2.Text = "label2";
            // 
            // userIdTextBox1
            // 
            this.userIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentsBindingSource, "User.UserId", true));
            this.userIdTextBox1.Location = new System.Drawing.Point(442, 486);
            this.userIdTextBox1.Name = "userIdTextBox1";
            this.userIdTextBox1.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox1.TabIndex = 27;
            // 
            // tabPageRentalDelete
            // 
            this.tabPageRentalDelete.Controls.Add(this.textBoxDelNumber);
            this.tabPageRentalDelete.Controls.Add(this.label1);
            this.tabPageRentalDelete.Controls.Add(this.buttonDelRental);
            this.tabPageRentalDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageRentalDelete.Name = "tabPageRentalDelete";
            this.tabPageRentalDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRentalDelete.Size = new System.Drawing.Size(849, 446);
            this.tabPageRentalDelete.TabIndex = 2;
            this.tabPageRentalDelete.Text = "Delete Rental";
            this.tabPageRentalDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxDelNumber
            // 
            this.textBoxDelNumber.Location = new System.Drawing.Point(322, 97);
            this.textBoxDelNumber.Name = "textBoxDelNumber";
            this.textBoxDelNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxDelNumber.TabIndex = 2;
            this.textBoxDelNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDelNumber_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dvd Number";
            // 
            // buttonDelRental
            // 
            this.buttonDelRental.Location = new System.Drawing.Point(322, 150);
            this.buttonDelRental.Name = "buttonDelRental";
            this.buttonDelRental.Size = new System.Drawing.Size(100, 45);
            this.buttonDelRental.TabIndex = 0;
            this.buttonDelRental.Text = "Delete Rental";
            this.buttonDelRental.UseVisualStyleBackColor = true;
            this.buttonDelRental.Click += new System.EventHandler(this.buttonDelRental_Click);
            // 
            // tabPageShowCharges
            // 
            this.tabPageShowCharges.Controls.Add(this.dataGridViewShowCharges);
            this.tabPageShowCharges.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowCharges.Name = "tabPageShowCharges";
            this.tabPageShowCharges.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowCharges.Size = new System.Drawing.Size(849, 446);
            this.tabPageShowCharges.TabIndex = 3;
            this.tabPageShowCharges.Text = "Show Charges";
            this.tabPageShowCharges.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShowCharges
            // 
            this.dataGridViewShowCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCharges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowCharges.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewShowCharges.Name = "dataGridViewShowCharges";
            this.dataGridViewShowCharges.Size = new System.Drawing.Size(843, 440);
            this.dataGridViewShowCharges.TabIndex = 0;
            // 
            // rentsBindingNavigator
            // 
            this.rentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rentsBindingNavigator.BindingSource = this.rentsBindingSource;
            this.rentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.rentsBindingNavigatorSaveItem});
            this.rentsBindingNavigator.Location = new System.Drawing.Point(0, 447);
            this.rentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rentsBindingNavigator.Name = "rentsBindingNavigator";
            this.rentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rentsBindingNavigator.Size = new System.Drawing.Size(857, 25);
            this.rentsBindingNavigator.TabIndex = 1;
            this.rentsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
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
            // rentsBindingNavigatorSaveItem
            // 
            this.rentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rentsBindingNavigatorSaveItem.Enabled = false;
            this.rentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rentsBindingNavigatorSaveItem.Image")));
            this.rentsBindingNavigatorSaveItem.Name = "rentsBindingNavigatorSaveItem";
            this.rentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rentsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // errorProviderRental
            // 
            this.errorProviderRental.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderRental.ContainerControl = this;
            // 
            // tabPageShowRentalWithoutCharges
            // 
            this.tabPageShowRentalWithoutCharges.Controls.Add(this.dataGridViewWithoutCharges);
            this.tabPageShowRentalWithoutCharges.Location = new System.Drawing.Point(4, 22);
            this.tabPageShowRentalWithoutCharges.Name = "tabPageShowRentalWithoutCharges";
            this.tabPageShowRentalWithoutCharges.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShowRentalWithoutCharges.Size = new System.Drawing.Size(849, 446);
            this.tabPageShowRentalWithoutCharges.TabIndex = 5;
            this.tabPageShowRentalWithoutCharges.Text = "Show Rentals Without Charges";
            this.tabPageShowRentalWithoutCharges.UseVisualStyleBackColor = true;
            this.tabPageShowRentalWithoutCharges.Enter += new System.EventHandler(this.tabPageShowRentalWithoutCharges_Enter);
            // 
            // dataGridViewWithoutCharges
            // 
            this.dataGridViewWithoutCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithoutCharges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWithoutCharges.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWithoutCharges.Name = "dataGridViewWithoutCharges";
            this.dataGridViewWithoutCharges.Size = new System.Drawing.Size(843, 440);
            this.dataGridViewWithoutCharges.TabIndex = 0;
            // 
            // rentsBindingSource
            // 
            this.rentsBindingSource.DataSource = typeof(MovieStore.Rent);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "RentId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReturnDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReturnDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OverduedDays";
            this.dataGridViewTextBoxColumn4.HeaderText = "OverduedDays";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Charge";
            this.dataGridViewTextBoxColumn5.HeaderText = "Charge";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn6.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 472);
            this.Controls.Add(this.rentsBindingNavigator);
            this.Controls.Add(this.tabControlRental);
            this.Name = "RentalForm";
            this.Text = "Rentals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentalForm_FormClosing);
            this.tabControlRental.ResumeLayout(false);
            this.tabPageAddRental.ResumeLayout(false);
            this.tabPageAddRental.PerformLayout();
            this.tabPageShowRental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentsDataGridView)).EndInit();
            this.tabPageEditRental.ResumeLayout(false);
            this.tabPageEditRental.PerformLayout();
            this.tabPageRentalDelete.ResumeLayout(false);
            this.tabPageRentalDelete.PerformLayout();
            this.tabPageShowCharges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingNavigator)).EndInit();
            this.rentsBindingNavigator.ResumeLayout(false);
            this.rentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRental)).EndInit();
            this.tabPageShowRentalWithoutCharges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithoutCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRental;
        private System.Windows.Forms.TabPage tabPageAddRental;
        private System.Windows.Forms.TabPage tabPageShowRental;
        private System.Windows.Forms.DataGridView rentsDataGridView;
        private System.Windows.Forms.BindingSource rentsBindingSource;
        private System.Windows.Forms.BindingNavigator rentsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton rentsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button buttonAddRental;
        private System.Windows.Forms.Label labelDvdNumber;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxDvdNumber;
        private System.Windows.Forms.TextBox textBoxUserNumber;
        private System.Windows.Forms.TabPage tabPageRentalDelete;
        private System.Windows.Forms.TextBox textBoxDelNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelRental;
        private System.Windows.Forms.TabPage tabPageShowCharges;
        private System.Windows.Forms.DataGridView dataGridViewShowCharges;
        private System.Windows.Forms.ErrorProvider errorProviderRental;
        private System.Windows.Forms.TabPage tabPageEditRental;
        private System.Windows.Forms.Button buttonEditRent;
        private System.Windows.Forms.TextBox chargeTextBox;
        private System.Windows.Forms.DateTimePicker dueDateDateTimePicker;
        private System.Windows.Forms.TextBox overduedDaysTextBox;
        private System.Windows.Forms.Label rentIdLabel1;
        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.Label userIdLabel2;
        private System.Windows.Forms.TextBox userIdTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPageShowRentalWithoutCharges;
        private System.Windows.Forms.DataGridView dataGridViewWithoutCharges;
    }
}