using System;

public class VendingMachine
{
    private IState noCoinState;
    private IState hasCoinState;
    private IState soldState;
    private IState currentState;
    
    public VendingMachine()
    {
        noCoinState = new NoCoinState();
        hasCoinState = new HasCoinState();
        soldState = new SoldState();
        
        currentState = noCoinState; 
        Console.WriteLine("🤖 Máquina de vendas inicializada");
    }
    
    public void InsertCoin()
    {
        currentState.InsertCoin(this);
    }
    
    public void SelectProduct()
    {
        currentState.SelectProduct(this);
    }
    
    public void DispenseProduct()
    {
        currentState.DispenseProduct(this);
    }
    
    public void SetState(IState state)
    {
        currentState = state;
        
        // Mostra qual estado atual para debug
        string stateName = state.GetType().Name;
        Console.WriteLine($"🔄 Estado mudou para: {stateName}");
    }
    
    public IState GetNoCoinState() => noCoinState;
    public IState GetHasCoinState() => hasCoinState;
    public IState GetSoldState() => soldState;
    
    public string GetCurrentStateName()
    {
        return currentState.GetType().Name;
    }
}
