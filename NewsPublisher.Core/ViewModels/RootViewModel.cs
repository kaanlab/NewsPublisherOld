using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisher.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
        
        private readonly IMvxNavigationService _navigationService;

        #region Commands
        public IMvxAsyncCommand NewArticleCommand { get; }
        #endregion

        public RootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            NewArticleCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<NewArticleViewModel>());
        }

        public override async Task Initialize()
        {
            await base.Initialize();
           
        }
    }
}
