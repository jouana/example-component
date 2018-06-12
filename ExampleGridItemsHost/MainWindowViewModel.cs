using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleGridItemsHost
{
    public class MainWindowViewModel : ViewModel
    {
        private IList<CellDataViewModel> datas;

        public IList<CellDataViewModel> Datas
        {
            get => this.datas;
            set
            {
                this.datas = value;
                RaisePropertyChanged();
            }
        }

        public void OnLoaded()
        {
            List<CellDataViewModel> datas = new List<CellDataViewModel>();

            for (int count = 0; count < 12; count++)
            {
                datas.Add(new CellDataViewModel($"Cell {count}"));
            }

            this.Datas = datas;
        }
    }
}
