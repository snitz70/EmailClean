using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailClean.Data;

namespace EmailClean
{
    public class EmailClean
    {
        private IQueryManager _querymanager;
        private Iclock _systemclock;

        public int DomainID { get; set; }
        public string Folder { get; set; }
        public int Days { get; set; }


        public EmailClean()
        {
            _querymanager = new QueryManager();
            _systemclock = new SystemClock();
        }

        public IQueryManager querymanager
        {
            get { return _querymanager; }
            set { _querymanager = value; }
        }

        public Iclock systemclock
        {
            get { return _systemclock; }
            set { _systemclock = value; }
        }

        public int StartCleaning(int DomainID, string Folder, int Days)
        {
            #region Validate properties

            if (String.IsNullOrWhiteSpace(Folder))
            {
                throw new Exception("Can't leave folder blank");
            }
            if (Days < 1 || Days > 30)
            {
                throw new Exception("Days must be between 1-30");
            }
            if (DomainID < 1)
            {
                throw new Exception("Domain ID must not be empty");
            }
            #endregion

            List<dynamic> messages = querymanager.GetMessages(DomainID, Folder,
                GetDateFromDaysToKeep(Days));
            return messages.Count;
        }

        public DateTime GetDateFromDaysToKeep(int daysToKeep)
        {
            return systemclock.Now.AddDays((double)(daysToKeep * -1));
        }

        public List<hmail.hm_domain> GetDomains()
        {
            return querymanager.GetDomains();
        }
    }
}
