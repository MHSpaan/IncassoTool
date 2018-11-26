namespace DBTrial
{
    partial class EventDetailsForm
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
            this.EventDetailsParticipantsGrid = new System.Windows.Forms.DataGridView();
            this.EventDetailsMembersGrid = new System.Windows.Forms.DataGridView();
            this.btnBackToEventsFromEventDetails = new System.Windows.Forms.Button();
            this.txtSearchMembersEventDetails = new System.Windows.Forms.TextBox();
            this.btnSearchMembersEventDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventDetailsParticipantsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDetailsMembersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDetailsParticipantsGrid
            // 
            this.EventDetailsParticipantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDetailsParticipantsGrid.Location = new System.Drawing.Point(57, 75);
            this.EventDetailsParticipantsGrid.Name = "EventDetailsParticipantsGrid";
            this.EventDetailsParticipantsGrid.RowTemplate.Height = 28;
            this.EventDetailsParticipantsGrid.Size = new System.Drawing.Size(324, 429);
            this.EventDetailsParticipantsGrid.TabIndex = 0;
            this.EventDetailsParticipantsGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.EventDetailsParticipantsGrid_CellContextMenuStripNeeded);
            this.EventDetailsParticipantsGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDetailsParticipantsGrid_CellMouseEnter);
            // 
            // EventDetailsMembersGrid
            // 
            this.EventDetailsMembersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDetailsMembersGrid.Location = new System.Drawing.Point(411, 75);
            this.EventDetailsMembersGrid.Name = "EventDetailsMembersGrid";
            this.EventDetailsMembersGrid.RowTemplate.Height = 28;
            this.EventDetailsMembersGrid.Size = new System.Drawing.Size(324, 429);
            this.EventDetailsMembersGrid.TabIndex = 1;
            this.EventDetailsMembersGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.EventDetailsMembersGrid_CellContextMenuStripNeeded);
            this.EventDetailsMembersGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDetailsMembersGrid_CellMouseEnter);
            // 
            // btnBackToEventsFromEventDetails
            // 
            this.btnBackToEventsFromEventDetails.Location = new System.Drawing.Point(57, 529);
            this.btnBackToEventsFromEventDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackToEventsFromEventDetails.Name = "btnBackToEventsFromEventDetails";
            this.btnBackToEventsFromEventDetails.Size = new System.Drawing.Size(159, 46);
            this.btnBackToEventsFromEventDetails.TabIndex = 2;
            this.btnBackToEventsFromEventDetails.Text = "Back";
            this.btnBackToEventsFromEventDetails.UseVisualStyleBackColor = true;
            this.btnBackToEventsFromEventDetails.Click += new System.EventHandler(this.btnBackToEventsFromEventDetails_Click);
            // 
            // txtSearchMembersEventDetails
            // 
            this.txtSearchMembersEventDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMembersEventDetails.Location = new System.Drawing.Point(546, 18);
            this.txtSearchMembersEventDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMembersEventDetails.Name = "txtSearchMembersEventDetails";
            this.txtSearchMembersEventDetails.Size = new System.Drawing.Size(187, 35);
            this.txtSearchMembersEventDetails.TabIndex = 3;
            this.txtSearchMembersEventDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMembersEventDetails_KeyDown);
            // 
            // btnSearchMembersEventDetails
            // 
            this.btnSearchMembersEventDetails.Location = new System.Drawing.Point(411, 18);
            this.btnSearchMembersEventDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMembersEventDetails.Name = "btnSearchMembersEventDetails";
            this.btnSearchMembersEventDetails.Size = new System.Drawing.Size(126, 40);
            this.btnSearchMembersEventDetails.TabIndex = 4;
            this.btnSearchMembersEventDetails.Text = "Search";
            this.btnSearchMembersEventDetails.UseVisualStyleBackColor = true;
            this.btnSearchMembersEventDetails.Click += new System.EventHandler(this.btnSearchMembersEventDetails_Click);
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.btnSearchMembersEventDetails);
            this.Controls.Add(this.txtSearchMembersEventDetails);
            this.Controls.Add(this.btnBackToEventsFromEventDetails);
            this.Controls.Add(this.EventDetailsMembersGrid);
            this.Controls.Add(this.EventDetailsParticipantsGrid);
            this.Name = "EventDetailsForm";
            this.Text = "EventDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.EventDetailsParticipantsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDetailsMembersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EventDetailsParticipantsGrid;
        private System.Windows.Forms.DataGridView EventDetailsMembersGrid;
        private System.Windows.Forms.Button btnBackToEventsFromEventDetails;
        private System.Windows.Forms.TextBox txtSearchMembersEventDetails;
        private System.Windows.Forms.Button btnSearchMembersEventDetails;
    }
}