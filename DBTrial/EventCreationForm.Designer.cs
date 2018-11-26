namespace DBTrial
{
    partial class EventCreationForm
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
            this.btnEventsFromEventCreation = new System.Windows.Forms.Button();
            this.EventParticipantsAdded = new System.Windows.Forms.DataGridView();
            this.EventParticipantsNotAdded = new System.Windows.Forms.DataGridView();
            this.EventMemberList = new System.Windows.Forms.DataGridView();
            this.lblEventAdded = new System.Windows.Forms.Label();
            this.lblEventNotAdded = new System.Windows.Forms.Label();
            this.txtEventSearchMembers = new System.Windows.Forms.TextBox();
            this.btnEventMemberSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventParticipantsAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventParticipantsNotAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEventsFromEventCreation
            // 
            this.btnEventsFromEventCreation.Location = new System.Drawing.Point(619, 407);
            this.btnEventsFromEventCreation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEventsFromEventCreation.Name = "btnEventsFromEventCreation";
            this.btnEventsFromEventCreation.Size = new System.Drawing.Size(96, 31);
            this.btnEventsFromEventCreation.TabIndex = 0;
            this.btnEventsFromEventCreation.Text = "Events";
            this.btnEventsFromEventCreation.UseVisualStyleBackColor = true;
            this.btnEventsFromEventCreation.Click += new System.EventHandler(this.btnEventsFromEventCreation_Click);
            // 
            // EventParticipantsAdded
            // 
            this.EventParticipantsAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventParticipantsAdded.Location = new System.Drawing.Point(48, 59);
            this.EventParticipantsAdded.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventParticipantsAdded.Name = "EventParticipantsAdded";
            this.EventParticipantsAdded.RowTemplate.Height = 28;
            this.EventParticipantsAdded.Size = new System.Drawing.Size(217, 325);
            this.EventParticipantsAdded.TabIndex = 2;
            this.EventParticipantsAdded.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.EventParticipantsAdded_CellContextMenuStripNeeded);
            this.EventParticipantsAdded.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventParticipantsAdded_CellMouseEnter);
            // 
            // EventParticipantsNotAdded
            // 
            this.EventParticipantsNotAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventParticipantsNotAdded.Location = new System.Drawing.Point(301, 59);
            this.EventParticipantsNotAdded.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventParticipantsNotAdded.Name = "EventParticipantsNotAdded";
            this.EventParticipantsNotAdded.RowTemplate.Height = 28;
            this.EventParticipantsNotAdded.Size = new System.Drawing.Size(217, 325);
            this.EventParticipantsNotAdded.TabIndex = 3;
            // 
            // EventMemberList
            // 
            this.EventMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventMemberList.Location = new System.Drawing.Point(553, 59);
            this.EventMemberList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EventMemberList.Name = "EventMemberList";
            this.EventMemberList.RowTemplate.Height = 28;
            this.EventMemberList.Size = new System.Drawing.Size(217, 325);
            this.EventMemberList.TabIndex = 4;
            this.EventMemberList.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.EventMemberList_CellContextMenuStripNeeded);
            this.EventMemberList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventMemberList_CellMouseEnter);
            // 
            // lblEventAdded
            // 
            this.lblEventAdded.AutoSize = true;
            this.lblEventAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventAdded.Location = new System.Drawing.Point(45, 6);
            this.lblEventAdded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventAdded.Name = "lblEventAdded";
            this.lblEventAdded.Size = new System.Drawing.Size(51, 20);
            this.lblEventAdded.TabIndex = 5;
            this.lblEventAdded.Text = "label1";
            // 
            // lblEventNotAdded
            // 
            this.lblEventNotAdded.AutoSize = true;
            this.lblEventNotAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventNotAdded.Location = new System.Drawing.Point(298, 19);
            this.lblEventNotAdded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventNotAdded.Name = "lblEventNotAdded";
            this.lblEventNotAdded.Size = new System.Drawing.Size(85, 20);
            this.lblEventNotAdded.TabIndex = 6;
            this.lblEventNotAdded.Text = "Not Added";
            // 
            // txtEventSearchMembers
            // 
            this.txtEventSearchMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventSearchMembers.Location = new System.Drawing.Point(624, 19);
            this.txtEventSearchMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEventSearchMembers.Name = "txtEventSearchMembers";
            this.txtEventSearchMembers.Size = new System.Drawing.Size(147, 26);
            this.txtEventSearchMembers.TabIndex = 7;
            this.txtEventSearchMembers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEventSearchMembers_KeyDown);
            // 
            // btnEventMemberSearch
            // 
            this.btnEventMemberSearch.Location = new System.Drawing.Point(553, 19);
            this.btnEventMemberSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEventMemberSearch.Name = "btnEventMemberSearch";
            this.btnEventMemberSearch.Size = new System.Drawing.Size(67, 23);
            this.btnEventMemberSearch.TabIndex = 8;
            this.btnEventMemberSearch.Text = "Search";
            this.btnEventMemberSearch.UseVisualStyleBackColor = true;
            this.btnEventMemberSearch.Click += new System.EventHandler(this.btnEventMemberSearch_Click);
            // 
            // EventCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 461);
            this.Controls.Add(this.btnEventMemberSearch);
            this.Controls.Add(this.txtEventSearchMembers);
            this.Controls.Add(this.lblEventNotAdded);
            this.Controls.Add(this.lblEventAdded);
            this.Controls.Add(this.EventMemberList);
            this.Controls.Add(this.EventParticipantsNotAdded);
            this.Controls.Add(this.EventParticipantsAdded);
            this.Controls.Add(this.btnEventsFromEventCreation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventCreationForm";
            this.Text = "EventCreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.EventParticipantsAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventParticipantsNotAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEventsFromEventCreation;
        private System.Windows.Forms.DataGridView EventParticipantsAdded;
        private System.Windows.Forms.DataGridView EventParticipantsNotAdded;
        private System.Windows.Forms.DataGridView EventMemberList;
        private System.Windows.Forms.Label lblEventAdded;
        private System.Windows.Forms.Label lblEventNotAdded;
        private System.Windows.Forms.TextBox txtEventSearchMembers;
        private System.Windows.Forms.Button btnEventMemberSearch;
    }
}