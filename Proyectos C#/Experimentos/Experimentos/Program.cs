class principal
{
    static void Main()
    {
        int entero = 10; //Valor / Stack
        object objeto = entero; //referencia / Heap // boxing

        int entero2 = (int)objeto; // unboxing

        int valueType = 5;
        float flotante = (float)valueType; // Casting
        //De un INT a un SHORT, no se puede convertir, debemos hacer lo siguiente "short nombre = numero;" // Casting
    }
}