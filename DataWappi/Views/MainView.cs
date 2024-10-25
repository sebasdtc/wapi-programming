using System.Runtime.InteropServices;

namespace DataWappi.Views;

public partial class MainView : Form, IMainView
{
    #region Public Properties
    public string FileName { get; set; } = string.Empty;
    #endregion

    #region Constructor
    public MainView()
    {
        InitializeComponent();
        AssociateAndRaiseViewEvents();
    }
    #endregion

    #region Events
    // Evento para convertir el archivo
    public event EventHandler? ConvertFileEvent;
    #endregion

    #region Private Methods
    // Asociacion de los eventos
    private void AssociateAndRaiseViewEvents()
    {
        btnConvert.Click += delegate { ConvertFileEvent?.Invoke(this, EventArgs.Empty); };
    }

    // Metodo para cerrar el formulario
    private void PicbClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // ejemplos momentaneos
    private void BtnLoadFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new()
        {
            Filter = "Archivos de Excel (*.xlsx, *.xls)|*.xlsx;*.xls|Todos los archivos (*.*)|*.*",
            FilterIndex = 1,
            Title = "Seleccionar archivo",
            RestoreDirectory = true
        };

        if(ofd.ShowDialog() == DialogResult.OK)
        {
            FileName = ofd.FileName;
            SetEllipsisText(ofd.SafeFileName);
            txtFileName.ForeColor = Color.Black;
            txtSize.Text = GetFileSizeInBytes(ofd.FileName);
            btnSettings.Enabled = true;
        }
        else
        {
            FileName = string.Empty;
            txtFileName.Text = "Operación cancelada";
            txtFileName.ForeColor = Color.Red;
            txtSize.Text = "";
            btnSettings.Enabled = false;
        }
    }

    private void SetEllipsisText(string text)
    {
        if(text.Length > 30)
        {
            text = $"{text[..14]}...{text[^14..]}";
        }

        // Asigna el texto completo al control Label
        txtFileName.Text = text;
    }
    private static string GetFileSizeInBytes(string fileName)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        int unitIndex = 0;

        var fileInfoSize = new FileInfo(fileName).Length;

        while(fileInfoSize >= 1024 && unitIndex < sizes.Length - 1)
        {
            fileInfoSize /= 1024;
            unitIndex++;
        }
        return $"{fileInfoSize} {sizes[unitIndex]}";
    }
    #endregion

    #region Move Panel
    /* funcion para poder mover la ventana con el mouse */
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

    private extern static void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]

    /* funcion SendMessage */
    private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

    /* Agregar funcion al evento MouseDown */
    private void PanelHearder_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }
    #endregion

    #region Style button close
    private void PicbClose_MouseMove(object sender, MouseEventArgs e)
    {
        picbClose.BackColor = Color.FromArgb(193, 43, 28);
    }

    private void PicClose_MouseLeave(object sender, EventArgs e)
    {
        picbClose.BackColor = Color.White;
    }
    #endregion

    private void button1_Click(object sender, EventArgs e)
    {

    }
}
