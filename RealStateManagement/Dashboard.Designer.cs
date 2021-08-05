namespace RealStateManagement
{
    partial class Dashboard
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
            this.btnAddSociety = new System.Windows.Forms.Button();
            this.btnDispSociety = new System.Windows.Forms.Button();
            this.dgvSociety = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociety)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSociety
            // 
            this.btnAddSociety.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddSociety.Location = new System.Drawing.Point(12, 36);
            this.btnAddSociety.Name = "btnAddSociety";
            this.btnAddSociety.Size = new System.Drawing.Size(105, 23);
            this.btnAddSociety.TabIndex = 0;
            this.btnAddSociety.Text = "Add Society";
            this.btnAddSociety.UseVisualStyleBackColor = true;
            this.btnAddSociety.Click += new System.EventHandler(this.btnAddSociety_Click);
            // 
            // btnDispSociety
            // 
            this.btnDispSociety.Location = new System.Drawing.Point(137, 36);
            this.btnDispSociety.Name = "btnDispSociety";
            this.btnDispSociety.Size = new System.Drawing.Size(104, 23);
            this.btnDispSociety.TabIndex = 1;
            this.btnDispSociety.Text = "Display Society";
            this.btnDispSociety.UseVisualStyleBackColor = true;
            this.btnDispSociety.Click += new System.EventHandler(this.btnDispSociety_Click);
            // 
            // dgvSociety
            // 
            this.dgvSociety.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSociety.Location = new System.Drawing.Point(23, 111);
            this.dgvSociety.Name = "dgvSociety";
            this.dgvSociety.Size = new System.Drawing.Size(440, 220);
            this.dgvSociety.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 343);
            this.Controls.Add(this.dgvSociety);
            this.Controls.Add(this.btnDispSociety);
            this.Controls.Add(this.btnAddSociety);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSociety)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSociety;
        private System.Windows.Forms.Button btnDispSociety;
        private System.Windows.Forms.DataGridView dgvSociety;
    }
}

