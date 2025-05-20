using System.Linq;

namespace ThreatLockerCommon.Constants
{
    public class DeploymentMethod
    {
        public static readonly DeploymentMethod ManualDeployment = new DeploymentMethod("Manual Deployment"
            , "manual"
            , ""
            , "");

        public static readonly DeploymentMethod Atera = new DeploymentMethod("Atera"
            , "atera"
            , "deployment/ThreatLockerDeploymentScript-Atera.txt"
            , "https://threatlocker.kb.help/deploying-threatlocker-using-atera-powershell-script/");

        public static readonly DeploymentMethod ConnectWiseControl = new DeploymentMethod("ConnectWise Control"
            , "connectwise-control"
            , "deployment/ThreatLockerDeploymentScript-Ninja.txt"
            , "https://threatlocker.kb.help/deploying-threatlocker-using-connectwise-control/");

        public static readonly DeploymentMethod ConnectWiseAutomate = new DeploymentMethod("ConnectWise Automate"
            , "connectwise-automate"
            , "deployment/automate.zip"
            , "https://threatlocker.kb.help/deploying-threatlocker-with-connectwise-automate/");

        public static readonly DeploymentMethod Continuum = new DeploymentMethod("Continuum"
            , "continuum"
            , "deployment/ThreatLockerDeploymentScript-Continuum.txt"
            , "https://threatlocker.kb.help/deploying-threatlocker-with-connectwise-command-formerly-continuum-rmm/");

        public static readonly DeploymentMethod Datto = new DeploymentMethod("Datto"
            , "datto"
            , ""
            , "https://threatlocker.kb.help/deploying-threatlocker-using-dattormm");

        public static readonly DeploymentMethod Kaseya = new DeploymentMethod("Kaseya"
            , "kaseya"
            , "deployment/kaseya.zip"
            , "https://threatlocker.kb.help/deploying-threatlocker-with-kaseya-vsa/");

        public static readonly DeploymentMethod N_able = new DeploymentMethod("N-able"
            , "n-able"
            , "deployment/solarwindsrmm.zip"
            , "https://threatlocker.kb.help/deploying-threatlocker-with-n-able-rmm/");

        public static readonly DeploymentMethod N_Central = new DeploymentMethod("N-Central"
            , "n-central"
            , "deployment/solarwinds.zip"
            , "https://threatlocker.kb.help/deploying-threatlocker-with-n-central/");

        public static readonly DeploymentMethod Nerdio = new DeploymentMethod("Nerdio"
            , "nerdio"
            , ""
            , "https://threatlocker.kb.help/deploy-threatlocker-using-nerdio-manager-for-msp-nmm/");

        public static readonly DeploymentMethod Ninja = new DeploymentMethod("Ninja"
            , "ninja"
            , "deployment/ThreatLockerDeploymentScript-Ninja.txt"
            , "https://threatlocker.kb.help/deploying-threatlocker-with-ninjarmm-powershell-script");

        public static readonly DeploymentMethod Syncro = new DeploymentMethod("Syncro"
            , "syncro"
            , "deployment/ThreatLockerDeploymentScript-Syncro.txt"
            , "https://threatlocker.kb.help/deploying-threatlocker-using-syncrormm-powershell-script/");

        public DeploymentMethod(string name, string code, string downloadLink, string instructionsLink, bool isActive = true)
        {
            Name = name;
            Code = code;
            DownloadLink = downloadLink;
            InstructionsLink = instructionsLink;
            IsActive = isActive;
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string DownloadLink { get; set; }
        public string InstructionsLink { get; set; }
        public bool IsActive { get; set; }

        public static readonly DeploymentMethod[] All =
        {
            ManualDeployment,
            Atera,
            ConnectWiseControl,
            ConnectWiseAutomate,
            Continuum,
            Datto,
            Kaseya,
            N_able,
            N_Central,
            Nerdio,
            Ninja,
            Syncro
        };

        //Optional Find method
        public static DeploymentMethod FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }

        //Optional Find method
        public static DeploymentMethod FindByCode(string code)
        {
            return All.FirstOrDefault(x => x.Code == code);
        }
    }
}
