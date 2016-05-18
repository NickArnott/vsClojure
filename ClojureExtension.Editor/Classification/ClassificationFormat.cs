// MIT License Copyright 2010-2013 jmis
// See LICENSE.txt or http://opensource.org/licenses/MIT
// See AUTHORS.txt for a complete list of all contributors

using System.ComponentModel.Composition;
using System.Windows.Media;
using ClojureExtension.Editor.Classification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.ClojureExtension.Editor.Classification
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureSymbol)]
    [Name(Classifications.ClojureSymbol)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureSymbol : ClassificationFormatDefinition
    {
        public ClojureSymbol()
        {
            DisplayName = "Clojure - Symbol";
            ForegroundColor = Theme.Current.Symbol;
            ForegroundCustomizable = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureString)]
    [Name(Classifications.ClojureString)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureString : ClassificationFormatDefinition
    {
        public ClojureString()
        {
            DisplayName = "Clojure - String";
            ForegroundColor = Theme.Current.String;
            ForegroundCustomizable = true;
            IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureNumber)]
    [Name(Classifications.ClojureNumber)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureNumber : ClassificationFormatDefinition
    {
        public ClojureNumber()
        {
            DisplayName = "Clojure - Number";
            ForegroundColor = Theme.Current.Number;
            ForegroundCustomizable = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureComment)]
    [Name(Classifications.ClojureComment)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureComment : ClassificationFormatDefinition
    {
        public ClojureComment()
        {
            DisplayName = "Clojure - Comment";
            ForegroundColor = Theme.Current.Comment;
            ForegroundCustomizable = true;
            IsItalic = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureKeyword)]
    [Name(Classifications.ClojureKeyword)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureKeyword : ClassificationFormatDefinition
    {
        public ClojureKeyword()
        {
            DisplayName = "Clojure - Keyword";
            ForegroundColor = Theme.Current.Keyword;
            ForegroundCustomizable = true;
            IsItalic = true;
            IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureCharacter)]
    [Name(Classifications.ClojureCharacter)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureCharacter : ClassificationFormatDefinition
    {
        public ClojureCharacter()
        {
            DisplayName = "Clojure - Character";
            ForegroundColor = Theme.Current.Character;
            ForegroundCustomizable = true;
            IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureBuiltIn)]
    [Name(Classifications.ClojureBuiltIn)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureBuiltIn : ClassificationFormatDefinition
    {
        public ClojureBuiltIn()
        {
            DisplayName = "Clojure - Built In";
            ForegroundColor = Theme.Current.BuiltIn;
            ForegroundCustomizable = true;
            IsBold = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureBoolean)]
    [Name(Classifications.ClojureBoolean)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureBoolean : ClassificationFormatDefinition
    {
        public ClojureBoolean()
        {
            DisplayName = "Clojure - Boolean";
            ForegroundColor = Theme.Current.Boolean;
            ForegroundCustomizable = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureList)]
    [Name(Classifications.ClojureList)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureList : ClassificationFormatDefinition
    {
        public ClojureList()
        {
            DisplayName = "Clojure - List";
            ForegroundColor = Theme.Current.List;
            ForegroundCustomizable = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureVector)]
    [Name(Classifications.ClojureVector)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureVector : ClassificationFormatDefinition
    {
        public ClojureVector()
        {
            DisplayName = "Clojure - Vector";
            ForegroundColor = Theme.Current.Vector;
            ForegroundCustomizable = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureMap)]
    [Name(Classifications.ClojureMap)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureMap : ClassificationFormatDefinition
    {
        public ClojureMap()
        {
            DisplayName = "Clojure - Map";
            ForegroundColor = Theme.Current.Map;
            ForegroundCustomizable = true;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Classifications.ClojureMetadataTypeHint)]
    [Name(Classifications.ClojureMetadataTypeHint)]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    internal sealed class ClojureMetadataTypeHint : ClassificationFormatDefinition
    {
        public ClojureMetadataTypeHint()
        {
            DisplayName = "Clojure - Type Hint";
            ForegroundColor = Theme.Current.MetadataTypeHint;
            ForegroundCustomizable = true;
        }
    }
}