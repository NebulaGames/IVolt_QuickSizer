using PaintDotNet;
using PaintDotNet.Effects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace IVolt_QuickSizer
{
    [PluginSupportInfo(typeof(PluginSupportInfo))]
    public class IVolt_QuickSizerPlugin : Effect
    {
        private int amount1 = 0;

        public IVolt_QuickSizerPlugin()
            : base("IVolt_QuickSizer", null, SubmenuNames.Blurs, new EffectOptions { Flags = EffectFlags.Configurable })
        {
        }

        public override EffectConfigDialog CreateConfigDialog()
        {
            return new IVolt_QuickSizerConfigDialog();
        }

        protected override void OnSetRenderInfo(EffectConfigToken parameters, RenderArgs dstArgs, RenderArgs srcArgs)
        {
            IVolt_QuickSizerConfigToken token = (IVolt_QuickSizerConfigToken)parameters;
            this.amount1 = token.Amount1;

            base.OnSetRenderInfo(parameters, dstArgs, srcArgs);
        }

        public override void Render(EffectConfigToken parameters, RenderArgs dstArgs, RenderArgs srcArgs, Rectangle[] rois, int startIndex, int length)
        {
            if (length == 0) return;
            for (int i = startIndex; i < startIndex + length; ++i)
            {
                Render(dstArgs.Surface, srcArgs.Surface, rois[i]);
            }
        }

        private void Render(Surface dst, Surface src, Rectangle rect)
        {
            // Delete any of these lines you don't need
            Rectangle selection = EnvironmentParameters.SelectionBounds;
            int CenterX = ((selection.Right - selection.Left) / 2) + selection.Left;
            int CenterY = ((selection.Bottom - selection.Top) / 2) + selection.Top;
            ColorBgra PrimaryColor = EnvironmentParameters.PrimaryColor;
            ColorBgra SecondaryColor = EnvironmentParameters.SecondaryColor;
            int BrushWidth = (int)EnvironmentParameters.BrushWidth;

            ColorBgra CurrentPixel;
            for (int y = rect.Top; y < rect.Bottom; y++)
            {
                if (IsCancelRequested) return;
                for (int x = rect.Left; x < rect.Right; x++)
                {
                    CurrentPixel = (y % this.amount1 == 0) ? ColorBgra.Black : src[x, y];
                    // TODO: Add pixel processing code here
                    // Access RGBA values this way, for example:
                    // CurrentPixel.R = PrimaryColor.R;
                    // CurrentPixel.G = PrimaryColor.G;
                    // CurrentPixel.B = PrimaryColor.B;
                    // CurrentPixel.A = PrimaryColor.A;
                    dst[x, y] = CurrentPixel;
                }
            }
        }
    }
}
