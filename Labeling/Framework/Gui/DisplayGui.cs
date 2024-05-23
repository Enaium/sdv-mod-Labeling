using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;

namespace Labeling.Framework.Gui;

public class DisplayGui : ScreenGui
{
    public DisplayGui()
    {
        foreach (var variable in ModEntry.GetInstance().Config.Labelings)
        {
            AddElement(new ToggleButton(variable.Name, variable.Name)
            {
                Current = variable.Display,
                OnCurrentChanged = (toggle) =>
                {
                    variable.Display = toggle;
                    ModEntry.GetInstance().ConfigReload();
                }
            });
        }
    }
}