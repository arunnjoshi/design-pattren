using CommandPattern;
using CommandPattern.FX;
using Iterator;
using Mediator;
using Memento;
using Observer;
using State;
using StrategyPattern;
using TemplateMethod;
using COR;
using visitor;
using Composite;
using Adapter;
using Adapter.pkg;
using Decorator;
using Facade;
using Flyweight;
using Bridge;
using Proxy;
using Prototype;
using Singleton;
internal class Program
{
	private static void Main(string[] args)
	{
		//                           Behavioral design pattern
		//MementoPattern();
		//StatePattern();
		//IteratorPattern();
		//StrategyPattern();
		//TemplateMethod();
		//CommandPattern();
		//ObserverPattern();
		//MediatorPattern();
		//ChainOfResponsibility();
		//VisitorPattern();

		//							structural design pattern
		//CompositePattern();
		//AdapterPattern();
		//DecoratorPattern();
		//FacadePattern();
		//FlyweightPattern();
		//BridgePattern();
		//ProxyPattern();
		//PrototypePattern();
		SingletonPatter();
	}

	#region MementoPatten
	private static void MementoPattern()
	{
		var editor = new Editor();
		var history = new History();
		editor.SetContent("a");
		history.Push(editor.CreateState());

		editor.SetContent("b");
		history.Push(editor.CreateState());

		editor.SetContent("c");

		editor.Restore(history.Pop());
		Console.WriteLine(editor.GetContent());
		editor.Restore(history.Pop());
		Console.WriteLine(editor.GetContent());
	}
	#endregion

	#region StatePattern
	public static void StatePattern()
	{
		var canvas = new Canvas();
		canvas.SetTool(new SelectionTool());
		canvas.MouseDown();
		canvas.MouseUp();


		canvas.SetTool(new BrushTool());
		canvas.MouseDown();
		canvas.MouseUp();
	}
	#endregion

	#region  IteratorPattern
	public static void IteratorPattern()
	{
		var browserHistory = new BrowserHistory();
		browserHistory.Push("a");
		browserHistory.Push("b");
		browserHistory.Push("c");

		var iterator = browserHistory.CreateIterator();
		while (iterator.HasNext())
		{
			var url = iterator.Current();
			Console.WriteLine(url);
			iterator.Next();
		}
	}
	#endregion

	#region StrategyPattern
	public static void StrategyPattern()
	{
		ImageStorage.Store("arun Joshi", new PngCompressor(), new BlackAndWhiteFilter());
		ImageStorage.Store("arun Joshi", new JpegCompressor(), new BlackAndWhiteFilter());
	}
	#endregion

	#region TemplateMethod
	private static void TemplateMethod()
	{
		var task = new TransferMoney();
		task.Execute();
	}
	#endregion

	#region CommandPattern
	public static void CommandPattern()
	{
		var service = new CustomerService();
		var command = new AddCustomerCommand(service);
		var button = new CommandPattern.FX.Button(command);
		button.Click();

		//composite command
		var compositeCommand = new CompositeCommand();
		compositeCommand.AddCommand(new ResizeCommand());
		compositeCommand.AddCommand(new BlackAndWhiteCommand());
		compositeCommand.Execute();

		//Undoable Command

		var history = new HistoryCommand();
		var document = new CommandPattern.HtmlDocument();
		document.SetContent("hello world");

		var boldCommand = new BoldCommand(document, history);
		boldCommand.Execute();
		Console.WriteLine(document.GetContent());
		boldCommand.UnExecute();
		Console.WriteLine(document.GetContent());
	}
	#endregion

	#region ObserverPattern
	public static void ObserverPattern()
	{
		var dataSource = new DataSource();
		var sheet1 = new SpreadSheet(dataSource);
		var sheet2 = new SpreadSheet(dataSource);
		var chart = new Chart(dataSource);
		dataSource.AddObserver(sheet1);
		dataSource.AddObserver(sheet2);
		dataSource.AddObserver(chart);
		dataSource.SetValue(10);
		dataSource.RemoveObserver(sheet2);
		dataSource.RemoveObserver(sheet1);
		dataSource.SetValue(20);
	}
	#endregion

