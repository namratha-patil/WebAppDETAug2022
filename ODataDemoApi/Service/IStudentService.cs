using ODataDemoApi.Models;

namespace ODataDemoApi.Service
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
