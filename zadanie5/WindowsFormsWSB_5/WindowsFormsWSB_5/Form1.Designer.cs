namespace WindowsFormsWSB_5
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sprzedażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunięcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.sprzedawcyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usunięcieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaFakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaFakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunięcieFakturyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpEmployee = new System.Windows.Forms.GroupBox();
            this.gpVentors = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNip = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.nieuregolowanafakturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpInvoices = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.lblNetto = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.txtNetto = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpEmployee.SuspendLayout();
            this.gpVentors.SuspendLayout();
            this.gpInvoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpInvoices);
            this.splitContainer1.Panel2.Controls.Add(this.gpVentors);
            this.splitContainer1.Panel2.Controls.Add(this.gpEmployee);
            this.splitContainer1.Size = new System.Drawing.Size(784, 703);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(784, 325);
            this.splitContainer2.SplitterDistance = 392;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(388, 325);
            this.dataGridView2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprzedażToolStripMenuItem,
            this.pracownikToolStripMenuItem,
            this.sprzedawcyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sprzedażToolStripMenuItem
            // 
            this.sprzedażToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem2,
            this.nowaFakturaToolStripMenuItem,
            this.edycjaFakturyToolStripMenuItem,
            this.usunięcieFakturyToolStripMenuItem,
            this.nieuregolowanafakturaToolStripMenuItem});
            this.sprzedażToolStripMenuItem.Name = "sprzedażToolStripMenuItem";
            this.sprzedażToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sprzedażToolStripMenuItem.Text = "&Sprzedaż";
            // 
            // pracownikToolStripMenuItem
            // 
            this.pracownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem,
            this.nowyToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.usunięcieToolStripMenuItem});
            this.pracownikToolStripMenuItem.Name = "pracownikToolStripMenuItem";
            this.pracownikToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.pracownikToolStripMenuItem.Text = "&Pracownik";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem.Text = "&Lista";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edycjaToolStripMenuItem.Text = "&Edycja";
            this.edycjaToolStripMenuItem.Click += new System.EventHandler(this.edycjaToolStripMenuItem_Click);
            // 
            // usunięcieToolStripMenuItem
            // 
            this.usunięcieToolStripMenuItem.Name = "usunięcieToolStripMenuItem";
            this.usunięcieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usunięcieToolStripMenuItem.Text = "&Usunięcie";
            this.usunięcieToolStripMenuItem.Click += new System.EventHandler(this.usunięcieToolStripMenuItem_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(482, 46);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(190, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(167, 46);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(111, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(18, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(115, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(479, 16);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(306, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(164, 16);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(53, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 16);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Imie";
            // 
            // sprzedawcyToolStripMenuItem
            // 
            this.sprzedawcyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem1,
            this.nowyToolStripMenuItem1,
            this.edycjaToolStripMenuItem1,
            this.usunięcieToolStripMenuItem1});
            this.sprzedawcyToolStripMenuItem.Name = "sprzedawcyToolStripMenuItem";
            this.sprzedawcyToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sprzedawcyToolStripMenuItem.Text = "Sp&rzedawcy";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem1.Text = "&Lista";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // nowyToolStripMenuItem1
            // 
            this.nowyToolStripMenuItem1.Name = "nowyToolStripMenuItem1";
            this.nowyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nowyToolStripMenuItem1.Text = "&Nowy";
            this.nowyToolStripMenuItem1.Click += new System.EventHandler(this.nowyToolStripMenuItem1_Click);
            // 
            // edycjaToolStripMenuItem1
            // 
            this.edycjaToolStripMenuItem1.Name = "edycjaToolStripMenuItem1";
            this.edycjaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.edycjaToolStripMenuItem1.Text = "&Edycja";
            this.edycjaToolStripMenuItem1.Click += new System.EventHandler(this.edycjaToolStripMenuItem1_Click);
            // 
            // usunięcieToolStripMenuItem1
            // 
            this.usunięcieToolStripMenuItem1.Name = "usunięcieToolStripMenuItem1";
            this.usunięcieToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usunięcieToolStripMenuItem1.Text = "&Usunięcie";
            this.usunięcieToolStripMenuItem1.Click += new System.EventHandler(this.usunięcieToolStripMenuItem1_Click);
            // 
            // listaToolStripMenuItem2
            // 
            this.listaToolStripMenuItem2.Name = "listaToolStripMenuItem2";
            this.listaToolStripMenuItem2.Size = new System.Drawing.Size(203, 22);
            this.listaToolStripMenuItem2.Text = "&Lista";
            this.listaToolStripMenuItem2.Click += new System.EventHandler(this.listaToolStripMenuItem2_Click);
            // 
            // nowaFakturaToolStripMenuItem
            // 
            this.nowaFakturaToolStripMenuItem.Name = "nowaFakturaToolStripMenuItem";
            this.nowaFakturaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nowaFakturaToolStripMenuItem.Text = "&Nowa_Faktura";
            this.nowaFakturaToolStripMenuItem.Click += new System.EventHandler(this.nowaFakturaToolStripMenuItem_Click);
            // 
            // edycjaFakturyToolStripMenuItem
            // 
            this.edycjaFakturyToolStripMenuItem.Name = "edycjaFakturyToolStripMenuItem";
            this.edycjaFakturyToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.edycjaFakturyToolStripMenuItem.Text = "&Edycja_Faktury";
            this.edycjaFakturyToolStripMenuItem.Click += new System.EventHandler(this.edycjaFakturyToolStripMenuItem_Click);
            // 
            // usunięcieFakturyToolStripMenuItem
            // 
            this.usunięcieFakturyToolStripMenuItem.Name = "usunięcieFakturyToolStripMenuItem";
            this.usunięcieFakturyToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.usunięcieFakturyToolStripMenuItem.Text = "&Usunięcie_Faktury";
            this.usunięcieFakturyToolStripMenuItem.Click += new System.EventHandler(this.usunięcieFakturyToolStripMenuItem_Click);
            // 
            // gpEmployee
            // 
            this.gpEmployee.Controls.Add(this.lblFirstName);
            this.gpEmployee.Controls.Add(this.txtPhone);
            this.gpEmployee.Controls.Add(this.lblLastName);
            this.gpEmployee.Controls.Add(this.txtEmail);
            this.gpEmployee.Controls.Add(this.lblEmail);
            this.gpEmployee.Controls.Add(this.txtLastName);
            this.gpEmployee.Controls.Add(this.lblPhone);
            this.gpEmployee.Controls.Add(this.txtFirstName);
            this.gpEmployee.Location = new System.Drawing.Point(12, 13);
            this.gpEmployee.Name = "gpEmployee";
            this.gpEmployee.Size = new System.Drawing.Size(718, 72);
            this.gpEmployee.TabIndex = 8;
            this.gpEmployee.TabStop = false;
            this.gpEmployee.Text = "Pracownicy";
            // 
            // gpVentors
            // 
            this.gpVentors.Controls.Add(this.txtCity);
            this.gpVentors.Controls.Add(this.txtStreet);
            this.gpVentors.Controls.Add(this.txtNip);
            this.gpVentors.Controls.Add(this.lblCity);
            this.gpVentors.Controls.Add(this.lblStreet);
            this.gpVentors.Controls.Add(this.lblNip);
            this.gpVentors.Controls.Add(this.txtName);
            this.gpVentors.Controls.Add(this.lblName);
            this.gpVentors.Location = new System.Drawing.Point(12, 91);
            this.gpVentors.Name = "gpVentors";
            this.gpVentors.Size = new System.Drawing.Size(718, 100);
            this.gpVentors.TabIndex = 9;
            this.gpVentors.TabStop = false;
            this.gpVentors.Text = "Kontrahenci";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblNip
            // 
            this.lblNip.AutoSize = true;
            this.lblNip.Location = new System.Drawing.Point(164, 20);
            this.lblNip.Name = "lblNip";
            this.lblNip.Size = new System.Drawing.Size(23, 13);
            this.lblNip.TabIndex = 2;
            this.lblNip.Text = "Nip";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(306, 20);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(31, 13);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Ulica";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(479, 20);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "Miasto";
            // 
            // txtNip
            // 
            this.txtNip.Location = new System.Drawing.Point(167, 36);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(100, 20);
            this.txtNip.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(309, 36);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(482, 36);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            // 
            // nieuregolowanafakturaToolStripMenuItem
            // 
            this.nieuregolowanafakturaToolStripMenuItem.Name = "nieuregolowanafakturaToolStripMenuItem";
            this.nieuregolowanafakturaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nieuregolowanafakturaToolStripMenuItem.Text = "Nieuregolowana_faktura";
            this.nieuregolowanafakturaToolStripMenuItem.Click += new System.EventHandler(this.nieuregolowanafakturaToolStripMenuItem_Click);
            // 
            // gpInvoices
            // 
            this.gpInvoices.Controls.Add(this.cbEmployee);
            this.gpInvoices.Controls.Add(this.lblEmployee);
            this.gpInvoices.Controls.Add(this.cbVendor);
            this.gpInvoices.Controls.Add(this.dtpDate);
            this.gpInvoices.Controls.Add(this.lblDate);
            this.gpInvoices.Controls.Add(this.txtNetto);
            this.gpInvoices.Controls.Add(this.lblVat);
            this.gpInvoices.Controls.Add(this.txtVat);
            this.gpInvoices.Controls.Add(this.lblVendor);
            this.gpInvoices.Controls.Add(this.txtPaid);
            this.gpInvoices.Controls.Add(this.lblNetto);
            this.gpInvoices.Controls.Add(this.lblPaid);
            this.gpInvoices.Controls.Add(this.txtNumber);
            this.gpInvoices.Controls.Add(this.lblNumber);
            this.gpInvoices.Location = new System.Drawing.Point(12, 197);
            this.gpInvoices.Name = "gpInvoices";
            this.gpInvoices.Size = new System.Drawing.Size(718, 141);
            this.gpInvoices.TabIndex = 10;
            this.gpInvoices.TabStop = false;
            this.gpInvoices.Text = "Faktury";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(18, 27);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(38, 13);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Numer";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(21, 43);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(18, 80);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(60, 13);
            this.lblPaid.TabIndex = 10;
            this.lblPaid.Text = "Zapłacono";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(21, 96);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(100, 20);
            this.txtPaid.TabIndex = 11;
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Location = new System.Drawing.Point(164, 27);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(33, 13);
            this.lblNetto.TabIndex = 12;
            this.lblNetto.Text = "Netto";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(309, 43);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 20);
            this.txtVat.TabIndex = 13;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(164, 80);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(59, 13);
            this.lblVendor.TabIndex = 14;
            this.lblVendor.Text = "Kontrahent";
            // 
            // txtNetto
            // 
            this.txtNetto.Location = new System.Drawing.Point(167, 43);
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.Size = new System.Drawing.Size(100, 20);
            this.txtNetto.TabIndex = 15;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(306, 27);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(23, 13);
            this.lblVat.TabIndex = 16;
            this.lblVat.Text = "Vat";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(479, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Data";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(482, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 19;
            // 
            // cbVendor
            // 
            this.cbVendor.DisplayMember = "Name";
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(167, 96);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(121, 21);
            this.cbVendor.TabIndex = 20;
            this.cbVendor.ValueMember = "Id";
            // 
            // cbEmployee
            // 
            this.cbEmployee.DisplayMember = "Name";
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(309, 96);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbEmployee.TabIndex = 22;
            this.cbEmployee.ValueMember = "Id";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(306, 80);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(57, 13);
            this.lblEmployee.TabIndex = 21;
            this.lblEmployee.Text = "Pracownik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 703);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpEmployee.ResumeLayout(false);
            this.gpEmployee.PerformLayout();
            this.gpVentors.ResumeLayout(false);
            this.gpVentors.PerformLayout();
            this.gpInvoices.ResumeLayout(false);
            this.gpInvoices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunięcieToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nowaFakturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaFakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunięcieFakturyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedawcyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usunięcieToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gpVentors;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblNip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gpEmployee;
        private System.Windows.Forms.ToolStripMenuItem nieuregolowanafakturaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpInvoices;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNetto;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cbVendor;
    }
}

