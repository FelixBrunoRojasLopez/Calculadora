namespace Calculadora;
public class Operacion
{
    private float _number;
    private static bool _estado;
    private List<float> list = new List<float>();
    static Operacion()
    {
        _estado = true;
    }
    public Operacion()
    {
        _number = 0;
    }
    public float Number {get => _number; set => _number = value;}
    public bool Estado {get => _estado; set => _estado = value;}
    public float Sumar(out float result)
    {
        float tmp = 0;
        foreach(var item in list)
        {
            tmp = tmp + item;
        }
        result = tmp;
        return result;
    }
    public void AddNumber(float numero) => list.Add(numero);
}