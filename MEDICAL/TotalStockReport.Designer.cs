namespace MEDICAL
{
    partial class TotalStockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GVReports = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnitemsearch = new System.Windows.Forms.Button();
            this.txtiname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVReports)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVReports
            // 
            this.GVReports.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GVReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.GVReports.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.GVReports.Location = new System.Drawing.Point(27, 92);
            this.GVReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GVReports.Name = "GVReports";
            this.GVReports.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            this.GVReports.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GVReports.Size = new System.Drawing.Size(1552, 511);
            this.GVReports.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GVReports);
            this.groupBox1.Controls.Add(this.btnitemsearch);
            this.groupBox1.Controls.Add(this.txtiname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(116, 303);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1605, 623);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Stock Report";
            // 
            // btnitemsearch
            // 
            this.btnitemsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnitemsearch.Location = new System.Drawing.Point(430, 32);
            this.btnitemsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnitemsearch.Name = "btnitemsearch";
            this.btnitemsearch.Size = new System.Drawing.Size(150, 43);
            this.btnitemsearch.TabIndex = 15;
            this.btnitemsearch.Text = "Search";
            this.btnitemsearch.UseVisualStyleBackColor = true;
            this.btnitemsearch.Click += new System.EventHandler(this.btnitemsearch_Click);
            // 
            // txtiname
            // 
            this.txtiname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtiname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtiname.BackColor = System.Drawing.Color.Honeydew;
            this.txtiname.Location = new System.Drawing.Point(182, 38);
            this.txtiname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtiname.Name = "txtiname";
            this.txtiname.Size = new System.Drawing.Size(238, 26);
            this.txtiname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(34, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(514, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 97);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOTAL STOCK REPORT";
            // 
            // TotalStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1838, 1050);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TotalStockReport";
            this.Text = "TotalStockReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TotalStockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVReports)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVReports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnitemsearch;
        private System.Windows.Forms.TextBox txtiname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}