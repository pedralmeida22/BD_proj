﻿namespace BD_Proj
{
    partial class Navigation
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
            this.casasBt = new System.Windows.Forms.Button();
            this.inquilinoBt = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.navpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.condominio_bt = new System.Windows.Forms.Button();
            this.navpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // casasBt
            // 
            this.casasBt.Location = new System.Drawing.Point(12, 41);
            this.casasBt.Name = "casasBt";
            this.casasBt.Size = new System.Drawing.Size(96, 23);
            this.casasBt.TabIndex = 0;
            this.casasBt.Text = "Casas";
            this.casasBt.UseVisualStyleBackColor = true;
            this.casasBt.Click += new System.EventHandler(this.casasBt_Click);
            // 
            // inquilinoBt
            // 
            this.inquilinoBt.Location = new System.Drawing.Point(12, 79);
            this.inquilinoBt.Name = "inquilinoBt";
            this.inquilinoBt.Size = new System.Drawing.Size(96, 44);
            this.inquilinoBt.TabIndex = 1;
            this.inquilinoBt.Text = "Dados Pessoais";
            this.inquilinoBt.UseVisualStyleBackColor = true;
            this.inquilinoBt.Click += new System.EventHandler(this.inquilinoBt_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Location = new System.Drawing.Point(12, 9);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(43, 17);
            this.menuLabel.TabIndex = 2;
            this.menuLabel.Text = "Menu";
            // 
            // navpanel
            // 
            this.navpanel.Controls.Add(this.button1);
            this.navpanel.Location = new System.Drawing.Point(114, 12);
            this.navpanel.Name = "navpanel";
            this.navpanel.Size = new System.Drawing.Size(798, 497);
            this.navpanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Connection to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // condominio_bt
            // 
            this.condominio_bt.Location = new System.Drawing.Point(11, 136);
            this.condominio_bt.Name = "condominio_bt";
            this.condominio_bt.Size = new System.Drawing.Size(97, 23);
            this.condominio_bt.TabIndex = 1;
            this.condominio_bt.Text = "Condominios";
            this.condominio_bt.UseVisualStyleBackColor = true;
            this.condominio_bt.Click += new System.EventHandler(this.condominio_bt_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 522);
            this.Controls.Add(this.condominio_bt);
            this.Controls.Add(this.navpanel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.inquilinoBt);
            this.Controls.Add(this.casasBt);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.navpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button casasBt;
        private System.Windows.Forms.Button inquilinoBt;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button condominio_bt;
    }
}