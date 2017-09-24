using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableApp.Models;
using PortableApp.Services;
using PortableApp.Constants;

namespace PortableApp.ViewModels
{
    public class CarsViewModel : BaseViewModel
    {
        private Cars _carsSelected;
        public ObservableCollection<Cars> _Cars { get; set; }

        public Cars CarsSelected
        {
            get { return _carsSelected; }
            set
            {
                if (_carsSelected != value)
                {
                    _carsSelected = value;
                    if (_carsSelected != null)
                    {
                        _navigation.PushAsync(new CarsDetailPage(_carsSelected));
                    }
                }
            }
        }


        ICommand getCarsCommand;
        public ICommand GetCarsCommand =>
            getCarsCommand ??
            (getCarsCommand = new Command(async () => await GetCars()));

        public INavigation _navigation;
        public CarsViewModel(INavigation navigation)
        {
            _Cars = new ObservableCollection<Cars>();
            GetCars();
            _navigation = navigation;
        }
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }
        private async Task GetCars()
        {
            if (IsBusy)
                return;

            Exception error = null;
            try
            {
                IsBusy = true;

                var carsService = new CarsService();
                var items = await carsService.GetCarsAsync(string.Format("{0}{1}", ServerConstants.CarsEndpoint, ServerConstants.METHOD_GET_MOVIES));
                _Cars.Clear();
                foreach (var item in items)
                    _Cars.Add(item);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex);
                error = ex;
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
