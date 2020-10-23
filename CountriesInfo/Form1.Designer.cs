namespace CountriesInfo
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
            this.countriesCB = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.flagPB = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.zxc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qwe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.flagPB)).BeginInit();
            this.SuspendLayout();
            // 
            // countriesCB
            // 
            this.countriesCB.DisplayMember = "sdf";
            this.countriesCB.FormattingEnabled = true;
            this.countriesCB.Location = new System.Drawing.Point(425, 43);
            this.countriesCB.Name = "countriesCB";
            this.countriesCB.Size = new System.Drawing.Size(232, 21);
            this.countriesCB.Sorted = true;
            this.countriesCB.TabIndex = 0;
            this.countriesCB.Tag = "";
            this.countriesCB.Text = "Select a country...";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(663, 41);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // flagPB
            // 
            this.flagPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flagPB.Location = new System.Drawing.Point(425, 70);
            this.flagPB.Name = "flagPB";
            this.flagPB.Size = new System.Drawing.Size(456, 368);
            this.flagPB.TabIndex = 3;
            this.flagPB.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(12, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(21, 31);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = " ";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zxc,
            this.qwe,
            this.asd});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(18, 43);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(401, 395);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // zxc
            // 
            this.zxc.Text = "qwer";
            this.zxc.Width = 0;
            // 
            // qwe
            // 
            this.qwe.Text = "asdf";
            this.qwe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qwe.Width = 200;
            // 
            // asd
            // 
            this.asd.Text = "zxcv";
            this.asd.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.flagPB);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.countriesCB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flagPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countriesCB;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox flagPB;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader qwe;
        private System.Windows.Forms.ColumnHeader zxc;
        private System.Windows.Forms.ColumnHeader asd;
    }
}

