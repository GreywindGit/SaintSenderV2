using S22.Imap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

//http://smiley22.github.io/S22.Imap/Documentation/

namespace SaintSenderV2
{
    public class MailHelper
    {
        string hostname = "imap.gmail.com";

        public String LoginCheck(String email, String password)
        {
            using (ImapClient client = new ImapClient(hostname, 993, email, password, AuthMethod.Login, true))
            {
                return("We are connected!");
            }
        }

        public IEnumerable<MailMessage> GetMessages(String email, String password, string filterOption = "")
        {
            try
            {
                using (ImapClient client = new ImapClient(hostname, 993, email, password, AuthMethod.Login, true))
                {
                    SearchCondition searchCondition;
                    switch (filterOption)
                    {
                        case "Unread":
                            searchCondition = SearchCondition.Unseen();
                            break;
                        case "New":
                            searchCondition = SearchCondition.New();
                            break;
                        case "Unanswered":
                            searchCondition = SearchCondition.Unanswered();
                            break;
                        default:
                            searchCondition = SearchCondition.All();
                            break;
                    }
                    // Returns a collection of identifiers of all mails matching the specified search criteria.
                    IEnumerable<uint> uids = client.Search(searchCondition);
                    // Download mail messages from the default mailbox.
                    IEnumerable<MailMessage> messages = client.GetMessages(uids);

                    return messages;
                }
            }
            catch (InvalidCredentialsException)
            {
                return null;
            }
        }



    }
}
