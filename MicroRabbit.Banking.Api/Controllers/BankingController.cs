using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountServices _accountServices;

        public BankingController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get() => Ok(_accountServices.GetAccounts());

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        {
            // 1st BackingTransferToBus Starts here
            _accountServices.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
