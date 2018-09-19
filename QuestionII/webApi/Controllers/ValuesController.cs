using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{n}")]
        public int[][] GetTable(int n)
        {
            var test = new multiTable();
            test.printTable(n);
            var number = test.Number;
            return number ;
        }

    }

    public class multiTable
    {
        public int[][] Number;

        public void printTable(int n)
        {
            Number = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Number[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Number[i][j] = (i+1) * (j+1);
                }
            }
        }



    }


}
