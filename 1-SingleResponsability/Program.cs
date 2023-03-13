using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportCSV(studentRepository.GetAll());
// studentRepository.Export();
Console.WriteLine("Proceso Completado");