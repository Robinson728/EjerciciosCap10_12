
namespace EjerciciosCap10_12
{
    partial class Capitulo10
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
            this.Ejercicio1Button = new System.Windows.Forms.Button();
            this.Ejercicio2Button = new System.Windows.Forms.Button();
            this.Ejercicio3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejercicio1Button
            // 
            this.Ejercicio1Button.Location = new System.Drawing.Point(12, 12);
            this.Ejercicio1Button.Name = "Ejercicio1Button";
            this.Ejercicio1Button.Size = new System.Drawing.Size(75, 37);
            this.Ejercicio1Button.TabIndex = 0;
            this.Ejercicio1Button.Text = "Ejercicio 1";
            this.Ejercicio1Button.UseVisualStyleBackColor = true;
            this.Ejercicio1Button.Click += new System.EventHandler(this.Ejercicio1Button_Click);
            // 
            // Ejercicio2Button
            // 
            this.Ejercicio2Button.Location = new System.Drawing.Point(93, 12);
            this.Ejercicio2Button.Name = "Ejercicio2Button";
            this.Ejercicio2Button.Size = new System.Drawing.Size(75, 37);
            this.Ejercicio2Button.TabIndex = 1;
            this.Ejercicio2Button.Text = "Ejercicio 2";
            this.Ejercicio2Button.UseVisualStyleBackColor = true;
            this.Ejercicio2Button.Click += new System.EventHandler(this.Ejercicio2Button_Click);
            // 
            // Ejercicio3Button
            // 
            this.Ejercicio3Button.Location = new System.Drawing.Point(174, 12);
            this.Ejercicio3Button.Name = "Ejercicio3Button";
            this.Ejercicio3Button.Size = new System.Drawing.Size(75, 37);
            this.Ejercicio3Button.TabIndex = 2;
            this.Ejercicio3Button.Text = "Ejercicio 3";
            this.Ejercicio3Button.UseVisualStyleBackColor = true;
            this.Ejercicio3Button.Click += new System.EventHandler(this.Ejercicio3Button_Click);
            // 
            // Capitulo10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.Ejercicio3Button);
            this.Controls.Add(this.Ejercicio2Button);
            this.Controls.Add(this.Ejercicio1Button);
            this.Name = "Capitulo10";
            this.Text = "Capitulo10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejercicio1Button;
        private System.Windows.Forms.Button Ejercicio2Button;
        private System.Windows.Forms.Button Ejercicio3Button;
    }
}