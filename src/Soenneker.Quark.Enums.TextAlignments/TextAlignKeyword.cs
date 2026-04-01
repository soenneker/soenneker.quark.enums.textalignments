using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

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
}