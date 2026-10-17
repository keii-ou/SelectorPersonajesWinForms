namespace SelectorPersonajes;

public enum ListType { Custom, LinkedList, List }

public interface IPersonasList
{
    ListType Type { get; }
    string Name { get; }
    int Count { get; }
    Persona this[int indice] { get; }
    void Add(Persona p);
    void DeleteIn(int indice);
    void Clear();
    int Index(Persona p);
    IEnumerable<Persona> Iterate();
    void Order(Comparison<Persona> criteria);
}

public static class Criteria
{
    public static readonly Comparison<Persona> NivelDesc =
        (a, b) => Playdown(b.Level.CompareTo(a.Level), a, b);

    public static readonly Comparison<Persona> DanoDesc =
        (a, b) => Playdown(b.Attack.CompareTo(a.Attack), a, b);

    public static readonly Comparison<Persona> VelocidadAsc =
        (a, b) => Playdown(a.AtackSpeed.CompareTo(b.AtackSpeed), a, b);

    // Playdown por nombre para que el resultado sea el mismo en las tres listas
    private static int Playdown(int comparison, Persona a, Persona b) =>
        comparison != 0 ? comparison : string.CompareOrdinal(a.Name, b.Name);
}

public static class ListFactory
{
    public static IPersonasList Create(ListType tipo) => tipo switch
    {
        ListType.Custom => new CustomList(),
        ListType.LinkedList => new ListaLinkedList(),
        _ => new ListaNet()
    };

    /// Crea una lista del type pedido con los mismos personajes y el mismo orden
    public static IPersonasList Convert(IPersonasList origin, ListType type)
    {
        var @new = Create(type);
        foreach (var p in origin.Iterate()) @new.Add(p);
        return @new;
    }
}

// ══ 1) Lista personalizada ══

public class Node
{
    public Persona Data { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }

    public Node(Persona datos)
    {
        Data = datos;
        Next = this;
        Previous = this;
    }
}

public class CustomList : IPersonasList
{
    private Node? head;
    private Node? cursor;  
    // último node visitado
    private int indexCursor;
    private int count;

    public ListType Type => ListType.Custom;
    public string Name => "Lista personalizada (nodos)";
    public int Count => count;

    public Persona this[int index] => NodeIn(index).Data;

   
    private Node NodeIn(int index)
    {
        if ((uint)index >= (uint)count) throw new ArgumentOutOfRangeException(nameof(index));

        var node = cursor!;
        int infront = ((index - indexCursor) % count + count) % count;
        int behind = count - infront;

        if (infront <= behind)
        {
            for (int i = 0; i < infront; i++) node = node.Next;
        }
        else
        {
            for (int i = 0; i < behind; i++) node = node.Previous;
        }

        cursor = node;
        indexCursor = index;
        return node;
    }

    public void Add(Persona p)
    {
        var newNode = new Node(p);

        if (head == null)
        {
            head = newNode;
            cursor = newNode;
            indexCursor = 0;
        }
        else
        {
            var last = head.Previous;
            newNode.Previous = last;
            newNode.Next = head;
            last.Next = newNode;
            head.Previous = newNode;
        }

        count++;
    }

    public void DeleteIn(int indice)
    {
        var node = NodeIn(indice);

        if (count == 1)
        {
            head = null;
            cursor = null;
        }
        else
        {
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            if (node == head) head = node.Next;
            cursor = head;
        }

        indexCursor = 0;
        count--;
    }

    public void Clear()
    {
        head = null;
        cursor = null;
        indexCursor = 0;
        count = 0;
    }

    public int Index(Persona p)
    {
        var node = head;
        for (int i = 0; i < count; i++)
        {
            if (ReferenceEquals(node!.Data, p)) return i;
            node = node.Next;
        }
        return -1;
    }

    public IEnumerable<Persona> Iterate()
    {
        var node = head;
        for (int i = 0; i < count; i++)
        {
            yield return node!.Data;
            node = node.Next;
        }
    }

    public void Order(Comparison<Persona> criterio)
    {
        if (count < 2) return;

        var array = new Persona[count];
        var node = head!;
        for (int i = 0; i < count; i++)
        {
            array[i] = node.Data;
            node = node.Next;
        }

        Array.Sort(array, criterio);

        node = head!;
        for (int i = 0; i < count; i++)
        {
            node.Data = array[i];
            node = node.Next;
        }
    }
}

// 2) LinkedList<T> de .NET

public class ListaLinkedList : IPersonasList
{
    private readonly LinkedList<Persona> list = new();
    private LinkedListNode<Persona>? cursor;
    private int indexCursor;

    public ListType Type => ListType.LinkedList;
    public string Name => "LinkedList<T>";
    public int Count => list.Count;

    public Persona this[int index] => NodoEn(index).Value;

    // LinkedList<T> no es circular
    private LinkedListNode<Persona> NodoEn(int index)
    {
        int n = list.Count;
        if ((uint)index >= (uint)n) throw new ArgumentOutOfRangeException(nameof(index));

        if (cursor == null)
        {
            cursor = list.First;
            indexCursor = 0;
        }

        var nodo = cursor!;
        int infront = ((index - indexCursor) % n + n) % n;
        int behind = n - infront;

        if (infront <= behind)
        {
            for (int i = 0; i < infront; i++) nodo = nodo.Next ?? list.First!;
        }
        else
        {
            for (int i = 0; i < behind; i++) nodo = nodo.Previous ?? list.Last!;
        }

        cursor = nodo;
        indexCursor = index;
        return nodo;
    }

    public void Add(Persona p) => list.AddLast(p);

    public void DeleteIn(int indice)
    {
        list.Remove(NodoEn(indice));
        cursor = null;
        indexCursor = 0;
    }

    public void Clear()
    {
        list.Clear();
        cursor = null;
        indexCursor = 0;
    }

    public int Index(Persona p)
    {
        int i = 0;
        for (var nodo = list.First; nodo != null; nodo = nodo.Next, i++)
            if (ReferenceEquals(nodo.Value, p)) return i;
        return -1;
    }

    public IEnumerable<Persona> Iterate() => list;

    public void Order(Comparison<Persona> criterio)
    {
        if (list.Count < 2) return;

        var array = list.ToArray();
        Array.Sort(array, criterio);

        int i = 0;
        for (var nodo = list.First; nodo != null; nodo = nodo.Next)
            nodo.Value = array[i++];
    }
}

//  3) List<T> de .NET 

public class ListaNet : IPersonasList
{
    private readonly List<Persona> list = new();

    public ListType Type => ListType.List;
    public string Name => "List<T>";
    public int Count => list.Count;

    public Persona this[int index] => list[index];

    public void Add(Persona p) => list.Add(p);
    public void DeleteIn(int indice) => list.RemoveAt(indice);
    public void Clear() => list.Clear();
    public int Index(Persona p) => list.IndexOf(p);   // Persona no sobrescribe Equals: compara por referencia
    public IEnumerable<Persona> Iterate() => list;
    public void Order(Comparison<Persona> criterio) => list.Sort(criterio);
}
