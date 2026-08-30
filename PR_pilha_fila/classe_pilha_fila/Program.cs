// Console.WriteLine("Hello, World!");

Pilha p = new Pilha();


for (int i = 1; i < 100; i++)
{
    p.Empilhar(i);
}

for (int i = 1; i < 25; i++)
{
    p.Desempilhar();
}

Console.WriteLine(p.GetTopo());