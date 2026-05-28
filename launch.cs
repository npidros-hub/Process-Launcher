  public static Process Start(ProcessStartInfo startInfo)
  {
    try
    {
      Process process = new Process();
      if (startInfo == null)
      {
        throw new ArgumentNullException("startInfo");
      }
      process.StartInfo = startInfo;
      if (process.Start())
      {
        return process;
      }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"failed to start, {ex.Message}");      
    }
    
    return null;
  }
