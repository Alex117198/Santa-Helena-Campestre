
namespace Santa_Helena_Campestre
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblIDType = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.cBoxIDType = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.errorProviderPw = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIDType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxSH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIDType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(70, 103);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario:";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(229, 100);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.Location = new System.Drawing.Point(70, 129);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(75, 15);
            this.lblPassword1.TabIndex = 3;
            this.lblPassword1.Text = "Contraseña:";
            this.lblPassword1.Click += new System.EventHandler(this.lblPassword1_Click);
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.Location = new System.Drawing.Point(70, 155);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(128, 15);
            this.lblPassword2.TabIndex = 4;
            this.lblPassword2.Text = "Confirma contraseña:";
            this.lblPassword2.Click += new System.EventHandler(this.lblPassword2_Click);
            // 
            // lblIDType
            // 
            this.lblIDType.AutoSize = true;
            this.lblIDType.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDType.Location = new System.Drawing.Point(71, 264);
            this.lblIDType.Name = "lblIDType";
            this.lblIDType.Size = new System.Drawing.Size(132, 15);
            this.lblIDType.TabIndex = 5;
            this.lblIDType.Text = "Tipo de Identificación:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(71, 290);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(152, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Numero de Identificación:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 316);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(71, 342);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 15);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Apellido:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(71, 368);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(118, 15);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Número Telefonico:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(229, 286);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(149, 20);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(229, 126);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(149, 20);
            this.txtPassword1.TabIndex = 2;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 311);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 6;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(229, 363);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(149, 20);
            this.txtPhoneNumber.TabIndex = 8;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(229, 337);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 20);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(229, 152);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(149, 20);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
            // 
            // cBoxIDType
            // 
            this.cBoxIDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxIDType.FormattingEnabled = true;
            this.cBoxIDType.Items.AddRange(new object[] {
            "CC",
            "TI",
            "TE"});
            this.cBoxIDType.Location = new System.Drawing.Point(229, 259);
            this.cBoxIDType.Name = "cBoxIDType";
            this.cBoxIDType.Size = new System.Drawing.Size(149, 21);
            this.cBoxIDType.TabIndex = 4;
            this.cBoxIDType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBoxIDType_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 19);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Datos de Usuario:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(69, 219);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(140, 19);
            this.lblSubTitle.TabIndex = 19;
            this.lblSubTitle.Text = "Datos Personales:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backBtn.Location = new System.Drawing.Point(229, 440);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(95, 29);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Volver";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerBtn.Location = new System.Drawing.Point(97, 440);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(92, 29);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "¡Registrar!";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // errorProviderPw
            // 
            this.errorProviderPw.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPw.ContainerControl = this;
            this.errorProviderPw.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPw.Icon")));
            // 
            // errorProviderIDType
            // 
            this.errorProviderIDType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderIDType.ContainerControl = this;
            this.errorProviderIDType.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderIDType.Icon")));
            // 
            // errorProviderID
            // 
            this.errorProviderID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderID.ContainerControl = this;
            this.errorProviderID.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderID.Icon")));
            // 
            // errorProviderName
            // 
            this.errorProviderName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderName.ContainerControl = this;
            this.errorProviderName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderName.Icon")));
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLastName.ContainerControl = this;
            this.errorProviderLastName.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLastName.Icon")));
            // 
            // errorProviderPhoneNumber
            // 
            this.errorProviderPhoneNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPhoneNumber.ContainerControl = this;
            this.errorProviderPhoneNumber.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderPhoneNumber.Icon")));
            // 
            // errorProviderUser
            // 
            this.errorProviderUser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUser.ContainerControl = this;
            this.errorProviderUser.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderUser.Icon")));
            // 
            // pictureBoxSH
            // 
            this.pictureBoxSH.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSH.Image")));
            this.pictureBoxSH.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSH.InitialImage")));
            this.pictureBoxSH.Location = new System.Drawing.Point(458, 0);
            this.pictureBoxSH.Name = "pictureBoxSH";
            this.pictureBoxSH.Size = new System.Drawing.Size(501, 502);
            this.pictureBoxSH.TabIndex = 0;
            this.pictureBoxSH.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(959, 500);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cBoxIDType);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblIDType);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBoxSH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Santa Helena";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIDType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblIDType;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.ComboBox cBoxIDType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ErrorProvider errorProviderPw;
        private System.Windows.Forms.ErrorProvider errorProviderIDType;
        private System.Windows.Forms.ErrorProvider errorProviderID;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBoxSH;
        private System.Windows.Forms.ErrorProvider errorProviderUser;
    }
}