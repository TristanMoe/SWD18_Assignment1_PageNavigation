namespace CarnGo
{
    public interface IUserDatabase
    {
        /// <summary>
        /// Interface for database
        /// </summary>
        /// <param name="usernameKey"></param>
        /// <param name="passwordKey"></param>
        /// <returns> UserModel if found in Database else NULL </returns>
        UserModel GetUserModel(string usernameKey, string passwordKey);

    }

    public class UserDatabaseStub : IUserDatabase
    {
        /// <summary>
        /// Creates a new UserModel with the given parameters 
        /// </summary>
        /// <param name="usernameKey"></param>
        /// <param name="passwordKey"></param>
        /// <returns></returns>
        public UserModel GetUserModel(string usernameKey, string passwordKey)
        {
            var user = new UserModel("jens","jens@jens.com","jens","jensen");
            return user; 
        }
    }





}
