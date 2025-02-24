namespace PATrilhasAtiv10_F
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
            btnVerificar = new Button();
            textBox1 = new TextBox();
            btnSair = new Button();
            lblSucesso = new Label();
            lblErro = new Label();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(308, 83);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 23);
            textBox1.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(572, 239);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblSucesso
            // 
            lblSucesso.AutoSize = true;
            lblSucesso.Font = new Font("Arial Narrow", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSucesso.Location = new Point(226, 140);
            lblSucesso.Name = "lblSucesso";
            lblSucesso.Size = new Size(0, 16);
            lblSucesso.TabIndex = 3;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Arial Narrow", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErro.Location = new Point(227, 179);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 16);
            lblErro.TabIndex = 4;
            lblErro.Click += lblErro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 274);
            Controls.Add(lblErro);
            Controls.Add(lblSucesso);
            Controls.Add(btnSair);
            Controls.Add(textBox1);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox textBox1;
        private Button btnSair;
        private Label lblSucesso;
        private Label lblErro;
    }
}
