using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    public class EditMode : Form
    {
        public EditMode()
        {
            this.Text = "Новая форма";
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMode));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(529, 315);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 65);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Login *";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 32);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "must be unique";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 18);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(100, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Change password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 131);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Password *";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(307, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 20);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 170);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Confirm *";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(306, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 21);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 220);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 12;
            label5.Text = "First name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 23);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 265);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 14;
            label6.Text = "Last name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 262);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 23);
            textBox5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 313);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 16;
            label7.Text = "Description";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(104, 310);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 68);
            textBox6.TabIndex = 17;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(106, 396);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Administrator";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(463, 396);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(69, 19);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Archival";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(643, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(758, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(352, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(58, 25);
            toolStrip1.TabIndex = 22;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(761, 34);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 23;
            label8.Text = "User groups";
            // 
            // EditMode
            // 
            ClientSize = new Size(902, 425);
            Controls.Add(label8);
            Controls.Add(toolStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "EditMode";
            Text = "_Edit_mode_";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Button button2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Label label8;
        private CheckBox checkBox1;

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
