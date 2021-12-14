namespace Abstract.Factory.Pattern
{
    public abstract  class BasePizza
    {
        internal string _dough;
        internal string _cheese;
        internal AbstractIngredientFactory _ingredientFactory;

        public BasePizza(AbstractIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public abstract void Bake();
    }
}
