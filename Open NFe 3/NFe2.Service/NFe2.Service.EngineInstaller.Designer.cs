namespace NFSe.Service
{
    partial class EngineNFeInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerEngine = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerEngine = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerEngine
            // 
            this.serviceProcessInstallerEngine.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstallerEngine.Password = null;
            this.serviceProcessInstallerEngine.Username = null;
            // 
            // serviceInstallerEngine
            // 
            this.serviceInstallerEngine.DisplayName = "EngineNFe2";
            this.serviceInstallerEngine.ServiceName = "EngineNFe2";
            this.serviceInstallerEngine.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // EngineNFeInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerEngine,
            this.serviceInstallerEngine});

        }

        #endregion

        private System.ServiceProcess.ServiceInstaller serviceInstallerEngine;
        public System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerEngine;
    }
}