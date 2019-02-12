namespace Bio_M.S
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lines = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.result_view = new System.Windows.Forms.DataGridView();
            this.subsequences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codelength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Size = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.Seq = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.right_result = new System.Windows.Forms.DataGridView();
            this.AgentNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_view)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.right_result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.right_result);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lines);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.result_view);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(433, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 563);
            this.panel2.TabIndex = 3;
            // 
            // lines
            // 
            this.lines.FormattingEnabled = true;
            this.lines.Location = new System.Drawing.Point(199, 38);
            this.lines.Name = "lines";
            this.lines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lines.Size = new System.Drawing.Size(121, 21);
            this.lines.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(326, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "شماره سطر :";
            // 
            // result_view
            // 
            this.result_view.AllowUserToAddRows = false;
            this.result_view.AllowUserToDeleteRows = false;
            this.result_view.AllowUserToOrderColumns = true;
            this.result_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subsequences,
            this.length,
            this.column,
            this.codelength});
            this.result_view.Location = new System.Drawing.Point(5, 68);
            this.result_view.Name = "result_view";
            this.result_view.ReadOnly = true;
            this.result_view.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result_view.Size = new System.Drawing.Size(405, 205);
            this.result_view.TabIndex = 1;
            // 
            // subsequences
            // 
            this.subsequences.HeaderText = "زیررشته";
            this.subsequences.Name = "subsequences";
            this.subsequences.ReadOnly = true;
            // 
            // length
            // 
            this.length.HeaderText = "میزان تکرار";
            this.length.Name = "length";
            this.length.ReadOnly = true;
            // 
            // column
            // 
            this.column.HeaderText = "شماره ستون";
            this.column.Name = "column";
            this.column.ReadOnly = true;
            // 
            // codelength
            // 
            this.codelength.HeaderText = "طول کد";
            this.codelength.Name = "codelength";
            this.codelength.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(174, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "موتیف بدست آمده از روش کد هافمن :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AgentNum);
            this.panel1.Controls.Add(this.Size);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.run);
            this.panel1.Controls.Add(this.Seq);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 563);
            this.panel1.TabIndex = 2;
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(131, 7);
            this.Size.Name = "Size";
            this.Size.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size.Size = new System.Drawing.Size(30, 20);
            this.Size.TabIndex = 16;
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(167, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "طول زیررشته :";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(278, 518);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(137, 42);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(320, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "توالی زیستی :";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(3, 518);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(137, 42);
            this.run.TabIndex = 4;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // Seq
            // 
            this.Seq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Seq.Location = new System.Drawing.Point(3, 46);
            this.Seq.Multiline = true;
            this.Seq.Name = "Seq";
            this.Seq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Seq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Seq.Size = new System.Drawing.Size(412, 466);
            this.Seq.TabIndex = 0;
            this.Seq.WordWrap = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(93, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(322, 31);
            this.label15.TabIndex = 8;
            this.label15.Text = "موتیف درست (در صورتی که از فایل لود شده باشد) :";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره ستون";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "طول زیر رشته";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "زیررشته";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // right_result
            // 
            this.right_result.AllowUserToAddRows = false;
            this.right_result.AllowUserToDeleteRows = false;
            this.right_result.AllowUserToOrderColumns = true;
            this.right_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.right_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.right_result.Enabled = false;
            this.right_result.Location = new System.Drawing.Point(5, 310);
            this.right_result.Name = "right_result";
            this.right_result.ReadOnly = true;
            this.right_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.right_result.Size = new System.Drawing.Size(405, 250);
            this.right_result.TabIndex = 9;
            // 
            // AgentNum
            // 
            this.AgentNum.Location = new System.Drawing.Point(3, 7);
            this.AgentNum.Name = "AgentNum";
            this.AgentNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgentNum.Size = new System.Drawing.Size(30, 20);
            this.AgentNum.TabIndex = 17;
            this.AgentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(39, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "تعداد :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result_view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.right_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView right_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox lines;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView result_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsequences;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn codelength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox Seq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AgentNum;

    }
}