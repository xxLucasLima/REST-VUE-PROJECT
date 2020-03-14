using System.Threading.Tasks;
using project_school_api.Models;

namespace project_school_api.Data
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ALUNO
        Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor);
        Task<Aluno[]> GetAlunosAsyncByProfessorId(int professorId, bool includeProfessor);
        Task<Aluno> GetAlunoAsyncById(int alunoId, bool includeProfessor);

        //PROFESSOR
        Task<Professor[]> GetAllProfessoresAsync(bool includeProfessor);
        Task<Professor> GetProfessorAsyncById(int professorId, bool includeProfessor);

    }
}