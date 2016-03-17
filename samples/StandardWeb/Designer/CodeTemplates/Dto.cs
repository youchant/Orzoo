﻿


//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace StandardWeb.Models.DTO
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using Orzoo.Core.Data;

    /// <summary>
    /// 人员
    /// </summary>
	[DisplayName("人员")]
    public partial class PersonDto : IDto, IEntity<int>
    {
        /// <summary>
		/// Id
		/// </summary>
		[Display(ResourceType = null, Name = "Id")]
		[UIHint("Hidden")]
		[Required]
		public int Id { get; set; }
        /// <summary>
		/// 名称
		/// </summary>
		[Display(ResourceType = null, Name = "名称")]
		[Required]
		public string Name { get; set; }
        /// <summary>
		/// 邮件
		/// </summary>
		[Display(ResourceType = null, Name = "邮件")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
        /// <summary>
		/// 生日
		/// </summary>
		[Display(ResourceType = null, Name = "生日")]
		public Nullable<System.DateTime> Birth { get; set; }
    }
}

namespace StandardWeb.Models.DTO
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using Orzoo.Core.Data;

    /// <summary>
    /// 人员
    /// </summary>
	[DisplayName("人员")]
    public partial class PersonItemDto : IDto, IEntity<int>
    {
        /// <summary>
		/// Id
		/// </summary>
		[Display(ResourceType = null, Name = "Id")]
		[UIHint("Hidden")]
		[Required]
		public int Id { get; set; }
        /// <summary>
		/// 名称
		/// </summary>
		[Display(ResourceType = null, Name = "名称")]
		[Required]
		public string Name { get; set; }
        /// <summary>
		/// 邮件
		/// </summary>
		[Display(ResourceType = null, Name = "邮件")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
        /// <summary>
		/// 生日
		/// </summary>
		[Display(ResourceType = null, Name = "生日")]
		public Nullable<System.DateTime> Birth { get; set; }
        /// <summary>
		/// 显示
		/// </summary>
		[Display(ResourceType = null, Name = "显示")]
		public string Display { get; set; }
    }
}
