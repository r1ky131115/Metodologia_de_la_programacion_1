using Metodologias_de_Programacion_I_2024;
Console.Write("Seleccionar una opcion segun la practica a revisar: ");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
	case 1:
        Menu.Practica_1();
        break;

	case 2:
		Menu.Practica_2();
		break;
	default:
		
		break;
}
