using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGridItemsHost
{
    public class CellDataViewModel : ViewModel
    {
        private string name;

        public CellDataViewModel(string name)
        {
            this.name = name;
        }

        public string Name => this.name;
    }
}
