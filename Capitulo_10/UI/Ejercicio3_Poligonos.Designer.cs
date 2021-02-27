
namespace EjerciciosCap10_12.Capitulo_10.UI
{
    partial class Ejercicio3_Poligonos
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
            this.ApotematextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LadosTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ApotematextBox
            // 
            this.ApotematextBox.Location = new System.Drawing.Point(134, 36);
            this.ApotematextBox.Name = "ApotematextBox";
            this.ApotematextBox.Size = new System.Drawing.Size(87, 23);
            this.ApotematextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Apotema";
            // 
            // LadosTextBox
            // 
            this.LadosTextBox.Location = new System.Drawing.Point(134, 2);
            this.LadosTextBox.Name = "LadosTextBox";
            this.LadosTextBox.Size = new System.Drawing.Size(87, 23);
            this.LadosTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Longitud de los Lados";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(73, 76);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 31;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(26, 105);
            this.ResultadotextBox.Multiline = true;
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(173, 108);
            this.ResultadotextBox.TabIndex = 32;
            // 
            // Ejercicio3_Poligonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 215);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.ApotematextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LadosTextBox);
            this.Controls.Add(this.label5);
            this.Name = "Ejercicio3_Poligonos";
            this.Text = "Ejercicio3_Poligonos";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApotematextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LadosTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.TextBox ResultadotextBox;
    }
}