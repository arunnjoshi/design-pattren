using Iterator;
using Memento;
using State;
using StrategyPattern;
using TemplateMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        //MementoPattern();
        // StatePattern();
        //IteratorPattern();
        //StrategyPattern();
        TemplateMethod();
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
        ImageStorage.Store("arun Joshi",new PngCompressor(),new BlackAndWhiteFilter());
        ImageStorage.Store("arun Joshi",new JpegCompressor(),new BlackAndWhiteFilter());
    }
    #endregion

    #region TemplateMethod
    private static void TemplateMethod()
    {
        var task = new TransferMoney();
        task.Execute();
    }
    #endregion
}