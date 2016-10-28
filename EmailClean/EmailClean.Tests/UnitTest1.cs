using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EmailClean.Data;

namespace EmailClean.Tests
{
    public class StubQueryManager : IQueryManager
    {
        public List<hmail.hm_domain> GetDomains()
        {
            List<hmail.hm_domain> test = new List<hmail.hm_domain>();
            hmail.hm_domain first = new hmail.hm_domain();
            first.domainname = "One";
            first.domainid = 1;
            test.Add(first);
            return test;
        }

        public List<dynamic> GetMessages(int domainid, string folder, DateTime dateToKeep)
        {
            List<dynamic> test = new List<dynamic>();
            test.Add("test one");
            return test;
        }
    }

    public class StubSystemClock : Iclock
    {
        public DateTime Now { get { return new DateTime(2016, 10, 24); } }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDisplayDomainsReturnsOne()
        {
            StubQueryManager querymanager = new StubQueryManager();
            EmailClean email = new EmailClean();
            email.querymanager = querymanager;
            Assert.AreEqual(1, email.GetDomains().Count);
        }

        [TestMethod]
        public void TestDaysToKeep_Returns_Correct_Date()
        {
            StubSystemClock stubsystemclock = new StubSystemClock();
            EmailClean email = new EmailClean();
            email.systemclock = stubsystemclock;
            Assert.AreEqual(email.GetDateFromDaysToKeep(14).ToString(), "10/10/2016 12:00:00 AM");
        }

        [TestMethod]
        public void TestGetMessagesReturnsOne()
        {
            StubQueryManager querymanager = new StubQueryManager();
            EmailClean email = new EmailClean();
            email.querymanager = querymanager;
            Assert.AreEqual(1, email.StartCleaning());
        }
    }
}
