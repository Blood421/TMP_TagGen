using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextMeshProTagGen
{
    public enum AlignType
    {
        Left = 0,
        Center = 1,
        Right = 2, 
        Justified = 3,
        Flush = 4,
    }

    public enum MarginType
    {
        Left = 0,
        Right = 1,
    }
    public class TagGen
    {
        public static string Align(AlignType type, string value)
        {
            switch (type)
            {
                case AlignType.Left:
                    value = "<align=\"left\">" + value + "\n" + "</align>";
                    return value;
                case AlignType.Center:
                    value = "<align=\"center\">" + value + "\n" + "</align>";
                    return value;
                case AlignType.Right:
                    value = "<align=\"right\">" + value + "\n" + "</align>";
                    return value;
                case AlignType.Justified:
                    value = "<align=\"justified\">" + value + "\n" + "</align>";
                    return value;
                case AlignType.Flush:
                    value = "<align=\"flush\">" + value + "\n" + "</align>";
                    return value;
                default:
                    Debug.LogError("TagError");
                    return value;
            }
        }
        public static string Allcaps(string value)
        {
            value = "<allcaps>" + value + "</allcaps>";
            return value;
        }

        public static string Alpha(string alphaCode, string value)
        {
            if (alphaCode[0] == '#')
            {
                value = "<alpha=" + alphaCode + ">" + value + "<alpha=#FF>";
                return value;
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }
        public static string Alpha(string alphaCode, string afterAlphaCode, string value)
        {
            if (alphaCode[0] == '#')
            {
                if (afterAlphaCode[0] == '#')
                {
                    value = "<alpha=" + alphaCode + ">" + value + "<alpha=" + afterAlphaCode + ">";
                    return value;
                }
                else
                {
                    Debug.LogError("TagError");
                    return value;
                }
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }

        public static string Bold(string value)
        {
            value = "<b>" + value + "</b>";
            return value;
        }

        public static string ColorCode(string colorCode, string value)
        {
            Color checkColor;
            if (ColorUtility.TryParseHtmlString(colorCode, out checkColor))
            {
                value = "<color=" + colorCode + ">" + value + "</color>";
                return value;
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }
        public static string ColorName(string colorName, string value)
        {
            if (colorName == "black" ||
                colorName == "blue" ||
                colorName == "green" ||
                colorName == "orange" ||
                colorName == "purple" ||
                colorName == "red" ||
                colorName == "white" ||
                colorName == "yellow")
            {
                value = "<color=\"" + colorName + "\">" + value + "</color>";
                return value;
            }
            Debug.LogError("TagError");
            return value;
        }
        public static string Cspace(float space, string value)
        {
            value = "<cspace=" + space.ToString() + "em>" + value + "</cspace>";
            return value;
        }
        public static string Font(string fontName, string value)
        {
            value = "<font=\"" + fontName + "\">" + value + "</font>";
            return value;
        }
        public static string FontWeight(float weight, string value)
        {
            value = "<font-weight=\"" + weight.ToString() + "\">" + value + "</font-weight>";
            return value;
        }
        public static string Gradient(string gradientAssetName, string value)
        {
            value = "<gradient=\"" + gradientAssetName + "\">" + value + "</gradient>";
            return value;
        }
        public static string Italic(string value)
        {
            value = "<i>" + value + "</i>";
            return value;
        }
        public static string Indent(float indent, string value)
        {
            value = "<indent=\"" + indent.ToString() + "%\">" + value + "</indent>";
            return value;
        }
        public static string LineHeight(float height, string value)
        {
            value = "<line-height=\"" + height.ToString() + "%\">" + value + "</line-height>";
            return value;
        }
        public static string LineIndent(float indent, string value)
        {
            value = "<line-indent=\"" + indent.ToString() + "%\">" + value + "</line-indent>";
            return value;
        }
        public static string Link(string ID, string value)
        {
            value = "<link=\"" + ID + "\">" + value + "</link>";
            return value;
        }
        public static string Lowercase(string value)
        {
            value = "<lowercase>" + value + "</lowercase>";
            return value;
        }
        public static string Margin(float margin, string value)
        {
            value = "<margin=" + margin.ToString() + "em>" + value + "</margin>\n";
            return value;
        }
        public static string Margin(float margin,MarginType type, string value)
        {
            switch (type)
            {
                case MarginType.Left:
                    value = "<margin-left=" + margin.ToString() + "em>" + value + "</margin>\n";
                    return value;
                case MarginType.Right:
                    value = "<margin-right=" + margin.ToString() + "em>" + value + "</margin>\n";
                    return value;
                default:
                    Debug.LogError("TagError");
                    return value;
            }
        }
        public static string Mark(string colorCode, string value)
        {
            Color checkColor;
            if (ColorUtility.TryParseHtmlString(colorCode, out checkColor))
            {
                value = "<mark=" + colorCode + ">" + value + "</mark>";
                return value;
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }

        public static string Mspace(float space, string value)
        {
            value = "<mspace=" + space.ToString() + "em>" + value + "</mspace>";
            return value;
        }

        public static string Nobr(string value)
        {
            value = "<nobr>" + value + "</nobr>";
            return value;
        }

        public static string Noparse(string value)
        {
            value = "<noparse>" + value + "</noparse>";
            return value;
        }
        public static string Page(string value)
        {
            value = "<page>" + value;
            return value;
        }
        public static string Pos(float pos,string value)
        {
            value = "<pos="+ pos.ToString() +"%>" + value;
            return value;
        }
        public static string Rotate(float rotate, string value)
        {
            value = "<rotate=\"" + rotate.ToString() + "\">" + value + "</rotate>";
            return value;
        }
        public static string Strikethrough(string value)
        {
            value = "<s>" + value + "</s>";
            return value;
        }
        public static string Size(float size, string value)
        {
            value = "<size=" + size.ToString() + "%>" + value + "</size>";
            return value;
        }
        public static string Smallcaps(string value)
        {
            value = "<smallcaps>" + value + "</smallcaps>";
            return value;
        }
        public static string Space(float space, string value)
        {
            value = "<space=" + space.ToString() + "em>" + value + "<space=0>";
            return value;
        }
        public static string Space(float space, float afterSpace, string value)
        {
            value = "<space=" + space.ToString() + "em>" + value + "<space=" + afterSpace.ToString() + "em>";
            return value;
        }
        public static string SpriteNum(int num)
        {
            string value = "";
            value = "<sprite=" + num.ToString() + ">";
            return value;
        }
        public static string SpriteNum(int num,string colorCode)
        {
            string value = "";
            Color checkColor;
            if (ColorUtility.TryParseHtmlString(colorCode, out checkColor))
            {

                value = "<sprite=" + num.ToString() + " color=" + colorCode + ">";
                return value;
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }
        public static string SpriteIndex(int index)
        {
            string value = "";
            value = "<sprite index=" + index.ToString() + ">";
            return value;
        }
        public static string SpriteIndex(int index, string colorCode)
        {
            string value = "";
            Color checkColor;
            if (ColorUtility.TryParseHtmlString(colorCode, out checkColor))
            {

                value = "<sprite index=" + index.ToString() + " color=" + colorCode + ">";
                return value;
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }

        public static string SpriteName(string name)
        {
            string value = "";
            value = "<sprite name=\"" + name + "\">";
            return value;
        }
        public static string SpriteName(string name, string colorCode)
        {
            string value = "";
            Color checkColor;
            if (ColorUtility.TryParseHtmlString(colorCode, out checkColor))
            {
                value = "<sprite name=\"" + name + "\" color=" + colorCode + ">";
                return value;
            }
            else
            {
                Debug.LogError("TagError");
                return value;
            }
        }

        public static string Style(string styleName,string value)
        {
            value = "<style=\"" + styleName + "\">" + value + "</style>";
            return value;
        }
        public static string Subscript(string value)
        {
            value = "<sub>" + value + "</sub>";
            return value;
        }
        public static string Superscript(string value)
        {
            value = "<sup>" + value + "</sup>";
            return value;
        }
        public static string Underline(string value)
        {
            value = "<u>" + value + "</u>";
            return value;
        }
        public static string Uppercase(string value)
        {
            value = "<uppercase>" + value + "</uppercase>";
            return value;
        }
        public static string VerticalOffset(float offset, string value)
        {
            value = "<voffset=" + offset.ToString() + "em>" + value + "</voffset>";
            return value;
        }
        public static string Width(float width, string value)
        {
            value = "<width=" + width.ToString() + "%>" + value + "</width>";
            return value;
        }
    }
}

