using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextMeshProTagGen;
using TMPro;

public class TextTagDebug : MonoBehaviour
{
    private TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text += TagGen.Align(AlignType.Left, "0");
        text.text += TagGen.Allcaps("1Abc");
        text.text += TagGen.Alpha("#2F","2");
        text.text += TagGen.Alpha("#0F","#FF","3");
        text.text += TagGen.Bold("4");
        text.text += TagGen.ColorCode("#FF00FFAA","5");
        text.text += TagGen.ColorName("red","6");
        text.text += TagGen.Cspace(1f,"7");
        text.text += TagGen.Font("Anton SDF","8");
        text.text += TagGen.FontWeight(800,"9");
        text.text += TagGen.Gradient("Blue to Purple - Vertical","A");
        text.text += TagGen.Italic("B");
        text.text += TagGen.Indent(500,"C");
        text.text += TagGen.LineHeight(50,"D\nEF");
        text.text += TagGen.LineIndent(100,"G");
        text.text += TagGen.Link("link","H");
        text.text += TagGen.Lowercase("IAbc");
        text.text += "\n";
        text.text += TagGen.Align(AlignType.Left,
            TagGen.Margin(2, "JK") +
            TagGen.Margin(4, MarginType.Left, "L"));
        text.text += TagGen.Mark("#AA0F0A3F","M");
        text.text += TagGen.Mspace(3,"N O P");
        text.text += "\n";
        text.text += TagGen.Nobr("Q");
        text.text += TagGen.Noparse(TagGen.Bold("R"));
        text.text += TagGen.Page("S");
        text.text += TagGen.Pos(25,"T");
        text.text += TagGen.Rotate(25,"U");
        text.text += TagGen.Strikethrough("V");
        text.text += TagGen.Size(125,"W");
        text.text += TagGen.Smallcaps("XAbc");
        text.text += "\n";
        text.text += TagGen.Space(20,"Y");
        text.text += "\n";
        text.text += TagGen.Space(20,0,"Z");
        text.text += "\n";
        text.text += TagGen.SpriteNum(0);
        text.text += TagGen.SpriteNum(1,"#00FA003F");
        text.text += TagGen.SpriteIndex(2);
        text.text += TagGen.SpriteIndex(3,"#AB0000AB");
        text.text += TagGen.SpriteName("Face with tears of joy");
        text.text += TagGen.SpriteName("1f923", "#0000ABCD");
        text.text += TagGen.Style("Title", "0");
        text.text += TagGen.Subscript("1");
        text.text += TagGen.Superscript("2");
        text.text += TagGen.Underline("3");
        text.text += TagGen.Uppercase("4Abc");
        text.text += TagGen.VerticalOffset(-1, "5");
        text.text += TagGen.Width(100, "6");



    }
    
}
