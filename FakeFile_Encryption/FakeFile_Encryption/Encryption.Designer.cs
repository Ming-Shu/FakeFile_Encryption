namespace FakeFile_Encryption
{
    partial class Encryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption));
            this.status_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.output_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.iuput_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_textBox2 = new System.Windows.Forms.TextBox();
            this.iuput_btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(201, 294);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(300, 31);
            this.status_label.TabIndex = 20;
            this.status_label.Text = "Please load the source file!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(605, 376);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(102, 62);
            this.start_btn.TabIndex = 18;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 376);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(519, 62);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 17;
            // 
            // output_btn
            // 
            this.output_btn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_btn.Location = new System.Drawing.Point(585, 209);
            this.output_btn.Name = "output_btn";
            this.output_btn.Size = new System.Drawing.Size(109, 46);
            this.output_btn.TabIndex = 16;
            this.output_btn.Text = "Output";
            this.output_btn.UseVisualStyleBackColor = true;
            this.output_btn.Click += new System.EventHandler(this.output_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Save as :";
            // 
            // output_textBox
            // 
            this.output_textBox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_textBox.Location = new System.Drawing.Point(198, 212);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(345, 45);
            this.output_textBox.TabIndex = 14;
            // 
            // iuput_btn
            // 
            this.iuput_btn.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iuput_btn.Location = new System.Drawing.Point(585, 35);
            this.iuput_btn.Name = "iuput_btn";
            this.iuput_btn.Size = new System.Drawing.Size(109, 46);
            this.iuput_btn.TabIndex = 13;
            this.iuput_btn.Text = "Input";
            this.iuput_btn.UseVisualStyleBackColor = true;
            this.iuput_btn.Click += new System.EventHandler(this.iuput_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Source File :";
            // 
            // input_textBox
            // 
            this.input_textBox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textBox.Location = new System.Drawing.Point(198, 35);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.ReadOnly = true;
            this.input_textBox.Size = new System.Drawing.Size(345, 45);
            this.input_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pack File :";
            // 
            // input_textBox2
            // 
            this.input_textBox2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textBox2.Location = new System.Drawing.Point(198, 120);
            this.input_textBox2.Name = "input_textBox2";
            this.input_textBox2.ReadOnly = true;
            this.input_textBox2.Size = new System.Drawing.Size(345, 45);
            this.input_textBox2.TabIndex = 22;
            // 
            // iuput_btn2
            // 
            this.iuput_btn2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iuput_btn2.Location = new System.Drawing.Point(585, 120);
            this.iuput_btn2.Name = "iuput_btn2";
            this.iuput_btn2.Size = new System.Drawing.Size(109, 46);
            this.iuput_btn2.TabIndex = 23;
            this.iuput_btn2.Text = "Input";
            this.iuput_btn2.UseVisualStyleBackColor = true;
            this.iuput_btn2.Click += new System.EventHandler(this.iuput_btn2_Click);
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 482);
            this.Controls.Add(this.iuput_btn2);
            this.Controls.Add(this.input_textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.output_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.iuput_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.Encryption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button output_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Button iuput_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_textBox2;
        private System.Windows.Forms.Button iuput_btn2;
    }
}