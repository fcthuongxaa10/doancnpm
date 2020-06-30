namespace doancnpm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buttonsearchacc = new FontAwesome.Sharp.IconButton();
            this.buttonupdateacc = new FontAwesome.Sharp.IconButton();
            this.buttondeleteacc = new FontAwesome.Sharp.IconButton();
            this.buttonaddacc = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.buttonsearchacc);
            this.panel1.Controls.Add(this.buttonupdateacc);
            this.panel1.Controls.Add(this.buttondeleteacc);
            this.panel1.Controls.Add(this.buttonaddacc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 514);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 395);
            this.dataGridView1.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(644, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(140, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // buttonsearchacc
            // 
            this.buttonsearchacc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonsearchacc.CausesValidation = false;
            this.buttonsearchacc.FlatAppearance.BorderSize = 0;
            this.buttonsearchacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsearchacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonsearchacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonsearchacc.ForeColor = System.Drawing.Color.Black;
            this.buttonsearchacc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonsearchacc.IconColor = System.Drawing.Color.Black;
            this.buttonsearchacc.IconSize = 15;
            this.buttonsearchacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsearchacc.Location = new System.Drawing.Point(788, 50);
            this.buttonsearchacc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsearchacc.Name = "buttonsearchacc";
            this.buttonsearchacc.Rotation = 0D;
            this.buttonsearchacc.Size = new System.Drawing.Size(80, 20);
            this.buttonsearchacc.TabIndex = 19;
            this.buttonsearchacc.Text = "SEARCH";
            this.buttonsearchacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonsearchacc.UseVisualStyleBackColor = false;
            this.buttonsearchacc.Click += new System.EventHandler(this.buttonsearchacc_Click);
            // 
            // buttonupdateacc
            // 
            this.buttonupdateacc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonupdateacc.CausesValidation = false;
            this.buttonupdateacc.FlatAppearance.BorderSize = 0;
            this.buttonupdateacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdateacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonupdateacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonupdateacc.ForeColor = System.Drawing.Color.Black;
            this.buttonupdateacc.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.buttonupdateacc.IconColor = System.Drawing.Color.Black;
            this.buttonupdateacc.IconSize = 15;
            this.buttonupdateacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonupdateacc.Location = new System.Drawing.Point(210, 49);
            this.buttonupdateacc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonupdateacc.Name = "buttonupdateacc";
            this.buttonupdateacc.Rotation = 0D;
            this.buttonupdateacc.Size = new System.Drawing.Size(80, 20);
            this.buttonupdateacc.TabIndex = 18;
            this.buttonupdateacc.Text = "UPDATE";
            this.buttonupdateacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonupdateacc.UseVisualStyleBackColor = false;
            this.buttonupdateacc.Click += new System.EventHandler(this.buttonupdateacc_Click);
            // 
            // buttondeleteacc
            // 
            this.buttondeleteacc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttondeleteacc.CausesValidation = false;
            this.buttondeleteacc.FlatAppearance.BorderSize = 0;
            this.buttondeleteacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeleteacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttondeleteacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttondeleteacc.ForeColor = System.Drawing.Color.Black;
            this.buttondeleteacc.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttondeleteacc.IconColor = System.Drawing.Color.Black;
            this.buttondeleteacc.IconSize = 15;
            this.buttondeleteacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondeleteacc.Location = new System.Drawing.Point(126, 49);
            this.buttondeleteacc.Margin = new System.Windows.Forms.Padding(2);
            this.buttondeleteacc.Name = "buttondeleteacc";
            this.buttondeleteacc.Rotation = 0D;
            this.buttondeleteacc.Size = new System.Drawing.Size(80, 20);
            this.buttondeleteacc.TabIndex = 17;
            this.buttondeleteacc.Text = "DELETE";
            this.buttondeleteacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttondeleteacc.UseVisualStyleBackColor = false;
            this.buttondeleteacc.Click += new System.EventHandler(this.buttondeleteacc_Click);
            // 
            // buttonaddacc
            // 
            this.buttonaddacc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonaddacc.CausesValidation = false;
            this.buttonaddacc.FlatAppearance.BorderSize = 0;
            this.buttonaddacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddacc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonaddacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonaddacc.ForeColor = System.Drawing.Color.Black;
            this.buttonaddacc.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonaddacc.IconColor = System.Drawing.Color.Black;
            this.buttonaddacc.IconSize = 15;
            this.buttonaddacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonaddacc.Location = new System.Drawing.Point(42, 49);
            this.buttonaddacc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonaddacc.Name = "buttonaddacc";
            this.buttonaddacc.Rotation = 0D;
            this.buttonaddacc.Size = new System.Drawing.Size(80, 20);
            this.buttonaddacc.TabIndex = 16;
            this.buttonaddacc.Text = "ADD";
            this.buttonaddacc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonaddacc.UseVisualStyleBackColor = false;
            this.buttonaddacc.Click += new System.EventHandler(this.buttonaddacc_Click);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(880, 514);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HangHoa";
            this.Text = "HangHoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton buttonsearchacc;
        private FontAwesome.Sharp.IconButton buttonupdateacc;
        private FontAwesome.Sharp.IconButton buttondeleteacc;
        private FontAwesome.Sharp.IconButton buttonaddacc;
    }
}