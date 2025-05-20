using NUnit.Framework;
using RuleEngine;
using System;
using System.Text.RegularExpressions;
using ThreatLocker.Helper;

namespace RuleEngineTest
{
    [TestFixture]
    public class RulesEngineSuccessTest
    {
        [Test]
        public void GetAppNameRulesEngine()
        {
            // Veeam.
            RuleEngine.ActionLogItem veeamItem = new RuleEngine.ActionLogItem()
            {
                Path = @"c:\phf",
                CertSubject = "this is a cert containing a valid cert o=veeam software"
            };

            var ruleModuleType = RuleModuleType<RuleEngine.ActionLogItem, string>.LearningApplicationName;
            ruleModuleType.RuleObject = veeamItem;
            string appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");

            Assert.That(appName == "Veeam", $"Result: {appName}, Expected: Veeam");

            // NO MATCH.
            RuleEngine.ActionLogItem noMatchItem = new RuleEngine.ActionLogItem()
            {
                Path = @"c:\phfd",
                CertSubject = "blah"
            };

            ruleModuleType.RuleObject = noMatchItem;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");

            Assert.That(appName == "Phfd", $"Result: {appName}, Expected: Phfd");

            // CrowdStrike.
            RuleEngine.ActionLogItem crowdStrikeItem = new RuleEngine.ActionLogItem()
            {
                Path = @"c:\program files\csinstalltemp",
                CertSubject = "this is a cert containing a valid cert o=veeam software"
            };

            ruleModuleType.RuleObject = crowdStrikeItem;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Crowdstrike", $"Result: {appName}, Expected: Crowdstrike");


            // RapidFire Tools.
            RuleEngine.ActionLogItem rapidFireItem = new RuleEngine.ActionLogItem()
            {
                Path = @"c:\prograsdsaam files\csinstalsaadsltemp",
                CertSubject = "this is a cert containing a valid cert o=rapidfire tools"
            };

            ruleModuleType.RuleObject = rapidFireItem;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Rapidfire Tools", $"Result: {appName}, Expected: Rapidfire Tools");

            // Bomgar.
            RuleEngine.ActionLogItem bomgarItem = new RuleEngine.ActionLogItem()
            {
                Path = @"c:\programdata\bomgar",
                CertSubject = "this is a ce"
            };

            ruleModuleType.RuleObject = bomgarItem;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Bomgar", $"Result: {appName}, Expected: Bomgar");

            // no match.
            RuleEngine.ActionLogItem nomatchItem3 = new RuleEngine.ActionLogItem()
            {
                Path = @"c:\psdfsdfsfdltemp",
                CertSubject = "this issdfsd cert sdfsdfire tools"
            };

            ruleModuleType.RuleObject = nomatchItem3;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Psdfsdfsfdltemp", $"Result: {appName}, Expected: Psdfsdfsfdltemp");

            // Webroot.
            RuleEngine.ActionLogItem webrootItem = new RuleEngine.ActionLogItem()
            {
                Path = @":\windows\system32\wrusr.dll",
                CertSubject = "th"
            };

            ruleModuleType.RuleObject = webrootItem;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Webroot", $"Result: {appName}, Expected: Webroot");

            // LogMeIn Rescue Applet.
            RuleEngine.ActionLogItem logmein = new RuleEngine.ActionLogItem()
            {
                Path = @":\windossdsd\appdata\local\lmir.bat",
                CertSubject = "th"
            };

            ruleModuleType.RuleObject = logmein;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Logmein Rescue Applet", $"Result: {appName}, Expected: Logmein Rescue Applet");

            // No match.
            RuleEngine.ActionLogItem driverMultipleConditions = new RuleEngine.ActionLogItem()
            {
                Path = @":\windossdsd\appdat\hpa\local\lmir.bat\systs\",
                CertSubject = "th"
            };

            ruleModuleType.RuleObject = driverMultipleConditions;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Windossdsd", $"Result: {appName}, Expected: Windossdsd");

            // Chromium extension.
            RuleEngine.ActionLogItem chromeExtension = new RuleEngine.ActionLogItem()
            {
                Path = @"C:\randomrandom\this is a manifest\akjsdbkajsbdkajbkjbkjdasd\extention\manifest.json",
                CertSubject = "th",
                ApplicationName = "Talend API Tester"
            };

            ruleModuleType.RuleObject = chromeExtension;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Chromium Extension Talend Api Tester", $"Result: {appName}, Expected: Chromium Extension Talend Api Tester");

            // Driver Rule.
            RuleEngine.ActionLogItem driverTest23 = new RuleEngine.ActionLogItem()
            {
                Path = "C:\\random file\\what is this",
                CertSubject = "to=novatek microelectronicsh",
            };

            ruleModuleType.RuleObject = driverTest23;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "$ADR-VM\\Drivers", $"Result: {appName}, Expected: $ADR-VM\\Drivers");


