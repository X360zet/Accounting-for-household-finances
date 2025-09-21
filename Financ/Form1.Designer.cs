namespace HomeFinanceApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.tabPageStoredProcedure = new System.Windows.Forms.TabPage();
            this.dataGridViewStoredProcedure = new System.Windows.Forms.DataGridView();
            this.btnExecuteStoredProcedure = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.tabPageStoredProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoredProcedure)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCategories);
            this.tabControl1.Controls.Add(this.tabPageTransactions);
            this.tabControl1.Controls.Add(this.tabPageStoredProcedure);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.dataGridViewCategories);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 25);
            this.tabPageCategories.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCategories.Size = new System.Drawing.Size(1027, 402);
            this.tabPageCategories.TabIndex = 0;
            this.tabPageCategories.Text = "Категории";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategories.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.Size = new System.Drawing.Size(1019, 394);
            this.dataGridViewCategories.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.dataGridViewTransactions);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabPageTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTransactions.Size = new System.Drawing.Size(1027, 402);
            this.tabPageTransactions.TabIndex = 1;
            this.tabPageTransactions.Text = "Транзакции";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(1019, 394);
            this.dataGridViewTransactions.TabIndex = 0;
            // 
            // tabPageStoredProcedure
            // 
            this.tabPageStoredProcedure.Controls.Add(this.dataGridViewStoredProcedure);
            this.tabPageStoredProcedure.Controls.Add(this.btnExecuteStoredProcedure);
            this.tabPageStoredProcedure.Controls.Add(this.dateTimePickerEnd);
            this.tabPageStoredProcedure.Controls.Add(this.dateTimePickerStart);
            this.tabPageStoredProcedure.Controls.Add(this.label1);
            this.tabPageStoredProcedure.Controls.Add(this.label2);
            this.tabPageStoredProcedure.Location = new System.Drawing.Point(4, 25);
            this.tabPageStoredProcedure.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStoredProcedure.Name = "tabPageStoredProcedure";
            this.tabPageStoredProcedure.Size = new System.Drawing.Size(1027, 402);
            this.tabPageStoredProcedure.TabIndex = 2;
            this.tabPageStoredProcedure.Text = "Отчет по категориям";
            this.tabPageStoredProcedure.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStoredProcedure
            // 
            this.dataGridViewStoredProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStoredProcedure.Location = new System.Drawing.Point(8, 49);
            this.dataGridViewStoredProcedure.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStoredProcedure.Name = "dataGridViewStoredProcedure";
            this.dataGridViewStoredProcedure.RowHeadersWidth = 51;
            this.dataGridViewStoredProcedure.Size = new System.Drawing.Size(1008, 342);
            this.dataGridViewStoredProcedure.TabIndex = 5;
            // 
            // btnExecuteStoredProcedure
            // 
            this.btnExecuteStoredProcedure.Location = new System.Drawing.Point(883, 7);
            this.btnExecuteStoredProcedure.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecuteStoredProcedure.Name = "btnExecuteStoredProcedure";
            this.btnExecuteStoredProcedure.Size = new System.Drawing.Size(133, 28);
            this.btnExecuteStoredProcedure.TabIndex = 4;
            this.btnExecuteStoredProcedure.Text = "Выполнить";
            this.btnExecuteStoredProcedure.UseVisualStyleBackColor = true;
            this.btnExecuteStoredProcedure.Click += new System.EventHandler(this.btnExecuteStoredProcedure_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(608, 10);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(200, 10);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная дата отчета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечная дата отчета:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 505);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Учет домашних финансов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.tabPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.tabPageStoredProcedure.ResumeLayout(false);
            this.tabPageStoredProcedure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoredProcedure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.TabPage tabPageStoredProcedure;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecuteStoredProcedure;
        private System.Windows.Forms.DataGridView dataGridViewStoredProcedure;
    }
}