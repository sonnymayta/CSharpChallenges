namespace PackingInventory
{
    public class Undefined : InventoryItem
    {
        public Undefined() : base(0, 0) { }

        public override string ToString() => "Undefined";
    }
}
