﻿namespace HomeControl
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(181, 12);
            button1.Name = "button1";
            button1.Size = new Size(166, 23);
            button1.TabIndex = 0;
            button1.Text = "Таблица квартир";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(388, 12);
            button2.Name = "button2";
            button2.Size = new Size(166, 23);
            button2.TabIndex = 1;
            button2.Text = "Таблица типо платежей";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(607, 12);
            button3.Name = "button3";
            button3.Size = new Size(166, 23);
            button3.TabIndex = 2;
            button3.Text = "Таблица платежей";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(811, 372);
            dataGridView1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(137, 438);
            button4.Name = "button4";
            button4.Size = new Size(166, 23);
            button4.TabIndex = 4;
            button4.Text = "Запрос 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(333, 438);
            button5.Name = "button5";
            button5.Size = new Size(166, 23);
            button5.TabIndex = 5;
            button5.Text = "Запрос 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(528, 438);
            button6.Name = "button6";
            button6.Size = new Size(143, 23);
            button6.TabIndex = 6;
            button6.Text = "Запрос 3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(697, 438);
            button7.Name = "button7";
            button7.Size = new Size(138, 23);
            button7.TabIndex = 7;
            button7.Text = "Запрос 4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 483);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домоуправление";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
