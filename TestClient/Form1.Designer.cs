namespace TestClient
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            but_Refresh = new Button();
            but_GetTested = new Button();
            dataGridView2 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            TestUser_id = new DataGridViewTextBoxColumn();
            Test_id = new DataGridViewTextBoxColumn();
            Test_Title = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "New test for user:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TestUser_id, Test_id, Test_Title, Date });
            dataGridView1.Location = new Point(29, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(736, 150);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 226);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Result test:";
            // 
            // but_Refresh
            // 
            but_Refresh.ForeColor = Color.Green;
            but_Refresh.Location = new Point(469, 217);
            but_Refresh.Name = "but_Refresh";
            but_Refresh.Size = new Size(136, 32);
            but_Refresh.TabIndex = 3;
            but_Refresh.Text = "Refresh";
            but_Refresh.UseVisualStyleBackColor = true;
            // 
            // but_GetTested
            // 
            but_GetTested.ForeColor = Color.Blue;
            but_GetTested.Location = new Point(634, 218);
            but_GetTested.Name = "but_GetTested";
            but_GetTested.Size = new Size(131, 31);
            but_GetTested.TabIndex = 4;
            but_GetTested.Text = "Get tested";
            but_GetTested.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView2.Location = new Point(29, 270);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(736, 150);
            dataGridView2.TabIndex = 5;
            // 
            // Column2
            // 
            Column2.HeaderText = "TestUser_id";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Test_id";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Test_Title";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Result Points";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Result Test";
            Column7.Name = "Column7";
            // 
            // TestUser_id
            // 
            TestUser_id.HeaderText = "TestUser_id";
            TestUser_id.Name = "TestUser_id";
            // 
            // Test_id
            // 
            Test_id.HeaderText = "Test_id";
            Test_id.Name = "Test_id";
            // 
            // Test_Title
            // 
            Test_Title.HeaderText = "Test_Title";
            Test_Title.Name = "Test_Title";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(but_GetTested);
            Controls.Add(but_Refresh);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TestClient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button but_Refresh;
        private Button but_GetTested;
        private DataGridViewTextBoxColumn TestUser_id;
        private DataGridViewTextBoxColumn Test_id;
        private DataGridViewTextBoxColumn Test_Title;
        private DataGridViewTextBoxColumn Date;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}