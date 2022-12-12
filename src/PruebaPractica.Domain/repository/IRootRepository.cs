//paso 2 crear interfaz reposotorio para hacer
namespace PruebaPractica.Domain.repository;

public interface IRootRepository
{
    Task<Root> ObtenerApiTask(); 
    ICollection<Root> MetodoGet();

}
