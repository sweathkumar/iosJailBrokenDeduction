bool CheckForSandboxViolation()
{
    try
    {
        var testFilePath = "/private/test_file.txt";
        File.WriteAllText(testFilePath, "test");
        File.Delete(testFilePath);
        return true; // Sandbox violation detected
    }
    catch
    {
        return false; // No violation detected
    }
}
