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
            this.buttondelete = new System.Windows.Forms.Button();
            this.dtAC = new System.Windows.Forms.DataGridView();
            this.textSearchAcc = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonaDD = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonsort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtAC)).BeginInit();
            this.SuspendLayout();
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(655, 256);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(97, 55);
            this.buttondelete.TabIndex = 0;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtAC
            // 
            this.dtAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAC.Location = new System.Drawing.Point(12, 104);
            this.dtAC.Name = "dtAC";
            this.dtAC.RowHeadersWidth = 62;
            this.dtAC.RowTemplate.Height = 28;
            this.dtAC.Size = new System.Drawing.Size(530, 150);
            this.dtAC.TabIndex = 1;
            // 
            // textSearchAcc
            // 
            this.textSearchAcc.Location = new System.Drawing.Point(467, 36);
            this.textSearchAcc.Name = "textSearchAcc";
            this.textSearchAcc.Size = new System.Drawing.Size(165, 26);
            this.textSearchAcc.TabIndex = 2;
            this.textSearchAcc.Enter += new System.EventHandler(this.textSearchAcc_Enter);
            this.textSearchAcc.Leave += new System.EventHandler(this.textSearchAcc_Leave);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(655, 22);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(97, 55);
            this.buttonsearch.TabIndex = 3;
            this.buttonsearch.Text = "SEARCH";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttonaDD
            // 
            this.buttonaDD.Location = new System.Drawing.Point(655, 104);
            this.buttonaDD.Name = "buttonaDD";
            this.buttonaDD.Size = new System.Drawing.Size(97, 55);
            this.buttonaDD.TabIndex = 4;
            this.buttonaDD.Text = "ADD";
            this.buttonaDD.UseVisualStyleBackColor = true;
            this.buttonaDD.Click += new System.EventHandler(this.buttonaDD_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(655, 178);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(97, 55);
            this.buttonupdate.TabIndex = 5;
            this.buttonupdate.Text = "UPDATE";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonsort
            // 
            this.buttonsort.Location = new System.Drawing.Point(655, 338);
            this.buttonsort.Name = "buttonsort";
            this.buttonsort.Size = new System.Drawing.Size(97, 55);
            this.buttonsort.TabIndex = 6;
            this.buttonsort.Text = "SORT";
            this.buttonsort.UseVisualStyleBackColor = true;
            this.buttonsort.Click += new System.EventHandler(this.buttonsort_Click);
            // 
            // Acount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsort);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonaDD);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.textSearchAcc);
            this.Controls.Add(this.dtAC);
            this.Controls.Add(this.buttondelete);
            this.Name = "Acount";
            this.Text = "Acount";
            this.Load += new System.EventHandler(this.Acount_Load);
            this.Enter += new System.EventHandler(this.Acount_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dtAC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.DataGridView dtAC;
        private System.Windows.Forms.TextBox textSearchAcc;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonaDD;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonsort;
    }
}