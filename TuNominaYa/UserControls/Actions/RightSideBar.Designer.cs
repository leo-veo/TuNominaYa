namespace TuNominaYa.UserControls.Actions
{
    partial class RightSideBar
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
            flpanel = new FlowLayoutPanel();
            btnSave = new Button();
            btnClean = new Button();
            btnCancel = new Button();
            btnSelect = new Button();
            btnSearch = new Button();
            btnPrint = new Button();
            btnAccess = new Button();
            btnPlus = new Button();
            flpanel.SuspendLayout();
            SuspendLayout();
            // 
            // flpanel
            // 
            flpanel.AutoScroll = true;
            flpanel.Controls.Add(btnSave);
            flpanel.Controls.Add(btnClean);
            flpanel.Controls.Add(btnCancel);
            flpanel.Controls.Add(btnSelect);
            flpanel.Controls.Add(btnSearch);
            flpanel.Controls.Add(btnPrint);
            flpanel.Controls.Add(btnAccess);
            flpanel.Controls.Add(btnPlus);
            flpanel.Dock = DockStyle.Fill;
            flpanel.Location = new Point(0, 0);
            flpanel.Name = "flpanel";
            flpanel.Padding = new Padding(3);
            flpanel.Size = new Size(108, 654);
            flpanel.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AccessibleDescription = "Button used to save the content";
            btnSave.AccessibleName = "Save Button";
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.BackgroundImage = Properties.Resources.diskDarkBlue;
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(6, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 81);
            btnSave.TabIndex = 0;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(224, 224, 224);
            btnClean.BackgroundImage = Properties.Resources.broomOpacYellow;
            btnClean.BackgroundImageLayout = ImageLayout.Center;
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(6, 93);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(96, 81);
            btnClean.TabIndex = 1;
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.BackgroundImage = Properties.Resources.octagon_xmarkRed;
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(6, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 81);
            btnCancel.TabIndex = 2;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(224, 224, 224);
            btnSelect.BackgroundImage = Properties.Resources.mouse_pointer_click;
            btnSelect.BackgroundImageLayout = ImageLayout.Center;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(6, 267);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(96, 81);
            btnSelect.TabIndex = 3;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.BackgroundImage = Properties.Resources.searchbluedark;
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(6, 354);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 81);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(224, 224, 224);
            btnPrint.BackgroundImage = Properties.Resources.printerPurple;
            btnPrint.BackgroundImageLayout = ImageLayout.Center;
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(6, 441);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(96, 81);
            btnPrint.TabIndex = 5;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnAccess
            // 
            btnAccess.BackColor = Color.FromArgb(224, 224, 224);
            btnAccess.BackgroundImage = Properties.Resources.access_control;
            btnAccess.BackgroundImageLayout = ImageLayout.Center;
            btnAccess.ForeColor = Color.White;
            btnAccess.Location = new Point(6, 528);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(96, 81);
            btnAccess.TabIndex = 6;
            btnAccess.UseVisualStyleBackColor = false;
            btnAccess.Click += btnAccess_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(224, 224, 224);
            btnPlus.BackgroundImage = Properties.Resources.plus;
            btnPlus.BackgroundImageLayout = ImageLayout.Center;
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(6, 615);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(96, 81);
            btnPlus.TabIndex = 7;
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // RightSideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpanel);
            Name = "RightSideBar";
            Size = new Size(108, 654);
            flpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpanel;
        private Button btnSave;
        private Button btnClean;
        private Button btnCancel;
        private Button btnSelect;
        private Button btnSearch;
        private Button btnPrint;
        private Button btnAccess;
        private Button btnPlus;
    }
}
