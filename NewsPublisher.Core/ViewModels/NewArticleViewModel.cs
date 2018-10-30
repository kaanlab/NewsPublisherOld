using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisher.Core.ViewModels
{
    public class NewArticleViewModel : MvxViewModel
    {
        public override async Task Initialize()
        {
            await base.Initialize();

            // do the heavy work here
        }
    }
}
