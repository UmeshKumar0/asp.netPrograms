using TaskUserAdmin.Models;
namespace TaskUserAdmin.Service
{
    public interface IServices
    {
        public bool ConnectToData(Login acc);
        public List<Login> UserList1();
        public List<Map> ConnectToPermission(int ID);
        public bool Complete(int Id, bool CanCreate, bool CanRead, bool CanWrite, bool CanDelete, bool CanCreate1, bool CanWrite1, bool CanRead1, bool CanDelete1);
        public bool CreatingUser(string Email, string Pass, string Name, int Role); 
    }
}
