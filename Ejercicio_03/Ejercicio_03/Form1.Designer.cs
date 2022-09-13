
namespace Ejercicio_03
{
    partial class Form1
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
            this.rtb_palabras = new System.Windows.Forms.RichTextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_palabras
            // 
            this.rtb_palabras.Location = new System.Drawing.Point(67, 25);
            this.rtb_palabras.Name = "rtb_palabras";
            this.rtb_palabras.Size = new System.Drawing.Size(344, 251);
            this.rtb_palabras.TabIndex = 0;
            this.rtb_palabras.Text = "";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(375, 305);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 340);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.rtb_palabras);
            this.Name = "Form1";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_palabras;
        private System.Windows.Forms.Button btn_calcular;
    }
}

