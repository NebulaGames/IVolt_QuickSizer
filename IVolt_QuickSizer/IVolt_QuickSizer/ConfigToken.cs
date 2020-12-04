using PaintDotNet.Effects;

namespace IVolt_QuickSizer
{
    public class IVolt_QuickSizerConfigToken : EffectConfigToken
    {
        internal int Amount1 { get; set; }

        internal IVolt_QuickSizerConfigToken()
        {
            this.Amount1 = 10;
        }

        private IVolt_QuickSizerConfigToken(IVolt_QuickSizerConfigToken copyMe)
        {
            this.Amount1 = copyMe.Amount1;
        }

        public override object Clone()
        {
            return new IVolt_QuickSizerConfigToken(this);
        }
    }
}
