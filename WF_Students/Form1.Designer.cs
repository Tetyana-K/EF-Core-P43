namespace WF_Students
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSortByName = new Button();
            btnSortByGrade = new Button();
            tbName = new TextBox();
            tbAge = new TextBox();
            tbGrade = new TextBox();
            tbFilter = new TextBox();
            btnFilter = new Button();
            btnClearFilter = new Button();
            groupBox1 = new GroupBox();
            tbGroup = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(357, 274);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(412, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(358, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.DialogResult = DialogResult.Yes;
            btnDelete.ForeColor = Color.Maroon;
            btnDelete.Location = new Point(411, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(358, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSortByName
            // 
            btnSortByName.Location = new Point(29, 312);
            btnSortByName.Name = "btnSortByName";
            btnSortByName.Size = new Size(108, 23);
            btnSortByName.TabIndex = 3;
            btnSortByName.Text = "Sort by Name";
            btnSortByName.UseVisualStyleBackColor = true;
            btnSortByName.Click += btnSortByName_Click;
            // 
            // btnSortByGrade
            // 
            btnSortByGrade.Location = new Point(275, 311);
            btnSortByGrade.Name = "btnSortByGrade";
            btnSortByGrade.Size = new Size(111, 23);
            btnSortByGrade.TabIndex = 4;
            btnSortByGrade.Text = "Sort by Grade";
            btnSortByGrade.UseVisualStyleBackColor = true;
            btnSortByGrade.Click += btnSortByGrade_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(19, 38);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Name";
            tbName.Size = new Size(149, 23);
            tbName.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(204, 38);
            tbAge.Name = "tbAge";
            tbAge.PlaceholderText = "Age";
            tbAge.Size = new Size(135, 23);
            tbAge.TabIndex = 6;
            // 
            // tbGrade
            // 
            tbGrade.Location = new Point(19, 94);
            tbGrade.Name = "tbGrade";
            tbGrade.PlaceholderText = "Grade";
            tbGrade.Size = new Size(149, 23);
            tbGrade.TabIndex = 7;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(412, 309);
            tbFilter.Name = "tbFilter";
            tbFilter.PlaceholderText = "Enter group";
            tbFilter.Size = new Size(207, 23);
            tbFilter.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(635, 309);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(134, 26);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filter by Group";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(411, 348);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(358, 26);
            btnClearFilter.TabIndex = 10;
            btnClearFilter.Text = "Clear filter";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbGroup);
            groupBox1.Controls.Add(tbGrade);
            groupBox1.Controls.Add(tbAge);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(411, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 139);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student";
            // 
            // tbGroup
            // 
            tbGroup.Location = new Point(204, 94);
            tbGroup.Name = "tbGroup";
            tbGroup.PlaceholderText = "Group";
            tbGroup.Size = new Size(135, 23);
            tbGroup.TabIndex = 8;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(412, 221);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(358, 23);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 415);
            Controls.Add(btnEdit);
            Controls.Add(groupBox1);
            Controls.Add(btnClearFilter);
            Controls.Add(btnFilter);
            Controls.Add(btnAdd);
            Controls.Add(tbFilter);
            Controls.Add(btnSortByGrade);
            Controls.Add(btnSortByName);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSortByName;
        private Button btnSortByGrade;
        private TextBox tbName;
        private TextBox tbAge;
        private TextBox tbGrade;
        private TextBox tbFilter;
        private Button btnFilter;
        private Button btnClearFilter;
        private GroupBox groupBox1;
        private TextBox tbGroup;
        private Button btnEdit;
    }
}
