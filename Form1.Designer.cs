namespace Bai28
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.BtnOoO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // picOn
            // 
            this.picOn.Image = global::Bai28.Properties.Resources.On1;
            this.picOn.Location = new System.Drawing.Point(103, 49);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(155, 183);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn.TabIndex = 2;
            this.picOn.TabStop = false;
            this.picOn.Visible = false;
            // 
            // picOff
            // 
            this.picOff.Image = global::Bai28.Properties.Resources.off;
            this.picOff.Location = new System.Drawing.Point(103, 49);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(155, 183);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 2;
            this.picOff.TabStop = false;
            // 
            // BtnOoO
            // 
            this.BtnOoO.Location = new System.Drawing.Point(40, 253);
            this.BtnOoO.Name = "BtnOoO";
            this.BtnOoO.Size = new System.Drawing.Size(255, 23);
            this.BtnOoO.TabIndex = 3;
            this.BtnOoO.UseVisualStyleBackColor = true;
            this.BtnOoO.Click += new System.EventHandler(this.BtnOoO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(45, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Designed by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NguyenDoan";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(220, 328);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 364);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOoO);
            this.Controls.Add(this.picOff);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều khiển đèn";
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private PictureBox picOn;
        private PictureBox picOff;
        private Button BtnOoO;
        private Label label2;
        private Label label3;
        private Button BtnThoat;
    }
}