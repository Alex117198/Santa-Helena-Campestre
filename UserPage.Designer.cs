
namespace Santa_Helena_Campestre
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.loginBtn = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblUserTag = new System.Windows.Forms.Label();
            this.pBoxSanta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSanta)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(111, 451);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(116, 40);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Domicilios";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.Location = new System.Drawing.Point(397, 451);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(116, 40);
            this.btnOrderHistory.TabIndex = 2;
            this.btnOrderHistory.Text = "Historial de Pedidos";
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(677, 451);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblName.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.SeaShell;
            this.lblName.Location = new System.Drawing.Point(0, 548);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 44);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Usuario";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestion.Location = new System.Drawing.Point(101, 377);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(705, 58);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "¿Como podemos ayudarte hoy?";
            // 
            // lblUserTag
            // 
            this.lblUserTag.AutoSize = true;
            this.lblUserTag.BackColor = System.Drawing.Color.Transparent;
            this.lblUserTag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserTag.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTag.ForeColor = System.Drawing.Color.Black;
            this.lblUserTag.Location = new System.Drawing.Point(0, 504);
            this.lblUserTag.Name = "lblUserTag";
            this.lblUserTag.Size = new System.Drawing.Size(159, 44);
            this.lblUserTag.TabIndex = 6;
            this.lblUserTag.Text = "Usuario:";
            // 
            // pBoxSanta
            // 
            this.pBoxSanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBoxSanta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBoxSanta.Image = global::Santa_Helena_Campestre.Properties.Resources._148864821_114107667334366_6215615232912445248_n1;
            this.pBoxSanta.Location = new System.Drawing.Point(0, 0);
            this.pBoxSanta.Name = "pBoxSanta";
            this.pBoxSanta.Size = new System.Drawing.Size(903, 361);
            this.pBoxSanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSanta.TabIndex = 7;
            this.pBoxSanta.TabStop = false;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(903, 592);
            this.Controls.Add(this.pBoxSanta);
            this.Controls.Add(this.lblUserTag);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblUserTag;
        private System.Windows.Forms.PictureBox pBoxSanta;
    }
}