	#region MediatorPattern
	public static void MediatorPattern()
	{
		var dialog = new ArticlesDialogBox();
		dialog.SimulateUserIntegration();
	}
	#endregion

	#region  ChainOfResponsibility
	public static void ChainOfResponsibility()
	{
		var compressor = new Compressor(null);
		var logger = new Logger(compressor);
		var authenticator = new Authenticator(logger);
		var service = new WebServer(authenticator);
		service.Handle(new HttpRequest("admin", "12341"));
	}
	#endregion

	#region VisitorPattern
	public static void VisitorPattern()
	{
		var document = new visitor.HtmlDocument();
		document.AddNode(new HeadingNode());
		document.AddNode(new AnchorNode());
		document.Execute(new HighlightOperation());
		document.Execute(new PlainTestOperation());
	}
	#endregion

	#region CompositePattern
	public static void CompositePattern()
	{
		var group = new Group();
		group.Add(new Shape());
		group.Add(new Shape());

		var group2 = new Group();
		group2.Add(new Shape());
		group2.Add(new Shape());

		var group3 = new Group();
		group3.Add(group);
		group3.Add(group2);
		group3.Render();
		group3.Move();
	}
	#endregion

	#region  AdapterPattern
	public static void AdapterPattern()
	{
		var imageView = new ImageView(new Image());
		imageView.Apply(new VividFilter());

		imageView.Apply(new CamelFilter(new Camel()));
	}
	#endregion

	#region DecoratorPattern
	public static void DecoratorPattern()
	{
		StoreCreditCard(new EncryptedCloudStream(new CompressCloudStream(new CloudStream())));
	}

	private static void StoreCreditCard(IStream stream)
	{
		stream.Write("1234-1234-1234-1234");
	}

	#endregion

	#region FacadePattern
	public static void FacadePattern()
	{
		NotificationService.Send("message", "ip");
	}
	#endregion

	#region FlyweightPattern
	public static void FlyweightPattern()
	{
		var pointService = new PointService(new PointIconFactory());
		foreach (var point in pointService.GetPoints())
		{
			point.Draw();
		}
	}
	#endregion

	#region BridgePattern
	public static void BridgePattern()
	{
		var remoteControl = new RemoteControl(new SonyTv());
		remoteControl.TurnOn();
		remoteControl.TurnOff();

		var advSonyRemote = new AdvanceRemoteControl(new SonyTv());
		advSonyRemote.TurnOn();
		advSonyRemote.TurnOn();
		advSonyRemote.SetChannel(100);


		var samsung = new RemoteControl(new SamsungTv());
		samsung.TurnOn();
		samsung.TurnOff();
	}
	#endregion

	#region ProxyPattern
	public static void ProxyPattern()
	{
		var library = new Library();

		foreach (var book in new string[] { "arun.txt", "arun.pdf", "arun.xlxs" })
		{
			var eBook = new LoggingEBookProxy(book);
			library.Add(eBook);
		}
		library.OpenEBook("arun.pdf");
		library.OpenEBook("arun.txt");
	}
	#endregion

	#region PrototypePattern
	public static void PrototypePattern()
	{
		var circle = new Circle();
		circle.SetRadius(20);
		circle.Render();

		var clone = circle.Clone();
		clone.Render();
	}
	#endregion

	#region SingletonPattern
	public static void SingletonPatter()
	{
		var configManager = ConfigManager.GetInstance();
		configManager.Set("arun", "joshi");
		Console.WriteLine(configManager.Get("arun"));
		var configManager2 = ConfigManager.GetInstance();
		Console.WriteLine(configManager2.Get("arun"));
	}
	#endregion
}