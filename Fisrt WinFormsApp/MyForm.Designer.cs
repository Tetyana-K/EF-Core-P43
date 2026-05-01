namespace Fisrt_WinFormsApp
{
    partial class MyForm
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
            button1 = new Button();
            lblCount = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnHello = new Button();
            tbName = new TextBox();
            groupBox3 = new GroupBox();
            lblResult = new Label();
            btnPlus = new Button();
            tbSecondNum = new TextBox();
            tbFirstNum = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            lblDate = new Label();
            btnGetDate = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 160);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(222, 55);
            button1.TabIndex = 0;
            button1.Text = "Click me!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCount
            // 
            lblCount.BackColor = Color.DarkOrange;
            lblCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(31, 59);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(222, 55);
            lblCount.TabIndex = 1;
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCount);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(31, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 254);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clicker";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHello);
            groupBox2.Controls.Add(tbName);
            groupBox2.Location = new Point(401, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 254);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hello";
            // 
            // btnHello
            // 
            btnHello.Location = new Point(25, 160);
            btnHello.Margin = new Padding(4);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(222, 55);
            btnHello.TabIndex = 2;
            btnHello.Text = "Hello!";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(25, 76);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Enter yout name";
            tbName.Size = new Size(222, 29);
            tbName.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblResult);
            groupBox3.Controls.Add(btnPlus);
            groupBox3.Controls.Add(tbSecondNum);
            groupBox3.Controls.Add(tbFirstNum);
            groupBox3.Location = new Point(759, 75);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(273, 241);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Calculator";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(110, 181);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(53, 21);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(59, 116);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(155, 42);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // tbSecondNum
            // 
            tbSecondNum.Location = new Point(59, 72);
            tbSecondNum.Name = "tbSecondNum";
            tbSecondNum.PlaceholderText = "Second number";
            tbSecondNum.Size = new Size(155, 29);
            tbSecondNum.TabIndex = 1;
            // 
            // tbFirstNum
            // 
            tbFirstNum.Location = new Point(59, 28);
            tbFirstNum.Name = "tbFirstNum";
            tbFirstNum.PlaceholderText = "First number";
            tbFirstNum.Size = new Size(155, 29);
            tbFirstNum.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(439, 355);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(780, 345);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(242, 29);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(439, 435);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 21);
            lblDate.TabIndex = 8;
            lblDate.Text = "label1";
            // 
            // btnGetDate
            // 
            btnGetDate.Location = new Point(800, 418);
            btnGetDate.Margin = new Padding(4);
            btnGetDate.Name = "btnGetDate";
            btnGetDate.Size = new Size(222, 55);
            btnGetDate.TabIndex = 3;
            btnGetDate.Text = "Get date";
            btnGetDate.UseVisualStyleBackColor = true;
            btnGetDate.Click += btnGetDate_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1098, 552);
            Controls.Add(btnGetDate);
            Controls.Add(lblDate);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Firebrick;
            Margin = new Padding(4);
            Name = "MyForm";
            Text = "My First Form";
            Click += MyForm_Click;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblCount;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnHello;
        private TextBox tbName;
        private GroupBox groupBox3;
        private TextBox tbSecondNum;
        private TextBox tbFirstNum;
        private Label lblResult;
        private Button btnPlus;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label lblDate;
        private Button btnGetDate;
    }
}
