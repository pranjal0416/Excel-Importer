namespace Testing_Stuff
{
    partial class frmExcel
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
            tblLayoutMain = new TableLayoutPanel();
            tblLayoutTop = new TableLayoutPanel();
            tblLayoutFileOpener = new TableLayoutPanel();
            txtBoxfilePath = new TextBox();
            fileBtn = new Button();
            openFileExcel = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            tblLayoutMain.SuspendLayout();
            tblLayoutTop.SuspendLayout();
            tblLayoutFileOpener.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tblLayoutMain
            // 
            tblLayoutMain.ColumnCount = 1;
            tblLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutMain.Controls.Add(dataGridView1, 0, 1);
            tblLayoutMain.Controls.Add(tblLayoutTop, 0, 0);
            tblLayoutMain.Dock = DockStyle.Fill;
            tblLayoutMain.Location = new Point(0, 0);
            tblLayoutMain.Name = "tblLayoutMain";
            tblLayoutMain.RowCount = 2;
            tblLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.68759F));
            tblLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 81.31241F));
            tblLayoutMain.Size = new Size(1228, 701);
            tblLayoutMain.TabIndex = 0;
            // 
            // tblLayoutTop
            // 
            tblLayoutTop.ColumnCount = 2;
            tblLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutTop.Controls.Add(tblLayoutFileOpener, 0, 0);
            tblLayoutTop.Dock = DockStyle.Fill;
            tblLayoutTop.Location = new Point(3, 3);
            tblLayoutTop.Name = "tblLayoutTop";
            tblLayoutTop.RowCount = 1;
            tblLayoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayoutTop.Size = new Size(1222, 125);
            tblLayoutTop.TabIndex = 0;
            // 
            // tblLayoutFileOpener
            // 
            tblLayoutFileOpener.ColumnCount = 2;
            tblLayoutFileOpener.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutFileOpener.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutFileOpener.Controls.Add(txtBoxfilePath, 0, 0);
            tblLayoutFileOpener.Controls.Add(fileBtn, 1, 0);
            tblLayoutFileOpener.Dock = DockStyle.Fill;
            tblLayoutFileOpener.Location = new Point(3, 3);
            tblLayoutFileOpener.Name = "tblLayoutFileOpener";
            tblLayoutFileOpener.RowCount = 2;
            tblLayoutFileOpener.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayoutFileOpener.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayoutFileOpener.Size = new Size(605, 119);
            tblLayoutFileOpener.TabIndex = 0;
            // 
            // txtBoxfilePath
            // 
            txtBoxfilePath.Location = new Point(3, 3);
            txtBoxfilePath.Name = "txtBoxfilePath";
            txtBoxfilePath.Size = new Size(296, 31);
            txtBoxfilePath.TabIndex = 0;
            // 
            // fileBtn
            // 
            fileBtn.Location = new Point(305, 3);
            fileBtn.Name = "fileBtn";
            fileBtn.Size = new Size(112, 34);
            fileBtn.TabIndex = 1;
            fileBtn.Text = "Select";
            fileBtn.UseVisualStyleBackColor = true;
            fileBtn.Click += fileBtn_Click;
            // 
            // openFileExcel
            // 
            openFileExcel.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1213, 544);
            dataGridView1.TabIndex = 1;
           
            // 
            // frmExcel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 701);
            Controls.Add(tblLayoutMain);
            Name = "frmExcel";
            Text = "frmExcel";
            tblLayoutMain.ResumeLayout(false);
            tblLayoutTop.ResumeLayout(false);
            tblLayoutFileOpener.ResumeLayout(false);
            tblLayoutFileOpener.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayoutMain;
        private TableLayoutPanel tblLayoutTop;
        private TableLayoutPanel tblLayoutFileOpener;
        private TextBox txtBoxfilePath;
        private Button fileBtn;
        private OpenFileDialog openFileExcel;
        private DataGridView dataGridView1;
    }
}