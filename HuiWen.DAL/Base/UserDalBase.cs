//-----------------------------------------------------------------------
namespace HuiWen.DAL
{
    public class UserDalBase : DalBase
    {
        public UserDalBase()
            : base("UserRead", "UserWrite")
        {
        }
    }
}
