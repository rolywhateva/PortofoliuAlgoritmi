﻿namespace FractalulLuiKoch
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonDesenare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1205, 765);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ButtonDesenare
            // 
            this.ButtonDesenare.Location = new System.Drawing.Point(909, 820);
            this.ButtonDesenare.Name = "ButtonDesenare";
            this.ButtonDesenare.Size = new System.Drawing.Size(75, 23);
            this.ButtonDesenare.TabIndex = 1;
            this.ButtonDesenare.Text = "Desenare";
            this.ButtonDesenare.UseVisualStyleBackColor = true;
            this.ButtonDesenare.Click += new System.EventHandler(this.ButtonDesenare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 855);
            this.Controls.Add(this.ButtonDesenare);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Fulg de nea ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ButtonDesenare;
    }
}

