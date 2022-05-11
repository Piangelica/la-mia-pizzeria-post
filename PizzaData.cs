namespace NetCore_01.Utils
{
	public static class PizzaData
	{
		private static List<Pizza> pizze;

		public static List<Pizza> GetPizze()
		{
		if(PizzaData.pizze != null)
			{
				return PizzaData.pizze;
	        }
			List<Pizze> nuovaListaPizze = new List<Pizze>();

			for(int i=0; i<5; i++)
			{
				Pizza pizza = new Pizza(i,"Nome pizza: "+ i, "mozzarella, pomodorini, basilico" )
			nuovaListaPizze.Add(pizza);
					}
			PizzaData.pizze = nuovaListaPizze;
			return PizzaData.pizze;
        }



		[HttpGet]
		public IActionResult Create()
		{
			return View("FormPost");
		}

		[HttpPizze]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Pizze nuovaPizza)
if (!ModelState.IssValid)
			{
return View("ErrorePost");
    }
	Pizze nuovaPizzaconNome = new Pizze(PizzaData.GetPizze().Count)
}return RedirectToAction("HomePage")
