Imports DevExpress.Data.Filtering
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports System
Imports System.Windows.Forms

Namespace Dashboard_FirstValueAggregate
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			BonusSkins.Register()
			SkinManager.EnableFormSkins()
			UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful")
			CriteriaOperator.RegisterCustomFunction(New FirstValueAggregateFunction())
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
