using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Features.Metadata;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }














    //var builder = new ContainerBuilder();
    //builder.RegisterType<SaveCommand>().As<ICommand>().WithMetadata("Name", "Save File");
    //builder.RegisterType<OpenCommand>().As<ICommand>().WithMetadata("Name", "Open File");
    //builder.RegisterType<EditorWindow>();

    //builder.RegisterAdapter<Meta<ICommand>, ToolbarButton>(cmd => new ToolbarButton(cmd.Value, (string)cmd.Metadata["Name"]));

    //using (var container = builder.Build())
    //{
    //    var window = container.Resolve<EditorWindow>();
    //}

    //public interface ICommand
    //{
    //    void Execute();
    //}

    //public class OpenCommand : ICommand
    //{
    //    public void Execute()
    //    {
    //        // Save the current image
    //    }
    //}
    //public class SaveCommand : ICommand
    //{
    //    public void Execute()
    //    {
    //        // Save the current image
    //    }
    //}

    //public class ToolbarButton
    //{
    //    ICommand _command;
    //    private readonly string _description;

    //    public ToolbarButton(ICommand command,string description)
    //    {
    //        _command = command;
    //        _description = description;
    //    }
    //    public void Click()
    //    {
    //        _command.Execute();
    //    }
    //}

    //public class EditorWindow
    //{
    //    public EditorWindow(IEnumerable<ToolbarButton> toolbarButtons)
    //    {
    //        Console.WriteLine(toolbarButtons.Count());
    //    }
    //}
}
