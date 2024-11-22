using SlackBotMessages;
using SlackBotMessages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Umbraco.Core.Composing;

namespace MyGovCMS.Core.Composing
{
    public class ApplicationComposer:ComponentComposer<ApplicationComponent>,IUserComposer
    {

    }
    public class ApplicationComponent : IComponent
    {
        public void Initialize() {
            try {
                
                var client = new SbmClient(WebConfigurationManager.AppSettings["SlackBotMessagesWebHookUrl"]);

                var message = new Message
                {
                    Username = "Website Bot",
                    IconEmoji = ":robot_face:",
                    Attachments = new List<Attachment>()
                    {
                        new Attachment()
                        {
                            Fallback="Website Started",
                            Color="good",
                            Fields=new List<Field>()
                            {
                                new Field()
                                {
                                    Value="Website Started..."
                                }
                            }
                        }
                    }
                };

                client.Send(message);
            }
            catch(Exception ex) {
                Current.Logger.Error(typeof(ApplicationComponent), ex, "Unable to send slack message to notify site starting up");
            }
            
        }
        public void Terminate() { }
    }

}
