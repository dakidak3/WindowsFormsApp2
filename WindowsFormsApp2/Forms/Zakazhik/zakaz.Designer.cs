﻿namespace WindowsFormsApp2.Forms
{
    partial class zakaz
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.изделиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.изделиеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(705, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Конструктор изделий";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Новый заказ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(155, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 342);
            this.listBox1.TabIndex = 3;
            // 
            // изделиеBindingSource
            // 
            this.изделиеBindingSource.DataSource = typeof(WindowsFormsApp2.Изделие);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(292, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить изделие";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.изделиеBindingSource1;
            this.comboBox1.DisplayMember = "Артикул";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // изделиеBindingSource1
            // 
            this.изделиеBindingSource1.DataSource = typeof(WindowsFormsApp2.Изделие);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "zakaz";
            this.Text = "zakaz";
            this.Load += new System.EventHandler(this.zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изделиеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource изделиеBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.BindingSource изделиеBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}