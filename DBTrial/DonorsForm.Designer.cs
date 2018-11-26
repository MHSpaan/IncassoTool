namespace DBTrial
{
    partial class DonorsForm
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
            this.btnIndexFromDonor = new System.Windows.Forms.Button();
            this.btnMemberView = new System.Windows.Forms.Button();
            this.DonorGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DonorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndexFromDonor
            // 
            this.btnIndexFromDonor.Location = new System.Drawing.Point(46, 22);
            this.btnIndexFromDonor.Name = "btnIndexFromDonor";
            this.btnIndexFromDonor.Size = new System.Drawing.Size(108, 40);
            this.btnIndexFromDonor.TabIndex = 3;
            this.btnIndexFromDonor.Text = "Back";
            this.btnIndexFromDonor.Click += new System.EventHandler(this.btnIndexFromDonor_Click);
            // 
            // btnMemberView
            // 
            this.btnMemberView.Location = new System.Drawing.Point(178, 22);
            this.btnMemberView.Name = "btnMemberView";
            this.btnMemberView.Size = new System.Drawing.Size(105, 40);
            this.btnMemberView.TabIndex = 1;
            this.btnMemberView.Text = "Members";
            this.btnMemberView.UseVisualStyleBackColor = true;
            this.btnMemberView.Click += new System.EventHandler(this.btnMemberView_Click_1);
            // 
            // DonorGrid
            // 
            this.DonorGrid.AllowUserToAddRows = false;
            this.DonorGrid.AllowUserToDeleteRows = false;
            this.DonorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorGrid.Location = new System.Drawing.Point(11, 77);
            this.DonorGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DonorGrid.MinimumSize = new System.Drawing.Size(33, 32);
            this.DonorGrid.Name = "DonorGrid";
            this.DonorGrid.RowTemplate.Height = 28;
            this.DonorGrid.Size = new System.Drawing.Size(1500, 845);
            this.DonorGrid.TabIndex = 2;
            // 
            // DonorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 842);
            this.Controls.Add(this.DonorGrid);
            this.Controls.Add(this.btnMemberView);
            this.Controls.Add(this.btnIndexFromDonor);
            this.Name = "DonorsForm";
            this.Text = "DonorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DonorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIndexFromDonor;
        private System.Windows.Forms.Button btnMemberView;
        private System.Windows.Forms.DataGridView DonorGrid;
    }
}