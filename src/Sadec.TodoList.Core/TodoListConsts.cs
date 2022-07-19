using Sadec.TodoList.Debugging;

namespace Sadec.TodoList
{
    public class TodoListConsts
    {
        public const string LocalizationSourceName = "TodoList";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "851faaacd8ec4448b7b42337581a91de";
    }
}
