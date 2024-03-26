// Primeira Clinica
using _240325_06.Models;

clinica c1 = new clinica();
c1.ObjectCount = 1;
clinica.InstanceCount = 1;

// Segunda clinica

clinica c2 = new clinica();
c2.ObjectCount = 10;
clinica.InstanceCount++;

Console.WriteLine($"Valor C1: {c1.ObjectCount}");

Console.WriteLine($"Instance Count: {clinica.InstanceCount}");

Console.WriteLine($"Valor C2: {c2.ObjectCount}");