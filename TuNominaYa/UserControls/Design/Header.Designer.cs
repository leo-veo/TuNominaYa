namespace TuNominaYa.UserControls.Design
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            main = new Panel();
            label = new Label();
            picturebox = new PictureBox();
            bottom = new Panel();
            main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox).BeginInit();
            SuspendLayout();
            // 
            // main
            // 
            main.BackColor = Color.DeepSkyBlue;
            main.Controls.Add(label);
            main.Controls.Add(picturebox);
            main.Controls.Add(bottom);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 0);
            main.Name = "main";
            main.Size = new Size(581, 65);
            main.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(55, 12);
            label.Name = "label";
            label.Size = new Size(171, 30);
            label.TabIndex = 3;
            label.Text = "Inicio de sesión";
            // 
            // picturebox
            // 
            picturebox.BackColor = Color.Transparent;
            picturebox.BackgroundImageLayout = ImageLayout.Stretch;
            picturebox.Location = new Point(17, 11);
            picturebox.Name = "picturebox";
            picturebox.Size = new Size(33, 33);
            picturebox.TabIndex = 2;
            picturebox.TabStop = false;
            // 
            // bottom
            // 
            bottom.BackColor = Color.DarkViolet;
            bottom.BorderStyle = BorderStyle.FixedSingle;
            bottom.Dock = DockStyle.Bottom;
            bottom.Location = new Point(0, 55);
            bottom.Name = "bottom";
            bottom.Size = new Size(581, 10);
            bottom.TabIndex = 1;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main);
            Name = "Header";
            Size = new Size(581, 65);
            main.ResumeLayout(false);
            main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main;
        private Panel bottom;
        private PictureBox picturebox;
        private Label label;
    }
}
