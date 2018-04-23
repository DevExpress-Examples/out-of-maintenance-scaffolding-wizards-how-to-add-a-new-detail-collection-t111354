using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;
using Scaffolding.DetailCollections.Model;
using System.Data.Entity;
using DevExpress.Internal;

namespace Scaffolding.DetailCollections {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ApplicationThemeHelper.UpdateApplicationThemeName();
            DbEngineDetector.PatchConnectionStringsAndConfigureEntityFrameworkDefaultConnectionFactory();
            Database.SetInitializer<DepartmentContext>(new DepartmentContextInitializer());
        }

        protected override void OnExit(ExitEventArgs e) {
            ApplicationThemeHelper.SaveApplicationThemeName();
        }
    }
}
