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
    ///The Recording2 recording.
    /// </summary>
    [TestModule("44bb48f2-64a1-486f-b66d-d0347cd473c8", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyNeoloadTestRepository repository.
        /// </summary>
        public static MyNeoloadTestRepository repo = MyNeoloadTestRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.google.com/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.google.com/", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NeoLoadWeb.LstIb' at 95;20.", repo.NeoLoadWeb.LstIbInfo, new RecordItemIndex(1));
            repo.NeoLoadWeb.LstIb.Click("95;20");
            Delay.Milliseconds(200);
            
            Ranorex.NeoLoad.NeoLoadCodeCollection.StartTransaction("home");
            Delay.Milliseconds(0);
            
            Ranorex.NeoLoad.NeoLoadCodeCollection.SendTimingValues(repo.Chrome.SelfInfo, "");
            Delay.Milliseconds(0);
            
            Ranorex.NeoLoad.NeoLoadCodeCollection.StopTransaction();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NeoLoadWeb.LstIb'.", repo.NeoLoadWeb.LstIbInfo, new RecordItemIndex(5));
            repo.NeoLoadWeb.LstIb.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'NeoLoadWeb.LstIb'.", repo.NeoLoadWeb.LstIbInfo, new RecordItemIndex(6));
            repo.NeoLoadWeb.LstIb.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NeoLoadWeb.TestWikipedia' at 24;5.", repo.NeoLoadWeb.TestWikipediaInfo, new RecordItemIndex(7));
            repo.NeoLoadWeb.TestWikipedia.Click("24;5");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}