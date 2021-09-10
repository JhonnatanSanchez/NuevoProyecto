
namespace NuevoProyecto
{
    partial class Form2
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
            this.btnIrForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIrForm1
            // 
            this.btnIrForm1.Location = new System.Drawing.Point(127, 352);
            this.btnIrForm1.Name = "btnIrForm1";
            this.btnIrForm1.Size = new System.Drawing.Size(459, 62);
            this.btnIrForm1.TabIndex = 0;
            this.btnIrForm1.Text = "Ir Formulario1";
            this.btnIrForm1.UseVisualStyleBackColor = true;
            this.btnIrForm1.Click += new System.EventHandler(this.btnIrForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 426);
            this.Controls.Add(this.btnIrForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIrForm1;
    }
}