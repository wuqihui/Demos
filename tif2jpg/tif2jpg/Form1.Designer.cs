namespace tif2jpg
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
            this.btnBrower = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnTif2jpg = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(443, 43);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 23);
            this.btnBrower.TabIndex = 0;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(52, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(385, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnTif2jpg
            // 
            this.btnTif2jpg.Location = new System.Drawing.Point(524, 43);
            this.btnTif2jpg.Name = "btnTif2jpg";
            this.btnTif2jpg.Size = new System.Drawing.Size(75, 23);
            this.btnTif2jpg.TabIndex = 2;
            this.btnTif2jpg.Text = "转换";
            this.btnTif2jpg.UseVisualStyleBackColor = true;
            this.btnTif2jpg.Click += new System.EventHandler(this.btnTif2jpg_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 48);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "路径：";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(52, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(547, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "进度:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.btnTif2jpg);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrower);
            this.Name = "Form1";
            this.Text = "Tif2Jpg---Keith.wu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnTif2jpg;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

