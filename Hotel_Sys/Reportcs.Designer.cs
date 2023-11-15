
namespace Hotel_Sys
{
    partial class Reportcs
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
            this.report1_btn = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // report1_btn
            // 
            this.report1_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1_btn.Location = new System.Drawing.Point(353, 12);
            this.report1_btn.Name = "report1_btn";
            this.report1_btn.Size = new System.Drawing.Size(162, 33);
            this.report1_btn.TabIndex = 0;
            this.report1_btn.Text = "Generate Report";
            this.report1_btn.UseVisualStyleBackColor = true;
            this.report1_btn.Click += new System.EventHandler(this.report1_btn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 74);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(871, 504);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // Reportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 590);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.report1_btn);
            this.Name = "Reportcs";
            this.Text = "Reportcs";
            this.Load += new System.EventHandler(this.Reportcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button report1_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}