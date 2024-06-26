﻿using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Elements;
using Labeling.Framework.Screen;

namespace Labeling.Framework.Gui;

public class LabelingGui : ScreenGui
{
    public LabelingGui() : base(ModEntry.GetInstance().GetTranslation("labeling.labelingGui.title"))
    {
        var recordTitle = ModEntry.GetInstance().GetTranslation("labeling.labelingGui.record");
        AddElement(new Button(recordTitle, recordTitle)
        {
            OnLeftClicked = () => { OpenScreenGui(new NamingScreen()); }
        });

        var displayTitle = ModEntry.GetInstance().GetTranslation("labeling.labelingGui.display");
        AddElement(new Button(displayTitle, displayTitle)
        {
            OnLeftClicked = () => { OpenScreenGui(new DisplayGui()); }
        });

        var colorTitle = ModEntry.GetInstance().GetTranslation("labeling.labelingGui.color");
        AddElement(new Button(colorTitle, colorTitle)
        {
            OnLeftClicked = () => { OpenScreenGui(new ColorGui()); }
        });

        var deleteTitle = ModEntry.GetInstance().GetTranslation("labeling.deleteLabeling.button.delete.title");
        AddElement(new Button(deleteTitle, deleteTitle)
        {
            OnLeftClicked = () => { OpenScreenGui(new DeleteLabelingGui()); }
        });
    }
}