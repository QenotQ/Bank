using B_A;
Bank sberbank = new Bank("Сбербанк");
Bank vtb = new Bank("ВТБ");

Client ekaterina = new Client("Елена", "Науменко", "Алексеевна");

Account sberbankAccount = new Account("10006534654934514738", sberbank, ekaterina, Currency.Dollar);
Account vtbAccount = new Account("20006034654934514739", vtb, ekaterina, Currency.Ruble);

Card sberbankCard = new Card("4276394583453241", sberbank, "385", 
    new DateTime(2024, 8, 1), ekaterina, PaymentSystem.Visa, sberbankAccount);
Card vtbCard = new Card("4276394583453242", vtb, "386",
    new DateTime(2026, 8, 1), ekaterina, PaymentSystem.MasterCard, vtbAccount);

sberbankAccount.Sum = 67890m;
vtbAccount.Sum = 240588m;


Console.Write($"Выберите банк\n 1 - Втб\n 2 - Сбербанк \nВыберите банк для выполнения дальнейших операций: ");
int bank = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"Возможные типы операций:\n 1 - Пополнение\n 2 - Перевод \n 3 - Снятие наличных\nВыберите тип операции: ");
int Operation = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите сумму операции: ");
decimal money = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();
if (bank == 1)
{
    switch (Operation)
    {
        case 1:
            var check = vtbCard.Refill(money);
            Console.WriteLine(check);
            break;
        case 2:
            check = vtbCard.Transfer(money);
            Console.WriteLine(check);
            break;
        case 3:
            check = vtbCard.Withdraw(money);
            Console.WriteLine(check);
            break;


    }
    if ((Operation > 3) || (Operation < 1))
    {
        Console.WriteLine("Ошибка выбора операции");

    }
}
if (bank == 2)
{
    switch (Operation)
    {
        case 1:
            var check = sberbankCard.Refill(money);
            Console.WriteLine(check);
            break;
        case 2:
            check = sberbankCard.Transfer(money);
            Console.WriteLine(check);
            break;
        case 3:
            check = sberbankCard.Withdraw(money);
            Console.WriteLine(check);
            break;


    }
    if ((Operation > 3) || (Operation < 1))
    {
        Console.WriteLine("Ошибка выбора операции");

    }
}


