﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyNeoloadTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Record_EUE recording.
    /// </summary>
    [TestModule("eeb7f29c-a03f-4a79-9ae5-efbc21c7d889", ModuleType.Recording, 1)]
    public partial class Record_EUE : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyNeoloadTestRepository repository.
        /// </summary>
        public static MyNeoloadTestRepository repo = MyNeoloadTestRepository.Instance;

        static Record_EUE instance = new Record_EUE();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Record_EUE()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Record_EUE Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://ushahidi.demo.neotys.com' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://ushahidi.demo.neotys.com", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Ranorex.NeoLoad.NeoLoadCodeCollection.StartTransaction("Report");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NeoLoadWeb.Mainmenu.Reports' at 40;9.", repo.NeoLoadWeb.Mainmenu.ReportsInfo, new RecordItemIndex(2));
            repo.NeoLoadWeb.Mainmenu.Reports.Click("40;9");
            Delay.Milliseconds(200);
            
            Ranorex.NeoLoad.NeoLoadCodeCollection.StartTransaction("Submit");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NeoLoadWeb.Mainmenu.SubmitAReport' at 36;10.", repo.NeoLoadWeb.Mainmenu.SubmitAReportInfo, new RecordItemIndex(4));
            repo.NeoLoadWeb.Mainmenu.SubmitAReport.Click("36;10");
            Delay.Milliseconds(200);
            
            Ranorex.NeoLoad.NeoLoadCodeCollection.StopTransaction();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NeoLoadWeb.Mainmenu.GetAlerts' at 55;16.", repo.NeoLoadWeb.Mainmenu.GetAlertsInfo, new RecordItemIndex(6));
            repo.NeoLoadWeb.Mainmenu.GetAlerts.Click("55;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NeoLoadWeb.BackToHome' at 46;7.", repo.NeoLoadWeb.BackToHomeInfo, new RecordItemIndex(7));
            repo.NeoLoadWeb.BackToHome.Click("46;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}