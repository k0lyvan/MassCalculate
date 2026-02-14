namespace MassCalculate
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            DGV2 = new DataGridView();
            btnDel1 = new Button();
            btnAddRow1 = new Button();
            btnAddColm1 = new Button();
            btnClear1 = new Button();
            btnClear2 = new Button();
            btnAddColm2 = new Button();
            btnAddRow2 = new Button();
            btnDel2 = new Button();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            SuspendLayout();
            // 
            // DGV1
            // 
            DGV1.AllowUserToAddRows = false;
            DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV1.ColumnHeadersVisible = false;
            DGV1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            DGV1.Location = new Point(12, 12);
            DGV1.Name = "DGV1";
            DGV1.RowHeadersVisible = false;
            DGV1.Size = new Size(375, 226);
            DGV1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            // 
            // DGV2
            // 
            DGV2.AllowUserToAddRows = false;
            DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV2.ColumnHeadersVisible = false;
            DGV2.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            DGV2.Location = new Point(411, 12);
            DGV2.Name = "DGV2";
            DGV2.RowHeadersVisible = false;
            DGV2.Size = new Size(375, 226);
            DGV2.TabIndex = 1;
            // 
            // btnDel1
            // 
            btnDel1.Location = new Point(12, 244);
            btnDel1.Name = "btnDel1";
            btnDel1.Size = new Size(82, 51);
            btnDel1.TabIndex = 2;
            btnDel1.Text = "Удалить матрицу";
            btnDel1.UseVisualStyleBackColor = true;
            btnDel1.Click += btnDel1_Click;
            // 
            // btnAddRow1
            // 
            btnAddRow1.Location = new Point(100, 244);
            btnAddRow1.Name = "btnAddRow1";
            btnAddRow1.Size = new Size(97, 51);
            btnAddRow1.TabIndex = 3;
            btnAddRow1.Text = "Добавить строку";
            btnAddRow1.UseVisualStyleBackColor = true;
            btnAddRow1.Click += btnAddRow_Click;
            // 
            // btnAddColm1
            // 
            btnAddColm1.Location = new Point(203, 244);
            btnAddColm1.Name = "btnAddColm1";
            btnAddColm1.Size = new Size(94, 51);
            btnAddColm1.TabIndex = 4;
            btnAddColm1.Text = "Добавить столбец";
            btnAddColm1.UseVisualStyleBackColor = true;
            btnAddColm1.Click += btnAddColm_Click;
            // 
            // btnClear1
            // 
            btnClear1.Location = new Point(303, 244);
            btnClear1.Name = "btnClear1";
            btnClear1.Size = new Size(84, 51);
            btnClear1.TabIndex = 5;
            btnClear1.Text = "Очистить";
            btnClear1.UseVisualStyleBackColor = true;
            btnClear1.Click += btnClear1_Click;
            // 
            // btnClear2
            // 
            btnClear2.Location = new Point(702, 244);
            btnClear2.Name = "btnClear2";
            btnClear2.Size = new Size(84, 51);
            btnClear2.TabIndex = 9;
            btnClear2.Text = "Очистить";
            btnClear2.UseVisualStyleBackColor = true;
            btnClear2.Click += btnClear2_Click;
            // 
            // btnAddColm2
            // 
            btnAddColm2.Location = new Point(602, 244);
            btnAddColm2.Name = "btnAddColm2";
            btnAddColm2.Size = new Size(94, 51);
            btnAddColm2.TabIndex = 8;
            btnAddColm2.Text = "Добавить столбец";
            btnAddColm2.UseVisualStyleBackColor = true;
            btnAddColm2.Click += btnAddColm2_Click;
            // 
            // btnAddRow2
            // 
            btnAddRow2.Location = new Point(499, 244);
            btnAddRow2.Name = "btnAddRow2";
            btnAddRow2.Size = new Size(97, 51);
            btnAddRow2.TabIndex = 7;
            btnAddRow2.Text = "Добавить строку";
            btnAddRow2.UseVisualStyleBackColor = true;
            btnAddRow2.Click += btnAddRow2_Click;
            // 
            // btnDel2
            // 
            btnDel2.Location = new Point(411, 244);
            btnDel2.Name = "btnDel2";
            btnDel2.Size = new Size(82, 51);
            btnDel2.TabIndex = 6;
            btnDel2.Text = "Удалить матрицу";
            btnDel2.UseVisualStyleBackColor = true;
            btnDel2.Click += btnDel2_Click;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 480);
            Controls.Add(btnClear2);
            Controls.Add(btnAddColm2);
            Controls.Add(btnAddRow2);
            Controls.Add(btnDel2);
            Controls.Add(btnClear1);
            Controls.Add(btnAddColm1);
            Controls.Add(btnAddRow1);
            Controls.Add(btnDel1);
            Controls.Add(DGV2);
            Controls.Add(DGV1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Mass Calculator";
            ((System.ComponentModel.ISupportInitialize)DGV1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV1;
        private DataGridView DGV2;
        private Button btnDel1;
        private Button btnAddRow1;
        private Button btnAddColm1;
        private Button btnClear1;
        private DataGridViewTextBoxColumn Column1;
        private Button btnClear2;
        private Button btnAddColm2;
        private Button btnAddRow2;
        private Button btnDel2;
        private DataGridViewTextBoxColumn Column2;
    }
}
