namespace DotNet.Testcontainers.Tests.Fixtures
{
  using System;
  using System.Threading.Tasks;
  using DotNet.Testcontainers.Core.Wait;

  public class WaitStrategyFixture : IWaitUntil
  {
    private readonly long timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

    public Task<bool> Until(string id)
    {
      return Task.Run(() =>
      {
        return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() > this.timestamp + 5;
      });
    }
  }
}
