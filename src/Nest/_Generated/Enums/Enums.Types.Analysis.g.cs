// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Runtime.Serialization;

#nullable restore
namespace Nest.Types.Analysis
{
	public enum DelimitedPayloadEncoding
	{
		[EnumMember(Value = "int")]
		Integer,
		[EnumMember(Value = "identity")]
		Identity,
		[EnumMember(Value = "float")]
		Float
	}

	public enum EdgeNGramSide
	{
		[EnumMember(Value = "front")]
		Front,
		[EnumMember(Value = "back")]
		Back
	}

	public enum KeepTypesMode
	{
		[EnumMember(Value = "include")]
		Include,
		[EnumMember(Value = "exclude")]
		Exclude
	}

	public enum NoriDecompoundMode
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "mixed")]
		Mixed,
		[EnumMember(Value = "discard")]
		Discard
	}

	public enum SnowballLanguage
	{
		[EnumMember(Value = "Turkish")]
		Turkish,
		[EnumMember(Value = "Swedish")]
		Swedish,
		[EnumMember(Value = "Spanish")]
		Spanish,
		[EnumMember(Value = "Russian")]
		Russian,
		[EnumMember(Value = "Romanian")]
		Romanian,
		[EnumMember(Value = "Portuguese")]
		Portuguese,
		[EnumMember(Value = "Porter")]
		Porter,
		[EnumMember(Value = "Norwegian")]
		Norwegian,
		[EnumMember(Value = "Lovins")]
		Lovins,
		[EnumMember(Value = "Kp")]
		Kp,
		[EnumMember(Value = "Italian")]
		Italian,
		[EnumMember(Value = "Hungarian")]
		Hungarian,
		[EnumMember(Value = "German2")]
		German2,
		[EnumMember(Value = "German")]
		German,
		[EnumMember(Value = "French")]
		French,
		[EnumMember(Value = "Finnish")]
		Finnish,
		[EnumMember(Value = "English")]
		English,
		[EnumMember(Value = "Dutch")]
		Dutch,
		[EnumMember(Value = "Danish")]
		Danish,
		[EnumMember(Value = "Catalan")]
		Catalan,
		[EnumMember(Value = "Basque")]
		Basque,
		[EnumMember(Value = "Armenian")]
		Armenian
	}

	public enum SynonymFormat
	{
		[EnumMember(Value = "wordnet")]
		Wordnet,
		[EnumMember(Value = "solr")]
		Solr
	}

	public enum TokenChar
	{
		[EnumMember(Value = "whitespace")]
		Whitespace,
		[EnumMember(Value = "symbol")]
		Symbol,
		[EnumMember(Value = "punctuation")]
		Punctuation,
		[EnumMember(Value = "letter")]
		Letter,
		[EnumMember(Value = "digit")]
		Digit,
		[EnumMember(Value = "custom")]
		Custom
	}
}