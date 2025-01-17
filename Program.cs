namespace Agenda
{
    class Program
    {
        public static void Main(string[] args)
        {
            Contatos contatos = new Contatos();

            contatos.AddContato("Ana", "1293213", "Banana@email.com");
            contatos.Listar();

        }
    }
}