using Metodologías_de_Programación_I;
using Metodologías_de_Programación_I.Clases;
using Metodologías_de_Programación_I.Interfaces;

Pila pila = new Pila();
Cola cola = new Cola();

ColeccionMultiple coleccionMultiple = new ColeccionMultiple(pila, cola);

//Helper.Llenar(pila);
//Helper.Llenar(cola);

Helper.LlenarPersonas(pila);
Helper.LlenarPersonas(cola);

//Helper.Informar(pila);
//Helper.Informar(cola);
//Helper.Informar(coleccionMultiple);

Pila pilaPersonas = new Pila();
Cola colaPersonas = new Cola();
Pila pilaAlumnos = new Pila();
Cola colaAlumnos = new Cola();

// Llenar Pila y Cola con Personas
Helper.LlenarPersonas(pilaPersonas);
Helper.LlenarPersonas(colaPersonas);

// Llenar Pila y Cola con Alumnos
Helper.LlenarAlumnos(pilaAlumnos);
Helper.LlenarAlumnos(colaAlumnos);

// Crear ColeccionMultiple de Personas
ColeccionMultiple multiplePersonas = new ColeccionMultiple(pilaPersonas, colaPersonas);

// Crear ColeccionMultiple de Alumnos
ColeccionMultiple multipleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);

// Informar sobre las colecciones
//Helper.Informar(pilaPersonas);
//Helper.Informar(colaPersonas);
//Helper.Informar(multiplePersonas);

//Helper.Informar(pilaAlumnos);
//Helper.Informar(colaAlumnos);
//Helper.Informar(multipleAlumnos);

/* REFLECCIÓN
Sí, podría haber hecho lo mismo sin interfaces, pero a un costo significativo. Sin interfaces, habría perdido la flexibilidad y el polimorfismo, obligándo a duplicar código para cada tipo de colección (Pila, Cola, etc.) y para cada tipo de objeto (Persona, Alumno). Esto resultaría en un diseño rígido, difícil de mantener y extender, ya que cada cambio requeriría modificar múltiples partes del código en lugar de simplemente implementar una nueva interfaz o clase que siga un contrato común. Además, el código sería menos reutilizable y menos claro.
    */

//Helper.ImprimirElementos(pilaAlumnos);

Helper.CambiarEstrategia(pilaAlumnos, new CompararPorDNI());
Helper.Informar(pilaAlumnos);


Helper.CambiarEstrategia(pilaAlumnos, new CompararPorLegajo());
Helper.Informar(pilaAlumnos);

Helper.CambiarEstrategia(pilaAlumnos, new CompararPorPromedio());
Helper.Informar(pilaAlumnos);