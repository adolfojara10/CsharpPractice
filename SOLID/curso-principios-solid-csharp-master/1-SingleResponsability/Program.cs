using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper export = new();
export.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");