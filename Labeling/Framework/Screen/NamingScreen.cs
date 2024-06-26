﻿using EnaiumToolKit.Framework.Screen;
using EnaiumToolKit.Framework.Screen.Components;
using Microsoft.Xna.Framework;
using StardewValley;

namespace Labeling.Framework.Screen;

public class NamingScreen : GuiScreen
{
    protected override void Init()
    {
        var x = Game1.graphics.GraphicsDevice.Viewport.Width / 2 - 100;
        var y = Game1.graphics.GraphicsDevice.Viewport.Height / 2 - 35;
        var name = new TextField("",
            ModEntry.GetInstance().GetTranslation("labeling.naming.textField.name.description"), x,
            y, 200, 70) { Text = Dialogue.randomName() };
        AddComponent(name);
        var done = new Button(ModEntry.GetInstance().GetTranslation("labeling.naming.button.done.title"),
            ModEntry.GetInstance().GetTranslation("labeling.naming.button.done.title"), x, y + 100, 200, 80)
        {
            OnLeftClicked = () =>
            {
                ModEntry.GetInstance().Config.Labelings.Add(new Labeling(name.Text,
                    ModEntry.GetInstance().FirstObjectTile, ModEntry.GetInstance().SecondObjectTile,
                    Game1.player.currentLocation.Name, true, Color.Aqua));
                ModEntry.GetInstance().ConfigReload();
                ModEntry.GetInstance().FirstObjectTile = Vector2.Zero;
                ModEntry.GetInstance().FirstObjectTile = Vector2.Zero;
                Game1.exitActiveMenu();
            }
        };

        if (ModEntry.GetInstance().FirstObjectTile.Equals(Vector2.Zero) ||
            ModEntry.GetInstance().SecondObjectTile.Equals(Vector2.Zero))
            done.Visibled = false;

        AddComponent(done);
        AddComponent(new Button(ModEntry.GetInstance().GetTranslation("labeling.naming.button.cancel.title"),
            ModEntry.GetInstance().GetTranslation("labeling.naming.button.cancel.title"), x, y + 200, 200, 80)
        {
            OnLeftClicked = Game1.exitActiveMenu
        });
        base.Init();
    }
}