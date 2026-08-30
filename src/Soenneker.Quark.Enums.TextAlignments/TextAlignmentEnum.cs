using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a Tailwind text-alignment utility class.
/// </summary>
[EnumValue<string>]
public sealed partial class TextAlignmentEnum
{
    /// <summary>
    /// Aligns text to the physical left edge.
    /// </summary>
    public static readonly TextAlignmentEnum Left = new("text-left");
    /// <summary>
    /// Aligns text to the logical start edge.
    /// </summary>
    public static readonly TextAlignmentEnum Start = new("text-start");
    /// <summary>
    /// Centers text.
    /// </summary>
    public static readonly TextAlignmentEnum Center = new("text-center");
    /// <summary>
    /// Aligns text to the logical end edge.
    /// </summary>
    public static readonly TextAlignmentEnum End = new("text-end");
    /// <summary>
    /// Aligns text to the physical right edge.
    /// </summary>
    public static readonly TextAlignmentEnum Right = new("text-right");
    /// <summary>
    /// Justifies text.
    /// </summary>
    public static readonly TextAlignmentEnum Justify = new("text-justify");
}
