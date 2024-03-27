using StardewModdingAPI;

namespace Labeling.Framework;

public class Config
{
    public SButton OpenLabelScreen { get; set; } = SButton.J;
    public List<Labeling> Labelings { get; set; } = new();
}