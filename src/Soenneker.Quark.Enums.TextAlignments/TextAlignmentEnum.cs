using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextAlignmentEnum
{
    public static readonly TextAlignmentEnum Left = new("text-left");
    public static readonly TextAlignmentEnum Start = new("text-start");
    public static readonly TextAlignmentEnum Center = new("text-center");
    public static readonly TextAlignmentEnum End = new("text-end");
    public static readonly TextAlignmentEnum Right = new("text-right");
    public static readonly TextAlignmentEnum Justify = new("text-justify");
}
