//PARTE 1/5
Random r = new Random(42);
//r é objeto
//() começa como construtor vazio
//se colocar algum número dentro do () sempre gera a mesma sequência, aka SEED


Console.WriteLine(r.Next(0, 9));
//sortear um núemro de 0 até 9
Console.WriteLine(r.Next(50, 100));
Console.WriteLine(r.Next(0, 1));
Console.WriteLine(r.Next(1, 10));
//colocar SEMPRE o número MENOR PRIMEIRO


//PARTE 2/5
Random r1 = new Random(42);
Random r2 = new Random(43);
Random r3 = new Random(44);
//única instância = tem um único objeto


//PARTE 3/5
Console.WriteLine(Math.PI);


//PARTE 4/5
string s = Console.ReadLine();
//vai pedir para o USUÁRIO inserir a ENTRADA, após inserção o sistema printa o que foi inserido


//PARTE 5
double entrada = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(entrada);