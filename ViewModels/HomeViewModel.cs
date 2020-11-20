using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteBakery.Models;

namespace RemoteBakery.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
