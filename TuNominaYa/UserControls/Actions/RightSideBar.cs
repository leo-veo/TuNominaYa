
using System.ComponentModel;

namespace TuNominaYa.UserControls.Actions
{
    public partial class RightSideBar : UserControl
    {
        public event EventHandler? ExecAct_Save, ExecAct_Clean, ExecAct_Cancel, ExecAct_Select,
            ExecAct_Search, ExecAct_Print, ExecAct_Access, ExecAct_Plus;
        private ToolTip _tt = new();        

        #region Buttons Behavior
        [Category("Buttons Behavior")]
        [Description("Show or hide the Save button")]
        [DefaultValue(true)]
        public bool SaveVisible
        {
            get => btnSave.Visible;
            set => btnSave.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Clean button")]
        [DefaultValue(true)]
        public bool CleanVisible
        {
            get => btnClean.Visible;
            set => btnClean.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Cancel button")]
        [DefaultValue(true)]
        public bool CancelVisible
        {
            get => btnCancel.Visible;
            set => btnCancel.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Select button")]
        [DefaultValue(true)]
        public bool SelectVisible
        {
            get => btnSelect.Visible;
            set => btnSelect.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Search button")]
        [DefaultValue(true)]
        public bool SearchVisible
        {
            get => btnSearch.Visible;
            set => btnSearch.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Print button")]
        [DefaultValue(true)]
        public bool PrintVisible
        {
            get => btnPrint.Visible;
            set => btnPrint.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Access button")]
        [DefaultValue(true)]
        public bool AccessVisible
        {
            get => btnAccess.Visible;
            set => btnAccess.Visible = value;
        }

        [Category("Buttons Behavior")]
        [Description("Show or hide the Plus button")]
        [DefaultValue(true)]
        public bool PlusVisible
        {
            get => btnPlus.Visible;
            set => btnPlus.Visible = value;
        }
        #endregion

        #region Buttons Position
        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Save button.")]
        [DefaultValue(0)]
        public int SaveButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnSave);
            set => flpanel.Controls.SetChildIndex(btnSave, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Clean button.")]
        [DefaultValue(1)]
        public int CleanButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnClean);
            set => flpanel.Controls.SetChildIndex(btnClean, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Cancel button.")]
        [DefaultValue(2)]
        public int CancelButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnCancel);
            set => flpanel.Controls.SetChildIndex(btnCancel, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Select button.")]
        [DefaultValue(3)]
        public int SelectButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnSelect);
            set => flpanel.Controls.SetChildIndex(btnSelect, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Search button.")]
        [DefaultValue(4)]
        public int SearchButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnSearch);
            set => flpanel.Controls.SetChildIndex(btnSearch, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Print button.")]
        [DefaultValue(5)]
        public int PrintButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnPrint);
            set => flpanel.Controls.SetChildIndex(btnPrint, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Access button.")]
        [DefaultValue(6)]
        public int AccessButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnAccess);
            set => flpanel.Controls.SetChildIndex(btnAccess, value);
        }

        [Category("Buttons Position")]
        [Description("Enter an integer to change the position of the Plus button.")]
        [DefaultValue(7)]
        public int PlusButtonPosition
        {
            get => flpanel.Controls.GetChildIndex(btnPlus);
            set => flpanel.Controls.SetChildIndex(btnPlus, value);
        }
        #endregion


        public RightSideBar()
        {
            InitializeComponent();
            _tt.SetToolTip(btnSave, "Guardar");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExecAct_Save?.Invoke(this, EventArgs.Empty);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ExecAct_Clean?.Invoke(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExecAct_Cancel?.Invoke(this, EventArgs.Empty);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ExecAct_Select?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecAct_Search?.Invoke(this, EventArgs.Empty);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExecAct_Print?.Invoke(this, EventArgs.Empty);
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            ExecAct_Access?.Invoke(this, EventArgs.Empty);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ExecAct_Plus?.Invoke(this, EventArgs.Empty);
        }
    }
}
