using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Restaurant_
{
    public interface IRestaurant
    {
        public void Start(CancellationToken cancellationToken);
        public Task StopAsync();

    }
}
