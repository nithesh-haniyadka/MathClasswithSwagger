using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MathClass.Model;
using MathClass.Service;

namespace MathClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMathOperations _op;
        public ValuesController(IMathOperations op)
        {
            _op = op;
        }

        [Route("Add")]
        [HttpPost]
        public ActionResult AddFun(InputValues values)
        {
            return Ok(_op.AddFun(values));
        }


        [Route("Substract")]
        [HttpPost]
        public ActionResult SubFun(InputValues values)
        {
            return Ok(_op.SubFun(values));
        }


        [Route("Multiply")]
        [HttpPost]
        public ActionResult MulFun(InputValues values)
        {
            return Ok(_op.MulFun(values));
        }


        [Route("Divide")]
        [HttpPost]

        public ActionResult DivFun(InputValues values)
        {
            return Ok(_op.DivFun(values));
        }

    }
}
