namespace WindowsFormsApp8
{
    partial class HangHoaComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tenhang = new System.Windows.Forms.Label();
            this.dongia = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(42, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tenhang
            // 
            this.tenhang.AutoSize = true;
            this.tenhang.Location = new System.Drawing.Point(20, 130);
            this.tenhang.Name = "tenhang";
            this.tenhang.Size = new System.Drawing.Size(34, 16);
            this.tenhang.TabIndex = 1;
            this.tenhang.Text = "text1";
            this.tenhang.Click += new System.EventHandler(this.label1_Click);
            // 
            // dongia
            // 
            this.dongia.AutoSize = true;
            this.dongia.Location = new System.Drawing.Point(20, 161);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(44, 16);
            this.dongia.TabIndex = 2;
            this.dongia.Text = "label2";
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Location = new System.Drawing.Point(144, 171);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(44, 16);
            this.soluong.TabIndex = 3;
            this.soluong.Text = "label3";
            // 
            // HangHoaComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.tenhang);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HangHoaComponent";
            this.Size = new System.Drawing.Size(200, 217);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tenhang;
        private System.Windows.Forms.Label dongia;
        private System.Windows.Forms.Label soluong;
    }
}
