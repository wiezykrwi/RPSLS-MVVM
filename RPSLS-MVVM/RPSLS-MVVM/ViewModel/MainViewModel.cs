using System.Collections.ObjectModel;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

using RPSLS_MVVM.Business;

namespace RPSLS_MVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IGameLogic _gameLogic;

        public MainViewModel(IGameLogic gameLogic)
        {
            _gameLogic = gameLogic;
        }

        public ICommand RockCommand => new RelayCommand(() => Play(Option.Rock));
        public ICommand PaperCommand => new RelayCommand(() => Play(Option.Paper));
        public ICommand ScissorsCommand => new RelayCommand(() => Play(Option.Scissors));
        public ICommand LizardCommand => new RelayCommand(() => Play(Option.Lizard));
        public ICommand SpockCommand => new RelayCommand(() => Play(Option.Spock));

        public ObservableCollection<string> Results { get; } = new ObservableCollection<string>();

        private void Play(Option option)
        {
            var result = _gameLogic.Play(option);
            Results.Add(result);
        }
    }
}