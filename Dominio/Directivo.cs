namespace Dominio
{
    public class Directivo : Empleado
    {
        public int IdDirectivo { get; set; }
        public string Categoria { get; set; }
        public int CantidadEmpleados { get; set; }
    
    }
}