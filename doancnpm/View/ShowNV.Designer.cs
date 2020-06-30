namespace doancnpm
{
    partial class ShowNV
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.buttonsearch = new FontAwesome.Sharp.IconButton();
            this.buttoneditnv = new FontAwesome.Sharp.IconButton();
            this.buttonxoanv = new FontAwesome.Sharp.IconButton();
            this.buttonaddnhanvien = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(438, 35);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(104, 20);
            this.txtsearch.TabIndex = 12;
            // 
            // buttonsearch
            // 
            this.buttonsearch.BackColor = System.Drawing.Color.Turquoise;
            this.buttonsearch.CausesValidation = false;
            this.buttonsearch.FlatAppearance.BorderSize = 0;
            this.buttonsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonsearch.ForeColor = System.Drawing.Color.Black;
            this.buttonsearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonsearch.IconColor = System.Drawing.Color.Black;
            this.buttonsearch.IconSize = 20;
            this.buttonsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsearch.Location = new System.Drawing.Point(559, 35);
            this.buttonsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Rotation = 0D;
            this.buttonsearch.Size = new System.Drawing.Size(100, 20);
            this.buttonsearch.TabIndex = 11;
            this.buttonsearch.Text = "SEARCH";
            this.buttonsearch.UseVisualStyleBackColor = false;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttoneditnv
            // 
            this.buttoneditnv.BackColor = System.Drawing.Color.Turquoise;
            this.buttoneditnv.CausesValidation = false;
            this.buttoneditnv.FlatAppearance.BorderSize = 0;
            this.buttoneditnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneditnv.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttoneditnv.ForeColor = System.Drawing.Color.Black;
            this.buttoneditnv.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.buttoneditnv.IconColor = System.Drawing.Color.Black;
            this.buttoneditnv.IconSize = 20;
            this.buttoneditnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneditnv.Location = new System.Drawing.Point(230, 24);
            this.buttoneditnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoneditnv.Name = "buttoneditnv";
            this.buttoneditnv.Rotation = 0D;
            this.buttoneditnv.Size = new System.Drawing.Size(100, 31);
            this.buttoneditnv.TabIndex = 10;
            this.buttoneditnv.Text = "UPDATE";
            this.buttoneditnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttoneditnv.UseVisualStyleBackColor = false;
            this.buttoneditnv.Click += new System.EventHandler(this.buttoneditnv_Click);
            // 
            // buttonxoanv
            // 
            this.buttonxoanv.BackColor = System.Drawing.Color.Turquoise;
            this.buttonxoanv.CausesValidation = false;
            this.buttonxoanv.FlatAppearance.BorderSize = 0;
            this.buttonxoanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonxoanv.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonxoanv.ForeColor = System.Drawing.Color.Black;
            this.buttonxoanv.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.buttonxoanv.IconColor = System.Drawing.Color.Black;
            this.buttonxoanv.IconSize = 20;
            this.buttonxoanv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonxoanv.Location = new System.Drawing.Point(126, 24);
            this.buttonxoanv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonxoanv.Name = "buttonxoanv";
            this.buttonxoanv.Rotation = 0D;
            this.buttonxoanv.Size = new System.Drawing.Size(100, 31);
            this.buttonxoanv.TabIndex = 9;
            this.buttonxoanv.Text = "DELETE";
            this.buttonxoanv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonxoanv.UseVisualStyleBackColor = false;
            this.buttonxoanv.Click += new System.EventHandler(this.buttonxoanv_Click);
            // 
            // buttonaddnhanvien
            // 
            this.buttonaddnhanvien.BackColor = System.Drawing.Color.Turquoise;
            this.buttonaddnhanvien.CausesValidation = false;
            this.buttonaddnhanvien.FlatAppearance.BorderSize = 0;
            this.buttonaddnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddnhanvien.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonaddnhanvien.ForeColor = System.Drawing.Color.Black;
            this.buttonaddnhanvien.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonaddnhanvien.IconColor = System.Drawing.Color.Black;
            this.buttonaddnhanvien.IconSize = 20;
            this.buttonaddnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonaddnhanvien.Location = new System.Drawing.Point(22, 24);
            this.buttonaddnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonaddnhanvien.Name = "buttonaddnhanvien";
            this.buttonaddnhanvien.Rotation = 0D;
            this.buttonaddnhanvien.Size = new System.Drawing.Size(100, 31);
            this.buttonaddnhanvien.TabIndex = 8;
            this.buttonaddnhanvien.Text = "ADD";
            this.buttonaddnhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonaddnhanvien.UseVisualStyleBackColor = false;
            this.buttonaddnhanvien.Click += new System.EventHandler(this.buttonaddnhanvien_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 404);
            this.dataGridView1.TabIndex = 14;
            // 
            // ShowNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(699, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttoneditnv);
            this.Controls.Add(this.buttonxoanv);
            this.Controls.Add(this.buttonaddnhanvien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowNV";
            this.Text = "ShowNV";
            this.Load += new System.EventHandler(this.ShowNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton buttonaddnhanvien;
        private FontAwesome.Sharp.IconButton buttonxoanv;
        private FontAwesome.Sharp.IconButton buttoneditnv;
        private FontAwesome.Sharp.IconButton buttonsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}