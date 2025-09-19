Arquivo a1 = new Arquivo("New-File.txt");
Console.WriteLine(a1.Open());

a1.Edit("This is my first document!");
Console.WriteLine(a1.Open());

a1.Edit("My name is Isadora."); //informação adicionada, sem excluir conteúdo do primeiro bloco Edit
Console.WriteLine(a1.Open());

a1.Clear(); //limpar conteúdo dos dois blocos Edit
Console.WriteLine(a1.Open());

a1.Rename("Document-Isadora.txt");
Console.WriteLine(a1.Open());