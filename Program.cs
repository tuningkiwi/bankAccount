using Classes;

const int BankAccountSize =3;


BankAccount[] account = new BankAccount[BankAccountSize];

// BankAccount account = new BankAccount("dong",1000);

// Console.WriteLine($"Account {0:D10} was created for {account.Owner} with {account.Balance} initial balance",account.Number);


for(int i = 0 ; i < BankAccountSize ; i++){
    string owner;
    string balance;
    decimal _balance;
    
    Console.Write("예금주:");
    owner = Console.ReadLine();
    Console.Write("입금액:");
    balance = Console.ReadLine(); 
    try{
        _balance = Convert.ToDecimal(balance);
    }catch(FormatException){
        Console.WriteLine("입금액은 숫자로 입력하세요");
        Console.Write("입금액:");
        balance = Console.ReadLine();
        _balance = Convert.ToDecimal(balance); 
    }
    
    account[i] = new BankAccount(owner,_balance);
    Console.WriteLine("Account {0}was created for {1} with {2} initial balance",account[i].Number,account[i].Owner,account[i].Balance);
    
}

Console.WriteLine("CURRENT BANK ACCOUNT LIST");
//string str = String.Format("{0,20}{21,40}{41,60}","NUMBER","OWNER","BALANCE");
Console.WriteLine("{0,-20}{1,-20}{2,-20}","NUMBER","OWNER","BALANCE");
//Console.WriteLine($"{,10}NUMBER{,40}OWNER{,60}BALANCE");
for(int i = 0 ; i < BankAccountSize ; i++){
    Console.WriteLine("{0,-20}{1,-20}{2,-20}",account[i].Number,account[i].Owner,account[i].Balance);
}



// try
// {
//     Console.WriteLine("withdrawal test");
//     account[0].MakeWithdrawal(500, DateTime.Now, "Rent payment");
//     Console.WriteLine("{0,-20}{1,-20}{2,-20}",account[0].Number,account[0].Owner,account[0].Balance);

//     Console.WriteLine("deposit test");
//     account[0].MakeDeposit(100, DateTime.Now, "Friend paid me back");
//     Console.WriteLine("{0,-20}{1,-20}{2,-20}",account[0].Number,account[0].Owner,account[0].Balance);
//     account[0].MakeWithdrawal(750, DateTime.Now, "attemp to overdraw");
// }
// catch(InvalidOperationException e){
//     Console.WriteLine("exception caught trying to overdraw");
//     Console.WriteLine(e.ToString());
//     return;
// }
// catch(ArgumentOutOfRangeException e){
//     Console.WriteLine("amount is not invalid ");
//     Console.WriteLine(e.ToString());
//     return;

// }


BankAccount invalidAccount;

try
{
    invalidAccount = new BankAccount("invalid",-55);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
    return;
}