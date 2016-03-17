﻿


//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace StandardWeb.Models.Maps
{
	using Orzoo.AspNet.Infrastructure;
	using StandardWeb.Models.PO;
	using StandardWeb.Models.DTO;

    public partial class PersonMapProfile : MapProfile
    {
        protected override void Configure()
        {
            AddMap<Person, PersonDto>()
				;
            AddMap<Person, PersonItemDto>()
				.ForMember(d => d.Display, opt => opt.MapFrom(d => d.Name + "(" + d.Email  + "}"))
				;
            AddMap<PersonDto, Person>()
				;

            base.Configure();
        }
    }
}