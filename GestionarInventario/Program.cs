// Declaración e inicialización del arreglo
// con cantidades de productos
int[] inventario = { 50, 20, 0, 15, 30};

// Rebastecimiento de un producto
// (por ejemplo, el tercer producto)
inventario[2] = 22;

// Verificar si algún producto necesita rebastecimiento
// (cantidad < 10)
for (int i = 0; i < 5; i++)
{
    if (inventario[i] < 10)
    {
        Console.WriteLine($"Producto {i + 1} necesita rebastecimiento. Cantidad actual: {inventario[i]}");
    }
}