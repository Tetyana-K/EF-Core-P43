namespace WF_One_To_One
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
            tbName = new TextBox();
            tbStreet = new TextBox();
            numAge = new NumericUpDown();
            tbCountry = new TextBox();
            tbCity = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(308, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tbName
            // 
            tbName.Location = new Point(359, 12);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Name";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            // 
            // tbStreet
            // 
            tbStreet.Location = new Point(359, 165);
            tbStreet.Name = "tbStreet";
            tbStreet.PlaceholderText = "Street";
            tbStreet.Size = new Size(100, 23);
            tbStreet.TabIndex = 2;
            // 
            // numAge
            // 
            numAge.Location = new Point(477, 12);
            numAge.Name = "numAge";
            numAge.Size = new Size(120, 23);
            numAge.TabIndex = 3;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(612, 165);
            tbCountry.Name = "tbCountry";
            tbCountry.PlaceholderText = "Country";
            tbCountry.Size = new Size(100, 23);
            tbCountry.TabIndex = 4;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(487, 165);
            tbCity.Name = "tbCity";
            tbCity.PlaceholderText = "City";
            tbCity.Size = new Size(100, 23);
            tbCity.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(359, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(487, 232);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(tbCity);
            Controls.Add(tbCountry);
            Controls.Add(numAge);
            Controls.Add(tbStreet);
            Controls.Add(tbName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox tbName;
        private TextBox tbStreet;
        private NumericUpDown numAge;
        private TextBox tbCountry;
        private TextBox tbCity;
        private Button btnAdd;
        private Button btnEdit;
    }
}
