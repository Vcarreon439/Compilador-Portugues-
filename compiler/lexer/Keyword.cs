namespace compiler.lexer
{
    public class Keyword : Token
    {
        public static readonly string[] KEYWORDS = { 
            // tipos
            "void",
            "bool",
            "byte",
            "char",
            "short",
            "int",
            "long",
            "float",
            "real", // double
            "texto",
            // conversión de tipo
            "cast",
            // declaraciones
            "var",
            "função",
            "externa",
            "estrutura",
            "programa",
            "unidade",
            "usando",
            // Lectura y escritura
            "leer",
            "escribir",
            "escribirln",
            // literais lógicos
            "verdad", // true
            "falso", // false
            // literal nulo
            "nulo", // null
            // estruturas de controle de fluxo
            "si", // if
            "sino", // else
            "mientras", // while
            "para", // for
            "haga", // do
            "retorna", // return
            "detener" // break
        };

        public static bool IsKeyword(string s)
        {
            for (int i = 0; i < KEYWORDS.Length; i++)
            {
                if (s == KEYWORDS[i])
                    return true;
            }

            return false;
        }

        public string Value
        {
            get;
        }

        internal Keyword(SourceInterval interval, string value) : base(interval) => Value = value;

        public override string ToString() => "keyword '" + Value + "'";
    }
}
