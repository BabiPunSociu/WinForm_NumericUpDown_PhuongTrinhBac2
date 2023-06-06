namespace Bai12_Trang74
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
			this.label1 = new System.Windows.Forms.Label();
			this.nudA = new System.Windows.Forms.NumericUpDown();
			this.nudB = new System.Windows.Forms.NumericUpDown();
			this.nudC = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGPT = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.lstKetQua = new System.Windows.Forms.ListBox();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(581, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Giải phương trình Ax^2+Bx+C=0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nudA
			// 
			this.nudA.Location = new System.Drawing.Point(88, 69);
			this.nudA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudA.Name = "nudA";
			this.nudA.Size = new System.Drawing.Size(84, 22);
			this.nudA.TabIndex = 1;
			this.nudA.ValueChanged += new System.EventHandler(this.nudA_ValueChanged);
			// 
			// nudB
			// 
			this.nudB.Location = new System.Drawing.Point(303, 69);
			this.nudB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudB.Name = "nudB";
			this.nudB.Size = new System.Drawing.Size(84, 22);
			this.nudB.TabIndex = 2;
			this.nudB.ValueChanged += new System.EventHandler(this.nudB_ValueChanged);
			// 
			// nudC
			// 
			this.nudC.Location = new System.Drawing.Point(497, 69);
			this.nudC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nudC.Name = "nudC";
			this.nudC.Size = new System.Drawing.Size(84, 22);
			this.nudC.TabIndex = 3;
			this.nudC.ValueChanged += new System.EventHandler(this.nudC_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(15, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 32);
			this.label2.TabIndex = 4;
			this.label2.Text = "A = ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(424, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 32);
			this.label3.TabIndex = 5;
			this.label3.Text = "C = ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(230, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 32);
			this.label4.TabIndex = 6;
			this.label4.Text = "B = ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGPT
			// 
			this.btnGPT.Location = new System.Drawing.Point(27, 254);
			this.btnGPT.Name = "btnGPT";
			this.btnGPT.Size = new System.Drawing.Size(180, 32);
			this.btnGPT.TabIndex = 8;
			this.btnGPT.Text = "&Giải phương trình";
			this.btnGPT.UseVisualStyleBackColor = true;
			this.btnGPT.Click += new System.EventHandler(this.btnGPT_Click);
			this.btnGPT.MouseEnter += new System.EventHandler(this.btnGPT_MouseEnter);
			this.btnGPT.MouseLeave += new System.EventHandler(this.btnGPT_MouseLeave);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(421, 254);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(182, 32);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "&Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			this.btnThoat.MouseEnter += new System.EventHandler(this.btnGPT_MouseEnter);
			this.btnThoat.MouseLeave += new System.EventHandler(this.btnGPT_MouseLeave);
			// 
			// lstKetQua
			// 
			this.lstKetQua.BackColor = System.Drawing.Color.LightGreen;
			this.lstKetQua.FormattingEnabled = true;
			this.lstKetQua.ItemHeight = 16;
			this.lstKetQua.Location = new System.Drawing.Point(27, 99);
			this.lstKetQua.Name = "lstKetQua";
			this.lstKetQua.Size = new System.Drawing.Size(575, 148);
			this.lstKetQua.TabIndex = 10;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(224, 255);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(180, 32);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "&Clear kết quả";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			this.btnClear.MouseEnter += new System.EventHandler(this.btnGPT_MouseEnter);
			this.btnClear.MouseLeave += new System.EventHandler(this.btnGPT_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(628, 299);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lstKetQua);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnGPT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nudC);
			this.Controls.Add(this.nudB);
			this.Controls.Add(this.nudA);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giải phương trình bậc 2";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGPT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstKetQua;
        private System.Windows.Forms.Button btnClear;
    }
}

