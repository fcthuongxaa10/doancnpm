﻿namespace doancnpm
{
    partial class HangHoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonsearchhang = new FontAwesome.Sharp.IconButton();
            this.buttonupdatehang = new FontAwesome.Sharp.IconButton();
            this.buttondelehang = new FontAwesome.Sharp.IconButton();
            this.buttonaddhang = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(21, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lí Hàng Hóa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(20, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá Bán";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Sản Xuất";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Hết Hạn";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số Lượng";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Đơn Vị Tính";
            this.Column7.Name = "Column7";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 13;
            // 
            // buttonsearchhang
            // 
            this.buttonsearchhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonsearchhang.CausesValidation = false;
            this.buttonsearchhang.FlatAppearance.BorderSize = 5;
            this.buttonsearchhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsearchhang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonsearchhang.ForeColor = System.Drawing.Color.White;
            this.buttonsearchhang.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonsearchhang.IconColor = System.Drawing.Color.White;
            this.buttonsearchhang.IconSize = 20;
            this.buttonsearchhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsearchhang.Location = new System.Drawing.Point(721, 93);
            this.buttonsearchhang.Name = "buttonsearchhang";
            this.buttonsearchhang.Rotation = 0D;
            this.buttonsearchhang.Size = new System.Drawing.Size(133, 32);
            this.buttonsearchhang.TabIndex = 12;
            this.buttonsearchhang.Text = "SEARCH";
            this.buttonsearchhang.UseVisualStyleBackColor = false;
            // 
            // buttonupdatehang
            // 
            this.buttonupdatehang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonupdatehang.CausesValidation = false;
            this.buttonupdatehang.FlatAppearance.BorderSize = 5;
            this.buttonupdatehang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdatehang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonupdatehang.ForeColor = System.Drawing.Color.White;
            this.buttonupdatehang.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.buttonupdatehang.IconColor = System.Drawing.Color.White;
            this.buttonupdatehang.IconSize = 20;
            this.buttonupdatehang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonupdatehang.Location = new System.Drawing.Point(721, 364);
            this.buttonupdatehang.Name = "buttonupdatehang";
            this.buttonupdatehang.Rotation = 0D;
            this.buttonupdatehang.Size = new System.Drawing.Size(133, 50);
            this.buttonupdatehang.TabIndex = 11;
            this.buttonupdatehang.Text = "UPDATE";
            this.buttonupdatehang.UseVisualStyleBackColor = false;
            // 
            // buttondelehang
            // 
            this.buttondelehang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttondelehang.CausesValidation = false;
            this.buttondelehang.FlatAppearance.BorderSize = 5;
            this.buttondelehang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelehang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttondelehang.ForeColor = System.Drawing.Color.White;
            this.buttondelehang.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttondelehang.IconColor = System.Drawing.Color.White;
            this.buttondelehang.IconSize = 20;
            this.buttondelehang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondelehang.Location = new System.Drawing.Point(721, 272);
            this.buttondelehang.Name = "buttondelehang";
            this.buttondelehang.Rotation = 0D;
            this.buttondelehang.Size = new System.Drawing.Size(133, 50);
            this.buttondelehang.TabIndex = 10;
            this.buttondelehang.Text = "DELETE";
            this.buttondelehang.UseVisualStyleBackColor = false;
            // 
            // buttonaddhang
            // 
            this.buttonaddhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonaddhang.CausesValidation = false;
            this.buttonaddhang.FlatAppearance.BorderSize = 5;
            this.buttonaddhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddhang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonaddhang.ForeColor = System.Drawing.Color.White;
            this.buttonaddhang.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonaddhang.IconColor = System.Drawing.Color.White;
            this.buttonaddhang.IconSize = 20;
            this.buttonaddhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonaddhang.Location = new System.Drawing.Point(721, 180);
            this.buttonaddhang.Name = "buttonaddhang";
            this.buttonaddhang.Rotation = 0D;
            this.buttonaddhang.Size = new System.Drawing.Size(133, 50);
            this.buttonaddhang.TabIndex = 9;
            this.buttonaddhang.Text = "ADD";
            this.buttonaddhang.UseVisualStyleBackColor = false;
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1056, 755);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonsearchhang);
            this.Controls.Add(this.buttonupdatehang);
            this.Controls.Add(this.buttondelehang);
            this.Controls.Add(this.buttonaddhang);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "HangHoa";
            this.Text = "HangHoa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private FontAwesome.Sharp.IconButton buttonaddhang;
        private FontAwesome.Sharp.IconButton buttondelehang;
        private FontAwesome.Sharp.IconButton buttonupdatehang;
        private FontAwesome.Sharp.IconButton buttonsearchhang;
        private System.Windows.Forms.TextBox textBox1;
    }
}