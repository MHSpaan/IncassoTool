namespace DBTrial
{
    partial class MembersForm
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
            this.MemberGrid = new System.Windows.Forms.DataGridView();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilterInEvent = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberGrid
            // 
            this.MemberGrid.AllowUserToAddRows = false;
            this.MemberGrid.AllowUserToDeleteRows = false;
            this.MemberGrid.BackgroundColor = System.Drawing.Color.White;
            this.MemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGrid.Location = new System.Drawing.Point(11, 54);
            this.MemberGrid.Margin = new System.Windows.Forms.Padding(2);
            this.MemberGrid.MinimumSize = new System.Drawing.Size(33, 32);
            this.MemberGrid.Name = "MemberGrid";
            this.MemberGrid.RowTemplate.Height = 28;
            this.MemberGrid.Size = new System.Drawing.Size(487, 554);
            this.MemberGrid.TabIndex = 4;
            this.MemberGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.MemberGrid_CellContextMenuStripNeeded);
            this.MemberGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberGrid_CellMouseEnter);
            this.MemberGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MemberGrid_ColumnHeaderMouseClick);
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.Location = new System.Drawing.Point(277, 16);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(70, 23);
            this.btnSearchMembers.TabIndex = 3;
            this.btnSearchMembers.Text = "Search";
            this.btnSearchMembers.UseVisualStyleBackColor = true;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMembers.Location = new System.Drawing.Point(361, 16);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.Size = new System.Drawing.Size(137, 26);
            this.txtSearchMembers.TabIndex = 0;
            this.txtSearchMembers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMembers_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Members";
            // 
            // btnFilterInEvent
            // 
            this.btnFilterInEvent.Location = new System.Drawing.Point(184, 16);
            this.btnFilterInEvent.Name = "btnFilterInEvent";
            this.btnFilterInEvent.Size = new System.Drawing.Size(87, 23);
            this.btnFilterInEvent.TabIndex = 6;
            this.btnFilterInEvent.Text = "Filter for events";
            this.btnFilterInEvent.UseVisualStyleBackColor = true;
            this.btnFilterInEvent.Click += new System.EventHandler(this.btnFilterInEvent_Click);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(121, 16);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(57, 23);
            this.btnResetFilters.TabIndex = 7;
            this.btnResetFilters.Text = "Reset";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 619);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.btnFilterInEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchMembers);
            this.Controls.Add(this.btnSearchMembers);
            this.Controls.Add(this.MemberGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MembersForm";
            this.Text = "MembersForm";
            ((System.ComponentModel.ISupportInitialize)(this.MemberGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MemberGrid;
        private System.Windows.Forms.Button btnSearchMembers;
        private System.Windows.Forms.TextBox txtSearchMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilterInEvent;
        private System.Windows.Forms.Button btnResetFilters;
    }
}