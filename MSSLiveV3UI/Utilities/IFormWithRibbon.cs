using DevExpress.XtraBars.Ribbon;

namespace MISLiveMed.UI.Utilities
{
    public interface IFormWithRibbon
    {
        RibbonControl MainRibbon { get; }
        RibbonPage DefaultPage { get; }
    }
}
