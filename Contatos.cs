using System.IO;
using System.Text;

class Contatos
{

    List<string> agenda = [];


    public void AddContato(string nome, string telefone, string email)
    {
        string NomeArquivo = "Contatos.cfg";
        StreamWriter sw = new StreamWriter(NomeArquivo);

        agenda.Add(nome);
        agenda.Add(telefone);
        agenda.Add(email);

        try
        {
            foreach (var name in agenda)
            {
                sw.WriteLine(name);
                sw.WriteLine("----------------");
            }

        }
        catch (Exception e)
        {
            System.Console.WriteLine("Erro ao adicionar contato: " + e.Message);
        }
        finally
        {
            sw.Close();
        }

        System.Console.WriteLine("Adicionado com sucesso!");
    }

    public void Listar()
    {
        foreach (var name in agenda)
        {
            Console.WriteLine($"Adicionado: {name.ToUpper()}");
        }
    }
}