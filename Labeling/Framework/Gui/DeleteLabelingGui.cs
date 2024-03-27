using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;

namespace Labeling.Framework.Gui;

public class DeleteLabelingGui : ScreenGui
{
    public DeleteLabelingGui()
    {
        foreach (var variable in ModEntry.GetInstance().Config.Labelings)
        {
            var deleteTitle =
                $"{ModEntry.GetInstance().GetTranslation("labeling.deleteLabeling.button.delete.title")}:{variable.Name}";
            var delete = new Button(deleteTitle, deleteTitle);
            delete.OnLeftClicked = () =>
            {
                ModEntry.GetInstance().Config.Labelings.Remove(variable);
                RemoveElement(delete);
            };
            AddElement(delete);
        }
    }
}