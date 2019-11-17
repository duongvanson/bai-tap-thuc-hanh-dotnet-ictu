namespace QLThongTinSinhVien
{
    partial class frmMoi
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
            this.dataViewMoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewMoi
            // 
            this.dataViewMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewMoi.Location = new System.Drawing.Point(12, 12);
            this.dataViewMoi.Name = "dataViewMoi";
            this.dataViewMoi.Size = new System.Drawing.Size(492, 400);
            this.dataViewMoi.TabIndex = 0;
            // 
            // frmMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 428);
            this.Controls.Add(this.dataViewMoi);
            this.Name = "frmMoi";
            this.Text = "frmMoi";
            this.Load += new System.EventHandler(this.frmMoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewMoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewMoi;
    }
}