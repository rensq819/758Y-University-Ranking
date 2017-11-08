namespace _758Y_Project_0502_10
{
    partial class SchoolFrom
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.schoolCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSPSchoolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bUDT758Y_ProjectDataSet = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSet();
            this.mSPSchoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.mSP_SchoolTableAdapter1 = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSetTableAdapters.MSP_SchoolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPSchoolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758Y_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPSchoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schoolCodeDataGridViewTextBoxColumn,
            this.schoolNameDataGridViewTextBoxColumn,
            this.admissionRateDataGridViewTextBoxColumn,
            this.schoolTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mSPSchoolBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(45, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(791, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolCodeDataGridViewTextBoxColumn
            // 
            this.schoolCodeDataGridViewTextBoxColumn.DataPropertyName = "schoolCode";
            this.schoolCodeDataGridViewTextBoxColumn.HeaderText = "schoolCode";
            this.schoolCodeDataGridViewTextBoxColumn.Name = "schoolCodeDataGridViewTextBoxColumn";
            // 
            // schoolNameDataGridViewTextBoxColumn
            // 
            this.schoolNameDataGridViewTextBoxColumn.DataPropertyName = "schoolName";
            this.schoolNameDataGridViewTextBoxColumn.HeaderText = "schoolName";
            this.schoolNameDataGridViewTextBoxColumn.Name = "schoolNameDataGridViewTextBoxColumn";
            // 
            // admissionRateDataGridViewTextBoxColumn
            // 
            this.admissionRateDataGridViewTextBoxColumn.DataPropertyName = "admissionRate";
            this.admissionRateDataGridViewTextBoxColumn.HeaderText = "admissionRate";
            this.admissionRateDataGridViewTextBoxColumn.Name = "admissionRateDataGridViewTextBoxColumn";
            // 
            // schoolTypeDataGridViewTextBoxColumn
            // 
            this.schoolTypeDataGridViewTextBoxColumn.DataPropertyName = "schoolType";
            this.schoolTypeDataGridViewTextBoxColumn.HeaderText = "schoolType";
            this.schoolTypeDataGridViewTextBoxColumn.Name = "schoolTypeDataGridViewTextBoxColumn";
            // 
            // mSPSchoolBindingSource1
            // 
            this.mSPSchoolBindingSource1.DataMember = "MSP_School";
            this.mSPSchoolBindingSource1.DataSource = this.bUDT758Y_ProjectDataSet;
            // 
            // bUDT758Y_ProjectDataSet
            // 
            this.bUDT758Y_ProjectDataSet.DataSetName = "BUDT758Y_ProjectDataSet";
            this.bUDT758Y_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mSPSchoolBindingSource
            // 
            this.mSPSchoolBindingSource.DataMember = "MSP_School";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(692, 538);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 52);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Retrun";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mSP_SchoolTableAdapter1
            // 
            this.mSP_SchoolTableAdapter1.ClearBeforeFill = true;
            // 
            // SchoolFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(895, 647);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SchoolFrom";
            this.Text = "schoolFrom";
            this.Load += new System.EventHandler(this.schoolFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPSchoolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758Y_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPSchoolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mSPSchoolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exitButton;
        private BUDT758Y_ProjectDataSet bUDT758Y_ProjectDataSet;
        private System.Windows.Forms.BindingSource mSPSchoolBindingSource1;
        private BUDT758Y_ProjectDataSetTableAdapters.MSP_SchoolTableAdapter mSP_SchoolTableAdapter1;
    }
}