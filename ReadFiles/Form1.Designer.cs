namespace ReadFiles
{
    partial class MainForm
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
            this.open_pos = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.btn_pos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_file_name = new System.Windows.Forms.TextBox();
            this.txt_gsd = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_gsd = new System.Windows.Forms.Button();
            this.save_gsd = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_file_name_start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_file_number = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_pos
            // 
            this.open_pos.DefaultExt = "txt";
            this.open_pos.FileName = "POS信息";
            this.open_pos.Title = "选择POS信息文档";
            this.open_pos.FileOk += new System.ComponentModel.CancelEventHandler(this.open_pos_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pos);
            this.groupBox1.Controls.Add(this.btn_pos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POS信息";
            // 
            // txt_pos
            // 
            this.txt_pos.Location = new System.Drawing.Point(7, 40);
            this.txt_pos.Multiline = true;
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.ReadOnly = true;
            this.txt_pos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_pos.Size = new System.Drawing.Size(781, 122);
            this.txt_pos.TabIndex = 1;
            // 
            // btn_pos
            // 
            this.btn_pos.Location = new System.Drawing.Point(713, 11);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Size = new System.Drawing.Size(75, 23);
            this.btn_pos.TabIndex = 0;
            this.btn_pos.Text = "打开文件";
            this.btn_pos.UseVisualStyleBackColor = true;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_file_number);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_file_name_start);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_file_name);
            this.groupBox2.Controls.Add(this.txt_gsd);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Controls.Add(this.btn_gsd);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GSD信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件名";
            // 
            // txt_file_name
            // 
            this.txt_file_name.Location = new System.Drawing.Point(121, 13);
            this.txt_file_name.Name = "txt_file_name";
            this.txt_file_name.Size = new System.Drawing.Size(95, 21);
            this.txt_file_name.TabIndex = 3;
            this.txt_file_name.TextChanged += new System.EventHandler(this.txt_file_name_TextChanged);
            // 
            // txt_gsd
            // 
            this.txt_gsd.Location = new System.Drawing.Point(7, 39);
            this.txt_gsd.Multiline = true;
            this.txt_gsd.Name = "txt_gsd";
            this.txt_gsd.ReadOnly = true;
            this.txt_gsd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gsd.Size = new System.Drawing.Size(781, 146);
            this.txt_gsd.TabIndex = 2;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(595, 10);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始转换";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_gsd
            // 
            this.btn_gsd.Location = new System.Drawing.Point(713, 10);
            this.btn_gsd.Name = "btn_gsd";
            this.btn_gsd.Size = new System.Drawing.Size(75, 23);
            this.btn_gsd.TabIndex = 0;
            this.btn_gsd.Text = "保存文件";
            this.btn_gsd.UseVisualStyleBackColor = true;
            this.btn_gsd.Click += new System.EventHandler(this.btn_gsd_Click);
            // 
            // save_gsd
            // 
            this.save_gsd.DefaultExt = "txt";
            this.save_gsd.Title = "保存GSD信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始数字";
            // 
            // txt_file_name_start
            // 
            this.txt_file_name_start.Location = new System.Drawing.Point(293, 12);
            this.txt_file_name_start.Name = "txt_file_name_start";
            this.txt_file_name_start.Size = new System.Drawing.Size(100, 21);
            this.txt_file_name_start.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "文件数";
            // 
            // txt_file_number
            // 
            this.txt_file_number.Location = new System.Drawing.Point(459, 13);
            this.txt_file_number.Name = "txt_file_number";
            this.txt_file_number.Size = new System.Drawing.Size(100, 21);
            this.txt_file_number.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "POS2GCS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog open_pos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_gsd;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_gsd;
        private System.Windows.Forms.SaveFileDialog save_gsd;
        private System.Windows.Forms.TextBox txt_file_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_file_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_file_name_start;
        private System.Windows.Forms.Label label2;
    }
}