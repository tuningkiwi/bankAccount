using Classes;

const int BankAccountSize =3;


BankAccount[] arr = new BankAccount[BankAccountSize];

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
    
    arr[i] = new BankAccount(owner,_balance);
    Console.WriteLine("Account {0}was created for {1} with {2} initial balance",arr[i].Number,arr[i].Owner,arr[i].Balance);
    
}

Console.WriteLine("CURRENT BANK ACCOUNT LIST");
//string str = String.Format("{0,20}{21,40}{41,60}","NUMBER","OWNER","BALANCE");
Console.WriteLine("{0,-20}{1,-20}{2,-20}","NUMBER","OWNER","BALANCE");
//Console.WriteLine($"{,10}NUMBER{,40}OWNER{,60}BALANCE");
for(int i = 0 ; i < BankAccountSize ; i++){
    Console.WriteLine("{0,-20}{1,-20}{2,-20}",arr[i].Number,arr[i].Owner,arr[i].Balance);
}