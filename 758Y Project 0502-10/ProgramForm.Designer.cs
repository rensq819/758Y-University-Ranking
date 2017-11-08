namespace _758Y_Project_0502_10
{
    partial class ProgramForm
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
            this.programCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptLeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSPOfferedByBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bUDT758Y_ProjectDataSet = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSet();
            this.mSP_OfferedByTableAdapter = new _758Y_Project_0502_10.BUDT758Y_ProjectDataSetTableAdapters.MSP_OfferedByTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPOfferedByBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758Y_ProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schoolCodeDataGridViewTextBoxColumn,
            this.programCodeDataGridViewTextBoxColumn,
            this.deptLeaderDataGridViewTextBoxColumn,
            this.deptPhoneDataGridViewTextBoxColumn,
            this.tuitionDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateNameDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mSPOfferedByBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1429, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // schoolCodeDataGridViewTextBoxColumn
            // 
            this.schoolCodeDataGridViewTextBoxColumn.DataPropertyName = "schoolCode";
            this.schoolCodeDataGridViewTextBoxColumn.HeaderText = "schoolCode";
            this.schoolCodeDataGridViewTextBoxColumn.Name = "schoolCodeDataGridViewTextBoxColumn";
            // 
            // programCodeDataGridViewTextBoxColumn
            // 
            this.programCodeDataGridViewTextBoxColumn.DataPropertyName = "programCode";
            this.programCodeDataGridViewTextBoxColumn.HeaderText = "programCode";
            this.programCodeDataGridViewTextBoxColumn.Name = "programCodeDataGridViewTextBoxColumn";
            // 
            // deptLeaderDataGridViewTextBoxColumn
            // 
            this.deptLeaderDataGridViewTextBoxColumn.DataPropertyName = "deptLeader";
            this.deptLeaderDataGridViewTextBoxColumn.HeaderText = "deptLeader";
            this.deptLeaderDataGridViewTextBoxColumn.Name = "deptLeaderDataGridViewTextBoxColumn";
            // 
            // deptPhoneDataGridViewTextBoxColumn
            // 
            this.deptPhoneDataGridViewTextBoxColumn.DataPropertyName = "deptPhone";
            this.deptPhoneDataGridViewTextBoxColumn.HeaderText = "deptPhone";
            this.deptPhoneDataGridViewTextBoxColumn.Name = "deptPhoneDataGridViewTextBoxColumn";
            // 
            // tuitionDataGridViewTextBoxColumn
            // 
            this.tuitionDataGridViewTextBoxColumn.DataPropertyName = "tuition";
            this.tuitionDataGridViewTextBoxColumn.HeaderText = "tuition";
            this.tuitionDataGridViewTextBoxColumn.Name = "tuitionDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "stateName";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "stateName";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "zip";
            this.zipDataGridViewTextBoxColumn.HeaderText = "zip";
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            // 
            // mSPOfferedByBindingSource
            // 
            this.mSPOfferedByBindingSource.DataMember = "MSP_OfferedBy";
            this.mSPOfferedByBindingSource.DataSource = this.bUDT758Y_ProjectDataSet;
            // 
            // bUDT758Y_ProjectDataSet
            // 
            this.bUDT758Y_ProjectDataSet.DataSetName = "BUDT758Y_ProjectDataSet";
            this.bUDT758Y_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mSP_OfferedByTableAdapter
            // 
            this.mSP_OfferedByTableAdapter.ClearBeforeFill = true;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1488, 684);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProgramForm";
            this.Text = "Programs";
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSPOfferedByBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUDT758Y_ProjectDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BUDT758Y_ProjectDataSet bUDT758Y_ProjectDataSet;
        private System.Windows.Forms.BindingSource mSPOfferedByBindingSource;
        private BUDT758Y_ProjectDataSetTableAdapters.MSP_OfferedByTableAdapter mSP_OfferedByTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptLeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
    }
}