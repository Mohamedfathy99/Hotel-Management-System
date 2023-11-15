
namespace Hotel_Sys
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.rdo_customer = new System.Windows.Forms.RadioButton();
            this.rdo_employee = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Load_Info = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdo_customer
            // 
            this.rdo_customer.AutoSize = true;
            this.rdo_customer.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_customer.Location = new System.Drawing.Point(238, 12);
            this.rdo_customer.Name = "rdo_customer";
            this.rdo_customer.Size = new System.Drawing.Size(194, 26);
            this.rdo_customer.TabIndex = 0;
            this.rdo_customer.TabStop = true;
            this.rdo_customer.Text = "Customer Information";
            this.rdo_customer.UseVisualStyleBackColor = true;
            // 
            // rdo_employee
            // 
            this.rdo_employee.AutoSize = true;
            this.rdo_employee.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_employee.Location = new System.Drawing.Point(238, 61);
            this.rdo_employee.Name = "rdo_employee";
            this.rdo_employee.Size = new System.Drawing.Size(194, 26);
            this.rdo_employee.TabIndex = 1;
            this.rdo_employee.TabStop = true;
            this.rdo_employee.Text = "Employee Information";
            this.rdo_employee.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // Load_Info
            // 
            this.Load_Info.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Info.Location = new System.Drawing.Point(238, 135);
            this.Load_Info.Name = "Load_Info";
            this.Load_Info.Size = new System.Drawing.Size(182, 33);
            this.Load_Info.TabIndex = 3;
            this.Load_Info.Text = "Load Information";
            this.Load_Info.UseVisualStyleBackColor = true;
            this.Load_Info.Click += new System.EventHandler(this.Load_Info_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(599, 545);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // home_btn
            // 
            this.home_btn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(626, 12);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(99, 36);
            this.home_btn.TabIndex = 5;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Load_Info);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdo_employee);
            this.Controls.Add(this.rdo_customer);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_customer;
        private System.Windows.Forms.RadioButton rdo_employee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Load_Info;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button home_btn;
    }
}