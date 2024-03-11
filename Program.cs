namespace PedidoEstruturado;

class Program
{
    static void Main(string[] args)
    {
        double porcentagem, totalD = 0;
        Console.WriteLine("Nome: ");
        string nomeP = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Preço: ");
        double preco = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Quantidade: ");
        double quantidade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------REVISAO PEDIDO-----------------------------");
        if (quantidade >= 11 && quantidade <= 20)
        {
            double total = preco * quantidade;
            porcentagem = (total / 100) * 10;
            totalD = total - porcentagem;
            Console.WriteLine($"Nome: {nomeP}\nPreço: {preco}\nValor total sem desconto: {total}\nValor total com desconto: {totalD}");
        }

        else if (quantidade >= 21 && quantidade <= 50)
        {
            double total = preco * quantidade;
            porcentagem = (total / 100) * 20;
            totalD = total - porcentagem;
            Console.WriteLine($"Nome: {nomeP}\nPreço: {preco}\nValor total sem desconto: {total}\nValor total com desconto: {totalD}");
        }
        else if (quantidade > 50)
        {
            double total = preco * quantidade;
            porcentagem = (total / 100) * 25;
            totalD = total - porcentagem;
            Console.WriteLine($"Nome: {nomeP}\nPreço: {preco}\nValor total sem desconto: {total}\nValor total com desconto: {totalD}");
        }
        else
        {
            double total = preco * quantidade;
            Console.WriteLine($"Nome: {nomeP}\nPreço: {preco}\nValor total sem desconto: {total}\nValor total com desconto: {total}");
        }

    }
}
