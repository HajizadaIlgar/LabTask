
using Newtonsoft.Json;

public class FileHelper
{
    public string Path { get; }
    public FileHelper(string path)
    {
        Path = path;
    }

    string json;
    List<string> names = [];

    public void Add(string name)
    {
        names.Add(name);
        json = JsonConvert.SerializeObject(names);
        using StreamWriter sw = new StreamWriter(Path, false);
        sw.Write(json);
    }

    public bool Exist(string name)
    {
        return names.Contains(name);
    }

    public void Update(int index, string name)
    {
        names[index] = name;
        json = JsonConvert.SerializeObject(names);
        using StreamWriter sw = new StreamWriter(Path, false);
        sw.Write(json);
    }

    public void Delete(int index)
    {
        names.RemoveAt(index);
        json = JsonConvert.SerializeObject(names);
        using StreamWriter sw = new StreamWriter(Path, false);
        sw.Write(json);

    }



}
