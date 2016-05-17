//-----------------------------------------------------------------------
namespace HuiWen.Dal
{
    public class UserDalBase : DalBase
    {
        public UserDalBase()
            : base("UserRead", "UserWrite")
        {
        }
    }
}
