using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ClojureExtension.Editor.Classification
{
    public static class Classifications
    {
        public const string ClojureSymbol = "ClojureSymbol";
        public const string ClojureString = "ClojureString";
        public const string ClojureNumber = "ClojureNumber";
        public const string ClojureComment = "ClojureComment";
        public const string ClojureKeyword = "ClojureKeyword";
        public const string ClojureCharacter = "ClojureCharacter";
        public const string ClojureBuiltIn = "ClojureBuiltIn";
        public const string ClojureBoolean = "ClojureBoolean";
        public const string ClojureList = "ClojureList";
        public const string ClojureVector = "ClojureVector";
        public const string ClojureMap = "ClojureMap";
        public const string ClojureMetadataTypeHint = "ClojureMetadataTypeHint";
    }

    public static class Theme
    {
        public static readonly ITheme Current = new DarkTheme();
    }

    public interface ITheme
    {
        Color Symbol { get; }
        Color String { get; }
        Color Number { get; }
        Color Comment { get; }
        Color Keyword { get; }
        Color Character { get; }
        Color BuiltIn { get; }
        Color Boolean { get; }
        Color List { get; }
        Color Vector { get; }
        Color Map { get; }
        Color MetadataTypeHint { get; }

        Color BraceNotFound { get; }
        Color BraceFound { get; }
    }

    public class DefaultTheme : ITheme
    {
        public Color Symbol { get { return Color.FromRgb(0, 0, 128); } }
        public Color String { get { return Color.FromRgb(0, 128, 0); } }
        public Color Number { get { return Color.FromRgb(0, 0, 255); } }
        public Color Comment { get { return Color.FromRgb(128, 128, 128); } }
        public Color Keyword { get { return Color.FromRgb(102, 14, 122); } }
        public Color Character { get { return Color.FromRgb(0, 128, 0); } }
        public Color BuiltIn { get { return Color.FromRgb(255, 165, 0); } }
        public Color Boolean { get { return Color.FromRgb(0, 0, 255); } }
        public Color List { get { return Color.FromRgb(0,0,0); } }
        public Color Vector { get { return Color.FromRgb(0,0,0); } }
        public Color Map { get { return Color.FromRgb(0,0,0); } }
        public Color MetadataTypeHint { get { return Color.FromRgb(53, 145, 175); } }

        public Color BraceNotFound { get { return Color.FromRgb(255, 228, 225); } }
        public Color BraceFound { get { return Color.FromRgb(173, 216, 230); } }
    }

    public class DarkTheme : ITheme
    {
        public Color Symbol { get { return Color.FromRgb(112, 193, 112); } }
        public Color String { get { return Color.FromRgb(255, 163, 122); } }
        public Color Number { get { return Color.FromRgb(255, 163, 122); } }
        public Color Comment { get { return Color.FromRgb(128, 128, 128); } }
        public Color Keyword { get { return Color.FromRgb(189, 114, 206); } }
        public Color Character { get { return Color.FromRgb(255, 122, 122); } }
        public Color BuiltIn { get { return Color.FromRgb(112, 193, 112); } }
        public Color Boolean { get { return Color.FromRgb(189, 114, 206); } }
        public Color List { get { return Color.FromRgb(255, 255, 255); } }
        public Color Vector { get { return Color.FromRgb(255, 255, 255); } }
        public Color Map { get { return Color.FromRgb(255, 255, 255); } }
        public Color MetadataTypeHint { get { return Color.FromRgb(53, 145, 175); } }

        public Color BraceNotFound { get { return Color.FromRgb(76, 8, 0); } }
        public Color BraceFound { get { return Color.FromRgb(0, 80, 105); } }
    }
}