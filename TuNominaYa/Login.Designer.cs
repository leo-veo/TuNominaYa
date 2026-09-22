namespace TuNominaYa
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Code_Generated_Image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 305);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(444, 66);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite su usuario";
            textBox1.Size = new Size(304, 37);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(444, 38);
            label1.Name = "label1";
            label1.Size = new Size(304, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(59, 115);
            label2.Name = "label2";
            label2.Size = new Size(304, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(444, 143);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Digite su contraseña";
            textBox2.Size = new Size(304, 37);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 11.8F, FontStyle.Bold);
            button1.Location = new Point(444, 213);
            button1.Name = "button1";
            button1.Size = new Size(304, 50);
            button1.TabIndex = 5;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 211, 211, 213);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(385, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 305);
            panel1.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 305);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inició de Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Panel panel1;
    }
}
