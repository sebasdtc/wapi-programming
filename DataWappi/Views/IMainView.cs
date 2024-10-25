namespace DataWappi.Views;

public interface IMainView
{
    string FileName { get; set; }

    event EventHandler ConvertFileEvent;

    void Show();

}
