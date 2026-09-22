namespace TuNominaYa.Forms.Configuration
{
    partial class Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
            header1 = new TuNominaYa.UserControls.Design.Header();
            panel1 = new Panel();
            rightSideBar1 = new TuNominaYa.UserControls.Actions.RightSideBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // header1
            // 
            header1.BottomBackColor = Color.White;
            header1.Dock = DockStyle.Top;
            header1.LabelFontColor = Color.White;
            header1.LabelText = "Gestión de la Empresa";
            header1.Location = new Point(0, 0);
            header1.MainBackColor = Color.DarkKhaki;
            header1.Name = "header1";
            header1.PictureBoxBackgroundImage = Properties.Resources.building;
            header1.Size = new Size(866, 65);
            header1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(rightSideBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 454);
            panel1.TabIndex = 1;
            // 
            // rightSideBar1
            // 
            rightSideBar1.AccessVisible = false;
            rightSideBar1.BackColor = SystemColors.ButtonFace;
            rightSideBar1.BorderStyle = BorderStyle.FixedSingle;
            rightSideBar1.CancelButtonPosition = 3;
            rightSideBar1.CleanButtonPosition = 2;
            rightSideBar1.Dock = DockStyle.Right;
            rightSideBar1.Location = new Point(758, 0);
            rightSideBar1.Name = "rightSideBar1";
            rightSideBar1.PlusVisible = false;
            rightSideBar1.PrintVisible = false;
            rightSideBar1.SearchButtonPosition = 1;
            rightSideBar1.SelectButtonPosition = 4;
            rightSideBar1.SelectVisible = false;
            rightSideBar1.Size = new Size(108, 454);
            rightSideBar1.TabIndex = 2;
            // 
            // Company
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 519);
            Controls.Add(panel1);
            Controls.Add(header1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "Company";
            Text = "Empresa";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.Design.Header header1;
        private Panel panel1;
        private UserControls.Actions.RightSideBar rightSideBar1;
    }
}