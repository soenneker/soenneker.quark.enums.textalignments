using Intellenum;
using Soenneker.Quark.Enums.GlobalKeywords;

namespace Soenneker.Quark;

/// <summary>
/// Common html text alignments in enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class TextAlignment
{
    public static readonly TextAlignment Left = new("left");
    public static readonly TextAlignment Right = new("right");
    public static readonly TextAlignment Center = new("center");
    public static readonly TextAlignment Justify = new("justify");
    public static readonly TextAlignment Start = new("start");
    public static readonly TextAlignment End = new("end");
    public static readonly TextAlignment MatchParent = new("match-parent");

    public static implicit operator TextAlignment(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
