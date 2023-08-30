/*Prueba DataAnnotations*/

//Step 1 create object
using System.ComponentModel.DataAnnotations;

Modelo.Customer obj = new();
obj.Name = "JOSEPH MENDOZA";

//Step 2 
var context = new ValidationContext(obj, null, null);

//Step 3
bool IsValid = Validator.TryValidateObject(obj, context, null, true);
Console.WriteLine(IsValid);

/********************************************************************/

Modelo.Producto objProduct = new();
objProduct.Name = "LECHE";
objProduct.Description = "LECHE DESLACTOSADA";
objProduct.Price = 20;

//Step 2 
var contextP = new ValidationContext(objProduct, null, null);

//Step 3
var result = new List<ValidationResult>();
bool IsValidP = Validator.TryValidateObject(objProduct, contextP, result, true);
foreach (var p in result)
{
    Console.WriteLine(p.ErrorMessage);
}