            // Next Folder.
            RuleEngine.ActionLogItem testGetNextFolder = new RuleEngine.ActionLogItem()
            {
                Path = "C:\\windows\\microsoft.net\\assembly\\",
                ProcessPath = "C:\\program files\\My next folder"
            };

            ruleModuleType.RuleObject = testGetNextFolder;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "My Next Folder", $"Result: {appName}, Expected: My Next Folder");

            // Driver.
            RuleEngine.ActionLogItem brotherDriver = new RuleEngine.ActionLogItem()
            {
                Path = "C:\\brother\\assembly\\",
            };

            ruleModuleType.RuleObject = brotherDriver;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "$ADR-VM\\Drivers", $"Result: {appName}, Expected: $ADR-VM\\Drivers");

            //  Driver Rules.
            RuleEngine.ActionLogItem testGrouping = new RuleEngine.ActionLogItem()
            {
                Path = "C:\\what\\hp\\test\\system32\\spool\\drivedrs\\program files\\winvdowsapps\\"
            };

            ruleModuleType.RuleObject = testGrouping;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "$ADR-VM\\Drivers", $"Result: {appName}, Expected: $ADR-VM\\Drivers");

            // Connectwise Automate Script.
            RuleEngine.ActionLogItem fileNaming36 = new RuleEngine.ActionLogItem()
            {
                Path = "C:\\what\\fp\\test\\systed32\\spool\\appdata\\local\\\\windjowsapps\\testhjgijuhectsudyhgithubhjgyfhg.ps1"
            };

            ruleModuleType.RuleObject = fileNaming36;
            appName = RuleManager.EvaluateRules(ruleModuleType, "ADR-VM");
            Assert.That(appName == "Connectwise Automate Scripts", $"Result: {appName}, Expected: Connectwise Automate Scripts");
        }

        [Test]
        public void GetAppNameLegacy()
        {
            ThreatLocker.Helper.ActionLogItem veeamItem = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"c:\phf",
                certSubject = "this is a cert containing a valid cert o=veeam software"
            };

            string appName = ThreatLocker.Applications.AppName.GetAppName(veeamItem, "ADR-VM");
            Assert.That(appName == "Veeam", $"Result: {appName}, Expected: Veeam");

            ThreatLocker.Helper.ActionLogItem noMatchItem = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"c:\phfd",
                certSubject = "blah"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(noMatchItem, "ADR-VM");
            Assert.That(appName == "Phfd", $"Result: {appName}, Expected: Phfd");


            ThreatLocker.Helper.ActionLogItem crowdStrikeItem = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"c:\program files\csinstalltemp",
                certSubject = "this is a cert containing a valid cert o=veeam software"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(crowdStrikeItem, "ADR-VM");
            Assert.That(appName == "Crowdstrike", $"Result: {appName}, Expected: Crowdstrike");

            ThreatLocker.Helper.ActionLogItem rapidFireItem = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"c:\prograsdsaam files\csinstalsaadsltemp",
                certSubject = "this is a cert containing a valid cert o=rapidfire tools"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(rapidFireItem, "ADR-VM");
            Assert.That(appName == "Rapidfire Tools", $"Result: {appName}, Expected: Rapidfire Tools");

            ThreatLocker.Helper.ActionLogItem bomgarItem = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"c:\programdata\bomgar",
                certSubject = "this is a ce"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(bomgarItem, "ADR-VM");
            Assert.That(appName == "Bomgar", $"Result: {appName}, Expected: Bomgar");

            ThreatLocker.Helper.ActionLogItem nomatchItem3 = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"c:\psdfsdfsfdltemp",
                certSubject = "this issdfsd cert sdfsdfire tools"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(nomatchItem3, "ADR-VM");
            Assert.That(appName == "Psdfsdfsfdltemp", $"Result: {appName}, Expected: Psdfsdfsfdltemp");

            ThreatLocker.Helper.ActionLogItem webrootItem = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @":\windows\system32\wrusr.dll",
                certSubject = "th"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(webrootItem, "ADR-VM");
            Assert.That(appName == "Webroot", $"Result: {appName}, Expected: Webroot");

            ThreatLocker.Helper.ActionLogItem logmein = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @":\windossdsd\appdata\local\lmir.bat",
                certSubject = "th"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(logmein, "ADR-VM");
            Assert.That(appName == "Logmein Rescue Applet", $"Result: {appName}, Expected: Logmein Rescue Applet");

            ThreatLocker.Helper.ActionLogItem driverMultipleConditions = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @":\windossdsd\appdat\hpa\local\lmir.bat\systs\",
                certSubject = "th"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(driverMultipleConditions, "ADR-VM");
            Assert.That(appName == "Windossdsd", $"Result: {appName}, Expected: Windossdsd");


            ThreatLocker.Helper.ActionLogItem chromeExtension = new ThreatLocker.Helper.ActionLogItem()
            {
                path = @"C:\randomrandom\this is a manifest\akjsdbkajsbdkajbkjbkjdasd\extention\manifest.json",
                certSubject = "th",
                applicationName = "Talend API Tester"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(chromeExtension, "ADR-VM");
            Assert.That(appName == "Chromium Extension Talend Api Tester", $"Result: {appName}, Expected: Chromium Extension Talend Api Tester");


            ThreatLocker.Helper.ActionLogItem driverTest23 = new ThreatLocker.Helper.ActionLogItem()
            {
                path = "C:\\random file\\what is this",
                certSubject = "to=novatek microelectronicsh"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(driverTest23, "ADR-VM");
            Assert.That(appName == "$ADR-VM\\Drivers", $"Result: {appName}, Expected: $ADR-VM\\Drivers");

            ThreatLocker.Helper.ActionLogItem testGetNextFolder = new ThreatLocker.Helper.ActionLogItem()
            {
                path = "C:\\windows\\microsoft.net\\assembly\\",
                processPath = "C:\\program files\\My next folder"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(testGetNextFolder, "ADR-VM");
            Assert.That(appName == "My Next Folder", $"Result: {appName}, Expected: My Next Folder");

            ThreatLocker.Helper.ActionLogItem brotherDriver = new ThreatLocker.Helper.ActionLogItem()
            {
                path = "C:\\brother\\assembly\\"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(brotherDriver, "ADR-VM");
            Assert.That(appName == "$ADR-VM\\Drivers", $"Result: {appName}, Expected: $ADR-VM\\Drivers");

            ThreatLocker.Helper.ActionLogItem testGrouping = new ThreatLocker.Helper.ActionLogItem()
            {
                path = "C:\\what\\hp\\test\\system32\\spool\\drivedrs\\program files\\winvdowsapps\\"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(testGrouping, "ADR-VM");
            Assert.That(appName == "$ADR-VM\\Drivers", $"Result: {appName}, Expected: $ADR-VM\\Drivers");

            ThreatLocker.Helper.ActionLogItem fileNaming36 = new ThreatLocker.Helper.ActionLogItem()
            {
                path = "C:\\what\\fp\\test\\systed32\\spool\\appdata\\local\\\\windjowsapps\\testhjgijuhectsudyhgithubhjgyfhg.ps1"
            };

            appName = ThreatLocker.Applications.AppName.GetAppName(fileNaming36, "ADR-VM");
            Assert.That(appName == "Connectwise Automate Scripts", $"Result: {appName}, Expected: Connectwise Automate Scripts");
        }
    }
}