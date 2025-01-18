using System.IO;
using System.Text;

class Contatos
{

    List<string> agenda = [];
    public StreamWriter sw = new StreamWriter("Contatos.cfg");


    public void AddContato(string nome, string telefone, string email)
    {

        agenda.Add(nome);
        agenda.Add(telefone);
        agenda.Add(email);

        try
        {
            foreach (var name in agenda)
            {
                sw.WriteLine(name);
            }

            sw.WriteLine("----------------");

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

    public void SubstituirContato()
    {
        StreamReader sr = new StreamReader("Contatos.cfg");
        System.Console.WriteLine("Digite o nome do contato: ");
        var nome = Console.ReadLine();
        System.Console.WriteLine("Digite o novo nome: ");
        var newName = Console.ReadLine();
        System.Console.WriteLine("Digite o novo Telefone: ");
        var newTelefone = Console.ReadLine();
        System.Console.WriteLine("Digite o novo email: ");
        var newEmail = Console.ReadLine();

        for (int i = 0; i < agenda.Count; i++)
        {
            if (agenda[i] == nome)
            {
                agenda[i] = newName;
                agenda[i + 1] = newTelefone;
                agenda[i + 2] = newEmail;
            }
        }



    }

    public void ExcluirContato()
    {

    }

    public void Menu()
    {

        try
        {
            int escolha;
            do
            {
                Console.WriteLine("Bem-vindo(a)! Escolha uma opção:");
                Console.WriteLine("1. Adicionar contato\n2. Consultar contato\n3. Substituir contato\n4. Excluir contato\n5. Sair");
                Console.WriteLine("Sua opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        var nome = Console.ReadLine();
                        var telefone = Console.ReadLine();
                        var email = Console.ReadLine();
                        AddContato(nome, telefone, email);
                        break;

                    case 2:
                        Listar();
                        break;

                    case 3:
                        SubstituirContato();
                        break;

                    case 4:
                        ExcluirContato();
                        break;

                    case 5:
                        Console.WriteLine("Volte sempre!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente!");
                        break;
                }

            } while (escolha != 5);
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Erro: " + e.Message);
        }
    }
}