using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaSystem.Core;

namespace VeterinariaSystem.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand SearchViewCommand { get; set; }
        
        //Enlazamos las vistas aqui
        public HomeViewModel HomeVM { get; set; }

        public SearchViewModel SearchVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; 
            OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SearchVM = new SearchViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });


            SearchViewCommand = new RelayCommand(o =>
            {
                CurrentView = SearchVM;
            });
        }
            
    }
}
