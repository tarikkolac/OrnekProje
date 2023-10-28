using OrnekProje.Debugging;

namespace OrnekProje
{
    public class OrnekProjeConsts
    {
        public const string LocalizationSourceName = "OrnekProje";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "19376fd466d14f4aa4ba7cd2fa20ef95";
    }
}
