using PaintDotNet.Effects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IVolt_QuickSizer
{
    internal partial class IVolt_QuickSizerConfigDialog : EffectConfigDialog
    {
        public IVolt_QuickSizerConfigDialog()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            FinishTokenUpdate();
        }

        protected override void InitialInitToken()
        {
            theEffectToken = new IVolt_QuickSizerConfigToken();
        }

        protected override void InitTokenFromDialog()
        {
            IVolt_QuickSizerConfigToken token = (IVolt_QuickSizerConfigToken)EffectToken;
            //token.Amount1 = this.trackBar1.Value;
        }

        protected override void InitDialogFromToken(EffectConfigToken effectTokenCopy)
        {
            IVolt_QuickSizerConfigToken token = (IVolt_QuickSizerConfigToken)effectTokenCopy;
            //this.trackBar1.Value = token.Amount1;
        }

        private void ProcessResizeCommand_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
