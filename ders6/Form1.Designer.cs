namespace ders6
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
            this.button_re = new System.Windows.Forms.Button();
            this.textBox_ri = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_rn = new System.Windows.Forms.TextBox();
            this.label_rt = new System.Windows.Forms.Label();
            this.label_ri = new System.Windows.Forms.Label();
            this.label_rn = new System.Windows.Forms.Label();
            this.label_er = new System.Windows.Forms.Label();
            this.label_re = new System.Windows.Forms.Label();
            this.label_er_r = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_re
            // 
            this.button_re.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_re.Enabled = false;
            this.button_re.Location = new System.Drawing.Point(12, 90);
            this.button_re.Name = "button_re";
            this.button_re.Size = new System.Drawing.Size(121, 38);
            this.button_re.TabIndex = 0;
            this.button_re.Text = "Randevu Ekle";
            this.button_re.UseVisualStyleBackColor = true;
            this.button_re.Click += new System.EventHandler(this.button_re_Click);
            // 
            // textBox_ri
            // 
            this.textBox_ri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_ri.Location = new System.Drawing.Point(230, 35);
            this.textBox_ri.Name = "textBox_ri";
            this.textBox_ri.Size = new System.Drawing.Size(212, 22);
            this.textBox_ri.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox_rn
            // 
            this.textBox_rn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_rn.Location = new System.Drawing.Point(448, 35);
            this.textBox_rn.Name = "textBox_rn";
            this.textBox_rn.Size = new System.Drawing.Size(222, 22);
            this.textBox_rn.TabIndex = 3;
            // 
            // label_rt
            // 
            this.label_rt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_rt.AutoSize = true;
            this.label_rt.Location = new System.Drawing.Point(9, 16);
            this.label_rt.Name = "label_rt";
            this.label_rt.Size = new System.Drawing.Size(99, 16);
            this.label_rt.TabIndex = 4;
            this.label_rt.Text = "Randevu Tarihi";
            // 
            // label_ri
            // 
            this.label_ri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ri.AutoSize = true;
            this.label_ri.Location = new System.Drawing.Point(227, 16);
            this.label_ri.Name = "label_ri";
            this.label_ri.Size = new System.Drawing.Size(89, 16);
            this.label_ri.TabIndex = 5;
            this.label_ri.Text = "Randevu İsmi";
            // 
            // label_rn
            // 
            this.label_rn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_rn.AutoSize = true;
            this.label_rn.Location = new System.Drawing.Point(445, 16);
            this.label_rn.Name = "label_rn";
            this.label_rn.Size = new System.Drawing.Size(93, 16);
            this.label_rn.TabIndex = 6;
            this.label_rn.Text = "Randevu Notu";
            // 
            // label_er
            // 
            this.label_er.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_er.AutoSize = true;
            this.label_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_er.ForeColor = System.Drawing.Color.Crimson;
            this.label_er.Location = new System.Drawing.Point(139, 90);
            this.label_er.Name = "label_er";
            this.label_er.Size = new System.Drawing.Size(336, 16);
            this.label_er.TabIndex = 7;
            this.label_er.Text = "Seçilen tarihte başka bir randevu bulunmaktadır";
            this.label_er.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_re
            // 
            this.label_re.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_re.AutoSize = true;
            this.label_re.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_re.ForeColor = System.Drawing.Color.Black;
            this.label_re.Location = new System.Drawing.Point(12, 131);
            this.label_re.Name = "label_re";
            this.label_re.Size = new System.Drawing.Size(124, 16);
            this.label_re.TabIndex = 9;
            this.label_re.Text = "Randevu eklendi";
            // 
            // label_er_r
            // 
            this.label_er_r.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_er_r.AutoSize = true;
            this.label_er_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_er_r.ForeColor = System.Drawing.Color.Crimson;
            this.label_er_r.Location = new System.Drawing.Point(139, 106);
            this.label_er_r.Name = "label_er_r";
            this.label_er_r.Size = new System.Drawing.Size(144, 16);
            this.label_er_r.TabIndex = 10;
            this.label_er_r.Text = "Bulunan Randevu    ";
            this.label_er_r.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 213);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_er_r);
            this.Controls.Add(this.label_re);
            this.Controls.Add(this.label_er);
            this.Controls.Add(this.label_rn);
            this.Controls.Add(this.label_ri);
            this.Controls.Add(this.label_rt);
            this.Controls.Add(this.textBox_rn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_ri);
            this.Controls.Add(this.button_re);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_re;
        private System.Windows.Forms.TextBox textBox_ri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_rn;
        private System.Windows.Forms.Label label_rt;
        private System.Windows.Forms.Label label_ri;
        private System.Windows.Forms.Label label_rn;
        private System.Windows.Forms.Label label_er;
        private System.Windows.Forms.Label label_re;
        private System.Windows.Forms.Label label_er_r;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

