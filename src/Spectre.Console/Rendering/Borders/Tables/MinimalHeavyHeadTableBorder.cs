namespace Spectre.Console.Rendering;

/// <summary>
/// Represents a minimal border with a heavy header.
/// </summary>
public sealed class MinimalHeavyHeadTableBorder : TableBorder
{
    /// <inheritdoc/>
    public override TableBorder? SafeBorder => TableBorder.Minimal;

    /// <inheritdoc/>
    public override string GetPart(TableBorderPart part)
    {
        return part switch
        {
            TableBorderPart.HeaderTopLeft => " ",
            TableBorderPart.HeaderTop => " ",
            TableBorderPart.HeaderTopSeparator => " ",
            TableBorderPart.HeaderTopRight => " ",
            TableBorderPart.HeaderLeft => " ",
            TableBorderPart.HeaderSeparator => "│",
            TableBorderPart.HeaderRight => " ",
            TableBorderPart.HeaderBottomLeft => " ",
            TableBorderPart.HeaderBottom => "━",
            TableBorderPart.HeaderBottomSeparator => "┿",
            TableBorderPart.HeaderBottomRight => " ",
            TableBorderPart.CellLeft => " ",
            TableBorderPart.CellSeparator => "│",
            TableBorderPart.CellRight => " ",
            TableBorderPart.FooterTopLeft => " ",
            TableBorderPart.FooterTop => "━",
            TableBorderPart.FooterTopSeparator => "┿",
            TableBorderPart.FooterTopRight => " ",
            TableBorderPart.FooterBottomLeft => " ",
            TableBorderPart.FooterBottom => " ",
            TableBorderPart.FooterBottomSeparator => " ",
            TableBorderPart.FooterBottomRight => " ",
            TableBorderPart.RowLeft => " ",
            TableBorderPart.RowCenter => "─",
            TableBorderPart.RowSeparator => "┼",
            TableBorderPart.RowRight => " ",
            _ => throw new InvalidOperationException("Unknown border part."),
        };
    }
}