using EnaiumToolKit.Framework.Utils;
using Microsoft.Xna.Framework;
using StardewValley;

namespace Labeling.Framework
{
    public class Labeling
    {
        public string Name { get; set; }
        public Vector2 FirstObjectTile { get; set; }
        public Vector2 SecondObjectTile { get; set; }

        public string CurrentGameLocation { get; set; }
        public bool Display { get; set; }
        public ColorUtils.NameType Color { get; set; }

        public Labeling(string name, Vector2 firstObjectTile, Vector2 secondObjectTile, string currentGameLocation, bool display, ColorUtils.NameType color)
        {
            Name = name;
            FirstObjectTile = firstObjectTile;
            SecondObjectTile = secondObjectTile;
            CurrentGameLocation = currentGameLocation;
            Display = display;
            Color = color;
        }
    }
}