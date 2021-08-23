namespace Tehtävä8
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
            this.paino_textBox = new System.Windows.Forms.TextBox();
            this.pituus_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laske_button = new System.Windows.Forms.Button();
            this.vastaus_label = new System.Windows.Forms.Label();
            this.kuvaus_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paino_textBox
            // 
            this.paino_textBox.Location = new System.Drawing.Point(177, 40);
            this.paino_textBox.Name = "paino_textBox";
            this.paino_textBox.Size = new System.Drawing.Size(100, 31);
            this.paino_textBox.TabIndex = 0;
            // 
            // pituus_textBox
            // 
            this.pituus_textBox.Location = new System.Drawing.Point(177, 77);
            this.pituus_textBox.Name = "pituus_textBox";
            this.pituus_textBox.Size = new System.Drawing.Size(100, 31);
            this.pituus_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anna pituus:";
            // 
            // laske_button
            // 
            this.laske_button.Location = new System.Drawing.Point(49, 123);
            this.laske_button.Name = "laske_button";
            this.laske_button.Size = new System.Drawing.Size(228, 35);
            this.laske_button.TabIndex = 4;
            this.laske_button.Text = "Laske painodeksi";
            this.laske_button.UseVisualStyleBackColor = true;
            this.laske_button.Click += new System.EventHandler(this.laske_button_Click);
            // 
            // vastaus_label
            // 
            this.vastaus_label.AutoSize = true;
            this.vastaus_label.Location = new System.Drawing.Point(51, 175);
            this.vastaus_label.Name = "vastaus_label";
            this.vastaus_label.Size = new System.Drawing.Size(26, 25);
            this.vastaus_label.TabIndex = 5;
            this.vastaus_label.Text = "X";
            this.vastaus_label.Visible = false;
            // 
            // kuvaus_label
            // 
            this.kuvaus_label.AutoSize = true;
            this.kuvaus_label.Location = new System.Drawing.Point(51, 209);
            this.kuvaus_label.Name = "kuvaus_label";
            this.kuvaus_label.Size = new System.Drawing.Size(26, 25);
            this.kuvaus_label.TabIndex = 6;
            this.kuvaus_label.Text = "X";
            this.kuvaus_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 263);
            this.Controls.Add(this.kuvaus_label);
            this.Controls.Add(this.vastaus_label);
            this.Controls.Add(this.laske_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pituus_textBox);
            this.Controls.Add(this.paino_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paino_textBox;
        private System.Windows.Forms.TextBox pituus_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button laske_button;
        private System.Windows.Forms.Label vastaus_label;
        private System.Windows.Forms.Label kuvaus_label;
    }
}

