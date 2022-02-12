namespace Oxide.Plugins
{
    [Info("BlockRustLink", "Strrobez", "0.0.1")]
    internal class BlockRustLink : RustPlugin
    {
        object OnPlayerChat(BasePlayer player, string message)
        {
            if (player == null) return null;

            if (message.StartsWith("rustLink |")) return true;

            return null;
        }
    }
}
