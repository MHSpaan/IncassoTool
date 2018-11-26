namespace DBTrial
{
    partial class MembersDetailsForm
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
            this.DetailsGrid = new System.Windows.Forms.DataGridView();
            this.btnBackDetailsMember = new System.Windows.Forms.Button();
            this.btnDeleteMemberDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsGrid
            // 
            this.DetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsGrid.Location = new System.Drawing.Point(380, 152);
            this.DetailsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetailsGrid.Name = "DetailsGrid";
            this.DetailsGrid.Size = new System.Drawing.Size(471, 334);
            this.DetailsGrid.TabIndex = 0;
            // 
            // btnBackDetailsMember
            // 
            this.btnBackDetailsMember.Location = new System.Drawing.Point(380, 523);
            this.btnBackDetailsMember.Name = "btnBackDetailsMember";
            this.btnBackDetailsMember.Size = new System.Drawing.Size(131, 74);
            this.btnBackDetailsMember.TabIndex = 1;
            this.btnBackDetailsMember.Text = "Back";
            this.btnBackDetailsMember.UseVisualStyleBackColor = true;
            this.btnBackDetailsMember.Click += new System.EventHandler(this.btnBackDetailsMember_Click);
            // 
            // btnDeleteMemberDetails
            // 
            this.btnDeleteMemberDetails.Location = new System.Drawing.Point(651, 523);
            this.btnDeleteMemberDetails.Name = "btnDeleteMemberDetails";
            this.btnDeleteMemberDetails.Size = new System.Drawing.Size(200, 74);
            this.btnDeleteMemberDetails.TabIndex = 2;
            this.btnDeleteMemberDetails.Text = "DeleteMember";
            this.btnDeleteMemberDetails.UseVisualStyleBackColor = true;
            this.btnDeleteMemberDetails.Click += new System.EventHandler(this.btnDeleteMemberDetails_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnDeleteMemberDetails);
            this.Controls.Add(this.btnBackDetailsMember);
            this.Controls.Add(this.DetailsGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DetailsGrid;
        private System.Windows.Forms.Button btnBackDetailsMember;
        private System.Windows.Forms.Button btnDeleteMemberDetails;
    }
}