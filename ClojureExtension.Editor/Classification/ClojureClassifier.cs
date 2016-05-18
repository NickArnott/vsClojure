// MIT License Copyright 2010-2013 jmis
// See LICENSE.txt or http://opensource.org/licenses/MIT
// See AUTHORS.txt for a complete list of all contributors

using System;
using System.Collections.Generic;
using ClojureExtension.Editor.Classification;
using ClojureExtension.Parsing;
using Microsoft.ClojureExtension.Editor.Tagger;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Tagging;

namespace Microsoft.ClojureExtension.Editor.Classification
{
	public class ClojureClassifier : ITagger<ClassificationTag>
	{
		private readonly ITextBuffer _buffer;
		private readonly ITagAggregator<ClojureTokenTag> _aggregator;
		private readonly IDictionary<TokenType, IClassificationType> _clojureTypes;
		public event EventHandler<SnapshotSpanEventArgs> TagsChanged;

		public ClojureClassifier(ITextBuffer buffer,
								   ITagAggregator<ClojureTokenTag> clojureTagAggregator,
								   IClassificationTypeRegistryService typeService)
		{
			_buffer = buffer;
			_aggregator = clojureTagAggregator;
			_aggregator.TagsChanged += TokenTagsChanged;
			_clojureTypes = new Dictionary<TokenType, IClassificationType>();
			_clojureTypes[TokenType.Symbol] = typeService.GetClassificationType(Classifications.ClojureSymbol);
			_clojureTypes[TokenType.String] = typeService.GetClassificationType(Classifications.ClojureString);
			_clojureTypes[TokenType.Number] = typeService.GetClassificationType(Classifications.ClojureNumber);
			_clojureTypes[TokenType.HexNumber] = typeService.GetClassificationType(Classifications.ClojureNumber);
			_clojureTypes[TokenType.Comment] = typeService.GetClassificationType(Classifications.ClojureComment);
			_clojureTypes[TokenType.Keyword] = typeService.GetClassificationType(Classifications.ClojureKeyword);
			_clojureTypes[TokenType.Character] = typeService.GetClassificationType(Classifications.ClojureCharacter);
			_clojureTypes[TokenType.BuiltIn] = typeService.GetClassificationType(Classifications.ClojureBuiltIn);
			_clojureTypes[TokenType.Boolean] = typeService.GetClassificationType(Classifications.ClojureBoolean);
			_clojureTypes[TokenType.ListStart] = typeService.GetClassificationType(Classifications.ClojureList);
			_clojureTypes[TokenType.ListEnd] = typeService.GetClassificationType(Classifications.ClojureList);
			_clojureTypes[TokenType.VectorStart] = typeService.GetClassificationType(Classifications.ClojureVector);
			_clojureTypes[TokenType.VectorEnd] = typeService.GetClassificationType(Classifications.ClojureVector);
			_clojureTypes[TokenType.MapStart] = typeService.GetClassificationType(Classifications.ClojureMap);
			_clojureTypes[TokenType.MapEnd] = typeService.GetClassificationType(Classifications.ClojureMap);
		}

		public void TokenTagsChanged(object sender, TagsChangedEventArgs e)
		{
			foreach (var span in e.Span.GetSpans(_buffer)) TagsChanged(this, new SnapshotSpanEventArgs(span));
		}

		public IEnumerable<ITagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans)
		{
			foreach (var tagSpan in _aggregator.GetTags(spans))
			{
				if (!_clojureTypes.ContainsKey(tagSpan.Tag.Token.Type)) continue;
				var tagSpans = tagSpan.Span.GetSpans(spans[0].Snapshot);
				yield return new TagSpan<ClassificationTag>(tagSpans[0], new ClassificationTag(_clojureTypes[tagSpan.Tag.Token.Type]));
			}
		}
	}
}