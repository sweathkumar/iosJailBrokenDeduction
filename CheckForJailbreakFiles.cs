bool CheckForJailbreakFiles()
{
    List<string> knownPaths = new List<string>
    {
        // Common paths
        "/Applications/Cydia.app",
        "/Applications/Sileo.app",
        "/Applications/Zebra.app",
        "/Library/MobileSubstrate/MobileSubstrate.dylib",
        "/usr/sbin/sshd",
        "/bin/bash",
        "/etc/apt",
        "/private/var/lib/cydia",
        "/private/var/stash",
        "/private/var/tmp/cydia.log",

        // Less common paths
        "/Applications/Checkra1n.app",
        "/Applications/FakeCarrier.app",
        "/Applications/IntelliScreen.app",
        "/Applications/IntelliScreenx.app",
        "/Applications/MxTube.app",
        "/Applications/RockApp.app",
        "/Applications/SBSettings.app",
        "/Applications/WinterBoard.app",
        "/Applications/blackra1n.app",
        "/Library/MobileSubstrate/DynamicLibraries/LiveClock.plist",
        "/Library/MobileSubstrate/DynamicLibraries/Veency.plist",
        "/System/Library/LaunchDaemons/com.ikey.bbot.plist",
        "/System/Library/LaunchDaemons/com.saurik.Cydia.Startup.plist",
        "/private/var/lib/apt",
        "/private/var/lib/cydia",
        "/private/var/mobile/Library/SBSettings/Themes",
        "/private/var/stash",
        "/private/var/tmp/cydia.log",
        "/usr/bin/sshd",
        "/var/cache/apt",
        "/var/lib/apt",
        "/var/lib/cydia",
        "/var/log/syslog",
        "/private/var/mobile/Library/Preferences/com.unc0ver.unc0ver.plist",

        // Additional less common paths
        "/Applications/Anemone.app",
        "/Applications/iFile.app",
        "/Applications/Phantom.app",
        "/Library/MobileSubstrate/DynamicLibraries/Barrel.plist",
        "/Library/MobileSubstrate/DynamicLibraries/Activator.plist",
        "/Library/MobileSubstrate/DynamicLibraries/SBSettings.plist",
        "/System/Library/LaunchDaemons/com.apple.amsd.plist",
        "/private/var/mobile/Library/Preferences/com.bigboss.repo.plist",
        "/private/var/mobile/Library/Preferences/com.pangu.pangu.plist",
        "/var/root/Library/Preferences/com.ih8sn0w.ih8sn0w.plist",
        "/usr/lib/libjailbreak.dylib",
        "/Applications/AFC2.app",
        "/Applications/MTerminal.app"
    };

    foreach (var path in knownPaths)
    {
        if (File.Exists(path))
            return true;
    }
    return false;
}
