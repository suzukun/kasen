namespace KasenCS
{
    using UnityEngine;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public static StyledOptions Styled => new();

        public static StyledOptions StyledText(string text)
        {
            return new(text);
        }

        public sealed class StyledOptions
        {
            private string text = string.Empty;
            private string color = "#000000";
            private int size = 12;
            private bool isBold = false;
            private bool isItalic = false;

            internal StyledOptions(string text = "")
            {
                this.text = text;
            }

            public StyledOptions Black => new()
            {
                text = this.text,
                color = "#000000",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Blue => new()
            {
                text = this.text,
                color = "#2196f3",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Bold => new()
            {
                text = this.text,
                color = this.color,
                size = this.size,
                isBold = true,
                isItalic = this.isItalic,
            };

            public StyledOptions Brown => new()
            {
                text = this.text,
                color = "#795548",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Green => new()
            {
                text = this.text,
                color = "#4caf50",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Gray => new()
            {
                text = this.text,
                color = "#9e9e9e",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Indigo => new()
            {
                text = this.text,
                color = "#3f51b5",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Italic => new()
            {
                text = this.text,
                color = this.color,
                size = this.size,
                isBold = this.isBold,
                isItalic = true,
            };

            public StyledOptions Lime => new()
            {
                text = this.text,
                color = "#cddc39",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions NewLine => new()
            {
                text = $"{this.text}\n",
                color = this.color,
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Orange => new()
            {
                text = this.text,
                color = "#ff9800",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Pink => new()
            {
                text = this.text,
                color = "#e91e63",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Purple => new()
            {
                text = this.text,
                color = "#9c27b0",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Red => new()
            {
                text = this.text,
                color = "#f44336",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions White => new()
            {
                text = this.text,
                color = "#ffffff",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public StyledOptions Yellow => new()
            {
                text = this.text,
                color = "#ffeb3b",
                size = this.size,
                isBold = this.isBold,
                isItalic = this.isItalic,
            };

            public string Value => this.Apply();

            public static implicit operator string(StyledOptions options)
            {
                return options.Apply();
            }

            public StyledOptions Add(string text, bool isNewLine = false)
            {
                return new()
                {
                    text = isNewLine ? $"{this.text}\n{text}" : $"{this.text}{text}",
                    color = this.color,
                    size = this.size,
                    isBold = this.isBold,
                    isItalic = this.isItalic,
                };
            }

            public StyledOptions Color(Color color)
            {
                return new()
                {
                    text = this.text,
                    color = ColorUtility.ToHtmlStringRGBA(color),
                    size = this.size,
                    isBold = this.isBold,
                    isItalic = this.isItalic,
                };
            }

            public StyledOptions Size(int size)
            {
                return new()
                {
                    text = this.text,
                    color = this.color,
                    size = size,
                    isBold = this.isBold,
                    isItalic = this.isItalic,
                };
            }

            public string Text(string text)
            {
                StyledOptions options = new()
                {
                    text = text,
                    color = this.color,
                    size = this.size,
                    isBold = this.isBold,
                    isItalic = this.isItalic,
                };

                return options.Apply();
            }

            private string Apply()
            {
                string result = this.text;

                result = $"<color={this.color}>{result}</color>";
                result = $"<size={this.size}>{result}</size>";

                if (this.isBold)
                {
                    result = $"<b>{result}</b>";
                }

                if (this.isItalic)
                {
                    result = $"<i>{result}</i>";
                }

                return result;
            }
        }
    }
}
