
namespace EjerciciosCap10_12
{
    partial class MainForms
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
            this.Capitulo10Button = new System.Windows.Forms.Button();
            this.Capitulo12Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Capitulo10Button
            // 
            this.Capitulo10Button.Location = new System.Drawing.Point(48, 44);
            this.Capitulo10Button.Name = "Capitulo10Button";
            this.Capitulo10Button.Size = new System.Drawing.Size(75, 39);
            this.Capitulo10Button.TabIndex = 0;
            this.Capitulo10Button.Text = "Capitulo 10";
            this.Capitulo10Button.UseVisualStyleBackColor = true;
            this.Capitulo10Button.Click += new System.EventHandler(this.Capitulo10Button_Click);
            // 
            // Capitulo12Button
            // 
            this.Capitulo12Button.Location = new System.Drawing.Point(129, 44);
            this.Capitulo12Button.Name = "Capitulo12Button";
            this.Capitulo12Button.Size = new System.Drawing.Size(75, 39);
            this.Capitulo12Button.TabIndex = 1;
            this.Capitulo12Button.Text = "Capitulo 12";
            this.Capitulo12Button.UseVisualStyleBackColor = true;
            this.Capitulo12Button.Click += new System.EventHandler(this.Capitulo12Button_Click);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 124);
            this.Controls.Add(this.Capitulo12Button);
            this.Controls.Add(this.Capitulo10Button);
            this.Name = "MainForms";
            this.Text = "MainForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Capitulo10Button;
        private System.Windows.Forms.Button Capitulo12Button;
    }
}

