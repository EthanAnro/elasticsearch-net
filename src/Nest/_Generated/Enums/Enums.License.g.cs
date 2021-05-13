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
namespace Nest
{
	public enum LicenseStatus
	{
		[EnumMember(Value = "valid")]
		Valid,
		[EnumMember(Value = "invalid")]
		Invalid,
		[EnumMember(Value = "expired")]
		Expired,
		[EnumMember(Value = "active")]
		Active
	}

	public enum LicenseType
	{
		[EnumMember(Value = "trial")]
		Trial,
		[EnumMember(Value = "standard")]
		Standard,
		[EnumMember(Value = "silver")]
		Silver,
		[EnumMember(Value = "platinum")]
		Platinum,
		[EnumMember(Value = "missing")]
		Missing,
		[EnumMember(Value = "gold")]
		Gold,
		[EnumMember(Value = "enterprise")]
		Enterprise,
		[EnumMember(Value = "dev")]
		Dev,
		[EnumMember(Value = "basic")]
		Basic
	}
}