
namespace WinFormCRUD
{
    partial class Form1
    {
      
        private System.ComponentModel.IContainer components = null;

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
            this.listBox_fruits = new System.Windows.Forms.ListBox();
            this.GyumiNev = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_fruits
            // 
            this.listBox_fruits.FormattingEnabled = true;
            this.listBox_fruits.ItemHeight = 16;
            this.listBox_fruits.Location = new System.Drawing.Point(13, 13);
            this.listBox_fruits.Name = "listBox_fruits";
            this.listBox_fruits.Size = new System.Drawing.Size(162, 420);
            this.listBox_fruits.TabIndex = 0;
            this.listBox_fruits.SelectedIndexChanged += new System.EventHandler(this.listBox_fruits_SelectedIndexChanged);
            // 
            // GyumiNev
            // 
            this.GyumiNev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GyumiNev.Location = new System.Drawing.Point(181, 13);
            this.GyumiNev.Name = "GyumiNev";
            this.GyumiNev.Size = new System.Drawing.Size(137, 22);
            this.GyumiNev.TabIndex = 2;
            this.GyumiNev.Text = "> Gyümölcs neve:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(304, 13);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(164, 22);
            this.textBox_nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "> Gyümölcs ára/KG:";
            // 
            // textBox_ar
            // 
            this.textBox_ar.Location = new System.Drawing.Point(324, 44);
            this.textBox_ar.Name = "textBox_ar";
            this.textBox_ar.Size = new System.Drawing.Size(144, 22);
            this.textBox_ar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(181, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "> Gyümölcs db:";
            // 
            // textBox_db
            // 
            this.textBox_db.Location = new System.Drawing.Point(304, 77);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(164, 22);
            this.textBox_db.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(181, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "> Gyümölcs Beszerzése:";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(349, 108);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(119, 22);
            this.textBox_date.TabIndex = 9;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Red;
            this.button_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_update.Location = new System.Drawing.Point(184, 136);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(284, 31);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Szerkesztés";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.GyumiNev);
            this.Controls.Add(this.listBox_fruits);
            this.Name = "Form1";
            this.Text = "WinForm CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_fruits;
        private System.Windows.Forms.Label GyumiNev;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button button_update;
    }
}

