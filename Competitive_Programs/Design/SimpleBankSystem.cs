namespace Competitive_Programs.Design{
   internal class SimpleBankSystem {
    long[] balance;
    public SimpleBankSystem(long[] balance) 
    {
        this.balance = balance;
    }
    
    public bool transfer(int account1, int account2, long money) {
        if(!IsValid(account2))
            return false;
        
        return withdraw(account1,money) && deposit(account2,money);
    }
    
    public bool deposit(int account, long money) {
         if(!IsValid(account))
            return false;
        balance[account-1] += money;
        return true;
    }
    
    public bool withdraw(int account, long money) {
         if(!IsValid(account))
            return false;
        if(balance[account-1]<money)
            return false;
          balance[account-1] -= money;
          return true;
    }

    public bool IsValid(int account)
    {
        return 1 <= account && account <= balance.length;
    }
  }
}