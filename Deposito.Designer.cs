namespace $safeprojectname$
{
    partial class Deposito
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
            button1 = new Button();
            txtDeposito = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 129);
            button1.Name = "button1";
            button1.Size = new Size(79, 25);
            button1.TabIndex = 0;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDeposito
            // 
            txtDeposito.AutoSize = true;
            txtDeposito.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDeposito.Location = new Point(50, 22);
            txtDeposito.Name = "txtDeposito";
            txtDeposito.Size = new Size(187, 23);
            txtDeposito.TabIndex = 1;
            txtDeposito.Text = "Quanto irá depositar? ";
            txtDeposito.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 72);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Valor:";
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(77, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 4;
            // 
            // Deposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 199);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtDeposito);
            Controls.Add(button1);
            Name = "Deposito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposito";
            TransparencyKey = SystemColors.WindowText;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label txtDeposito;
        private Label label1;
        private TextBox textBox1;
    }
}