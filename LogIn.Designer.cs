
namespace Santa_Helena_Campestre
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBoxSH = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSH
            // 
            this.pictureBoxSH.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSH.Image")));
            this.pictureBoxSH.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSH.InitialImage")));
            this.pictureBoxSH.Location = new System.Drawing.Point(0, 248);
            this.pictureBoxSH.Name = "pictureBoxSH";
            this.pictureBoxSH.Size = new System.Drawing.Size(410, 253);
            this.pictureBoxSH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSH.TabIndex = 1;
            this.pictureBoxSH.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(60, 91);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(60, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(248, 199);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogIn.Location = new System.Drawing.Point(63, 199);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(114, 29);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Iniciar Sesión";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(58, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(285, 25);
            this.lblWelcome.TabIndex = 23;
            this.lblWelcome.Text = "¡Que gusto tenerte de vuelta!";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(203, 87);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(140, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(203, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(409, 500);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBoxSH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSH;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
    }
}