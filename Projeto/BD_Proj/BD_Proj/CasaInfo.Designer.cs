﻿namespace BD_Proj
{
    partial class CasaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasaInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.casas_listBox = new System.Windows.Forms.ListBox();
            this.morada_text = new System.Windows.Forms.TextBox();
            this.quartos_text = new System.Windows.Forms.TextBox();
            this.cidade_text = new System.Windows.Forms.TextBox();
            this.habitantes_text = new System.Windows.Forms.TextBox();
            this.descricao_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.condo_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Morada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Quartos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maximo Habitantes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Descrição";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ver Habitantes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // casas_listBox
            // 
            this.casas_listBox.FormattingEnabled = true;
            this.casas_listBox.ItemHeight = 16;
            this.casas_listBox.Location = new System.Drawing.Point(344, 103);
            this.casas_listBox.Name = "casas_listBox";
            this.casas_listBox.Size = new System.Drawing.Size(219, 244);
            this.casas_listBox.TabIndex = 12;
            // 
            // morada_text
            // 
            this.morada_text.Location = new System.Drawing.Point(837, 105);
            this.morada_text.Name = "morada_text";
            this.morada_text.ReadOnly = true;
            this.morada_text.Size = new System.Drawing.Size(100, 22);
            this.morada_text.TabIndex = 13;
            // 
            // quartos_text
            // 
            this.quartos_text.Location = new System.Drawing.Point(837, 167);
            this.quartos_text.Name = "quartos_text";
            this.quartos_text.ReadOnly = true;
            this.quartos_text.Size = new System.Drawing.Size(100, 22);
            this.quartos_text.TabIndex = 14;
            // 
            // cidade_text
            // 
            this.cidade_text.Location = new System.Drawing.Point(837, 217);
            this.cidade_text.Name = "cidade_text";
            this.cidade_text.ReadOnly = true;
            this.cidade_text.Size = new System.Drawing.Size(100, 22);
            this.cidade_text.TabIndex = 15;
            // 
            // habitantes_text
            // 
            this.habitantes_text.Location = new System.Drawing.Point(837, 270);
            this.habitantes_text.Name = "habitantes_text";
            this.habitantes_text.ReadOnly = true;
            this.habitantes_text.Size = new System.Drawing.Size(100, 22);
            this.habitantes_text.TabIndex = 16;
            // 
            // descricao_text
            // 
            this.descricao_text.Location = new System.Drawing.Point(837, 314);
            this.descricao_text.Name = "descricao_text";
            this.descricao_text.ReadOnly = true;
            this.descricao_text.Size = new System.Drawing.Size(100, 22);
            this.descricao_text.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descrição";
            // 
            // condo_box
            // 
            this.condo_box.Location = new System.Drawing.Point(837, 355);
            this.condo_box.Name = "condo_box";
            this.condo_box.ReadOnly = true;
            this.condo_box.Size = new System.Drawing.Size(100, 22);
            this.condo_box.TabIndex = 19;
            // 
            // CasaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 469);
            this.Controls.Add(this.condo_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descricao_text);
            this.Controls.Add(this.habitantes_text);
            this.Controls.Add(this.cidade_text);
            this.Controls.Add(this.quartos_text);
            this.Controls.Add(this.morada_text);
            this.Controls.Add(this.casas_listBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CasaInfo";
            this.Text = "CasaInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CasaInfo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox casas_listBox;
        private System.Windows.Forms.TextBox morada_text;
        private System.Windows.Forms.TextBox quartos_text;
        private System.Windows.Forms.TextBox cidade_text;
        private System.Windows.Forms.TextBox habitantes_text;
        private System.Windows.Forms.TextBox descricao_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox condo_box;
    }
}