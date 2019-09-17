namespace Interview
{
    partial class Form1
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parentChildLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.populateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Interview.DataSet2();
            this.partTableAdapter = new Interview.DataSet2TableAdapters.partTableAdapter();
            this.bomTableAdapter = new Interview.DataSet2TableAdapters.bomTableAdapter();
            this.bomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(13, 19);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(288, 175);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testing Functionality for Tree and Datagrid";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.parentChildLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.populateButton);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 234);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.currentLabel.Location = new System.Drawing.Point(399, 46);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(0, 13);
            this.currentLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(326, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Part:";
            // 
            // parentChildLabel
            // 
            this.parentChildLabel.AutoSize = true;
            this.parentChildLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.parentChildLabel.Location = new System.Drawing.Point(422, 20);
            this.parentChildLabel.Name = "parentChildLabel";
            this.parentChildLabel.Size = new System.Drawing.Size(0, 13);
            this.parentChildLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(326, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parent Child Part:";
            // 
            // populateButton
            // 
            this.populateButton.Location = new System.Drawing.Point(326, 106);
            this.populateButton.Name = "populateButton";
            this.populateButton.Size = new System.Drawing.Size(136, 28);
            this.populateButton.TabIndex = 2;
            this.populateButton.Text = "Populate Data In Tree";
            this.populateButton.UseVisualStyleBackColor = true;
            this.populateButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(326, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit From Application";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "part";
            this.partBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // bomTableAdapter
            // 
            this.bomTableAdapter.ClearBeforeFill = true;
            // 
            // bomBindingSource
            // 
            this.bomBindingSource.DataMember = "bom";
            this.bomBindingSource.DataSource = this.dataSet2;
            // 
            // partView
            // 
            this.partView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partView.Location = new System.Drawing.Point(12, 296);
            this.partView.Name = "partView";
            this.partView.Size = new System.Drawing.Size(848, 248);
            this.partView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 556);
            this.Controls.Add(this.partView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QBuild";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label parentChildLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button populateButton;
        private System.Windows.Forms.Button exitButton;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource partBindingSource;
        private DataSet2TableAdapters.partTableAdapter partTableAdapter;
        private DataSet2TableAdapters.bomTableAdapter bomTableAdapter;
        private System.Windows.Forms.BindingSource bomBindingSource;
        private System.Windows.Forms.DataGridView partView;
    }
}

