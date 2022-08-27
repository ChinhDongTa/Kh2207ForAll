namespace ReadExcelKH2207
{
    partial class FrmMain
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnLoadExxcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInsert2SqlServer = new System.Windows.Forms.Button();
            this.LbFilePath = new System.Windows.Forms.Label();
            this.LbTotalRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoadExxcel
            // 
            this.BtnLoadExxcel.Location = new System.Drawing.Point(511, 12);
            this.BtnLoadExxcel.Name = "BtnLoadExxcel";
            this.BtnLoadExxcel.Size = new System.Drawing.Size(178, 23);
            this.BtnLoadExxcel.TabIndex = 0;
            this.BtnLoadExxcel.Text = "Load Excel file";
            this.BtnLoadExxcel.UseVisualStyleBackColor = true;
            this.BtnLoadExxcel.Click += new System.EventHandler(this.BtnLoadExxcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1374, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 442);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 291);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Excel đã được ghi vào Database";
            // 
            // BtnInsert2SqlServer
            // 
            this.BtnInsert2SqlServer.Location = new System.Drawing.Point(682, 442);
            this.BtnInsert2SqlServer.Name = "BtnInsert2SqlServer";
            this.BtnInsert2SqlServer.Size = new System.Drawing.Size(160, 51);
            this.BtnInsert2SqlServer.TabIndex = 4;
            this.BtnInsert2SqlServer.Text = "Insert to Sql Server ";
            this.BtnInsert2SqlServer.UseVisualStyleBackColor = true;
            this.BtnInsert2SqlServer.Click += new System.EventHandler(this.BtnInsert2SqlServer_Click);
            // 
            // LbFilePath
            // 
            this.LbFilePath.AutoSize = true;
            this.LbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFilePath.Location = new System.Drawing.Point(31, 17);
            this.LbFilePath.Name = "LbFilePath";
            this.LbFilePath.Size = new System.Drawing.Size(150, 16);
            this.LbFilePath.TabIndex = 5;
            this.LbFilePath.Text = "Please , select excel file";
            // 
            // LbTotalRecord
            // 
            this.LbTotalRecord.AutoSize = true;
            this.LbTotalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalRecord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LbTotalRecord.Location = new System.Drawing.Point(1135, 401);
            this.LbTotalRecord.Name = "LbTotalRecord";
            this.LbTotalRecord.Size = new System.Drawing.Size(105, 20);
            this.LbTotalRecord.TabIndex = 6;
            this.LbTotalRecord.Text = "Total records:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 749);
            this.Controls.Add(this.LbTotalRecord);
            this.Controls.Add(this.LbFilePath);
            this.Controls.Add(this.BtnInsert2SqlServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnLoadExxcel);
            this.Name = "FrmMain";
            this.Text = "Read Excel file insert to Sql Server";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnLoadExxcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInsert2SqlServer;
        private System.Windows.Forms.Label LbFilePath;
        private System.Windows.Forms.Label LbTotalRecord;
    }
}

