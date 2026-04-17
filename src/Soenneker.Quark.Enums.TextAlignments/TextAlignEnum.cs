using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

[EnumValue<string>]
public sealed partial class TextAlignmentEnum
{
    public static readonly TextAlignmentEnum Start = new("text-start");
    public static readonly TextAlignmentEnum Center = new("text-center");
    public static readonly TextAlignmentEnum End = new("text-end");
}