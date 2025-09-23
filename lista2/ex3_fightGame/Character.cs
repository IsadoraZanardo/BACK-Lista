class Character
{
    //ATRIBUTOS
    public string Name { get; private set; }
    public int Life { get; private set; }
    public int PowerAttack { get; private set; }
    public int PowerDefense { get; private set; }
    public bool IsAlive { get; private set; }


    // CONSTRUTORES
    public Character(string name)
    {
        Name = name;
        Life = 100;
        PowerAttack = PowerGenerate(min: 20, max: 31); //método random acaba sempre com um número a mais do que o desejado
        PowerDefense = PowerGenerate(min: 10, max: 16); //método random acaba sempre com um número a mais do que o desejado
        IsAlive = true;
    }


    //MÉTODOS
    public void Attack(Character opponent)
    {
        if (!IsAlive)
            throw new Exception("Operação inválida! Personagem morto :(");
        opponent.Damage(value: this.PowerAttack - opponent.PowerDefense); //.this é opicional
    }

    private void Damage(int value)
    {
        Life -= value;

        if (Life <= 0)
            IsAlive = false; //ver se o personagem está vivo
    }

    private int PowerGenerate(int min, int max)
    {
        Random r = new Random();
        return r.Next(min, max);
    }


    //TO.STRING
    public override string ToString()
    {
        return $"Nome do Personagem: {Name}\nVida: {Life}\n\n";
    }
}