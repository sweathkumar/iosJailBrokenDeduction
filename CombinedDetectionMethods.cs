bool IsDeviceJailbroken()
{
    return CheckForJailbreakFiles() || 
           CheckForSandboxViolation() || 
           CheckForRootAccess() || 
           CheckForJailbreakApps() || 
           CheckForUnusualDaemons() || 
           CheckForBehaviorAnomalies() || 
           UseAntiJailbreakLibrary();
}
