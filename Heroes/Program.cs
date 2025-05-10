//Estetico
Console.WriteLine(" ");

SuperHeroe batman = new SuperHeroe();

batman.Nombre = "Bruce";
batman.Identidad = "Batman";
batman.Ciudad = "Gotham";
batman.PuedeVolar = false;
batman.Super.Nombre = "Tiene Dinero";
batman.Super.Descripcion = "Puede comprar equipo para ser fuerte";
batman.Super.Nivel = 8;
batman.Imprimir();

Console.WriteLine(" ");
Console.WriteLine("<------------------------->");
Console.WriteLine(" ");

SuperHeroe superman = new SuperHeroe();
superman.Nombre = "Clark Kent";
superman.Identidad = "Superman";
superman.Ciudad = "Metrópolis";
superman.PuedeVolar = true;
superman.Super.Nombre = "Super fuerza";
superman.Super.Descripcion = "Capacidad de levantar objetos muy pesados";
superman.Super.Nivel = 9;
superman.Imprimir();

// Estetico
Console.WriteLine(" ");
