namespace DBTrial
{
    partial class EventsForm
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
            this.EventGrid = new System.Windows.Forms.DataGridView();
            this.lblEvents = new System.Windows.Forms.Label();
            this.btnExportEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EventGrid
            // 
            this.EventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventGrid.Location = new System.Drawing.Point(8, 44);
            this.EventGrid.Margin = new System.Windows.Forms.Padding(2);
            this.EventGrid.Name = "EventGrid";
            this.EventGrid.RowTemplate.Height = 28;
            this.EventGrid.Size = new System.Drawing.Size(352, 203);
            this.EventGrid.TabIndex = 0;
            this.EventGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.EventGrid_CellContextMenuStripNeeded);
            this.EventGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventGrid_CellMouseEnter);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(11, 9);
            this.lblEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(85, 29);
            this.lblEvents.TabIndex = 1;
            this.lblEvents.Text = "Events";
            // 
            // btnExportEvents
            // 
            this.btnExportEvents.Location = new System.Drawing.Point(213, 266);
            this.btnExportEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportEvents.Name = "btnExportEvents";
            this.btnExportEvents.Size = new System.Drawing.Size(96, 40);
            this.btnExportEvents.TabIndex = 3;
            this.btnExportEvents.Text = "Export";
            this.btnExportEvents.UseVisualStyleBackColor = true;
            this.btnExportEvents.Click += new System.EventHandler(this.btnExportEvents_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 339);
            this.Controls.Add(this.btnExportEvents);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.EventGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.EventGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EventGrid;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Button btnExportEvents;
    }
}