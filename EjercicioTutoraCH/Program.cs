// See https://aka.ms/new-console-template for more information


Auto ecomeme = new Auto();
Moto yamahameme = new Moto();
ecomeme.Anio = 2020;
ecomeme.Modelo = "Ecosport";
ecomeme.Marca = "Ford";
ecomeme.CantidadRuedas = 5;
yamahameme.Anio = 2020;
yamahameme.Modelo = "twister";
yamahameme.Marca = "yamaha";
yamahameme.CantidadRuedas = 2;
yamahameme.Cilindrada = 2200;

Console.WriteLine(ecomeme.ObtenerDescripcion());
Console.WriteLine(yamahameme.ObtenerDescripcion());
Console.ReadLine();

class Auto: IDescripcion
{
    private int _cantidadRuedas;
    private string _modelo = "";
    private string _marca = "";
    private int _anio;

    public string Modelo 
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public int CantidadRuedas 
    {
        get { return _cantidadRuedas; }
        set { _cantidadRuedas = value; }
    }
    public string Marca 
    {
        get { return _marca; }
        set
        {
            _marca = value;
        }
    }
    public int Anio 
    {
        get { return _anio; }
        set
        {
            _anio = value;
        }
    }

    public string ObtenerDescripcion() 
    {

        return "cantidad de ruedas:" + _cantidadRuedas +" modelo: "+ _modelo + " marca: " + _marca + " año: " + _anio ;
    }
}

class Moto : IDescripcion 
{
    private int _cantidadRuedas;
    private string _modelo = "";
    private string _marca = "";
    private int _anio;
    private int _cilindrada;

    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value; }
    }
    public int CantidadRuedas
    {
        get { return _cantidadRuedas; }
        set { _cantidadRuedas = value; }
    }
    public string Marca
    {
        get { return _marca; }
        set
        {
            _marca = value;
        }
    }
    public int Anio
    {
        get { return _anio; }
        set
        {
            _anio = value;
        }
    }

    public int Cilindrada 
    {
        get { return _cilindrada; } 
        set { _cilindrada = value; }
    }

    public string ObtenerDescripcion()
    {

        return "cantidad de ruedas:" + _cantidadRuedas + " modelo: " + _modelo + " marca: " + _marca + " año: " + _anio + " cilindrada: " + _cilindrada;
    }

}

public interface IDescripcion
{
    string ObtenerDescripcion();
}