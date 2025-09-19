class Arquivo
{
    //ATRIBUTOS
    public string Name { get; private set; }
    public int Size { get; private set; }
    private string Content;


    //CONSTRUTOR
    public Arquivo(string name) //Arquivo em concordãncia com o arquico .cs
    {
        //atributo = parâmetro
        Name = name;
        Content = ""; //vazio
        Size = CalculateSize();
    }

    //MÉTODOS
    private int CalculateSize()
    {
        return Content.Length * 8; //valor do tamanho do conteúdo vezes oito (conversão bytes -> bits) 
    }

    public string Open()
    {
        return $"File Name: {Name}\n File Content: {Content}\n File Size: {Size}";
    }

    public void Edit(string newContent)
    {
        Content += newContent;
    }

    public bool Rename(string newName)
    {
        if (newName == null)
            return false;

        Name = newName;
        return true;
    }

    public void Clear()
    {
        Content = "";
        Size = CalculateSize();
    }

}