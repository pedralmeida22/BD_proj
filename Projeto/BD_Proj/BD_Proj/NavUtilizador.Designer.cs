﻿namespace BD_Proj
{
    partial class NavUtilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavUtilizador));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.empresa_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(297, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-Vindo Utilizador1 !";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Condomínio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Casas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Contratos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // empresa_button
            // 
            this.empresa_button.Location = new System.Drawing.Point(622, 296);
            this.empresa_button.Name = "empresa_button";
            this.empresa_button.Size = new System.Drawing.Size(144, 52);
            this.empresa_button.TabIndex = 4;
            this.empresa_button.Text = "Empresas";
            this.empresa_button.UseVisualStyleBackColor = true;
            this.empresa_button.Click += new System.EventHandler(this.empresa_button_Click);
            // 
            // NavUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empresa_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NavUtilizador";
            this.Text = "NextHause";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavUtilizador_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button empresa_button;
    }
}