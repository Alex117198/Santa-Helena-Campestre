
namespace Santa_Helena_Campestre
{
    partial class Delivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegisterDelivery = new System.Windows.Forms.Button();
            this.cBoxProduct = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxCity = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPaidMethod = new System.Windows.Forms.Label();
            this.lblallProductPrices = new System.Windows.Forms.Label();
            this.lblTotalProductPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.gBoxPurchaseData = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cBoxPaidMethod = new System.Windows.Forms.ComboBox();
            this.gBoxDelivery = new System.Windows.Forms.GroupBox();
            this.btnAddressConfirm = new System.Windows.Forms.Button();
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPayMethod = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvSelectedItems = new System.Windows.Forms.DataGridView();
            this.gBoxInstructions = new System.Windows.Forms.GroupBox();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblTurnNumber = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblInv = new System.Windows.Forms.Label();
            this.gBoxBuyInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.gBoxPurchaseData.SuspendLayout();
            this.gBoxDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPayMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).BeginInit();
            this.gBoxInstructions.SuspendLayout();
            this.gBoxBuyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(295, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar Producto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(519, 477);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegisterDelivery
            // 
            this.btnRegisterDelivery.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRegisterDelivery.Enabled = false;
            this.btnRegisterDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterDelivery.Location = new System.Drawing.Point(213, 477);
            this.btnRegisterDelivery.Name = "btnRegisterDelivery";
            this.btnRegisterDelivery.Size = new System.Drawing.Size(116, 40);
            this.btnRegisterDelivery.TabIndex = 10;
            this.btnRegisterDelivery.Text = "Realizar Pedido";
            this.btnRegisterDelivery.UseVisualStyleBackColor = false;
            this.btnRegisterDelivery.Click += new System.EventHandler(this.btnRegisterDelivery_Click);
            // 
            // cBoxProduct
            // 
            this.cBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxProduct.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxProduct.FormattingEnabled = true;
            this.cBoxProduct.Location = new System.Drawing.Point(189, 64);
            this.cBoxProduct.Name = "cBoxProduct";
            this.cBoxProduct.Size = new System.Drawing.Size(172, 23);
            this.cBoxProduct.TabIndex = 6;
            this.cBoxProduct.SelectedIndexChanged += new System.EventHandler(this.cBoxProduct_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(189, 142);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(71, 23);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nUpDnQuantity_ValueChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(179, 36);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(93, 23);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2024, 5, 12, 5, 0, 53, 0);
            // 
            // cBoxCity
            // 
            this.cBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCity.FormattingEnabled = true;
            this.cBoxCity.Items.AddRange(new object[] {
            "Chivata",
            "Cómbita",
            "Motavita",
            "Oicatá",
            "Soracá",
            "Tunja"});
            this.cBoxCity.Location = new System.Drawing.Point(179, 72);
            this.cBoxCity.Name = "cBoxCity";
            this.cBoxCity.Size = new System.Drawing.Size(163, 23);
            this.cBoxCity.TabIndex = 2;
            this.cBoxCity.TextChanged += new System.EventHandler(this.cBoxCity_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(179, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 23);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(38, 70);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(145, 18);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Selecciona tu producto:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(38, 148);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(60, 15);
            this.lblQuantity.TabIndex = 15;
            this.lblQuantity.Text = "Cantidad:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(22, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 15);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Fecha:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(22, 78);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 15);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "Ciudad:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(22, 114);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 15);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Dirección";
            // 
            // lblPaidMethod
            // 
            this.lblPaidMethod.AutoSize = true;
            this.lblPaidMethod.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidMethod.Location = new System.Drawing.Point(22, 151);
            this.lblPaidMethod.Name = "lblPaidMethod";
            this.lblPaidMethod.Size = new System.Drawing.Size(101, 15);
            this.lblPaidMethod.TabIndex = 19;
            this.lblPaidMethod.Text = "Metodo de pago:";
            // 
            // lblallProductPrices
            // 
            this.lblallProductPrices.AutoSize = true;
            this.lblallProductPrices.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblallProductPrices.Location = new System.Drawing.Point(38, 187);
            this.lblallProductPrices.Name = "lblallProductPrices";
            this.lblallProductPrices.Size = new System.Drawing.Size(74, 15);
            this.lblallProductPrices.TabIndex = 20;
            this.lblallProductPrices.Text = "Precio total:";
            // 
            // lblTotalProductPrice
            // 
            this.lblTotalProductPrice.AutoSize = true;
            this.lblTotalProductPrice.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductPrice.Location = new System.Drawing.Point(189, 186);
            this.lblTotalProductPrice.Name = "lblTotalProductPrice";
            this.lblTotalProductPrice.Size = new System.Drawing.Size(35, 15);
            this.lblTotalProductPrice.TabIndex = 21;
            this.lblTotalProductPrice.Text = "$$$$";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(38, 109);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(91, 15);
            this.lblUnitPrice.TabIndex = 22;
            this.lblUnitPrice.Text = "Precio unitario:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.Location = new System.Drawing.Point(189, 108);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(35, 15);
            this.lblPricePerUnit.TabIndex = 23;
            this.lblPricePerUnit.Text = "$$$$";
            this.lblPricePerUnit.TextChanged += new System.EventHandler(this.lblPricePerUnit_TextChanged);
            // 
            // gBoxPurchaseData
            // 
            this.gBoxPurchaseData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBoxPurchaseData.BackColor = System.Drawing.Color.RosyBrown;
            this.gBoxPurchaseData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gBoxPurchaseData.Controls.Add(this.lblInv);
            this.gBoxPurchaseData.Controls.Add(this.lblTurn);
            this.gBoxPurchaseData.Controls.Add(this.lblTurnNumber);
            this.gBoxPurchaseData.Controls.Add(this.btnRemove);
            this.gBoxPurchaseData.Controls.Add(this.lblQuantity);
            this.gBoxPurchaseData.Controls.Add(this.lblPricePerUnit);
            this.gBoxPurchaseData.Controls.Add(this.cBoxProduct);
            this.gBoxPurchaseData.Controls.Add(this.lblUnitPrice);
            this.gBoxPurchaseData.Controls.Add(this.nudQuantity);
            this.gBoxPurchaseData.Controls.Add(this.btnAdd);
            this.gBoxPurchaseData.Controls.Add(this.lblTotalProductPrice);
            this.gBoxPurchaseData.Controls.Add(this.lblProduct);
            this.gBoxPurchaseData.Controls.Add(this.lblallProductPrices);
            this.gBoxPurchaseData.Enabled = false;
            this.gBoxPurchaseData.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPurchaseData.Location = new System.Drawing.Point(12, 227);
            this.gBoxPurchaseData.Name = "gBoxPurchaseData";
            this.gBoxPurchaseData.Size = new System.Drawing.Size(444, 231);
            this.gBoxPurchaseData.TabIndex = 24;
            this.gBoxPurchaseData.TabStop = false;
            this.gBoxPurchaseData.Text = "Datos de Compra:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(295, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(143, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Quitar Producto";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cBoxPaidMethod
            // 
            this.cBoxPaidMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPaidMethod.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPaidMethod.FormattingEnabled = true;
            this.cBoxPaidMethod.Items.AddRange(new object[] {
            "Bancolombia a la Mano",
            "Daviplata",
            "Efectivo",
            "Nequi",
            "Transferencia Bancaria"});
            this.cBoxPaidMethod.Location = new System.Drawing.Point(179, 145);
            this.cBoxPaidMethod.Name = "cBoxPaidMethod";
            this.cBoxPaidMethod.Size = new System.Drawing.Size(163, 23);
            this.cBoxPaidMethod.TabIndex = 4;
            this.cBoxPaidMethod.TextChanged += new System.EventHandler(this.cBoxPaidMethod_TextChanged);
            // 
            // gBoxDelivery
            // 
            this.gBoxDelivery.BackColor = System.Drawing.Color.RosyBrown;
            this.gBoxDelivery.Controls.Add(this.btnAddressConfirm);
            this.gBoxDelivery.Controls.Add(this.lblPaidMethod);
            this.gBoxDelivery.Controls.Add(this.cBoxPaidMethod);
            this.gBoxDelivery.Controls.Add(this.dtpDate);
            this.gBoxDelivery.Controls.Add(this.cBoxCity);
            this.gBoxDelivery.Controls.Add(this.txtAddress);
            this.gBoxDelivery.Controls.Add(this.lblAddress);
            this.gBoxDelivery.Controls.Add(this.lblDate);
            this.gBoxDelivery.Controls.Add(this.lblCity);
            this.gBoxDelivery.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDelivery.Location = new System.Drawing.Point(386, 12);
            this.gBoxDelivery.Name = "gBoxDelivery";
            this.gBoxDelivery.Size = new System.Drawing.Size(444, 209);
            this.gBoxDelivery.TabIndex = 26;
            this.gBoxDelivery.TabStop = false;
            this.gBoxDelivery.Text = "Datos de Domicilio:";
            // 
            // btnAddressConfirm
            // 
            this.btnAddressConfirm.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddressConfirm.Enabled = false;
            this.btnAddressConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddressConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddressConfirm.Location = new System.Drawing.Point(295, 180);
            this.btnAddressConfirm.Name = "btnAddressConfirm";
            this.btnAddressConfirm.Size = new System.Drawing.Size(143, 23);
            this.btnAddressConfirm.TabIndex = 5;
            this.btnAddressConfirm.Text = "Confirmar Domicilio";
            this.btnAddressConfirm.UseVisualStyleBackColor = false;
            this.btnAddressConfirm.Click += new System.EventHandler(this.btnAddressConfirm_Click);
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCity.ContainerControl = this;
            this.errorProviderCity.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderCity.Icon")));
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAddress.ContainerControl = this;
            this.errorProviderAddress.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderAddress.Icon")));
            // 
            // errorProviderPayMethod
            // 
            this.errorProviderPayMethod.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPayMethod.ContainerControl = this;
            this.errorProviderPayMethod.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPayMethod.Icon")));
            // 
            // dgvSelectedItems
            // 
            this.dgvSelectedItems.AllowUserToAddRows = false;
            this.dgvSelectedItems.AllowUserToDeleteRows = false;
            this.dgvSelectedItems.AllowUserToOrderColumns = true;
            this.dgvSelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSelectedItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSelectedItems.BackgroundColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedItems.Location = new System.Drawing.Point(6, 24);
            this.dgvSelectedItems.Name = "dgvSelectedItems";
            this.dgvSelectedItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSelectedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectedItems.Size = new System.Drawing.Size(356, 201);
            this.dgvSelectedItems.TabIndex = 27;
            // 
            // gBoxInstructions
            // 
            this.gBoxInstructions.BackColor = System.Drawing.Color.Plum;
            this.gBoxInstructions.Controls.Add(this.lblInfo2);
            this.gBoxInstructions.Controls.Add(this.lblStep2);
            this.gBoxInstructions.Controls.Add(this.lblStep1);
            this.gBoxInstructions.Controls.Add(this.lblInfo1);
            this.gBoxInstructions.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxInstructions.Location = new System.Drawing.Point(12, 12);
            this.gBoxInstructions.Name = "gBoxInstructions";
            this.gBoxInstructions.Size = new System.Drawing.Size(368, 209);
            this.gBoxInstructions.TabIndex = 28;
            this.gBoxInstructions.TabStop = false;
            this.gBoxInstructions.Text = "Instrucciones:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(6, 122);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(356, 72);
            this.lblInfo2.TabIndex = 19;
            this.lblInfo2.Text = "Ingresa los datos de compra por cada producto.\r\nSi deseas agregar o quitar produc" +
    "tos a la lista puedes dirigirte a los botones asignados.\r\nUna vez termines presi" +
    "ona el botón \"Realizar Pedido\".";
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.Location = new System.Drawing.Point(153, 101);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(63, 19);
            this.lblStep2.TabIndex = 18;
            this.lblStep2.Text = "Paso 2:";
            this.lblStep2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.Location = new System.Drawing.Point(153, 23);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(63, 19);
            this.lblStep1.TabIndex = 16;
            this.lblStep1.Text = "Paso 1:";
            this.lblStep1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo1
            // 
            this.lblInfo1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(6, 47);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(356, 39);
            this.lblInfo1.TabIndex = 17;
            this.lblInfo1.Text = "Ingresa tus datos de domicilio y luego presiona el botón \"Confirmar Domicilio\".";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurnNumber
            // 
            this.lblTurnNumber.AutoSize = true;
            this.lblTurnNumber.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnNumber.Location = new System.Drawing.Point(189, 32);
            this.lblTurnNumber.Name = "lblTurnNumber";
            this.lblTurnNumber.Size = new System.Drawing.Size(15, 15);
            this.lblTurnNumber.TabIndex = 24;
            this.lblTurnNumber.Text = "#";
            // 
            // lblTurn
            // 
            this.lblTurn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(38, 32);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(67, 18);
            this.lblTurn.TabIndex = 25;
            this.lblTurn.Text = "Turno:";
            // 
            // lblInv
            // 
            this.lblInv.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblInv.Location = new System.Drawing.Point(205, 32);
            this.lblInv.Name = "lblInv";
            this.lblInv.Size = new System.Drawing.Size(15, 15);
            this.lblInv.TabIndex = 26;
            this.lblInv.Text = "#";
            // 
            // gBoxBuyInfo
            // 
            this.gBoxBuyInfo.BackColor = System.Drawing.Color.Plum;
            this.gBoxBuyInfo.Controls.Add(this.dgvSelectedItems);
            this.gBoxBuyInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxBuyInfo.Location = new System.Drawing.Point(462, 227);
            this.gBoxBuyInfo.Name = "gBoxBuyInfo";
            this.gBoxBuyInfo.Size = new System.Drawing.Size(368, 231);
            this.gBoxBuyInfo.TabIndex = 29;
            this.gBoxBuyInfo.TabStop = false;
            this.gBoxBuyInfo.Text = "Lista de Compra:";
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(842, 541);
            this.Controls.Add(this.gBoxBuyInfo);
            this.Controls.Add(this.gBoxInstructions);
            this.Controls.Add(this.gBoxDelivery);
            this.Controls.Add(this.gBoxPurchaseData);
            this.Controls.Add(this.btnRegisterDelivery);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domicilios";
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.gBoxPurchaseData.ResumeLayout(false);
            this.gBoxPurchaseData.PerformLayout();
            this.gBoxDelivery.ResumeLayout(false);
            this.gBoxDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPayMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).EndInit();
            this.gBoxInstructions.ResumeLayout(false);
            this.gBoxInstructions.PerformLayout();
            this.gBoxBuyInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegisterDelivery;
        private System.Windows.Forms.ComboBox cBoxProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cBoxCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPaidMethod;
        private System.Windows.Forms.Label lblallProductPrices;
        private System.Windows.Forms.Label lblTotalProductPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.GroupBox gBoxPurchaseData;
        private System.Windows.Forms.ComboBox cBoxPaidMethod;
        private System.Windows.Forms.GroupBox gBoxDelivery;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderPayMethod;
        private System.Windows.Forms.DataGridView dgvSelectedItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddressConfirm;
        private System.Windows.Forms.GroupBox gBoxInstructions;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblTurnNumber;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblInv;
        private System.Windows.Forms.GroupBox gBoxBuyInfo;
    }
}