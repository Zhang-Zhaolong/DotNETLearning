using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> stack = new List<T>();

    public int Count()
    {
        return stack.Count;
    }

    public void Push(T item)
    {
        stack.Add(item);
    }

    public T Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        T item = stack[^1]; // Get last element
        stack.RemoveAt(stack.Count - 1);
        return item;
    }
}


public class MyList<T>
{
    private List<T> list = new List<T>();

    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        T item = list[index];
        list.RemoveAt(index);
        return item;
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    public void Clear()
    {
        list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        list.RemoveAt(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= list.Count)
            throw new ArgumentOutOfRangeException("Index out of range.");

        return list[index];
    }
}



public interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}

public class Entity
{
    public int Id { get; set; }
}

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> _entities = new List<T>();

    public void Add(T item)
    {
        _entities.Add(item);
    }

    public void Remove(T item)
    {
        _entities.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Changes saved to the data source.");
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

    public T GetById(int id)
    {
        for (int i = 0; i < _entities.Count; i++)
        {
            if (_entities[i].Id == id)
            {
                return _entities[i];
            }
        }

        return null;
    }
}
