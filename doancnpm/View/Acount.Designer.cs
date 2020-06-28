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
            this.textSearchAcc = new System.Windows.Forms.TextBox();
            this.buttonsearchacc = new FontAwesome.Sharp.IconButton();
            this.buttonupdateacc = new FontAwesome.Sharp.IconButton();
            this.buttondeleteacc = new FontAwesome.Sharp.IconButton();
            this.buttonaddacc = new FontAwesome.Sharp.IconButton();
            this.dtAC = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtAC)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearchAcc
            // 
            this.textSearchAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchAcc.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textSearchAcc.Location = new System.Drawing.Point(578, 115);
            this.textSearchAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSearchAcc.Name = "textSearchAcc";
            this.textSearchAcc.Size = new System.Drawing.Size(235, 35);
            this.textSearchAcc.TabIndex = 14;
            this.textSearchAcc.Text = "Nhập họ tên user";
            this.textSearchAcc.Enter += new System.EventHandler(this.textSearchAcc_Enter);
            this.textSearchAcc.Leave += new System.EventHandler(this.textSearchAcc_Leave);
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
            this.buttonsearchacc.Location = new System.Drawing.Point(895, 115);
            this.buttonsearchacc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsearchacc.Name = "buttonsearchacc";
            this.buttonsearchacc.Rotation = 0D;
            this.buttonsearchacc.Size = new System.Drawing.Size(150, 40);
            this.buttonsearchacc.TabIndex = 13;
            this.buttonsearchacc.Text = "SEARCH";
            this.buttonsearchacc.UseVisualStyleBackColor = false;
            this.buttonsearchacc.Click += new System.EventHandler(this.buttonsearchacc_Click);
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
            this.buttonupdateacc.Location = new System.Drawing.Point(895, 503);
            this.buttonupdateacc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonupdateacc.Name = "buttonupdateacc";
            this.buttonupdateacc.Rotation = 0D;
            this.buttonupdateacc.Size = new System.Drawing.Size(150, 62);
            this.buttonupdateacc.TabIndex = 12;
            this.buttonupdateacc.Text = "UPDATE";
            this.buttonupdateacc.UseVisualStyleBackColor = false;
            this.buttonupdateacc.Click += new System.EventHandler(this.buttonupdateacc_Click);
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
            this.buttondeleteacc.Location = new System.Drawing.Point(895, 357);
            this.buttondeleteacc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttondeleteacc.Name = "buttondeleteacc";
            this.buttondeleteacc.Rotation = 0D;
            this.buttondeleteacc.Size = new System.Drawing.Size(150, 62);
            this.buttondeleteacc.TabIndex = 11;
            this.buttondeleteacc.Text = "DELETE";
            this.buttondeleteacc.UseVisualStyleBackColor = false;
            this.buttondeleteacc.Click += new System.EventHandler(this.buttondeleteacc_Click);
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
            this.buttonaddacc.Location = new System.Drawing.Point(895, 229);
            this.buttonaddacc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonaddacc.Name = "buttonaddacc";
            this.buttonaddacc.Rotation = 0D;
            this.buttonaddacc.Size = new System.Drawing.Size(150, 62);
            this.buttonaddacc.TabIndex = 10;
            this.buttonaddacc.Text = "ADD";
            this.buttonaddacc.UseVisualStyleBackColor = false;
            this.buttonaddacc.Click += new System.EventHandler(this.buttonaddacc_Click);
            // 
            // dtAC
            // 
            this.dtAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAC.Location = new System.Drawing.Point(29, 178);
            this.dtAC.Name = "dtAC";
            this.dtAC.RowHeadersWidth = 62;
            this.dtAC.RowTemplate.Height = 28;
            this.dtAC.Size = new System.Drawing.Size(818, 402);
            this.dtAC.TabIndex = 15;
//            this.dtAC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.CausesValidation = false;
            this.iconButton1.FlatAppearance.BorderSize = 5;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(905, 614);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(150, 62);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "SORT";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Acount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1298, 801);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dtAC);
            this.Controls.Add(this.textSearchAcc);
            this.Controls.Add(this.buttonsearchacc);
            this.Controls.Add(this.buttonupdateacc);
            this.Controls.Add(this.buttondeleteacc);
            this.Controls.Add(this.buttonaddacc);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Acount";
            this.Text = "Acount";
            this.Load += new System.EventHandler(this.Acount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton buttonaddacc;
        private FontAwesome.Sharp.IconButton buttondeleteacc;
        private FontAwesome.Sharp.IconButton buttonupdateacc;
        private FontAwesome.Sharp.IconButton buttonsearchacc;
        private System.Windows.Forms.TextBox textSearchAcc;
        private System.Windows.Forms.DataGridView dtAC;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}