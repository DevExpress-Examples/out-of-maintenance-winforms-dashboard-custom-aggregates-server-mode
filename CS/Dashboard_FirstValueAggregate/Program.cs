using DevExpress.Data.Filtering;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace Dashboard_FirstValueAggregate
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            CriteriaOperator.RegisterCustomFunction(new FirstValueAggregateFunction());
            Application.Run(new Form1());      
        }
    }
}
