﻿using SwissAcademic.Citavi.Shell;
using System;
using System.Windows.Forms;

namespace SwissAcademic.Addons.HideHelpBox
{

    public class KnowledgeItemFileFormAddon : CitaviAddOn
    {
        public override AddOnHostingForm HostingForm => AddOnHostingForm.KnowledgeItemFileForm;

        #region Methods
        protected override void OnHostingFormLoaded(Form form)
        {
            if (form is KnowledgeItemFileForm knowledgeItemFileForm)
            {
                try
                {
                    knowledgeItemFileForm.HelpBox.Width = 0;
                }
                catch (Exception)
                {
                }
            }

            base.OnHostingFormLoaded(form);
        }

        #endregion
    }
}