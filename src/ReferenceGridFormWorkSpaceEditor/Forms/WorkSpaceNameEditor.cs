﻿using SwissAcademic.Controls;
using System;
using System.Windows.Forms;

namespace SwissAcademic.Addons.ReferenceGridFormWorkSpaceEditor
{
    public partial class WorkSpaceNameEditor : FormBase
    {
        #region Constructors

        public WorkSpaceNameEditor(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        protected override void OnLoad(EventArgs e)
        {
            Localize();
            base.OnLoad(e);
        }

        #endregion

        #region Methods

        public override void Localize()
        {
            base.Localize();
            Text = Properties.ReferenceGridFormWorkSpaceEditorResources.NameEditor_Form_Text;
            lbl_workspace_name.Text = Properties.ReferenceGridFormWorkSpaceEditorResources.NameEditor_Label_Name;
            btn_cancel.Text = Properties.ReferenceGridFormWorkSpaceEditorResources.NameEditor_Button_Cancel;
            btn_create.Text = Properties.ReferenceGridFormWorkSpaceEditorResources.NameEditor_Button_Create;
        }

        protected override void OnApplicationIdle()
        {
            btn_create.Enabled = !string.IsNullOrEmpty(txt_workspace_name.Text.Trim());
            base.OnApplicationIdle();
        }

        #endregion

        #region Properties

        public string WorkSpaceName => txt_workspace_name.Text;

        #endregion

        #region EventHandlers

        void Btn_create_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        void Btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
