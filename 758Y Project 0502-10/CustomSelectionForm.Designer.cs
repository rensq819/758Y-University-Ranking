namespace _758Y_Project_0502_10
{
    partial class CustomSelectionForm
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
            this.programCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tuitionCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rateCombobox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.programRankingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSPRankingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bUDT758Y_ProjectDataSet = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSet();
            this.mSPOfferedByBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSP_OfferedByTableAdapter = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSetTableAdapters.MSP_OfferedByTableAdapter();
            this.mSP_RankingTableAdapter = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSetTableAdapters.MSP_RankingTableAdapter();
            this.bUDT758YProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPRankingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758Y_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPOfferedByBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758YProjectDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // programCombobox
            // 
            this.programCombobox.FormattingEnabled = true;
            this.programCombobox.Items.AddRange(new object[] {
            "Masters of Information System",
            "Masters of Business Analytics",
            "Masters of Business Administration"});
            this.programCombobox.Location = new System.Drawing.Point(115, 36);
            this.programCombobox.Name = "programCombobox";
            this.programCombobox.Size = new System.Drawing.Size(295, 28);
            this.programCombobox.TabIndex = 0;
            this.programCombobox.SelectionChangeCommitted += new System.EventHandler(this.programCombobox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuition";
            // 
            // tuitionCombobox
            // 
            this.tuitionCombobox.FormattingEnabled = true;
            this.tuitionCombobox.Items.AddRange(new object[] {
            "<$20,000",
            "$20,000 - $40,000",
            "$40,000 - $60,000",
            ">$60,000"});
            this.tuitionCombobox.Location = new System.Drawing.Point(498, 36);
            this.tuitionCombobox.Name = "tuitionCombobox";
            this.tuitionCombobox.Size = new System.Drawing.Size(210, 28);
            this.tuitionCombobox.TabIndex = 5;
            this.tuitionCombobox.SelectionChangeCommitted += new System.EventHandler(this.tuitionCombobox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(724, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Admission Rate";
            // 
            // rateCombobox
            // 
            this.rateCombobox.FormattingEnabled = true;
            this.rateCombobox.Items.AddRange(new object[] {
            "< 20%",
            "20% - 40%",
            "40% - 60%",
            ">60%"});
            this.rateCombobox.Location = new System.Drawing.Point(851, 37);
            this.rateCombobox.Name = "rateCombobox";
            this.rateCombobox.Size = new System.Drawing.Size(143, 28);
            this.rateCombobox.TabIndex = 7;
            this.rateCombobox.SelectionChangeCommitted += new System.EventHandler(this.rateCombobox_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programRankingDataGridViewTextBoxColumn,
            this.schoolNameDataGridViewTextBoxColumn,
            this.admissionRateDataGridViewTextBoxColumn,
            this.departmentLeaderDataGridViewTextBoxColumn,
            this.departmentPhoneDataGridViewTextBoxColumn,
            this.tuitionDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mSPRankingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 634);
            this.dataGridView1.TabIndex = 8;
            // 
            // programRankingDataGridViewTextBoxColumn
            // 
            this.programRankingDataGridViewTextBoxColumn.DataPropertyName = "Program Ranking";
            this.programRankingDataGridViewTextBoxColumn.HeaderText = "Program Ranking";
            this.programRankingDataGridViewTextBoxColumn.Name = "programRankingDataGridViewTextBoxColumn";
            // 
            // schoolNameDataGridViewTextBoxColumn
            // 
            this.schoolNameDataGridViewTextBoxColumn.DataPropertyName = "School Name";
            this.schoolNameDataGridViewTextBoxColumn.HeaderText = "School Name";
            this.schoolNameDataGridViewTextBoxColumn.Name = "schoolNameDataGridViewTextBoxColumn";
            // 
            // admissionRateDataGridViewTextBoxColumn
            // 
            this.admissionRateDataGridViewTextBoxColumn.DataPropertyName = "Admission Rate (%)";
            this.admissionRateDataGridViewTextBoxColumn.HeaderText = "Admission Rate (%)";
            this.admissionRateDataGridViewTextBoxColumn.Name = "admissionRateDataGridViewTextBoxColumn";
            // 
            // departmentLeaderDataGridViewTextBoxColumn
            // 
            this.departmentLeaderDataGridViewTextBoxColumn.DataPropertyName = "Department Leader";
            this.departmentLeaderDataGridViewTextBoxColumn.HeaderText = "Department Leader";
            this.departmentLeaderDataGridViewTextBoxColumn.Name = "departmentLeaderDataGridViewTextBoxColumn";
            // 
            // departmentPhoneDataGridViewTextBoxColumn
            // 
            this.departmentPhoneDataGridViewTextBoxColumn.DataPropertyName = "Department Phone";
            this.departmentPhoneDataGridViewTextBoxColumn.HeaderText = "Department Phone";
            this.departmentPhoneDataGridViewTextBoxColumn.Name = "departmentPhoneDataGridViewTextBoxColumn";
            // 
            // tuitionDataGridViewTextBoxColumn
            // 
            this.tuitionDataGridViewTextBoxColumn.DataPropertyName = "Tuition ($)";
            this.tuitionDataGridViewTextBoxColumn.HeaderText = "Tuition ($)";
            this.tuitionDataGridViewTextBoxColumn.Name = "tuitionDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // mSPRankingBindingSource
            // 
            this.mSPRankingBindingSource.DataMember = "MSP_Ranking";
            this.mSPRankingBindingSource.DataSource = this.bUDT758Y_ProjectDataSet;
            // 
            // bUDT758Y_ProjectDataSet
            // 
            this.bUDT758Y_ProjectDataSet.DataSetName = "BUDT758Y_ProjectDataSet";
            this.bUDT758Y_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mSPOfferedByBindingSource
            // 
            this.mSPOfferedByBindingSource.DataMember = "MSP_OfferedBy";
            this.mSPOfferedByBindingSource.DataSource = this.bUDT758Y_ProjectDataSet;
            // 
            // mSP_OfferedByTableAdapter
            // 
            this.mSP_OfferedByTableAdapter.ClearBeforeFill = true;
            // 
            // mSP_RankingTableAdapter
            // 
            this.mSP_RankingTableAdapter.ClearBeforeFill = true;
            // 
            // bUDT758YProjectDataSetBindingSource
            // 
            this.bUDT758YProjectDataSetBindingSource.DataSource = this.bUDT758Y_ProjectDataSet;
            this.bUDT758YProjectDataSetBindingSource.Position = 0;
            // 
            // CustomSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1342, 769);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rateCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tuitionCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programCombobox);
            this.Name = "CustomSelectionForm";
            this.Text = "Custom Selection";
            this.Load += new System.EventHandler(this.CustomSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPRankingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758Y_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPOfferedByBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758YProjectDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox programCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tuitionCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rateCombobox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BUDT758Y_ProjectDataSet bUDT758Y_ProjectDataSet;
        private System.Windows.Forms.BindingSource mSPOfferedByBindingSource;
        private BUDT758Y_ProjectDataSetTableAdapters.MSP_OfferedByTableAdapter mSP_OfferedByTableAdapter;
        private System.Windows.Forms.BindingSource mSPRankingBindingSource;
        private BUDT758Y_ProjectDataSetTableAdapters.MSP_RankingTableAdapter mSP_RankingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn programRankingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentLeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bUDT758YProjectDataSetBindingSource;
    }
}