public interface IState
{
    void InsertCoin(VendingMachine machine);
    void SelectProduct(VendingMachine machine);
    void DispenseProduct(VendingMachine machine);
}
