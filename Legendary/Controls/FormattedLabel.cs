using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legendary.Controls
{
    public class FormattedLabel : Label
    {
        const string BoldStartTag = "<b>";
        const string BoldEndTag = "</b>";
        const int PaddingAdjustment = -4;
        const int PixelAdjustment = 1;

        protected override void OnPaint(PaintEventArgs e)
        {
            // Define fonts
            Font normalFont = Font;
            Font boldFont = new Font(normalFont, FontStyle.Bold);

            int lineHeight = TextRenderer.MeasureText("kp", boldFont).Height;

            // Initialize variables
            List<(bool bold, string part, Point drawPoint, int width)> wordParts = new List<(bool, string, Point, int)>();
            bool bold = false;
            bool noMoreSpaces = false;
            bool noMoreNewLines = false;
            bool noMoreBoldTags = false;
            int line = 0;
            int lineWidth = 0;
            string word = "";
            int cursor = 0;
            while (cursor < Text.Length)
            {
                int spaceIndex = noMoreSpaces ? Text.Length : Text.IndexOf(' ', cursor);
                int newLineIndex = noMoreNewLines ? Text.Length : Text.IndexOf("\r\n", cursor);
                int boldTagIndex = noMoreBoldTags ? Text.Length : Text.IndexOf(bold ? BoldEndTag : BoldStartTag, cursor);

                // The next three if statements save searching for something we know isn't there in future iterations
                if (spaceIndex == -1)
                {
                    spaceIndex = Text.Length;
                    noMoreSpaces = true;
                }

                if (newLineIndex == -1)
                {
                    newLineIndex = Text.Length;
                    noMoreNewLines = true;
                }

                if (boldTagIndex == -1)
                {
                    boldTagIndex = Text.Length;
                    noMoreBoldTags = true;
                }

                int index;
                string symbol;
                // If a new line is next
                if (newLineIndex < spaceIndex && newLineIndex < boldTagIndex)
                {
                    index = newLineIndex;
                    symbol = "\r\n";
                }
                // If a bold tag is next
                else if (boldTagIndex < spaceIndex && boldTagIndex < newLineIndex)
                {
                    index = boldTagIndex;
                    symbol = bold ? BoldEndTag : BoldStartTag;
                }
                // If a space is next, or they're all the same (end of text)
                else
                {
                    index = spaceIndex;
                    symbol = " ";
                }

                string wordPart = (word.Length == 0 && lineWidth > 0 ? " " : "") + Text.Substring(cursor, index - cursor);

                if (wordPart.Trim().Length > 0)
                {
                    // Add part of word
                    int wordPartWidth = TextRenderer.MeasureText(e.Graphics, wordPart, bold ? boldFont : normalFont, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPadding).Width + PixelAdjustment;

                    // Test width, start a new line if it's too long
                    if (lineWidth + wordPartWidth >= MaximumSize.Width + PaddingAdjustment)
                    {
                        line++;
                        lineWidth = 0;
                        if (wordPart.StartsWith(" "))
                        {
                            wordPart = wordPart.Substring(1);
                            wordPartWidth = TextRenderer.MeasureText(e.Graphics, wordPart, bold ? boldFont : normalFont, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPadding).Width + PixelAdjustment;
                        }
                    }

                    // Queue word to be printed
                    wordParts.Add((bold, wordPart, new Point(lineWidth, line * lineHeight), wordPartWidth));

                    lineWidth += wordPartWidth;
                }

                if (spaceIndex < newLineIndex && spaceIndex < boldTagIndex)
                {
                    // Reset word
                    word = "";
                }
                else if (newLineIndex < spaceIndex && newLineIndex < boldTagIndex)
                {
                    // Start a new line
                    line++;
                    lineWidth = 0;
                    // Reset word
                    word = "";
                }
                else if (boldTagIndex < spaceIndex && boldTagIndex < newLineIndex)
                {
                    bold = !bold;
                }
                cursor = index + symbol.Length;
            }

            foreach ((bool isBold, string part, Point drawPoint, int width) in wordParts)
            {
                Rectangle rect = new Rectangle(drawPoint, new Size(width, lineHeight));
                TextRenderer.DrawText(e.Graphics, part, isBold ? boldFont : normalFont, rect, ForeColor, TextFormatFlags.NoPadding);
            }
        }
    }
}
