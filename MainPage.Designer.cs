
namespace Santa_Helena_Campestre
{
    partial class MainInterface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.registerButton = new System.Windows.Forms.Button();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.PeachPuff;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(189, 449);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(99, 40);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Registrate";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // leaveBtn
            // 
            this.leaveBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.leaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveBtn.Location = new System.Drawing.Point(770, 449);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(99, 40);
            this.leaveBtn.TabIndex = 3;
            this.leaveBtn.Text = "Salir";
            this.leaveBtn.UseVisualStyleBackColor = false;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(44, 449);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(116, 40);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Iniciar Sesión";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(959, 593);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Santa Helena Campestre";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button leaveBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}

