using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    public class Answer : Form
    {
        public Answer()
        {
            this.Text = "Новая форма";
        }

        private Label label1;
        private CheckBox checkBox1;
        private Button but_Save;
        private Button but_Cancel;
        private TextBox textBox1;

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            but_Save = new Button();
            but_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Add new answer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 80);
            textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 139);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Is true answer";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // but_Save
            // 
            but_Save.Location = new Point(20, 177);
            but_Save.Name = "but_Save";
            but_Save.Size = new Size(99, 23);
            but_Save.TabIndex = 3;
            but_Save.Text = "Save";
            but_Save.UseVisualStyleBackColor = true;
            // 
            // but_Cancel
            // 
            but_Cancel.Location = new Point(204, 177);
            but_Cancel.Name = "but_Cancel";
            but_Cancel.Size = new Size(114, 23);
            but_Cancel.TabIndex = 4;
            but_Cancel.Text = "Cancel";
            but_Cancel.UseVisualStyleBackColor = true;
            // 
            // Answer
            // 
            ClientSize = new Size(341, 230);
            Controls.Add(but_Cancel);
            Controls.Add(but_Save);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Answer";
            Text = "Answer";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
