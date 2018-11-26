namespace DBTrial
{
    partial class Form1
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
            this.btnOpenFileMembers = new System.Windows.Forms.Button();
            this.btnMemberData = new System.Windows.Forms.Button();
            this.btnImportEvent = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnToIncassoForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFileMembers
            // 
            this.btnOpenFileMembers.Location = new System.Drawing.Point(56, 153);
            this.btnOpenFileMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFileMembers.Name = "btnOpenFileMembers";
            this.btnOpenFileMembers.Size = new System.Drawing.Size(146, 54);
            this.btnOpenFileMembers.TabIndex = 0;
            this.btnOpenFileMembers.Text = "Import Member File";
            this.btnOpenFileMembers.UseVisualStyleBackColor = true;
            this.btnOpenFileMembers.Click += new System.EventHandler(this.btnOpenFileMembers_Click);
            // 
            // btnMemberData
            // 
            this.btnMemberData.Location = new System.Drawing.Point(202, 88);
            this.btnMemberData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMemberData.Name = "btnMemberData";
            this.btnMemberData.Size = new System.Drawing.Size(183, 31);
            this.btnMemberData.TabIndex = 1;
            this.btnMemberData.Text = "GoToMemberView";
            this.btnMemberData.UseVisualStyleBackColor = true;
            this.btnMemberData.Click += new System.EventHandler(this.btnMemberData_Click);
            // 
            // btnImportEvent
            // 
            this.btnImportEvent.Location = new System.Drawing.Point(250, 220);
            this.btnImportEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportEvent.Name = "btnImportEvent";
            this.btnImportEvent.Size = new System.Drawing.Size(99, 42);
            this.btnImportEvent.TabIndex = 2;
            this.btnImportEvent.Text = "Import Event";
            this.btnImportEvent.UseVisualStyleBackColor = true;
            this.btnImportEvent.Click += new System.EventHandler(this.btnImportEvent_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(389, 153);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(113, 54);
            this.btnEvents.TabIndex = 4;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnToIncassoForm
            // 
            this.btnToIncassoForm.Location = new System.Drawing.Point(44, 12);
            this.btnToIncassoForm.Name = "btnToIncassoForm";
            this.btnToIncassoForm.Size = new System.Drawing.Size(75, 23);
            this.btnToIncassoForm.TabIndex = 5;
            this.btnToIncassoForm.Text = "Incasso\'s";
            this.btnToIncassoForm.UseVisualStyleBackColor = true;
            this.btnToIncassoForm.Click += new System.EventHandler(this.btnToIncassoForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnToIncassoForm);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnImportEvent);
            this.Controls.Add(this.btnMemberData);
            this.Controls.Add(this.btnOpenFileMembers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileMembers;
        private System.Windows.Forms.Button btnMemberData;
        private System.Windows.Forms.Button btnImportEvent;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnToIncassoForm;
    }
}

