namespace CoR;


interface ComponentWithContextualHelp
{
    void ShowHelp();
}


abstract class Component : ComponentWithContextualHelp
{
    private Container _container;
    public string tooltipText = null;

    public virtual void ShowHelp()
    {
        if (tooltipText != null)
            Console.WriteLine("Showing Component tooltip...");
        else
            _container.ShowHelp();
    }

}

abstract class Container : Component
{

    private Component _children;

    public void Add(Component child) { }

}


class Button : Component
{
    public override void ShowHelp()
    {
        Console.WriteLine("Showing Button tooltip...");
    }
}


class Panel : Container
{
    private string _modalHelpText;

    public override void ShowHelp()
    {
        if (_modalHelpText != null)
            Console.WriteLine(_modalHelpText);
        else
            base.ShowHelp();
    }

}

class Dialog : Container
{
    private string _wikiPageURL;

    public override void ShowHelp()
    {
        if (_wikiPageURL != null)
            Console.WriteLine(_wikiPageURL);
        else
            base.ShowHelp();
    }

}