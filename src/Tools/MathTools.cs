using System.ComponentModel;
using ModelContextProtocol;
using ModelContextProtocol.Server;

namespace ProtectedMcpServer.Tools;

[McpServerToolType]
public sealed class MathTools
{
    [McpServerTool, Description("Add two numbers together.")]
    public Task<double> Add(
        [Description("First operand")] double a,
        [Description("Second operand")] double b)
    {
        return Task.FromResult(a + b);
    }

    [McpServerTool, Description("Multiply two numbers together.")]
    public Task<double> Multiply(
        [Description("First operand")] double a,
        [Description("Second operand")] double b)
    {
        return Task.FromResult(a * b);
    }
}
