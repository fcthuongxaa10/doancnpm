namespace doancnpm
{
    partial class Acount
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonsearchacc = new FontAwesome.Sharp.IconButton();
            this.buttonupdateacc = new FontAwesome.Sharp.IconButton();
            this.buttondeleteacc = new FontAwesome.Sharp.IconButton();
            this.buttonaddacc = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(43, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lí Account";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dataGridView3.Location = new System.Drawing.Point(20, 27);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(693, 337);
            this.dataGridView3.TabIndex = 1;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "ID nhân viên";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "UserName";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Password";
            this.Column17.MinimumWidth = 8;
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Ngày lập";
            this.Column18.MinimumWidth = 8;
            this.Column18.Name = "Column18";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 14;
            // 
            // buttonsearchacc
            // 
            this.buttonsearchacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonsearchacc.CausesValidation = false;
            this.buttonsearchacc.FlatAppearance.BorderSize = 5;
            this.buttonsearchacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsearchacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonsearchacc.ForeColor = System.Drawing.Color.White;
            this.buttonsearchacc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonsearchacc.IconColor = System.Drawing.Color.White;
            this.buttonsearchacc.IconSize = 20;
            this.buttonsearchacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsearchacc.Location = new System.Drawing.Point(807, 81);
            this.buttonsearchacc.Name = "buttonsearchacc";
            this.buttonsearchacc.Rotation = 0D;
            this.buttonsearchacc.Size = new System.Drawing.Size(133, 32);
            this.buttonsearchacc.TabIndex = 13;
            this.buttonsearchacc.Text = "SEARCH";
            this.buttonsearchacc.UseVisualStyleBackColor = false;
            // 
            // buttonupdateacc
            // 
            this.buttonupdateacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonupdateacc.CausesValidation = false;
            this.buttonupdateacc.FlatAppearance.BorderSize = 5;
            this.buttonupdateacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdateacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonupdateacc.ForeColor = System.Drawing.Color.White;
            this.buttonupdateacc.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.buttonupdateacc.IconColor = System.Drawing.Color.White;
            this.buttonupdateacc.IconSize = 20;
            this.buttonupdateacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonupdateacc.Location = new System.Drawing.Point(807, 347);
            this.buttonupdateacc.Name = "buttonupdateacc";
            this.buttonupdateacc.Rotation = 0D;
            this.buttonupdateacc.Size = new System.Drawing.Size(133, 50);
            this.buttonupdateacc.TabIndex = 12;
            this.buttonupdateacc.Text = "UPDATE";
            this.buttonupdateacc.UseVisualStyleBackColor = false;
            // 
            // buttondeleteacc
            // 
            this.buttondeleteacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttondeleteacc.CausesValidation = false;
            this.buttondeleteacc.FlatAppearance.BorderSize = 5;
            this.buttondeleteacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeleteacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttondeleteacc.ForeColor = System.Drawing.Color.White;
            this.buttondeleteacc.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttondeleteacc.IconColor = System.Drawing.Color.White;
            this.buttondeleteacc.IconSize = 20;
            this.buttondeleteacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondeleteacc.Location = new System.Drawing.Point(807, 248);
            this.buttondeleteacc.Name = "buttondeleteacc";
            this.buttondeleteacc.Rotation = 0D;
            this.buttondeleteacc.Size = new System.Drawing.Size(133, 50);
            this.buttondeleteacc.TabIndex = 11;
            this.buttondeleteacc.Text = "DELETE";
            this.buttondeleteacc.UseVisualStyleBackColor = false;
            // 
            // buttonaddacc
            // 
            this.buttonaddacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.buttonaddacc.CausesValidation = false;
            this.buttonaddacc.FlatAppearance.BorderSize = 5;
            this.buttonaddacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonaddacc.ForeColor = System.Drawing.Color.White;
            this.buttonaddacc.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonaddacc.IconColor = System.Drawing.Color.White;
            this.buttonaddacc.IconSize = 20;
            this.buttonaddacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonaddacc.Location = new System.Drawing.Point(807, 152);
            this.buttonaddacc.Name = "buttonaddacc";
            this.buttonaddacc.Rotation = 0D;
            this.buttonaddacc.Size = new System.Drawing.Size(133, 50);
            this.buttonaddacc.TabIndex = 10;
            this.buttonaddacc.Text = "ADD";
            this.buttonaddacc.UseVisualStyleBackColor = false;
            // 
            // Acount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1154, 641);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonsearchacc);
            this.Controls.Add(this.buttonupdateacc);
            this.Controls.Add(this.buttondeleteacc);
            this.Controls.Add(this.buttonaddacc);
            this.Controls.Add(this.groupBox1);
            this.Name = "Acount";
            this.Text = "Acount";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private FontAwesome.Sharp.IconButton buttonaddacc;
        private FontAwesome.Sharp.IconButton buttondeleteacc;
        private FontAwesome.Sharp.IconButton buttonupdateacc;
        private FontAwesome.Sharp.IconButton buttonsearchacc;
        private System.Windows.Forms.TextBox textBox1;
    }
}