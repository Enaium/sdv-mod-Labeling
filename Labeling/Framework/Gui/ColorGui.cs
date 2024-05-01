using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;
using EnaiumToolKit.Framework.Utils;
using StardewValley;

namespace Labeling.Framework.Gui;

public class ColorGui : ScreenGui
{
    public ColorGui()
    {
        foreach (var variable in ModEntry.GetInstance().Config.Labelings)
        {
            AddElement(new Label(variable.Name, variable.Name));
            var colorPicker = new ColorPicker(variable.Name, variable.Name, variable.Color);
            colorPicker.OnColorChanged = () => { variable.Color = colorPicker.Color; };
            AddElement(colorPicker);
        }
    }
}