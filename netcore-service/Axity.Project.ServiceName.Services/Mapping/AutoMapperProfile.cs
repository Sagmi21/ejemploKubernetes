// <summary>
// <copyright file="AutoMapperProfile.cs" company="Axity">
// This source code is Copyright © Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.Project.ServiceName.Services.Mapping
{
    using AutoMapper;
    using Axity.Project.ServiceName.Dtos.User;
    using Axity.Project.ServiceName.Entities.Model;

    /// <summary>
    /// Class Automapper.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
        /// </summary>
        public AutoMapperProfile()
        {
            this.CreateMap<UserModel, UserDto>();
            this.CreateMap<UserDto, UserModel>();
        }
    }
}