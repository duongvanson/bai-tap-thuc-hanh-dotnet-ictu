namespace GUI_BTH3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtFrac2 = new System.Windows.Forms.TextBox();
            this.txtFrac1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fraction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fraction 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fraction 2:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(15, 150);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(282, 147);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "Hi, i\'m SRG.";
            // 
            // txtFrac2
            // 
            this.txtFrac2.Location = new System.Drawing.Point(125, 105);
            this.txtFrac2.Name = "txtFrac2";
            this.txtFrac2.Size = new System.Drawing.Size(172, 27);
            this.txtFrac2.TabIndex = 6;
            this.txtFrac2.TextChanged += new System.EventHandler(this.TxtFrac2_TextChanged);
            // 
            // txtFrac1
            // 
            this.txtFrac1.Location = new System.Drawing.Point(125, 65);
            this.txtFrac1.Name = "txtFrac1";
            this.txtFrac1.Size = new System.Drawing.Size(172, 27);
            this.txtFrac1.TabIndex = 6;
            this.txtFrac1.TextChanged += new System.EventHandler(this.TxtFrac1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(123, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "( Input: numer/denom )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrac1);
            this.Controls.Add(this.txtFrac2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTH3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TextBox txtFrac2;
        private System.Windows.Forms.TextBox txtFrac1;
        private System.Windows.Forms.Label label4;
    }
}

