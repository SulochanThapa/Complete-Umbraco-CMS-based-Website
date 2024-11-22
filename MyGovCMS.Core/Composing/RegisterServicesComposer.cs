using MyGovCMS.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace MyGovCMS.Core.Composing
{
   public  class RegisterServicesComposer:IUserComposer
    {
        public void Compose(Composition composition)
        {
            //var serviceContainer = composition.Concrete as LightInject.ServiceContainer;
            //serviceContainer.RegisterApiControllers(GetType().Assembly);
            composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);
        }
    }
}
