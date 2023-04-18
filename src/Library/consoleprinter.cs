using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.Steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
/* El patrón o principio utilizado en este cambio es el principio de Responsabilidad Única (SRP), 
que establece que una clase debe tener una única responsabilidad y motivo para cambiar. 
Al implementar una clase ConsolePrinter separada, se está cumpliendo con este principio, 
ya que ahora la clase Recipe tiene una única responsabilidad de representar la receta y 
no tiene que preocuparse por cómo se imprime.*/
