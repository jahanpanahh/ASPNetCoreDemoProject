using AutoMapper;
using DemoProject.Data;
using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Mappings
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Member, MemberViewModel>().ForMember(x => x.ProfileImage, opt => opt.Ignore());
            CreateMap<MemberViewModel, Member>();
            CreateMap<Member, MemberListViewModel>().ReverseMap();
        }
    }
}
