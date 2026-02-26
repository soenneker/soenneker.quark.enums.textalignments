using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Common html text alignments in enumeration form.
/// </summary>
[EnumValue<string>]
public sealed partial class TextAlignKeyword
{
    public static readonly TextAlignKeyword Left = new("left");
    public static readonly TextAlignKeyword Right = new("right");
    public static readonly TextAlignKeyword Center = new("center");
    public static readonly TextAlignKeyword Justify = new("justify");
    public static readonly TextAlignKeyword Start = new("start");
    public static readonly TextAlignKeyword End = new("end");
    public static readonly TextAlignKeyword MatchParent = new("match-parent");

    public static implicit operator TextAlignKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
