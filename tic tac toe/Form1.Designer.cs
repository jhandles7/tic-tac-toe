﻿
namespace tic_tac_toe
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tile1 = new System.Windows.Forms.Button();
            this.tile2 = new System.Windows.Forms.Button();
            this.tile3 = new System.Windows.Forms.Button();
            this.tile4 = new System.Windows.Forms.Button();
            this.tile5 = new System.Windows.Forms.Button();
            this.tile6 = new System.Windows.Forms.Button();
            this.tile8 = new System.Windows.Forms.Button();
            this.tile7 = new System.Windows.Forms.Button();
            this.tile9 = new System.Windows.Forms.Button();
            this.btn_play_again = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tile1
            // 
            this.tile1.Location = new System.Drawing.Point(0, 20);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(91, 76);
            this.tile1.TabIndex = 0;
            this.tile1.UseVisualStyleBackColor = true;
            // 
            // tile2
            // 
            this.tile2.Location = new System.Drawing.Point(97, 20);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(91, 76);
            this.tile2.TabIndex = 1;
            this.tile2.UseVisualStyleBackColor = true;
            // 
            // tile3
            // 
            this.tile3.Location = new System.Drawing.Point(194, 20);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(91, 76);
            this.tile3.TabIndex = 2;
            this.tile3.UseVisualStyleBackColor = true;
            // 
            // tile4
            // 
            this.tile4.Location = new System.Drawing.Point(0, 102);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(91, 76);
            this.tile4.TabIndex = 3;
            this.tile4.UseVisualStyleBackColor = true;
            // 
            // tile5
            // 
            this.tile5.Location = new System.Drawing.Point(97, 102);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(91, 76);
            this.tile5.TabIndex = 4;
            this.tile5.UseVisualStyleBackColor = true;
            // 
            // tile6
            // 
            this.tile6.Location = new System.Drawing.Point(194, 102);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(91, 76);
            this.tile6.TabIndex = 5;
            this.tile6.UseVisualStyleBackColor = true;
            // 
            // tile8
            // 
            this.tile8.Location = new System.Drawing.Point(97, 184);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(91, 76);
            this.tile8.TabIndex = 7;
            this.tile8.UseVisualStyleBackColor = true;
            // 
            // tile7
            // 
            this.tile7.Location = new System.Drawing.Point(0, 184);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(91, 76);
            this.tile7.TabIndex = 8;
            this.tile7.UseVisualStyleBackColor = true;
            // 
            // tile9
            // 
            this.tile9.Location = new System.Drawing.Point(194, 184);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(91, 76);
            this.tile9.TabIndex = 9;
            this.tile9.UseVisualStyleBackColor = true;
            // 
            // btn_play_again
            // 
            this.btn_play_again.Location = new System.Drawing.Point(97, 271);
            this.btn_play_again.Name = "btn_play_again";
            this.btn_play_again.Size = new System.Drawing.Size(83, 29);
            this.btn_play_again.TabIndex = 10;
            this.btn_play_again.Text = "Play Again";
            this.btn_play_again.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(286, 312);
            this.Controls.Add(this.btn_play_again);
            this.Controls.Add(this.tile9);
            this.Controls.Add(this.tile7);
            this.Controls.Add(this.tile8);
            this.Controls.Add(this.tile6);
            this.Controls.Add(this.tile5);
            this.Controls.Add(this.tile4);
            this.Controls.Add(this.tile3);
            this.Controls.Add(this.tile2);
            this.Controls.Add(this.tile1);
            this.Name = "form1";
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tile1;
        private System.Windows.Forms.Button tile2;
        private System.Windows.Forms.Button tile3;
        private System.Windows.Forms.Button tile4;
        private System.Windows.Forms.Button tile5;
        private System.Windows.Forms.Button tile6;
        private System.Windows.Forms.Button tile8;
        private System.Windows.Forms.Button tile7;
        private System.Windows.Forms.Button tile9;
        private System.Windows.Forms.Button btn_play_again;
    }
}
