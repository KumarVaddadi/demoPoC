using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoPoC.Models;
using MvvmHelpers;

namespace demoPoC.ViewModels
{
    public class CarsDetailViewModel: BaseViewModel
    {
        private Cars _cars;

        public Cars _Cars
        {
            get { return _cars; }
            set { SetProperty(ref _cars, value); }
        }

        public CarsDetailViewModel()
        {


        }

        public void SetData(Cars cars)
        {
            _Cars = cars;


        }
    }
}
