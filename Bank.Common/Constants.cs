namespace Bank.Common
{
    public static class Constants
    {
        public static class Moneda
        {
            public const int Sol = 1;
            public const int Dolar = 2;

            public const string StrSol = "Soles";
            public const string StrDolar = "Dólares";
        }

        public static class EstadoOrden
        {
            public const int Pagada = 1;
            public const int Declinada = 2;
            public const int Fallida = 3;
            public const int Anulada = 4;

            public const string StrPagada = "Pagada";
            public const string StrDeclinada = "Declinada";
            public const string StrFallida = "Fallida";
            public const string StrAnulada = "Anulada";
        }
    }
}
