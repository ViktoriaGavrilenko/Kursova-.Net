using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    public class Question : Form
    {
        public Question()
        {
            this.Text = "Новая форма";
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            domainUpDown_Points = new DomainUpDown();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            but_LoadImage = new Button();
            but_ClearImage = new Button();
            but_Save = new Button();
            but_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Text of question:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(112, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "incorrect,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(166, 9);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "text is empty";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 119);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Points:";
            // 
            // domainUpDown_Points
            // 
            domainUpDown_Points.Location = new Point(76, 170);
            domainUpDown_Points.Name = "domainUpDown_Points";
            domainUpDown_Points.Size = new Size(330, 23);
            domainUpDown_Points.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 209);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 6;
            label5.Text = "Image of question";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 134);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 11);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 8;
            label6.Text = "Answers:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(488, 11);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 9;
            label7.Text = "incorect,";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(547, 11);
            label8.Name = "label8";
            label8.Size = new Size(177, 15);
            label8.TabIndex = 10;
            label8.Text = "at least one answer must be true";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(431, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(127, 25);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.add;
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
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 22);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 22);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(434, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(487, 305);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Text of anwer";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Is true answer";
            Column2.Name = "Column2";
            // 
            // but_LoadImage
            // 
            but_LoadImage.ForeColor = Color.Blue;
            but_LoadImage.Location = new Point(17, 384);
            but_LoadImage.Name = "but_LoadImage";
            but_LoadImage.Size = new Size(176, 23);
            but_LoadImage.TabIndex = 13;
            but_LoadImage.Text = " Load image...";
            but_LoadImage.UseVisualStyleBackColor = true;
            // 
            // but_ClearImage
            // 
            but_ClearImage.Location = new Point(233, 384);
            but_ClearImage.Name = "but_ClearImage";
            but_ClearImage.Size = new Size(173, 23);
            but_ClearImage.TabIndex = 14;
            but_ClearImage.Text = "Clear image";
            but_ClearImage.UseVisualStyleBackColor = true;
            // 
            // but_Save
            // 
            but_Save.Location = new Point(434, 385);
            but_Save.Name = "but_Save";
            but_Save.Size = new Size(235, 23);
            but_Save.TabIndex = 15;
            but_Save.Text = "Save";
            but_Save.UseVisualStyleBackColor = true;
            // 
            // but_Cancel
            // 
            but_Cancel.Location = new Point(719, 384);
            but_Cancel.Name = "but_Cancel";
            but_Cancel.Size = new Size(202, 23);
            but_Cancel.TabIndex = 16;
            but_Cancel.Text = "Cancel";
            but_Cancel.UseVisualStyleBackColor = true;
            // 
            // Question
            // 
            ClientSize = new Size(933, 419);
            Controls.Add(but_Cancel);
            Controls.Add(but_Save);
            Controls.Add(but_ClearImage);
            Controls.Add(but_LoadImage);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(domainUpDown_Points);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Question";
            Text = "x";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button but_LoadImage;
        private Button but_ClearImage;
        private Button but_Save;
        private Button but_Cancel;
        private DomainUpDown domainUpDown_Points;
    }
}
