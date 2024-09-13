bool CheckForJailbreakApps()
{
    List<string> jailbreakApps = new List<string>
    {
        // Common jailbreak apps
        "/Applications/Cydia.app",
        "/Applications/Sileo.app",
        "/Applications/Zebra.app",
        "/Applications/Anemone.app",
        "/Applications/iFile.app",
        "/Applications/Phantom.app",
        "/Applications/MxTube.app",
        "/Applications/RockApp.app",
        "/Applications/SBSettings.app",
        "/Applications/WinterBoard.app",
        "/Applications/blackra1n.app",
        "/Applications/Checkra1n.app",
        "/Applications/FakeCarrier.app",
        "/Applications/IntelliScreen.app",
        "/Applications/IntelliScreenx.app",
        "/Applications/blackra1n.app",
        "/Applications/AFC2.app",
        "/Applications/MTerminal.app",

        // Less common jailbreak apps
        "/Library/MobileSubstrate/DynamicLibraries/LiveClock.plist",
        "/Library/MobileSubstrate/DynamicLibraries/Veency.plist",
        "/Library/MobileSubstrate/DynamicLibraries/Barrel.plist",
        "/Library/MobileSubstrate/DynamicLibraries/Activator.plist",
        "/Library/MobileSubstrate/DynamicLibraries/SBSettings.plist",

        // Files associated with specific jailbreak tools
        "/private/var/mobile/Library/Preferences/com.unc0ver.unc0ver.plist",
        "/private/var/mobile/Library/Preferences/com.bigboss.repo.plist",
        "/private/var/mobile/Library/Preferences/com.pangu.pangu.plist",
        "/var/root/Library/Preferences/com.ih8sn0w.ih8sn0w.plist"
    };

    foreach (var appPath in jailbreakApps)
    {
        if (File.Exists(appPath))
            return true;
    }
    return false;
}
