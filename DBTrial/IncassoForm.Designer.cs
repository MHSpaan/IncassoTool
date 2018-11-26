namespace DBTrial
{
    partial class IncassoForm
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
            this.IncassosGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncassosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IncassosGrid
            // 
            this.IncassosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncassosGrid.Location = new System.Drawing.Point(12, 59);
            this.IncassosGrid.Name = "IncassosGrid";
            this.IncassosGrid.Size = new System.Drawing.Size(332, 196);
            this.IncassosGrid.TabIndex = 0;
            this.IncassosGrid.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.IncassosGrid_CellContextMenuStripNeeded);
            this.IncassosGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.IncassosGrid_CellMouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Incasso\'s";
            // 
            // IncassoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncassosGrid);
            this.Name = "IncassoForm";
            this.Text = "IncassoForm";
            ((System.ComponentModel.ISupportInitialize)(this.IncassosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IncassosGrid;
        private System.Windows.Forms.Label label1;
    }
}