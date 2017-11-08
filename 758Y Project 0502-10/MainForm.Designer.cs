namespace _758Y_Project_0502_10
{
    partial class MainForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.mSPOfferedByBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewSchoolButton = new System.Windows.Forms.Button();
            this.viewProgramButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.customButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mSPOfferedByBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.Window;
            this.menuButton.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.menuButton.Location = new System.Drawing.Point(151, 394);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(226, 51);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "View Rankings";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // viewSchoolButton
            // 
            this.viewSchoolButton.BackColor = System.Drawing.SystemColors.Window;
            this.viewSchoolButton.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSchoolButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.viewSchoolButton.Location = new System.Drawing.Point(151, 285);
            this.viewSchoolButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSchoolButton.Name = "viewSchoolButton";
            this.viewSchoolButton.Size = new System.Drawing.Size(226, 51);
            this.viewSchoolButton.TabIndex = 1;
            this.viewSchoolButton.Text = "View All Schools";
            this.viewSchoolButton.UseVisualStyleBackColor = false;
            this.viewSchoolButton.Click += new System.EventHandler(this.viewSchoolButton_Click);
            // 
            // viewProgramButton
            // 
            this.viewProgramButton.BackColor = System.Drawing.SystemColors.Window;
            this.viewProgramButton.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProgramButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.viewProgramButton.Location = new System.Drawing.Point(481, 285);
            this.viewProgramButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewProgramButton.Name = "viewProgramButton";
            this.viewProgramButton.Size = new System.Drawing.Size(226, 51);
            this.viewProgramButton.TabIndex = 2;
            this.viewProgramButton.Text = "View All Programs";
            this.viewProgramButton.UseVisualStyleBackColor = false;
            this.viewProgramButton.Click += new System.EventHandler(this.viewProgramButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLabel.Location = new System.Drawing.Point(84, 123);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(692, 57);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Multi-Dimension School Pinner";
            // 
            // customButton
            // 
            this.customButton.BackColor = System.Drawing.SystemColors.Window;
            this.customButton.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.customButton.Location = new System.Drawing.Point(481, 394);
            this.customButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customButton.Name = "customButton";
            this.customButton.Size = new System.Drawing.Size(226, 51);
            this.customButton.TabIndex = 4;
            this.customButton.Text = "Custom Selection";
            this.customButton.UseVisualStyleBackColor = false;
            this.customButton.Click += new System.EventHandler(this.customButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(863, 555);
            this.Controls.Add(this.customButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.viewProgramButton);
            this.Controls.Add(this.viewSchoolButton);
            this.Controls.Add(this.menuButton);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Multi-Dimension School Pinner";
            ((System.ComponentModel.ISupportInitialize)(this.mSPOfferedByBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.BindingSource mSPOfferedByBindingSource;
        private System.Windows.Forms.Button viewSchoolButton;
        private System.Windows.Forms.Button viewProgramButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button customButton;
    }
}

