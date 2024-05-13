
namespace Santa_Helena_Campestre
{
    partial class OrderHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistory));
            this.gBoxOrderHistory = new System.Windows.Forms.GroupBox();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.gBoxOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxOrderHistory
            // 
            this.gBoxOrderHistory.Controls.Add(this.dgvOrderHistory);
            this.gBoxOrderHistory.Controls.Add(this.btnBack);
            this.gBoxOrderHistory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxOrderHistory.Location = new System.Drawing.Point(12, 12);
            this.gBoxOrderHistory.Name = "gBoxOrderHistory";
            this.gBoxOrderHistory.Size = new System.Drawing.Size(776, 426);
            this.gBoxOrderHistory.TabIndex = 0;
            this.gBoxOrderHistory.TabStop = false;
            this.gBoxOrderHistory.Text = "Historial de Pedidos";
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.AllowUserToAddRows = false;
            this.dgvOrderHistory.AllowUserToDeleteRows = false;
            this.dgvOrderHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrderHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrderHistory.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvOrderHistory.Location = new System.Drawing.Point(6, 26);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.Size = new System.Drawing.Size(764, 348);
            this.dgvOrderHistory.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(654, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxOrderHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Pedidos";
            this.gBoxOrderHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxOrderHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
    }
}