namespace DBTrial
{
    partial class ExportForm
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
            this.lblExportFormIncassoNumber = new System.Windows.Forms.Label();
            this.txtExportFormIncassoNumber = new System.Windows.Forms.TextBox();
            this.cldrExportFormIncassoDate = new System.Windows.Forms.MonthCalendar();
            this.lblExportFormIncassoDate = new System.Windows.Forms.Label();
            this.btnExportForm = new System.Windows.Forms.Button();
            this.btnExportFormBackToEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExportFormIncassoNumber
            // 
            this.lblExportFormIncassoNumber.AutoSize = true;
            this.lblExportFormIncassoNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportFormIncassoNumber.Location = new System.Drawing.Point(50, 21);
            this.lblExportFormIncassoNumber.Name = "lblExportFormIncassoNumber";
            this.lblExportFormIncassoNumber.Size = new System.Drawing.Size(119, 20);
            this.lblExportFormIncassoNumber.TabIndex = 0;
            this.lblExportFormIncassoNumber.Text = "Incassonumber";
            // 
            // txtExportFormIncassoNumber
            // 
            this.txtExportFormIncassoNumber.Location = new System.Drawing.Point(53, 47);
            this.txtExportFormIncassoNumber.Name = "txtExportFormIncassoNumber";
            this.txtExportFormIncassoNumber.Size = new System.Drawing.Size(100, 20);
            this.txtExportFormIncassoNumber.TabIndex = 1;
            // 
            // cldrExportFormIncassoDate
            // 
            this.cldrExportFormIncassoDate.Location = new System.Drawing.Point(53, 117);
            this.cldrExportFormIncassoDate.MaxSelectionCount = 1;
            this.cldrExportFormIncassoDate.Name = "cldrExportFormIncassoDate";
            this.cldrExportFormIncassoDate.ShowTodayCircle = false;
            this.cldrExportFormIncassoDate.ShowWeekNumbers = true;
            this.cldrExportFormIncassoDate.TabIndex = 3;
            // 
            // lblExportFormIncassoDate
            // 
            this.lblExportFormIncassoDate.AutoSize = true;
            this.lblExportFormIncassoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportFormIncassoDate.Location = new System.Drawing.Point(50, 88);
            this.lblExportFormIncassoDate.Name = "lblExportFormIncassoDate";
            this.lblExportFormIncassoDate.Size = new System.Drawing.Size(104, 20);
            this.lblExportFormIncassoDate.TabIndex = 4;
            this.lblExportFormIncassoDate.Text = "Incasso Date";
            // 
            // btnExportForm
            // 
            this.btnExportForm.Location = new System.Drawing.Point(140, 291);
            this.btnExportForm.Name = "btnExportForm";
            this.btnExportForm.Size = new System.Drawing.Size(84, 32);
            this.btnExportForm.TabIndex = 5;
            this.btnExportForm.Text = "Export";
            this.btnExportForm.UseVisualStyleBackColor = true;
            this.btnExportForm.Click += new System.EventHandler(this.btnExportForm_Click);
            // 
            // btnExportFormBackToEvents
            // 
            this.btnExportFormBackToEvents.Location = new System.Drawing.Point(53, 291);
            this.btnExportFormBackToEvents.Name = "btnExportFormBackToEvents";
            this.btnExportFormBackToEvents.Size = new System.Drawing.Size(81, 32);
            this.btnExportFormBackToEvents.TabIndex = 6;
            this.btnExportFormBackToEvents.Text = "Back";
            this.btnExportFormBackToEvents.UseVisualStyleBackColor = true;
            this.btnExportFormBackToEvents.Click += new System.EventHandler(this.btnExportFormBackToEvents_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 342);
            this.Controls.Add(this.btnExportFormBackToEvents);
            this.Controls.Add(this.btnExportForm);
            this.Controls.Add(this.lblExportFormIncassoDate);
            this.Controls.Add(this.cldrExportFormIncassoDate);
            this.Controls.Add(this.txtExportFormIncassoNumber);
            this.Controls.Add(this.lblExportFormIncassoNumber);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExportFormIncassoNumber;
        private System.Windows.Forms.TextBox txtExportFormIncassoNumber;
        private System.Windows.Forms.MonthCalendar cldrExportFormIncassoDate;
        private System.Windows.Forms.Label lblExportFormIncassoDate;
        private System.Windows.Forms.Button btnExportForm;
        private System.Windows.Forms.Button btnExportFormBackToEvents;
    }
}