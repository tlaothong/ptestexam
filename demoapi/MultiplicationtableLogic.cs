using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoapi
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplicationtableLogic : ControllerBase
    {
        public double Multiplicationtable (int Number)
        {
            return Number*3
            ;
        }
        

    }
}