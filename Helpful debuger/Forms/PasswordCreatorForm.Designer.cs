﻿
namespace Helpful_debugger.Forms
{
    partial class PasswordCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordCreatorForm));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LegthNumberic = new System.Windows.Forms.NumericUpDown();
            this.NumberOFNumberic = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LegthNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOFNumberic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Passwords";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 382);
            this.textBox1.TabIndex = 1;
            // 
            // LegthNumberic
            // 
            this.LegthNumberic.Location = new System.Drawing.Point(12, 452);
            this.LegthNumberic.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.LegthNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LegthNumberic.Name = "LegthNumberic";
            this.LegthNumberic.Size = new System.Drawing.Size(776, 20);
            this.LegthNumberic.TabIndex = 3;
            this.LegthNumberic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumberOFNumberic
            // 
            this.NumberOFNumberic.Location = new System.Drawing.Point(12, 413);
            this.NumberOFNumberic.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumberOFNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOFNumberic.Name = "NumberOFNumberic";
            this.NumberOFNumberic.Size = new System.Drawing.Size(776, 20);
            this.NumberOFNumberic.TabIndex = 4;
            this.NumberOFNumberic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "# Of Passwords";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Length Of Passwords";
            // 
            // PasswordCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOFNumberic);
            this.Controls.Add(this.LegthNumberic);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordCreatorForm";
            this.Text = "Helpful Debugger - PasswordCreator";
            ((System.ComponentModel.ISupportInitialize)(this.LegthNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOFNumberic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown LegthNumberic;
        private System.Windows.Forms.NumericUpDown NumberOFNumberic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}