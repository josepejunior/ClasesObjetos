/*Prueba DataAnnotations*/

//Step 1 create object
using System.ComponentModel.DataAnnotations;

Modelo.Customer obj = new();
obj.First= "";

//Step 2 
var context = new ValidationContext(obj, null, null);

//Step 3
var result = new List<ValidationResult>();
bool IsValid = Validator.TryValidateObject(obj, context, result, true);
Console.WriteLine(IsValid);
foreach (var item in result)
{
    Console.WriteLine(item.ErrorMessage);
}

/********************************************************************/

Modelo.Producto objProduct = new();
objProduct.Name = "";
objProduct.Description = "";
objProduct.Price = 20;

//Step 2 
var contextP = new ValidationContext(objProduct, null, null);

//Step 3
var resultp = new List<ValidationResult>();
bool IsValidP = Validator.TryValidateObject(objProduct, contextP, resultp, true);
Console.Write(IsValidP);
foreach (var p in resultp)
{
    Console.WriteLine(p.ErrorMessage);
}