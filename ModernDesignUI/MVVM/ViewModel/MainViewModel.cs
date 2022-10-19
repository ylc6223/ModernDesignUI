using ModernDesignUI.Core;

namespace ModernDesignUI.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        // relay转发 传播
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        
        // 定义变量 类型为HomeViewModel
        public HomeViewModel HomeVm { get; set; }
        public DiscoveryViewModel DiscoveryVm { get; set; }
        
        // 定义变量
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView;}
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVm = new DiscoveryViewModel();
            CurrentView = HomeVm;
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVm;
            });
        }
    }
}