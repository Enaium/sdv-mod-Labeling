using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;

namespace Labeling.Framework.Gui;

public class ColorGui : ScreenGui
{
    public ColorGui()
    {
        foreach (var variable in ModEntry.GetInstance().Config.Labelings)
        {
            AddElement(new Label(variable.Name, variable.Name));
            AddElement(new ColorPicker(variable.Name, variable.Name, variable.Color)
            {
                OnCurrentChanged = (color) =>
                {
                    variable.Color = color;
                }
            });
        }
    }
}