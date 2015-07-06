namespace XMLer
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
            this.but_StartFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_NewNode = new System.Windows.Forms.Button();
            this.but_EndNode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.but_AddData = new System.Windows.Forms.Button();
            this.but_EndFile = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.but_ResetPage = new System.Windows.Forms.Button();
            this.but_ResetRow = new System.Windows.Forms.Button();
            this.but_ResetCol = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // but_StartFile
            // 
            this.but_StartFile.Location = new System.Drawing.Point(12, 12);
            this.but_StartFile.Name = "but_StartFile";
            this.but_StartFile.Size = new System.Drawing.Size(97, 23);
            this.but_StartFile.TabIndex = 0;
            this.but_StartFile.Text = "Start a file";
            this.but_StartFile.UseVisualStyleBackColor = true;
            this.but_StartFile.Click += new System.EventHandler(this.but_StartFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "<Node name=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "RepeatData=";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = ">";
            // 
            // but_NewNode
            // 
            this.but_NewNode.Enabled = false;
            this.but_NewNode.Location = new System.Drawing.Point(117, 12);
            this.but_NewNode.Name = "but_NewNode";
            this.but_NewNode.Size = new System.Drawing.Size(75, 23);
            this.but_NewNode.TabIndex = 6;
            this.but_NewNode.Text = "New Node";
            this.but_NewNode.UseVisualStyleBackColor = true;
            this.but_NewNode.Click += new System.EventHandler(this.but_NewNode_Click);
            // 
            // but_EndNode
            // 
            this.but_EndNode.Enabled = false;
            this.but_EndNode.Location = new System.Drawing.Point(115, 114);
            this.but_EndNode.Name = "but_EndNode";
            this.but_EndNode.Size = new System.Drawing.Size(71, 23);
            this.but_EndNode.TabIndex = 7;
            this.but_EndNode.Text = "End Node";
            this.but_EndNode.UseVisualStyleBackColor = true;
            this.but_EndNode.Click += new System.EventHandler(this.but_EndNode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "<Data page=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 21);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "row=";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 21);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "col=";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(275, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 21);
            this.textBox5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = ">";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(339, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 21);
            this.textBox6.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "</Data>";
            // 
            // but_AddData
            // 
            this.but_AddData.Enabled = false;
            this.but_AddData.Location = new System.Drawing.Point(12, 114);
            this.but_AddData.Name = "but_AddData";
            this.but_AddData.Size = new System.Drawing.Size(71, 23);
            this.but_AddData.TabIndex = 17;
            this.but_AddData.Text = "Add Data";
            this.but_AddData.UseVisualStyleBackColor = true;
            this.but_AddData.Click += new System.EventHandler(this.but_AddData_Click);
            // 
            // but_EndFile
            // 
            this.but_EndFile.Enabled = false;
            this.but_EndFile.Location = new System.Drawing.Point(213, 114);
            this.but_EndFile.Name = "but_EndFile";
            this.but_EndFile.Size = new System.Drawing.Size(97, 23);
            this.but_EndFile.TabIndex = 18;
            this.but_EndFile.Text = "End File";
            this.but_EndFile.UseVisualStyleBackColor = true;
            this.but_EndFile.Click += new System.EventHandler(this.but_EndFile_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(495, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Page count";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(495, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 16);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Row count";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(495, 53);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 16);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Col count";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // but_ResetPage
            // 
            this.but_ResetPage.Location = new System.Drawing.Point(585, 5);
            this.but_ResetPage.Name = "but_ResetPage";
            this.but_ResetPage.Size = new System.Drawing.Size(71, 23);
            this.but_ResetPage.TabIndex = 22;
            this.but_ResetPage.Text = "Reset";
            this.but_ResetPage.UseVisualStyleBackColor = true;
            this.but_ResetPage.Click += new System.EventHandler(this.but_ResetPage_Click);
            // 
            // but_ResetRow
            // 
            this.but_ResetRow.Location = new System.Drawing.Point(585, 27);
            this.but_ResetRow.Name = "but_ResetRow";
            this.but_ResetRow.Size = new System.Drawing.Size(71, 23);
            this.but_ResetRow.TabIndex = 23;
            this.but_ResetRow.Text = "Reset";
            this.but_ResetRow.UseVisualStyleBackColor = true;
            this.but_ResetRow.Click += new System.EventHandler(this.but_ResetRow_Click);
            // 
            // but_ResetCol
            // 
            this.but_ResetCol.Location = new System.Drawing.Point(585, 49);
            this.but_ResetCol.Name = "but_ResetCol";
            this.but_ResetCol.Size = new System.Drawing.Size(71, 23);
            this.but_ResetCol.TabIndex = 24;
            this.but_ResetCol.Text = "Reset";
            this.but_ResetCol.UseVisualStyleBackColor = true;
            this.but_ResetCol.Click += new System.EventHandler(this.but_ResetCol_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(713, 284);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 451);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.but_ResetCol);
            this.Controls.Add(this.but_ResetRow);
            this.Controls.Add(this.but_ResetPage);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.but_EndFile);
            this.Controls.Add(this.but_AddData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_EndNode);
            this.Controls.Add(this.but_NewNode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_StartFile);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_StartFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_NewNode;
        private System.Windows.Forms.Button but_EndNode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_AddData;
        private System.Windows.Forms.Button but_EndFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button but_ResetPage;
        private System.Windows.Forms.Button but_ResetRow;
        private System.Windows.Forms.Button but_ResetCol;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

