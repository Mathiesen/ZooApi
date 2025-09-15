namespace ZooApi;

// Animal service provides access to animals in the database
public class AnimalService
{
    private readonly DatabaseAccess _databaseAccess;
    private Dictionary<int, string> _animals = new();
    
    public AnimalService()
    {
        _animals.Add(1, "Lion");
        _animals.Add(2, "Seal");
        _animals.Add(3, "Snake");
        _animals.Add(4, "Badger");
    }
    
    public Dictionary<int, string> GetAnimals()
    {
        return _animals;
    }

    public string GetAnimal(int id)
    {
        _animals.TryGetValue(id, out var value);
        return value;
    }

    public void InsertAnimal(int id, string animal)
    {
        _animals.Add(id, animal);
    }

    public void RemoveAnimal(int id)
    {
        _animals.Remove(id);
    }
}