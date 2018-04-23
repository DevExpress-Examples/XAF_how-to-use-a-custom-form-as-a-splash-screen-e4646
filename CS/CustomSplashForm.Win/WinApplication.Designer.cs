namespace CustomSplashForm.Win {
    partial class CustomSplashFormWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = @"Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=CustomSplashForm";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // CustomSplashFormWindowsFormsApplication
            // 
            this.ApplicationName = "CustomSplashForm";
            this.Connection = this.sqlConnection1;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomSplashFormWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.CustomSplashFormWindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}
