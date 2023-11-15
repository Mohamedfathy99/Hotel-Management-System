
namespace Hotel_Sys
{
    partial class Report2
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
            this.report2_btn = new System.Windows.Forms.Button();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.room_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // report2_btn
            // 
            this.report2_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2_btn.Location = new System.Drawing.Point(353, 23);
            this.report2_btn.Name = "report2_btn";
            this.report2_btn.Size = new System.Drawing.Size(147, 33);
            this.report2_btn.TabIndex = 0;
            this.report2_btn.Text = "Generate Report";
            this.report2_btn.UseVisualStyleBackColor = true;
            this.report2_btn.Click += new System.EventHandler(this.report2_btn_Click);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(12, 150);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1008, 469);
            this.crystalReportViewer2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Number";
            // 
            // room_cmb
            // 
            this.room_cmb.FormattingEnabled = true;
            this.room_cmb.Location = new System.Drawing.Point(728, 26);
            this.room_cmb.Name = "room_cmb";
            this.room_cmb.Size = new System.Drawing.Size(121, 21);
            this.room_cmb.TabIndex = 3;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 660);
            this.Controls.Add(this.room_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.report2_btn);
            this.Name = "Report2";
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button report2_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox room_cmb;
    }
}