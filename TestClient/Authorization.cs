namespace TestClient
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            this.Text = "Новая форма";
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button_Login = new Button();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 23);
            textBox2.TabIndex = 3;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(29, 150);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(104, 23);
            button_Login.TabIndex = 4;
            button_Login.Text = "Log in";
            button_Login.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(216, 150);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(105, 23);
            button_Cancel.TabIndex = 5;
            button_Cancel.Text = "Cancel";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += this.button_Cancel_Click;
            // 
            // Authorization
            // 
            ClientSize = new Size(352, 208);
            Controls.Add(button_Cancel);
            Controls.Add(button_Login);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Authorization";
            Text = "Authorization for TestClient";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button_Login;
        private Button button_Cancel;
    }
}
