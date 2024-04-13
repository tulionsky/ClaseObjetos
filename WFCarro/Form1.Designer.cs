namespace WFCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            Acelerar = new Button();
            lblVelocidad = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(108, 73);
            button1.Name = "button1";
            button1.Size = new Size(154, 67);
            button1.TabIndex = 0;
            button1.Text = "Encender carro\r\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // Acelerar
            // 
            Acelerar.Location = new Point(108, 161);
            Acelerar.Name = "Acelerar";
            Acelerar.Size = new Size(154, 29);
            Acelerar.TabIndex = 1;
            Acelerar.Text = "Acelerar";
            Acelerar.UseVisualStyleBackColor = true;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Segoe UI", 20F);
            lblVelocidad.Location = new Point(543, 144);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(83, 46);
            lblVelocidad.TabIndex = 2;
            lblVelocidad.Text = "KPH";
            lblVelocidad.Click += lblVelocidad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVelocidad);
            Controls.Add(Acelerar);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Acelerar;
        private Label lblVelocidad;
    }
}
