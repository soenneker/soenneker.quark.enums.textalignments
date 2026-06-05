using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents the text alignment enum.
/// </summary>
[EnumValue<string>]
public sealed partial class TextAlignmentEnum
{
    /// <summary>
    /// The left.
    /// </summary>
    public static readonly TextAlignmentEnum Left = new("text-left");
    /// <summary>
    /// The start.
    /// </summary>
    public static readonly TextAlignmentEnum Start = new("text-start");
    /// <summary>
    /// The center.
    /// </summary>
    public static readonly TextAlignmentEnum Center = new("text-center");
    /// <summary>
    /// The end.
    /// </summary>
    public static readonly TextAlignmentEnum End = new("text-end");
    /// <summary>
    /// The right.
    /// </summary>
    public static readonly TextAlignmentEnum Right = new("text-right");
    /// <summary>
    /// The justify.
    /// </summary>
    public static readonly TextAlignmentEnum Justify = new("text-justify");
}
