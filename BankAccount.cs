using System.Security.Cryptography.X509Certificates;

namespace Classes;

// 은행 계좌를 고유하게 식별하는 10자리 숫자가 있습니다.
// 소유자의 이름을 저장하는 문자열이 있습니다.
// 잔액을 검색할 수 있습니다.
// 예금을 허용합니다.
// 인출을 허용합니다.
// 초기 잔액은 양수여야 합니다.
// 인출은 부정적인 균형을 초래할 수 없습니다.

public class BankAccount {

    private static int s_accountNumberSeed = 0;

    //계좌번호
    public string Number{get;}
    //예금주
    public string Owner{get;set;}
    //잔액
    public decimal Balance{get; set;}

    //입금
    public void MakeDeposit(decimal amount, DateTime date, string note){

    }
    
    //인출
    public void MakeWithdrawal(decimal amount, DateTime date, string note){

    }

    public BankAccount(string name, decimal initialBalance){
        Owner = name;
        Balance = initialBalance;    
        Number = s_accountNumberSeed.ToString("D10");
        s_accountNumberSeed++;
        
    }

}
