using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using hmail;

namespace EmailClean.Data
{
    public interface IQueryManager
    {
        List<hm_domain> GetDomains();
        List<dynamic> GetMessages(int domainid, string folder, DateTime dateToKeep);
    }

    public class QueryManager : IQueryManager
    {
        public List<dynamic> result = new List<dynamic>();

        public List<hm_domain> GetDomains()
        {
            string query = "SELECT domainid, domainname from hm_domains";
            using (Database db = new Database("EmailClean.Data.Properties.Settings.MySql"))
            {
                return db.Fetch<hm_domain>(query);
            }
        }

        public List<dynamic> GetMessages(int domainid, string folder, DateTime dateToKeep)
        {
            string Query = "SELECT accountaddress, messageid, messagefilename " +
                "FROM hm_messages " +
                "JOIN hm_imapfolders ON messagefolderid = folderid " +
                "JOIN hm_accounts ON folderaccountid = accountid " +
                "JOIN hm_domains ON accountdomainid = domainid " +
                "WHERE hm_imapfolders.foldername = @0 and hm_domains.domainid = @1 " +
                "and hm_messages.messagecreatetime < @2";

            using (Database db = new Database("EmailClean.Data.Properties.Settings.MySql"))
            {
                db.CommandTimeout = 600;

                result = db.Fetch<dynamic>(Query,
                    folder, domainid, dateToKeep);
            }

            return result;
        }
    }
}
