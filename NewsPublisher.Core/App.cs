using MvvmCross.ViewModels;
using NewsPublisher.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublisher.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<RootViewModel>();
        }
    }
}
