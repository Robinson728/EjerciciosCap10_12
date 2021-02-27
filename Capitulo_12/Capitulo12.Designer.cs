
namespace EjerciciosCap10_12.Capitulo_12
{
    partial class Capitulo12
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
            this.Ejercicio1button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejercicio1button
            // 
            this.Ejercicio1button.Location = new System.Drawing.Point(56, 30);
            this.Ejercicio1button.Name = "Ejercicio1button";
            this.Ejercicio1button.Size = new System.Drawing.Size(113, 56);
            this.Ejercicio1button.TabIndex = 0;
            this.Ejercicio1button.Text = "Ejercicio #1 y #2";
            this.Ejercicio1button.UseVisualStyleBackColor = true;
            this.Ejercicio1button.Click += new System.EventHandler(this.Ejercicio1button_Click);
            // 
            // Capitulo12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 113);
            this.Controls.Add(this.Ejercicio1button);
            this.Name = "Capitulo12";
            this.Text = "Capitulo12";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejercicio1button;
    }
}