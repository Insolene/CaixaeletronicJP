namespace $safeprojectname$
{
    partial class ConfirmSenha
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
            txtConfirmSenha = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.AutoSize = true;
            txtConfirmSenha.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmSenha.Location = new Point(86, 36);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.Size = new Size(150, 19);
            txtConfirmSenha.TabIndex = 0;
            txtConfirmSenha.Text = "Confirme sua senha: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(99, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 26);
            textBox1.TabIndex = 1;
            textBox1.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(111, 110);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 2;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // ConfirmSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 180);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(txtConfirmSenha);
            Name = "ConfirmSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtConfirmSenha;
        private TextBox textBox1;
        private Button button1;
    }
}