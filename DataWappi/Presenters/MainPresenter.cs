using DataWappi.Lib;
using DataWappi.Models;
using DataWappi.Views;
using Microsoft.Extensions.Configuration;

namespace DataWappi.Presenters;

public class MainPresenter
{
    private string OutFileName { get; set; } = string.Empty;
    private readonly IMainView _mainView;
    private readonly IDirectvCustomersRepository _customersRepository;
    private readonly IConfiguration _configuration;
    private List<DirectvCustomers>? directvCustomersList;

    public MainPresenter(IMainView mainView, IDirectvCustomersRepository customersRepository, IConfiguration configuration)
    {
        _mainView = mainView;
        _customersRepository = customersRepository;
        _configuration = configuration;
        directvCustomersList = new List<DirectvCustomers>();
        SubscribeToEventsSetup();
    }

    private void SubscribeToEventsSetup()
    {
        _mainView.ConvertFileEvent += OnConvertFileEvent;
    }
    private void OnConvertFileEvent(object? sender, EventArgs e)
    {
        if (_mainView.FileName == string.Empty)
        {
            MessageBox.Show("No se ha seleccionado ningún archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Obtenemos un nombre unico para el archivo.
        OutFileName = GenerateUniqueFileName(_mainView.FileName);

        // Posicion de los encabezados
        int[] headerIndices = _configuration.GetSection("HeaderIndices").Get<int[]>() ?? Array.Empty<int>();

        // Titulos del encabezados
        string[] headerTitles = _configuration.GetSection("HeaderTitles").Get<string[]>() ?? Array.Empty<string>();

        // Obtenemos la lista de los clientes leidos en el archivo cargado
        directvCustomersList = GetDirectvCustomersList(headerIndices, _mainView.FileName);

        // Iteramos
        if(directvCustomersList is not null)
        {
            ProcessDirectvCustomersList(directvCustomersList);

            SaveDirectvCustomersToFile(directvCustomersList, headerTitles, OutFileName);

            // Mensaje de salida notificando el exito
            // Implementar mas cosas como un gif y un messageBox mejor
            // Mensaje de éxito
            MessageBox.Show("Archivo creado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Mensaje de error
            MessageBox.Show("El archivo no tiene el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
    private static void ProcessDirectvCustomersList(List<DirectvCustomers> customersList)
    {
        foreach(var customer in customersList)
        {
            // Obtenemos la lista de los clientes con los mensajes wappi
            customer.MessageWappi = PhoneNumberExtractor.GetAll(customer.PhoneNumber, customer.Names);
        }
    }
    private void SaveDirectvCustomersToFile(List<DirectvCustomers> customersList, string[] headerTitles, string fileName)
    {
        //  Guardamos todos los datos en el archivo de salida
        _customersRepository.AddAll(customersList, headerTitles, fileName);
    }
    private List<DirectvCustomers>? GetDirectvCustomersList(int[] headerIndices, string fileName)
    {
        return _customersRepository.GetAll(headerIndices, fileName)?.ToList();
    }

    private static string GenerateUniqueFileName(string fileName)
    {
        // Obtenemos el directorio 
        string directory = Path.GetDirectoryName(fileName)??string.Empty;

        // Obtenemos el nombre del fichero sin extension
        string baseName = Path.GetFileNameWithoutExtension(fileName);

        // Obtenemos la extension
        string extension = Path.GetExtension(fileName);

        int counter = 1;

        // Iniciamos el nombre de salida del archivo
        string newFileName = Path.Combine(directory, $"{baseName}-wappi{extension}");

        // Iteramos hasta encontrar un nombre único
        while(File.Exists(newFileName))
        {
            newFileName = Path.Combine(directory, $"{baseName}-wappi ({counter}){extension}");
            counter++;
        }
        return newFileName;
    }
}