using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableApp.Models;
using MvvmHelpers;

namespace PortableApp.ViewModels
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
