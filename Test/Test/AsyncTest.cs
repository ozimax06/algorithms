using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class AsyncTest
    {
        

        public async Task Foo()
        {
            await Task.Run(() =>
            {
                for (int counter = 0; counter < 50000000; counter++)
                {
                    for (int i = 0; i < 50; i++)
                    {

                    }

                }
                Console.WriteLine("Countin completed");
            });
        }
    }
}
