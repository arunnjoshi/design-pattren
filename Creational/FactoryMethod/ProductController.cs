namespace FactoryMethod;

public class ProductController : SharpController
{
	public void ListProduct()
	{
		var context = new Dictionary<string, object>();
		Render("product.html", context);
	}
}
