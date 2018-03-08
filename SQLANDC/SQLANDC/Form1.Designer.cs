namespace SQLANDC
{
    partial class vendorDataGrid
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
            this.vendorDG = new System.Windows.Forms.DataGridView();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorDG
            // 
            this.vendorDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDG.Location = new System.Drawing.Point(12, 12);
            this.vendorDG.Name = "vendorDG";
            this.vendorDG.Size = new System.Drawing.Size(268, 220);
            this.vendorDG.TabIndex = 0;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(105, 238);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(75, 23);
            this.loadDataBtn.TabIndex = 1;
            this.loadDataBtn.Text = "Load Data";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendorDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.loadDataBtn);
            this.Controls.Add(this.vendorDG);
            this.Name = "vendorDataGrid";
            this.Text = "Vendor Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.vendorDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vendorDG;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

