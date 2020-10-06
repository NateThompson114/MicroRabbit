﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountServcices _accountServcices;

        public BankingController(IAccountServcices accountServcices)
        {
            _accountServcices = accountServcices;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get() => Ok(_accountServcices.GetAccounts());
    }
}
