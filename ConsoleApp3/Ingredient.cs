
namespace recipeApplication
{
    internal class Ingredient
    {
        private string? name;
        private double quantity;
        private string? unit;

        public Ingredient(string? name, double quantity, string? unit)
        {
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
        }

        public object Name { get; internal set; }
        public object Quantity { get; internal set; }
        public object Unit { get; internal set; }

        internal void ResetQuantity()
        {
            throw new NotImplementedException();
        }
    }
}