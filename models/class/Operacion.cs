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
    public float Number { get => _number; set => _number = value; }
    public bool Estado { get => _estado; set => _estado = value; }
    public float Sumar(out float result)
    {
        bool first = true;
        float tmp = 0;
        float i = 0;
        foreach (var item in list)
        {
            if (first)
            {
                tmp = item;
                first = false;
                continue;
            }
            i=item;
            tmp = Oper((int) Operar.multiplicar,ref tmp,ref i);
        }
        result = tmp;
        return result;
    }
    private float Oper(int op,ref float tmp,ref float item)
    {
        switch (op)
        {
            case (int)Operar.sumar:
                return tmp + item; 
            case (int)Operar.restar:
                return tmp - item;
            case (int)Operar.multiplicar:
                return tmp * item;
            case (int)Operar.dividir:
                return tmp / item;
            default:
                return 0;
        }
    }
    public void AddNumber(float numero) => list.Add(numero);
}
public enum Operar
{
    sumar = 1,
    restar = 2,
    multiplicar = 3,
    dividir = 4
}