using HtmlAgilityPack;

namespace AssetScope.Shared.Helpers;

public class HtmlFormatter
{
    private static readonly HashSet<string> AllowedTags = new()
    {
        "html", "head", "body", "div", "span", "p", "br", "strong", "em",
        "a", "img", "table", "tr", "td", "th", "tbody", "thead", "tfoot",
        "ul", "ol", "li", "h1", "h2", "h3", "h4", "h5", "h6"
    };

    private static readonly HashSet<string> AllowedAttributes = new()
    {
        "href", "src", "alt", "title", "style", "width", "height", "align", "border", "cellpadding", "cellspacing"
    };

    public static string FormatHtml(string htmlFragment)
    {
        if (string.IsNullOrWhiteSpace(htmlFragment))
            throw new ArgumentException("HTML fragment cannot be null or empty.", nameof(htmlFragment));

        // Load the HTML into the HtmlDocument
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(htmlFragment);

        // Set options for pretty formatting and suppress XML declaration
        htmlDocument.OptionOutputAsXml = false; // Do not output XML format
        htmlDocument.OptionWriteEmptyNodes = true; // Properly close empty nodes


        // Use the HtmlDocument's WriteTo() method to format
        using var writer = new StringWriter();
        htmlDocument.Save(writer);
        return writer.ToString();
    }

    public static string ScrubHtmlForEmail(string htmlFragment)
    {
        if (string.IsNullOrWhiteSpace(htmlFragment))
            throw new ArgumentException("HTML fragment cannot be null or empty.", nameof(htmlFragment));

        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(htmlFragment);

        CleanNode(htmlDocument.DocumentNode);
        InlineStyles(htmlDocument.DocumentNode);

        return htmlDocument.DocumentNode.OuterHtml;
    }

    private static void CleanNode(HtmlNode node)
    {
        if (!AllowedTags.Contains(node.Name.ToLower()) && node.NodeType == HtmlNodeType.Element)
        {
            node.ParentNode.RemoveChild(node, true); // Remove disallowed tag but keep its inner content
            return;
        }

        if (node.Attributes.Count > 0)
            for (var i = node.Attributes.Count - 1; i >= 0; i--)
            {
                var attribute = node.Attributes[i];
                if (!AllowedAttributes.Contains(attribute.Name.ToLower()))
                    node.Attributes.Remove(attribute); // Remove disallowed attributes
            }

        // Recursively clean child nodes
        foreach (var child in node.ChildNodes.ToList()) CleanNode(child);
    }

    private static void InlineStyles(HtmlNode node)
    {
        // Example: Implement a method to convert <style> rules into inline styles (advanced, use a library like PreMailer.Net for this)
        // For simplicity, this is a placeholder.
        // PreMailer.Net can handle CSS-to-inline conversion for email.

        foreach (var child in node.ChildNodes) InlineStyles(child);
    }
}