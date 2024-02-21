using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.Security.Policy;

internal class Pessoa
{

    public string Nome { get; set; }

    public string CPF { get; set; }
    public string Telefone { get; set; }    
    public int Idade { get; set; }

    
  
    public bool JsonSerializarLista(List<Pessoa> lista, string path)
    {
        var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
        return SaveFilePessoa(strJson, path);
    }
    public static List<Pessoa> JsonDesserializarLista(string path)
    {
        var strJson = OpenFilePessoa(path);
        if (strJson.Substring(0,5) != "Falha")
        {
            return JsonConvert.DeserializeObject<List<Pessoa>>(strJson);
        }
        else
        {
            var lista = new List<Pessoa>();
            var cadrastro = new Pessoa();
            cadrastro.Nome = strJson;
            lista.Add(cadrastro);
            cadrastro.Nome = strJson;
            return lista;
        }           
    }

    private bool SaveFilePessoa(string strJson, string path)
    {
        try
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(strJson);
            }
            return true;
        }
        catch (Exception at)
        {
            MessageBox.Show("Falha " + at.Message);
            return false;
        }    
    }
    private static string OpenFilePessoa(string path)
    {
        try
        {
            var strJson = "";

            using (StreamReader JS = new StreamReader(path))
            {
                strJson = JS.ReadToEnd();
            }
            return strJson;
        }

        catch(Exception ex)
        {
            MessageBox.Show("Falha " + ex.Message);
            return "";
        }

    }

    //public static Pessoa JsonDesserializar(string Json)
    //{
    //    return JsonConvert.DeserializeObject<Pessoa>(Json);
    //}
    public Pessoa()
    {

    }

    public Pessoa(string nome, string cpf, int idade, string telefone)
    {
        Nome = nome;
        CPF = cpf;
        Idade = idade;
        Telefone = telefone;
       
    }
    public int CalculoIdade(int ano, int mes, int dia)
    {
        int anoAtual = Convert.ToInt32(DateTime.Now.Year);
        int mesAtual = Convert.ToInt32(DateTime.Now.Month);
        int diaAtual = Convert.ToInt32(DateTime.Now.Day);

        int idade = anoAtual - ano;

        if (mesAtual < mes || (mesAtual == mes && diaAtual < dia))
        {
            idade -= 1;
        }
        return idade;
    }
    public int Taxa (int peso)
    {
       return peso * 5;
    }


}




