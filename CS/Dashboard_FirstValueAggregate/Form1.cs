using DevExpress.XtraBars.Ribbon;

namespace Dashboard_FirstValueAggregate {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.LoadDashboard(@"..\..\Data\FirstValueAggregate.xml");
        }
    }
}
