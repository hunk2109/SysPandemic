﻿namespace SysPandemic
{
    partial class topay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sid_rbtn = new System.Windows.Forms.RadioButton();
            this.spatient_rbtn = new System.Windows.Forms.RadioButton();
            this.sdoctor_rbtn = new System.Windows.Forms.RadioButton();
            this.snopay_rbtn = new System.Windows.Forms.RadioButton();
            this.spay_rbtn = new System.Windows.Forms.RadioButton();
            this.sprocedure_rbtn = new System.Windows.Forms.RadioButton();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(927, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sid_rbtn
            // 
            this.sid_rbtn.AutoSize = true;
            this.sid_rbtn.Location = new System.Drawing.Point(13, 16);
            this.sid_rbtn.Name = "sid_rbtn";
            this.sid_rbtn.Size = new System.Drawing.Size(36, 17);
            this.sid_rbtn.TabIndex = 1;
            this.sid_rbtn.TabStop = true;
            this.sid_rbtn.Text = "ID";
            this.sid_rbtn.UseVisualStyleBackColor = true;
            // 
            // spatient_rbtn
            // 
            this.spatient_rbtn.AutoSize = true;
            this.spatient_rbtn.Location = new System.Drawing.Point(55, 16);
            this.spatient_rbtn.Name = "spatient_rbtn";
            this.spatient_rbtn.Size = new System.Drawing.Size(67, 17);
            this.spatient_rbtn.TabIndex = 2;
            this.spatient_rbtn.TabStop = true;
            this.spatient_rbtn.Text = "Paciente";
            this.spatient_rbtn.UseVisualStyleBackColor = true;
            // 
            // sdoctor_rbtn
            // 
            this.sdoctor_rbtn.AutoSize = true;
            this.sdoctor_rbtn.Location = new System.Drawing.Point(128, 16);
            this.sdoctor_rbtn.Name = "sdoctor_rbtn";
            this.sdoctor_rbtn.Size = new System.Drawing.Size(68, 17);
            this.sdoctor_rbtn.TabIndex = 3;
            this.sdoctor_rbtn.TabStop = true;
            this.sdoctor_rbtn.Text = "Doctor/a";
            this.sdoctor_rbtn.UseVisualStyleBackColor = true;
            // 
            // snopay_rbtn
            // 
            this.snopay_rbtn.AutoSize = true;
            this.snopay_rbtn.Location = new System.Drawing.Point(368, 16);
            this.snopay_rbtn.Name = "snopay_rbtn";
            this.snopay_rbtn.Size = new System.Drawing.Size(81, 17);
            this.snopay_rbtn.TabIndex = 4;
            this.snopay_rbtn.TabStop = true;
            this.snopay_rbtn.Text = "NO Pagado";
            this.snopay_rbtn.UseVisualStyleBackColor = true;
            // 
            // spay_rbtn
            // 
            this.spay_rbtn.AutoSize = true;
            this.spay_rbtn.Location = new System.Drawing.Point(300, 16);
            this.spay_rbtn.Name = "spay_rbtn";
            this.spay_rbtn.Size = new System.Drawing.Size(62, 17);
            this.spay_rbtn.TabIndex = 5;
            this.spay_rbtn.TabStop = true;
            this.spay_rbtn.Text = "Pagado";
            this.spay_rbtn.UseVisualStyleBackColor = true;
            // 
            // sprocedure_rbtn
            // 
            this.sprocedure_rbtn.AutoSize = true;
            this.sprocedure_rbtn.Location = new System.Drawing.Point(202, 16);
            this.sprocedure_rbtn.Name = "sprocedure_rbtn";
            this.sprocedure_rbtn.Size = new System.Drawing.Size(92, 17);
            this.sprocedure_rbtn.TabIndex = 6;
            this.sprocedure_rbtn.TabStop = true;
            this.sprocedure_rbtn.Text = "Procedimiento";
            this.sprocedure_rbtn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(449, 13);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(328, 20);
            this.search_txt.TabIndex = 7;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(864, 11);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 8;
            this.refresh_btn.Text = "Refrescar";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(783, 11);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "Buscar";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // topay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(951, 365);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.sprocedure_rbtn);
            this.Controls.Add(this.spay_rbtn);
            this.Controls.Add(this.snopay_rbtn);
            this.Controls.Add(this.sdoctor_rbtn);
            this.Controls.Add(this.spatient_rbtn);
            this.Controls.Add(this.sid_rbtn);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "topay";
            this.Text = "Procedimiento a facturar";
            this.Load += new System.EventHandler(this.topay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sid_rbtn;
        private System.Windows.Forms.RadioButton spatient_rbtn;
        private System.Windows.Forms.RadioButton sdoctor_rbtn;
        private System.Windows.Forms.RadioButton snopay_rbtn;
        private System.Windows.Forms.RadioButton spay_rbtn;
        private System.Windows.Forms.RadioButton sprocedure_rbtn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button search_btn;
    }
}