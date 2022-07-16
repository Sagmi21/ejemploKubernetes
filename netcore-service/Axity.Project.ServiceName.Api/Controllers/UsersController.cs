// <summary>
// <copyright file="UsersController.cs" company="Axity">
// This source code is Copyright © Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.Project.ServiceName.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Axity.Project.ServiceName.Dtos.User;
    using Axity.Project.ServiceName.Facade.Catalogs.Users;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using StackExchange.Redis;

    /// <summary>
    /// Class User Controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserFacade logicFacade;

        private readonly IDatabase database;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="logicFacade">User Facade.</param>
        public UsersController(IUserFacade logicFacade)
        {
            this.logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        /// <summary>
        /// Method to get all users.
        /// </summary>
        /// <returns>List of users.</returns>
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this.logicFacade.GetListUsersActive();
            return this.Ok(response);
        }

        /// <summary>
        /// Method to get user By Id.
        /// </summary>
        /// <param name="userId">User Id.</param>
        /// <returns>User Model.</returns>
        [Route("{userId}")]
        [HttpGet]
        public async Task<IActionResult> Get(int userId)
        {
            UserDto response = null;
            response = await this.logicFacade.GetListUserActive(userId);

            return this.Ok(response);
        }

        /// <summary>
        /// Method to Add User.
        /// </summary>
        /// <param name="user">User Model.</param>
        /// <returns>Success or exception.</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDto user)
        {
            var response = await this.logicFacade.InsertUser(user);
            return this.Ok(response);
        }

        /// <summary>
        /// Method Ping.
        /// </summary>
        /// <returns>Pong.</returns>
        [Route("/ping")]
        [HttpGet]
        public IActionResult Ping()
        {
            return this.Ok("Pong");
        }
    }
}